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


            //DateTime fecha = DateTime.ParseExact(fecha_desde.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture);
            DateTime fecha = DateTime.ParseExact("01-02-2018","dd-MM-yyyy", null);

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

            // Muestro los objetos ocultos
            dg_disponibilidad.Visible = true;
            Container_disponibilidad.Visible = true;
            Container_pasajero.Visible = true;

            // Habilito la seleccion de Clientes
            accesoSistema.habilitarSeleccionCliente = true;

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
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
                txt_reserva_total.Text = "$0.00";
            }
        }
    }
}
