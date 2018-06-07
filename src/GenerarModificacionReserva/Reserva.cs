﻿using System;
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
    public partial class Reserva : Form
    {
        private DataBase db;
        public Reserva()
        {
            db = DataBase.GetInstance();
            InitializeComponent();

            // Cargo los Combos
            Combos.cargarComboTipoHabitacion(cmb_tipo_hab);
            Combos.cargarComboTipoRegimen(cmb_regimen, true);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.obtener_disponibilidad", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (fecha_desde.Text != "")
                cmd.Parameters.AddWithValue("@fecha_desde", SqlDbType.DateTime).Value = fecha_desde.Value;

            if (fecha_hasta.Text != "")
                cmd.Parameters.AddWithValue("@fecha_hasta", SqlDbType.DateTime).Value = fecha_hasta.Value;

            if (cmb_tipo_hab.SelectedValue.ToString().CompareTo("0") > 0)
            //if (cmb_tipo_hab.SelectedIndex > 0)
                cmd.Parameters.AddWithValue("@tipo_habitacion", SqlDbType.Int).Value = Convert.ToInt32(cmb_tipo_hab.SelectedValue);


            if (cmb_regimen.SelectedIndex > 0)
                cmd.Parameters.AddWithValue("@regimen_id", SqlDbType.Int).Value = Convert.ToInt32(cmb_regimen.SelectedValue);

            cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = Convert.ToInt32(accesoSistema.HotelIdActual);

            // Creo el DataTable para obtener los resultados del SP
            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            // Cargo la Grilla con los datos obtenidos
            dg_disponibilidad.DataSource = dt;

            // Oculto la Columna con Max Pax
            dg_disponibilidad.Columns[4].Visible = false;

            // Muestro los objetos ocultos
            dg_disponibilidad.Visible = true;
            Container_disponibilidad.Visible = true;
            Container_pasajero.Visible = true;

            // Habilito la seleccion de Clientes
            accesoSistema.habilitarSeleccionCliente = true;

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            // Deshabilito la seleccion de Clientes
            accesoSistema.habilitarSeleccionCliente = true;

            Cliente frm = new Cliente();
            frm.Show();
        }

        private void Reserva_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Deshabilito la seleccion de Clientes
            accesoSistema.habilitarSeleccionCliente = false;
        }

        private void Reserva_Activated(object sender, EventArgs e)
        {
            // Si existe un cliente seleccionado
            if (accesoSistema.ClienteSeleccionado.cliente_apellido != "")
            {

                Container_Detalle_Reserva.Visible = true;

                // Cuando se activa el formulario, si existe el cliente seleccionado, lo cargo
                txt_reserva_pasajero.Text = accesoSistema.ClienteSeleccionado.cliente_apellido + ' ' + accesoSistema.ClienteSeleccionado.cliente_nombre + " (" + accesoSistema.ClienteSeleccionado.cliente_tipo_documento + ' ' + accesoSistema.ClienteSeleccionado.cliente_dni+')';
                txt_reserva_fechas.Text = fecha_desde.Text +" / "+ fecha_hasta.Text;
                txt_reserva_habitacion.Text = cmb_tipo_hab.Text;

                //Levanto las lineas seleccionada de disponibilidades
                DataGridViewSelectedRowCollection row = dg_disponibilidad.SelectedRows;

                // Calculo el total de la Reserva
                int total_reserva = 0;
                for (var indice = 0; indice < row.Count;indice++ )
                {
                    total_reserva += Convert.ToInt32(row[indice].Cells[4].Value) * Convert.ToInt32(row[indice].Cells[3].Value);
                }

                txt_reserva_total.Text = "$" + total_reserva;
            }
        }

        // Si se cambio la seleccion de la reserva, actualizo el Total
        private void dg_disponibilidad_SelectionChanged(object sender, EventArgs e)
        {
            Reserva_Activated(sender, e);
        }

        private void btn_confirmar_reserva_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("denver.crear_reserva", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@reserva_fecha_inicio", SqlDbType.DateTime).Value = fecha_desde.Value;
            cmd.Parameters.AddWithValue("@reserva_fecha_fin", SqlDbType.DateTime).Value = fecha_hasta.Value;
            cmd.Parameters.AddWithValue("@reserva_cliente_tipo_documento_id", SqlDbType.Int).Value = Convert.ToInt32(accesoSistema.ClienteSeleccionado.cliente_tipo_documento_id);
            cmd.Parameters.AddWithValue("@reserva_cliente_pasaporte_nro", SqlDbType.Int).Value = Convert.ToInt32(accesoSistema.ClienteSeleccionado.cliente_dni);
            cmd.Parameters.AddWithValue("@reserva_hotel_id", SqlDbType.Int).Value = Convert.ToInt32(accesoSistema.HotelIdActual);
            cmd.Parameters.AddWithValue("@reserva_usuario_user", SqlDbType.VarChar).Value = accesoSistema.UsuarioLogueado.Id;
            cmd.Parameters.AddWithValue("@reserva_estado_id", SqlDbType.Int).Value = 1;
            cmd.Parameters.AddWithValue("@nro_reserva", SqlDbType.Int).Direction = ParameterDirection.Output;

            // Ejecuto el SP
            cmd.ExecuteNonQuery();

            // Muestro el Nro de Reserva
            DialogResult result = MessageBox.Show("Reserva Nro.: " + cmd.Parameters["@nro_reserva"].Value.ToString(), "Confirmacion de Reserva",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reseteo los datos
            dg_disponibilidad.Visible = false;
            Container_disponibilidad.Visible = false;
            Container_pasajero.Visible = false;
            Container_Detalle_Reserva.Visible = false;
            accesoSistema.habilitarSeleccionCliente = false;

            accesoSistema.ClienteSeleccionado.cliente_apellido = "";
            accesoSistema.ClienteSeleccionado.cliente_nombre = "";
            accesoSistema.ClienteSeleccionado.cliente_dni = 0;
            accesoSistema.ClienteSeleccionado.cliente_tipo_documento = "";
            accesoSistema.ClienteSeleccionado.cliente_tipo_documento_id = 0;
        }
    }
}
