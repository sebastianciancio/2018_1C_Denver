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

        private DateTime original_fecha_inicio;
        private DateTime original_fecha_fin;
        private int original_tipo_habitacion;
        private int original_regimen_id;
        private int original_habitacion_nro;
        private int nueva_precio;
        private int nueva_habitacion_nro;

        public ModificacionReserva()
        {
            db = DataBase.GetInstance();
            InitializeComponent();

            // Cargo los Combos
            Combos.cargarComboHotel(cmb_hotel, false);
            Combos.cargarComboTipoHabitacion(cmb_tipo_hab);
            Combos.cargarComboTipoRegimen(cmb_regimen, accesoSistema.HotelIdActual);

            // Si existe un usuario logueado
            if (accesoSistema.HotelIdActual != 0)
            {
                cmb_hotel.SelectedValue = accesoSistema.HotelIdActual;
                cmb_hotel.Enabled = false;
            }
        }

        private void btn_buscar_reserva_Click(object sender, EventArgs e)
        {
            label_disponibilidad.Visible = false;
            label_hab_precio.Visible = false;

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
                    sda = new SqlDataAdapter("SELECT denver.dias_antes_reserva ('" + nro_reserva.Text + "','" + accesoSistema.fechaSistemaSQL + "')", db.Connection);
                    dt = new DataTable();
                    sda.Fill(dt);

                    // Si la reserva comienza antes de hoy
                    if (Convert.ToInt32(dt.Rows[0][0]) < 0)
                    {
                        // Cargo el detalle de la reserva
                        SqlCommand cmd = new SqlCommand("denver.obtener_detalle_reserva", db.Connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@nro_reserva", SqlDbType.Int).Value = Convert.ToInt32(nro_reserva.Text);
                        cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = Convert.ToInt32(cmb_hotel.SelectedValue);

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
                        DialogResult result = MessageBox.Show("No se puede modificar la Reserva ya que debe hacerse 24 hs antes del inicio", "Modificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            label_hab_precio.Visible = false;

            DataGridViewRow row = dg_reserva.CurrentRow;

            // Guardo los registros anteriores
            original_fecha_inicio = DateTime.ParseExact(row.Cells[0].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
            original_fecha_fin = DateTime.ParseExact(row.Cells[1].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
            original_tipo_habitacion = Convert.ToInt32(row.Cells[6].Value);
            original_regimen_id = Convert.ToInt32(row.Cells[8].Value);
            original_habitacion_nro = Convert.ToInt32(row.Cells[5].Value);

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
            label_hab_precio.Visible = false;

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

                // Guardo una Habitacion y su precio
                nueva_precio = (Convert.ToInt32(dg_disponibilidad.Rows[0].Cells[4].Value) * Convert.ToInt32(dg_disponibilidad.Rows[0].Cells[3].Value)) + Convert.ToInt32(dg_disponibilidad.Rows[0].Cells[7].Value);
                nueva_habitacion_nro = Convert.ToInt32(dg_disponibilidad.Rows[0].Cells[0].Value);

                label_hab_precio.Text = "Nro. de Habitación disponible: " + nueva_habitacion_nro.ToString() + " - Precio Diario por Pax: " + nueva_precio.ToString();

                // Muestro el boton Modificar
                btn_Modificar.Visible = true;
                label_hab_precio.Visible = true;
            }
            else
            {
                label_disponibilidad.Visible = true;
                label_disponibilidad.BackColor = Color.Red;
                label_disponibilidad.ForeColor = Color.White;
                label_disponibilidad.Text = "No existe disponibilidad";

                // Oculto el boton Modificar
                btn_Modificar.Visible = false;
                label_hab_precio.Visible = false;
            }

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.modificar_reserva", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@original_fecha_inicio", SqlDbType.DateTime).Value = original_fecha_inicio;
            cmd.Parameters.AddWithValue("@original_fecha_fin", SqlDbType.DateTime).Value = original_fecha_fin;
            cmd.Parameters.AddWithValue("@original_tipo_habitacion", SqlDbType.Int).Value = original_tipo_habitacion;
            cmd.Parameters.AddWithValue("@original_regimen_id", SqlDbType.Int).Value = original_regimen_id;
            cmd.Parameters.AddWithValue("@original_habitacion_nro", SqlDbType.Int).Value = original_habitacion_nro;

            cmd.Parameters.AddWithValue("@nueva_fecha_inicio", SqlDbType.DateTime).Value = fecha_desde.Value;
            cmd.Parameters.AddWithValue("@nueva_fecha_fin", SqlDbType.DateTime).Value = fecha_hasta.Value;
            cmd.Parameters.AddWithValue("@nueva_tipo_habitacion", SqlDbType.Int).Value = Convert.ToInt32(cmb_tipo_hab.SelectedValue);
            cmd.Parameters.AddWithValue("@nueva_regimen_id", SqlDbType.Int).Value = Convert.ToInt32(cmb_regimen.SelectedValue);
            cmd.Parameters.AddWithValue("@nueva_precio", SqlDbType.Int).Value = Convert.ToInt32(cmb_tipo_hab.SelectedValue);
            cmd.Parameters.AddWithValue("@nueva_habitacion_nro", SqlDbType.Int).Value = nueva_habitacion_nro;



            if (accesoSistema.UsuarioLogueado.Nombre == "")
            {
                cmd.Parameters.AddWithValue("@reserva_usuario_user", SqlDbType.VarChar).Value = "GUEST";
            }
            else
            {
                cmd.Parameters.AddWithValue("@reserva_usuario_user", SqlDbType.VarChar).Value = accesoSistema.UsuarioLogueado.Id;
            }

            cmd.Parameters.AddWithValue("@reserva_hotel_id", SqlDbType.Int).Value = Convert.ToInt32(cmb_hotel.SelectedValue);
            cmd.Parameters.AddWithValue("@fecha_sistema", SqlDbType.DateTime).Value = accesoSistema.fechaSistemaSQL;
            cmd.Parameters.AddWithValue("@nro_reserva", SqlDbType.Int).Value = Convert.ToInt32(nro_reserva.Text);

            // Ejecuto el SP
            cmd.ExecuteNonQuery();

            MessageBox.Show("La reserva se ha modificado", "Mensaje");

            // Oculto los objetos
            btn_Modificar.Visible = false;
            label_hab_precio.Visible = false;
            Container_reserva.Visible = false;
            Container_modif_reserva.Visible = false;
            label_disponibilidad.Visible = false;

        }
    }
}
