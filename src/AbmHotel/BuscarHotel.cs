using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel.AbmHotel
{     
    
    public partial class BuscarHotel : Form
    {
        private DataBase db;
        public BuscarHotel()
        {
            InitializeComponent();
            db = DataBase.GetInstance();

            // Cargo los combos
            Combos.cargarComboPais(combo_pais, true);
            Combos.cargarComboCantidad(cmb_estrellas, 1,5, true);
            Combos.cargarComboHotel(cmb_hotel, true);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.buscar_hotel", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (cmb_hotel.SelectedIndex > 0)
                cmd.Parameters.AddWithValue("@hotel_nombre", SqlDbType.VarChar).Value = cmb_hotel.Text;

            if (txb_ciudad.Text != "")
                cmd.Parameters.AddWithValue("@hotel_ciudad", SqlDbType.VarChar).Value = txb_ciudad.Text;

            if (combo_pais.SelectedIndex > 0)
                cmd.Parameters.AddWithValue("@pais_nombre", SqlDbType.VarChar).Value = combo_pais.Text;

            if (cmb_estrellas.SelectedIndex > 0)
            {
                cmd.Parameters.AddWithValue("@hotel_estrellas", SqlDbType.Int).Value = Convert.ToInt32(cmb_estrellas.Text);
            }
                

            // Creo el DataTable para obtener los resultados del SP
            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }
           
            // Cargo la Grilla con los datos obtenidos
            dgv_tablaHotel.DataSource = dt;

            // Muestro los objetos ocultos
            btn_baja.Visible = true;
            btn_modif.Visible = true;
            dgv_tablaHotel.Visible = true;
        }

        private void btn_modif_Click(object sender, EventArgs e)
        {
            AbmHotel.Hotel_modificacion frm = new AbmHotel.Hotel_modificacion();
            DataGridViewRow row = dgv_tablaHotel.CurrentRow;

            //por el numero obtiene la columna
            // Obtenés El ID del hotel
            string hotel_nombre = row.Cells[0].Value.ToString();
            string hotel_ciudad = row.Cells[1].Value.ToString();
            string hotel_pais_id = row.Cells[2].Value.ToString();
            string hotel_mail = row.Cells[3].Value.ToString();
            //Paso el valor de las claves al nuevo formulario de modificación
            //para poder consultar la base de datos y traer los campos que se quieran modificar
            frm.hotel_nombre = hotel_nombre;
            frm.hotel_ciudad = hotel_ciudad;
            frm.hotel_pais_id = hotel_pais_id;
            frm.hotel_mail = hotel_mail;
            frm.Show();
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {

                AbmHotel.Hotel_Baja frm = new AbmHotel.Hotel_Baja();
                DataGridViewRow row = dgv_tablaHotel.CurrentRow;
                string id_hotel = row.Cells[0].Value.ToString();

                frm.id_hotel = id_hotel;
            }
        

        private void btn_new_hotel_Click(object sender, EventArgs e)
        {
            AbmHotel.Hotel_alta frm = new AbmHotel.Hotel_alta();
            frm.Show(); 
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.eliminar_hotel", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
             //Levanto la linea seleccionada
            DataGridViewRow row = dgv_tablaHotel.CurrentRow;

            // Si existen datos
            if (row != null)
            {
                DialogResult result = MessageBox.Show("Esta seguro de que desea eliminar el hotel?", "Confirmar eliminación",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string hotel_nombre = row.Cells[0].Value.ToString();
                    cmd.Parameters.AddWithValue("@hotel_nombre", SqlDbType.VarChar).Value = hotel_nombre;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("El hotel " + hotel_nombre + " Se elimino correctamente", "Mensaje");
                }
            }

        }
        }


    }

