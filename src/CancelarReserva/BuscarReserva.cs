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

namespace FrbaHotel.CancelarReserva
{
    public partial class BuscarReserva : Form
    {
        private DataBase db;
        public BuscarReserva()
        {
            
            InitializeComponent();
            db = DataBase.GetInstance();
            //Combos.cargarComboTipoDocumento(cmb_tipo_doc, false);

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            accesoSistema frm = new accesoSistema();
            frm.Show();
            Close();
        }

        private void bt_canc_Click(object sender, EventArgs e)
        {
            CancelarReserva.Cancelar_reserva frm = new CancelarReserva.Cancelar_reserva();
            // DataGridViewRow row = dgv_reserva.CurrentRow;
             frm.cod_reserva = Convert.ToInt32(txb_reserva.Text);
            frm.Show();
        }

        private void BuscarReserva_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
         if (!Validacion.esInicial(txb_reserva.Text))
            {  


      /*          SqlCommand cmd = new SqlCommand("denver.obtener_disponibilidad", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                DateTime fecha_sin_hora = new DateTime();

                if (fecha_desde.Text != "")
                {
                    fecha_sin_hora = new DateTime(Convert.ToDateTime(fecha_desde.Value).Year, Convert.ToDateTime(fecha_desde.Value).Month, Convert.ToDateTime(fecha_desde.Value).Day);
                    cmd.Parameters.AddWithValue("@fecha_desde", SqlDbType.DateTime).Value = fecha_sin_hora;
                }

                if (fecha_hasta.Text != "")
                {
                    fecha_sin_hora = new DateTime(Convert.ToDateTime(fecha_hasta.Value).Year, Convert.ToDateTime(fecha_hasta.Value).Month, Convert.ToDateTime(fecha_hasta.Value).Day);
                    cmd.Parameters.AddWithValue("@fecha_hasta", SqlDbType.DateTime).Value = fecha_sin_hora;
                }


                if (cmb_tipo_hab.SelectedValue.ToString().CompareTo("0") > 0)
                    //if (cmb_tipo_hab.SelectedIndex > 0)
                    cmd.Parameters.AddWithValue("@tipo_habitacion", SqlDbType.Int).Value = Convert.ToInt32(cmb_tipo_hab.SelectedValue);


                if (cmb_regimen.SelectedIndex > 0)
                    cmd.Parameters.AddWithValue("@regimen_id", SqlDbType.Int).Value = Convert.ToInt32(cmb_regimen.SelectedValue);

                if (accesoSistema.HotelIdActual != 0)
                    cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = Convert.ToInt32(accesoSistema.HotelIdActual);

                // Creo el DataTable para obtener los resultados del SP
                DataTable dt = new DataTable();

                using (var da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                */



            }
            else
            {
                MessageBox.Show("El cdigo de reserva obligatorio", "Mensaje");
            }
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {
            //CancelarReserva.Modificar_reserva frm = new CancelarReserva.Modificar_reserva();
            //DataGridViewRow row = dgv_reserva.CurrentRow;
            //frm.cod_reserva = Convert.ToInt32(row.Cells[0].Value.ToString());
            //frm.Show();

            SqlCommand cmd = new SqlCommand("denver.obtener_disponibilidad", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            DateTime fecha_sin_hora = new DateTime();

            if (fecha_desde.Text != "")
            {
                fecha_sin_hora = new DateTime(Convert.ToDateTime(fecha_desde.Value).Year, Convert.ToDateTime(fecha_desde.Value).Month, Convert.ToDateTime(fecha_desde.Value).Day);
                cmd.Parameters.AddWithValue("@fecha_desde", SqlDbType.DateTime).Value = fecha_sin_hora;
            }

            if (fecha_hasta.Text != "")
            {
                fecha_sin_hora = new DateTime(Convert.ToDateTime(fecha_hasta.Value).Year, Convert.ToDateTime(fecha_hasta.Value).Month, Convert.ToDateTime(fecha_hasta.Value).Day);
                cmd.Parameters.AddWithValue("@fecha_hasta", SqlDbType.DateTime).Value = fecha_sin_hora;
            }


            if (cmb_tipo_hab.SelectedValue.ToString().CompareTo("0") > 0)
                //if (cmb_tipo_hab.SelectedIndex > 0)
                cmd.Parameters.AddWithValue("@tipo_habitacion", SqlDbType.Int).Value = Convert.ToInt32(cmb_tipo_hab.SelectedValue);


            if (cmb_regimen.SelectedIndex > 0)
                cmd.Parameters.AddWithValue("@regimen_id", SqlDbType.Int).Value = Convert.ToInt32(cmb_regimen.SelectedValue);

            if (accesoSistema.HotelIdActual != 0)
                cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = Convert.ToInt32(accesoSistema.HotelIdActual);

            // Creo el DataTable para obtener los resultados del SP
            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }









        }

        private void btn_dispo_Click(object sender, EventArgs e)
        {

        }
    }
}
