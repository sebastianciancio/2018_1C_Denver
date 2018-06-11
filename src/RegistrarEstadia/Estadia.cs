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

namespace FrbaHotel
{
    public partial class Estadia : Form
    {
        private DataBase db;
        DataTable dt_pasajeros = new DataTable();
        DateTime fecha_desde, fecha_hasta;
        public Estadia()
        {
            db = DataBase.GetInstance();
            InitializeComponent();

            // Cargo los combos
            Combos.cargarComboHabitacion(accesoSistema.HotelIdActual, cmb_habitacion);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_checkin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.obtener_pasajero_reserva", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nro_reserva", SqlDbType.Int).Value = Convert.ToInt32(nro_reserva.Text);

            dt_pasajeros.Clear();

            // Creo el DataTable para obtener los resultados del SP
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt_pasajeros);
            }

            // Cargo la Grilla con los datos obtenidos
            dg_pasajeros.DataSource = dt_pasajeros;

            // Oculto Columnas del Resultado
            dg_pasajeros.Columns[4].Visible = false;

            // Cargo el detalle de la reserva
            cmd = new SqlCommand("denver.obtener_detalle_reserva", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nro_reserva", SqlDbType.Int).Value = Convert.ToInt32(nro_reserva.Text);

            // Creo el DataTable para obtener los resultados del SP
            DataTable dt_detalle_reserva = new DataTable();
            using (var da2 = new SqlDataAdapter(cmd))
            {
                da2.Fill(dt_detalle_reserva);
            }

            // Cargo la Grilla con los datos obtenidos
            dg_estadia.DataSource = dt_detalle_reserva;

            // Oculto Columnas del Resultado
            dg_estadia.Columns[6].Visible = false;

            // Si hay Registros y el estado no es cancelado ni confimado
            if (dg_estadia.RowCount > 0 & Convert.ToInt32(dg_estadia.Rows[0].Cells[7].Value) <= 2)
            {
                fecha_desde = Convert.ToDateTime(dg_estadia.Rows[0].Cells[0].Value);
                fecha_hasta = Convert.ToDateTime(dg_estadia.Rows[0].Cells[1].Value);

                // Muestro los objetos ocultos
                Container_estadia.Visible = true;
                Container_pasajero.Visible = true;
            }
            else
            {
                DialogResult result = MessageBox.Show("No se encontraron datos de la Reserva", "Check/In", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Container_estadia.Visible = false;
                Container_pasajero.Visible = false;
            }
        }

        private void btn_agregar_pax_Click(object sender, EventArgs e)
        {
            // Habilito la seleccion de Clientes
            accesoSistema.habilitarSeleccionCliente = true;

            Cliente frm = new Cliente();
            frm.Show();
        }

        private void Estadia_Activated(object sender, EventArgs e)
        {
            // Si existe un cliente seleccionado
            if (accesoSistema.ClienteSeleccionado.cliente_apellido != "")
            {
                DataRow nueva_fila = dt_pasajeros.NewRow();
                nueva_fila[0] = accesoSistema.ClienteSeleccionado.cliente_apellido;
                nueva_fila[1] = accesoSistema.ClienteSeleccionado.cliente_nombre;
                nueva_fila[2] = accesoSistema.ClienteSeleccionado.cliente_tipo_documento;
                nueva_fila[3] = accesoSistema.ClienteSeleccionado.cliente_dni;
                nueva_fila[4] = accesoSistema.ClienteSeleccionado.cliente_tipo_documento_id;

                dt_pasajeros.Rows.Add(nueva_fila);
            }
            // Deshabilito la seleccion de Clientes
            accesoSistema.habilitarSeleccionCliente = false;
        }

        // Valido que el cliente original no se pueda borrar
        private void dg_pasajeros_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Index == 0)
            {
                DialogResult result = MessageBox.Show("No se puede eliminar el Cliente original de la Reserva", "Check/In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void btn_confirmar_checkin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;

            // Asocio los pasajeros a la estadia
            for (var indice = 0; indice < dg_pasajeros.Rows.Count; indice++)
            {
                cmd = new SqlCommand("denver.confirmar_checkin", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@estadia_fecha_inicio", SqlDbType.DateTime).Value = fecha_desde;
                cmd.Parameters.AddWithValue("@estadia_fecha_fin", SqlDbType.DateTime).Value = fecha_hasta;
                cmd.Parameters.AddWithValue("@estadia_cliente_tipo_documento_id", SqlDbType.Int).Value = Convert.ToInt32(dg_pasajeros.Rows[indice].Cells[4].Value);
                cmd.Parameters.AddWithValue("@estadia_cliente_pasaporte_nro", SqlDbType.Int).Value = Convert.ToInt32(dg_pasajeros.Rows[indice].Cells[3].Value);
                cmd.Parameters.AddWithValue("@estadia_hotel_id", SqlDbType.Int).Value = Convert.ToInt32(accesoSistema.HotelIdActual);
                cmd.Parameters.AddWithValue("@estadia_usuario_user", SqlDbType.VarChar).Value = accesoSistema.UsuarioLogueado.Id;
                cmd.Parameters.AddWithValue("@nro_reserva", SqlDbType.Int).Value = Convert.ToInt32(nro_reserva.Text);

                // Ejecuto el SP
                cmd.ExecuteNonQuery();
            }

            // Bloqueo las disponibilidades para las fechas de la estadia
            DateTime fecha_sin_hora;
            while (fecha_desde <= fecha_hasta)
            {
                for (var indice = 0; indice < dg_estadia.Rows.Count; indice++)
                {
                    cmd = new SqlCommand("denver.ocupar_disponibilidad", db.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    fecha_sin_hora = new DateTime(fecha_desde.Year, fecha_desde.Month, fecha_desde.Day);

                    cmd.Parameters.AddWithValue("@fecha_ocupacion", SqlDbType.DateTime).Value = fecha_sin_hora;
                    cmd.Parameters.AddWithValue("@habitacion_nro", SqlDbType.Int).Value = Convert.ToInt32(dg_estadia.Rows[indice].Cells[5].Value);
                    cmd.Parameters.AddWithValue("@tipo_habitacion", SqlDbType.Int).Value = Convert.ToInt32(dg_estadia.Rows[indice].Cells[6].Value);
                    cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = Convert.ToInt32(accesoSistema.HotelIdActual);

                    // Ejecuto el SP
                    cmd.ExecuteNonQuery();
                }
                // Incremento la fecha
                fecha_desde = fecha_desde.AddDays(1);
            }

            // Confirmo la Estadia
            DialogResult result = MessageBox.Show("Estadia confirmada", "Confirmacion de Estadia",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reseteo los datos
            Container_estadia.Visible = false;
            Container_pasajero.Visible = false;
            accesoSistema.habilitarSeleccionCliente = false;

            accesoSistema.ClienteSeleccionado.cliente_apellido = "";
            accesoSistema.ClienteSeleccionado.cliente_nombre = "";
            accesoSistema.ClienteSeleccionado.cliente_dni = 0;
            accesoSistema.ClienteSeleccionado.cliente_tipo_documento = "";
            accesoSistema.ClienteSeleccionado.cliente_tipo_documento_id = 0;

        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;

            // Cargo el detalle de la reserva
            cmd = new SqlCommand("denver.obtener_detalle_reserva", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@habitacion_nro", SqlDbType.Int).Value = Convert.ToInt32(cmb_habitacion.Text);

            // Creo el DataTable para obtener los resultados del SP
            DataTable dt_detalle_reserva = new DataTable();
            using (var da2 = new SqlDataAdapter(cmd))
            {
                da2.Fill(dt_detalle_reserva);
            }

            // Cargo la Grilla con los datos obtenidos
            dg_estadia.DataSource = dt_detalle_reserva;


            // Si hay Registros
            if (dg_estadia.RowCount > 0)
            {

                // Oculto Columnas del Resultado
                dg_estadia.Columns[6].Visible = false;
                dg_estadia.Columns[7].Visible = false;


                fecha_desde = Convert.ToDateTime(dg_estadia.Rows[0].Cells[0].Value);
                fecha_hasta = Convert.ToDateTime(dg_estadia.Rows[0].Cells[1].Value);

                // Muestro los objetos ocultos
                Container_estadia.Visible = true;
                btn_confirmar_checkout.Visible = true;
                Container_pasajero.Visible = false;
            }
            else
            {
                DialogResult result = MessageBox.Show("No se encontraron Estadias activas", "Check/Out", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Container_estadia.Visible = false;
                Container_pasajero.Visible = false;
                btn_confirmar_checkout.Visible = false;
            }

        }

        private void btn_confirmar_checkout_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;

            // Libero las disponibilidades para las fechas de la estadia
            DateTime fecha_sin_hora;
            while (fecha_desde <= fecha_hasta)
            {
                for (var indice = 0; indice < dg_estadia.Rows.Count; indice++)
                {
                    cmd = new SqlCommand("denver.liberar_disponibilidad", db.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    fecha_sin_hora = new DateTime(fecha_desde.Year, fecha_desde.Month, fecha_desde.Day);

                    cmd.Parameters.AddWithValue("@fecha_ocupacion", SqlDbType.DateTime).Value = fecha_sin_hora;
                    cmd.Parameters.AddWithValue("@habitacion_nro", SqlDbType.Int).Value = Convert.ToInt32(dg_estadia.Rows[indice].Cells[5].Value);
                    cmd.Parameters.AddWithValue("@tipo_habitacion", SqlDbType.Int).Value = Convert.ToInt32(dg_estadia.Rows[indice].Cells[6].Value);
                    cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = Convert.ToInt32(accesoSistema.HotelIdActual);

                    // Ejecuto el SP
                    cmd.ExecuteNonQuery();
                }
                // Incremento la fecha
                fecha_desde = fecha_desde.AddDays(1);
            }

            // Confirmo la Estadia
            DialogResult result = MessageBox.Show("Check-Out confirmado", "Confirmacion",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
