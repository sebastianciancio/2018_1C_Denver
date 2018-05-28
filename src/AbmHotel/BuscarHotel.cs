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
        //public int hotel_id;
        public BuscarHotel()
        {
            InitializeComponent();
            db = DataBase.GetInstance();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("dbo.buscar_hotel", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (txb_nombre.Text != "")
                cmd.Parameters.AddWithValue("@hotel_nombre", SqlDbType.VarChar).Value = txb_nombre.Text;

            if (txb_ciudad.Text != "")
                cmd.Parameters.AddWithValue("@hotel_ciudad", SqlDbType.VarChar).Value = txb_ciudad.Text;

            if (txb_pais.Text != "")
                cmd.Parameters.AddWithValue("@pais_nombre", SqlDbType.VarChar).Value = txb_pais.Text;

            if (cmb_estrellas.SelectedItem != "")
                cmd.Parameters.AddWithValue("@hotel_estrellas", SqlDbType.VarChar).Value = cmb_estrellas.Text;

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
            string hotel_id = row.Cells[0].Value.ToString();

            //Paso el valor de las claves al nuevo formulario de modificación
            //para poder consultar la base de datos y traer los campos que se quieran modificar
            frm.hotel_id = hotel_id;
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
        }


    }

