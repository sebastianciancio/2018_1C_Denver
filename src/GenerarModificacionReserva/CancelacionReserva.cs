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
using System.Globalization;

namespace FrbaHotel
{
    public partial class CancelacionReserva : Form
    {
        private DataBase db;
        public CancelacionReserva()
        {
            db = DataBase.GetInstance();
            InitializeComponent();

            // Cargo los Combos
            Combos.cargarComboHotel(cmb_hotel, false);

            // Si existe un usuario logueado
            if (accesoSistema.HotelIdActual != 0)
            {
                cmb_hotel.SelectedValue = accesoSistema.HotelIdActual;
                cmb_hotel.Enabled = false;
            }
        }

        private void btn_checkin_Click(object sender, EventArgs e)
        {
            float numero_generico;

            // Si se cargo la Reserva
            if (nro_reserva.Text != "" & float.TryParse(nro_reserva.Text, out numero_generico))
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT denver.dias_antes_reserva ('" + nro_reserva.Text + "','"+ accesoSistema.fechaSistema +"')", db.Connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Si la reserva comienza antes de hoy
                if (Convert.ToInt32(dt.Rows[0][0]) < 0)
                {
                    // Cargo el detalle de la reserva
                    SqlCommand cmd = new SqlCommand("denver.obtener_detalle_reserva", db.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nro_reserva", SqlDbType.Int).Value = Convert.ToInt32(nro_reserva.Text);

                    // Creo el DataTable para obtener los resultados del SP
                    DataTable dt_detalle_reserva = new DataTable();
                    using (var da2 = new SqlDataAdapter(cmd))
                    {
                        da2.Fill(dt_detalle_reserva);
                    }

                    // Cargo la Grilla con los datos obtenidos
                    dg_reserva.DataSource = dt_detalle_reserva;

                    // Oculto Columnas del Resultado
                    dg_reserva.Columns[6].Visible = false;
                    dg_reserva.Columns[7].Visible = false;

                    // Si no hay Registros 
                    if (dg_reserva.RowCount == 0)
                    {
                        DialogResult result = MessageBox.Show("No se encontraron datos de la Reserva", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Container_reserva.Visible = false;
                    }
                    else
                    {
                        Container_reserva.Visible = true;
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("No se puede cancelar la Reserva ya que debe hacerse 24 hs antes del inicio", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Container_reserva.Visible = false;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Debe ingresar la Reserva para continuar", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancelar_reserva_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < txb_motivo.Lines.Count(); i++)
            {
                sb.Append(txb_motivo.Lines[i].ToString());
            }
            string desc = sb.ToString();

            SqlCommand cmd = new SqlCommand("denver.cancelar_reserva", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cod_reserva", SqlDbType.Int).Value = Convert.ToInt32(nro_reserva.Text);
            cmd.Parameters.AddWithValue("@motivo", SqlDbType.VarChar).Value = desc;
            if (accesoSistema.UsuarioLogueado.Nombre == "")
            {
                cmd.Parameters.AddWithValue("@user", SqlDbType.VarChar).Value = "GUEST";
                cmd.Parameters.AddWithValue("@estado", SqlDbType.Int).Value = 4;
            }
            else
            {
                cmd.Parameters.AddWithValue("@user", SqlDbType.VarChar).Value = accesoSistema.UsuarioLogueado.Id;
                cmd.Parameters.AddWithValue("@estado", SqlDbType.Int).Value = 3;
            }
            cmd.Parameters.AddWithValue("@fecha_sistema", SqlDbType.DateTime).Value = accesoSistema.fechaSistema;

            cmd.ExecuteNonQuery();

            MessageBox.Show("La reserva se canceló con exito", "Mensaje");

            Close();
        }
    }
}
