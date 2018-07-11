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
    public partial class ModificacionReserva : Form
    {
        private DataBase db;
        public ModificacionReserva()
        {
            db = DataBase.GetInstance();
            InitializeComponent();

            // Cargo los Combos
            Combos.cargarComboHotel(cmb_hotel, false);
            Combos.cargarComboTipoHabitacion(cmb_tipo_hab);
            Combos.cargarComboTipoRegimen(cmb_regimen);

            // Si existe un usuario logueado
            if (accesoSistema.HotelIdActual != 0)
            {
                cmb_hotel.SelectedValue = accesoSistema.HotelIdActual;
                cmb_hotel.Enabled = false;
            }
        }

        private void btn_buscar_reserva_Click(object sender, EventArgs e)
        {
            float numero_generico;

            // Si se cargo la Reserva
            if (nro_reserva.Text != "" & float.TryParse(nro_reserva.Text, out numero_generico))
            {

                // Valido que exista la reserva
                SqlDataAdapter sda = new SqlDataAdapter("SELECT denver.existe_reserva ('" + nro_reserva.Text + "')", db.Connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Si existe
                if (Convert.ToInt32(dt.Rows[0][0]) == 1)
                {
                    sda = new SqlDataAdapter("SELECT denver.dias_antes_reserva ('" + nro_reserva.Text + "','" + accesoSistema.fechaSistema + "')", db.Connection);
                    dt = new DataTable();
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
                        dg_reserva.Columns[8].Visible = false;

                        // Si no hay Registros 
                        if (dg_reserva.RowCount == 0)
                        {
                            DialogResult result = MessageBox.Show("No se encontraron datos de la Reserva", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Container_reserva.Visible = false;
                        }
                        else
                        {
                            Container_reserva.Visible = true;
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("No se puede cancelar la Reserva ya que debe hacerse 24 hs antes del inicio", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Container_reserva.Visible = false;
                    }
                }
                else 
                {
                    DialogResult result = MessageBox.Show("No existe la Reserva ingresada", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Container_reserva.Visible = false;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Debe ingresar la Reserva para continuar", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dg_reserva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label_disponibilidad.Visible = false;

            DataGridViewRow row = dg_reserva.CurrentRow;

            // Cargo el registro para poder modificarlo
            fecha_desde.Value = DateTime.ParseExact(row.Cells[0].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
            fecha_hasta.Value = DateTime.ParseExact(row.Cells[1].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
            cmb_regimen.SelectedValue= row.Cells[8].Value.ToString();
            cmb_tipo_hab.SelectedValue = row.Cells[6].Value.ToString();
            
            // Muestro el Container del registro a modificar
            Container_modif_reserva.Visible = true;
        }

        private void btn_check_disponibilidad_Click(object sender, EventArgs e)
        {

            label_disponibilidad.Visible = false;

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

            cmd.Parameters.AddWithValue("@tipo_habitacion", SqlDbType.Int).Value = Convert.ToInt32(cmb_tipo_hab.SelectedValue);
            cmd.Parameters.AddWithValue("@regimen_id", SqlDbType.Int).Value = Convert.ToInt32(cmb_regimen.SelectedValue);
            cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = Convert.ToInt32(cmb_hotel.SelectedValue);

            // Creo el DataTable para obtener los resultados del SP
            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            // Cargo la Grilla con los datos obtenidos
            dg_disponibilidad.DataSource = dt;

            // Si hay disponibilidad
            if (dg_disponibilidad.RowCount > 0)
            {
                label_disponibilidad.Visible = true;
                label_disponibilidad.BackColor = Color.GreenYellow;
                label_disponibilidad.ForeColor = Color.Black;
                label_disponibilidad.Text = "Existe disponibilidad";

                // Muestro el boton Modificar
                btn_Modificar.Visible = true;
            }
            else
            {
                label_disponibilidad.Visible = true;
                label_disponibilidad.BackColor = Color.Red;
                label_disponibilidad.ForeColor = Color.White;
                label_disponibilidad.Text = "No existe disponibilidad";

                // Oculto el boton Modificar
                btn_Modificar.Visible = false;
            }

        }
    }
}
