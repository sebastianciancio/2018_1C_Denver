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
    public partial class Consumibles : Form
    {
        private DataBase db;
        DataTable dt_consumos = new DataTable();
        DataTable dt_consumos_nuevos = new DataTable();
        bool existe_estadia_habitacion_seleccionada = false;

        public Consumibles()
        {
            db = DataBase.GetInstance();
            InitializeComponent();

            // Cargo los Combos
            Combos.cargarComboCantidad(cmb_cantidad);
            Combos.cargarComboConsumibles(cmb_productos);
            Combos.cargarComboHabitacion(accesoSistema.HotelIdActual, cmb_habitaciones);
        }

        private void cargar_tabla_consumos(){
            SqlCommand cmd = new SqlCommand("denver.obtener_consumos", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@habitacion_nro", SqlDbType.Int).Value = Convert.ToInt32(cmb_habitaciones.SelectedValue);
            cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = Convert.ToInt32(accesoSistema.HotelIdActual);
            cmd.Parameters.AddWithValue("@nro_reserva", SqlDbType.Int).Direction = ParameterDirection.Output;

            // Limpio la Tabla de consumos nuevos
            dt_consumos.Clear();

            // Creo el DataTable para obtener los resultados del SP
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt_consumos);
            }

            // Cargo la Grilla con los datos obtenidos
            dg_consumos.DataSource = dt_consumos;

            // Oculto Columnas del Resultado
            dg_consumos.Columns[2].Visible = false;

            // Si no existe reserva para la habitacion elegida
            if (cmd.Parameters["@nro_reserva"].Value.ToString() == "")
            {
                Container_consumos.Visible = false;
                Container_consumos_nuevos.Visible = false;
                btn_confirmar.Visible = false;
                dt_consumos.Clear();
                dt_consumos_nuevos.Clear();
                existe_estadia_habitacion_seleccionada = false;

                DialogResult result = MessageBox.Show("No se encontraron Estadias para la Habitacion Nro. " + cmb_habitaciones.Text, "Registro de Consumos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                existe_estadia_habitacion_seleccionada = true;

                // Muestro los objetos ocultos
                Container_consumos.Visible = true;
                Container_consumos_nuevos.Visible = true;
                btn_confirmar.Visible = true;
            }

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            cargar_tabla_consumos();

            if (existe_estadia_habitacion_seleccionada)
            {

                if (dt_consumos_nuevos.Columns.Count == 0)
                {
                    dt_consumos_nuevos = dt_consumos.Clone();
                }

                dg_consumos_nuevos.DataSource = dt_consumos_nuevos;

                // Oculto Columnas del Resultado
                dg_consumos_nuevos.Columns[2].Visible = false;


                for (var veces = 1; veces <= Convert.ToInt32(cmb_cantidad.Text); veces++)
                {

                    DataRow nueva_fila = dt_consumos_nuevos.NewRow();
                    nueva_fila[0] = accesoSistema.fechaSistema.Day.ToString() + "/" + accesoSistema.fechaSistema.Month.ToString() + "/" + accesoSistema.fechaSistema.Year.ToString();
                    nueva_fila[1] = cmb_productos.Text;
                    nueva_fila[2] = cmb_productos.SelectedValue;

                    dt_consumos_nuevos.Rows.Add(nueva_fila);
                }

            }

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd;

            // Asocio los pasajeros a la estadia
            for (var indice = 0; indice < dg_consumos_nuevos.Rows.Count; indice++)
            {
                cmd = new SqlCommand("denver.registrar_consumos", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fecha_consumo", SqlDbType.DateTime).Value = dg_consumos_nuevos.Rows[indice].Cells[0].Value;
                cmd.Parameters.AddWithValue("@consumible_id", SqlDbType.Int).Value = Convert.ToInt32(dg_consumos_nuevos.Rows[indice].Cells[2].Value);
                cmd.Parameters.AddWithValue("@habitacion_nro", SqlDbType.Int).Value = Convert.ToInt32(cmb_habitaciones.Text);
                cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = Convert.ToInt32(accesoSistema.HotelIdActual);

                // Ejecuto el SP
                cmd.ExecuteNonQuery();
            }

            // Limpio la Tabla de consumos nuevos
            dt_consumos_nuevos.Clear();

            // Cargo la Tabla de Consumos
            cargar_tabla_consumos();
        }
    }
}
