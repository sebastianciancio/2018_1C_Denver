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

namespace FrbaHotel.AbmHabitacion
{
    public partial class Habitaciones_buscador : Form
    {
        private DataBase db;
        public Habitaciones_buscador()
        {
            db = DataBase.GetInstance();
            InitializeComponent();

            // Cargo los combos
            Combos.cargarComboHotel(cmb_hotel, true);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.buscar_habitacion", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (cmb_hotel.SelectedIndex > 0)
                cmd.Parameters.AddWithValue("@hotel_nombre", SqlDbType.Int).Value = cmb_hotel.SelectedValue;

            if (txb_numero.Text != "")
                cmd.Parameters.AddWithValue("@hab_numero", SqlDbType.Int).Value = Convert.ToInt32(txb_numero.Text);

            if (txb_piso.Text != "")
                cmd.Parameters.AddWithValue("@hab_piso", SqlDbType.Int).Value = Convert.ToInt32(txb_piso.Text);

            // Creo el DataTable para obtener los resultados del SP
            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            // Cargo la Grilla con los datos obtenidos
            dgv_hab.DataSource = dt;

            // Muestro los objetos ocultos
            btn_baja.Visible = true;
            btn_modif.Visible = true;
            dgv_hab.Visible = true;
            dgv_hab.Columns[5].Visible = false;
            dgv_hab.Columns[6].Visible = false;
            foreach (DataGridViewRow row in dgv_hab.Rows)
            {
                if (row.Cells[6].Value.ToString() == "N")
                { row.DefaultCellStyle.BackColor = Color.Orange; };

            }
        }
        private void btn_new_hotel_Click(object sender, EventArgs e)
        {
            AbmHabitacion.Habitacion_alta frm = new AbmHabitacion.Habitacion_alta();
            frm.Show();

        }

        private void btn_modif_Click(object sender, EventArgs e)
        {
            AbmHabitacion.Habitacion_modificar frm = new AbmHabitacion.Habitacion_modificar();
            DataGridViewRow row = dgv_hab.CurrentRow;
           
            //Paso el valor de las claves al nuevo formulario de modificación
            //para poder consultar la base de datos y traer los campos que se quieran modificar
            frm.hab_nro = Convert.ToInt32(row.Cells[0].Value.ToString());
            frm.hotel_id = Convert.ToInt32(row.Cells[5].Value.ToString());
            frm.Show();
        }

        private void btn_baja_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_hab.CurrentRow;
            if (row.Cells[6].Value.ToString() == "N")
            {
                DialogResult result = MessageBox.Show("Desea dar de alta la habitación?"
                    , "Confirmar habilitación",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    SqlCommand alta = new SqlCommand("denver.alta_habitacion", db.Connection);
                    alta.CommandType = CommandType.StoredProcedure;

                    alta.Parameters.AddWithValue("@habitacion_nro", SqlDbType.Int).Value = Convert.ToInt32(row.Cells[0].Value.ToString());
                    alta.Parameters.AddWithValue("@habitacion_hotel_id", SqlDbType.Int).Value = Convert.ToInt32(row.Cells[5].Value.ToString());

                    alta.ExecuteNonQuery();

                    MessageBox.Show(" La habilitó la habitación " + row.Cells[0].Value.ToString(), "Mensaje");

                    btn_buscar_Click(null, null);
                    
                }
            }
            else
            {

                SqlCommand sda = new SqlCommand("denver.buscar_reserva_hab_hotel", db.Connection);
                sda.CommandType = CommandType.StoredProcedure;

                sda.Parameters.AddWithValue("@habitacion_nro", SqlDbType.Int).Value = Convert.ToInt32(row.Cells[0].Value.ToString());
                sda.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = Convert.ToInt32(row.Cells[5].Value.ToString());

                DataTable dt = new DataTable();

                using (var da = new SqlDataAdapter(sda))
                {
                    da.Fill(dt);
                }
                if (dt.Rows.Count != 0)
                {
                    MessageBox.Show("No se puede dar de baja la habitacion número " + row.Cells[0].Value.ToString() + " ya que tiene reservas activas", "Mensaje");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("denver.eliminar_habitacion", db.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@habitacion_nro", SqlDbType.Int).Value = Convert.ToInt32(row.Cells[0].Value.ToString());
                    cmd.Parameters.AddWithValue("@habitacion_hotel_id", SqlDbType.Int).Value = Convert.ToInt32(row.Cells[5].Value.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(" La habitación se dió de baja correctamente", "Mensaje");

                    btn_buscar_Click(null, null);

                }
            }



        }

    }
}
