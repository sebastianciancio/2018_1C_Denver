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

        public Consumibles()
        {
            db = DataBase.GetInstance();
            InitializeComponent();

            // Cargo los Combos
            Combos.cargarComboCantidad(cmb_cantidad);
            Combos.cargarComboConsumibles(cmb_productos);
            Combos.cargarComboHabitacion(accesoSistema.HotelIdActual, cmb_habitaciones);
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.obtener_consumos", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@habitacion_nro", SqlDbType.Int).Value = Convert.ToInt32(cmb_habitaciones.SelectedValue);
            cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = Convert.ToInt32(accesoSistema.HotelIdActual);

 
            // Creo el DataTable para obtener los resultados del SP
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt_consumos);
            }

            // Cargo la Grilla con los datos obtenidos
            dg_consumos.DataSource = dt_consumos;

            if (dt_consumos_nuevos.Columns.Count == 0)
            {
                dt_consumos_nuevos = dt_consumos.Clone();
            }

            dg_consumos_nuevos.DataSource = dt_consumos_nuevos;

            // Oculto Columnas del Resultado
            dg_consumos.Columns[2].Visible = false;
            dg_consumos_nuevos.Columns[2].Visible = false;

            // Muestro los objetos ocultos
            Container_consumos.Visible = true;
            Container_consumos_nuevos.Visible = true;

            for (var veces = 1; veces <= Convert.ToInt32(cmb_cantidad.Text); veces++ )
            {

                DataRow nueva_fila = dt_consumos_nuevos.NewRow();
                nueva_fila[0] = DateTime.Now.ToString("dd/MM/yyyy");
                nueva_fila[1] = cmb_productos.Text;
                nueva_fila[2] = cmb_productos.SelectedValue;

                dt_consumos_nuevos.Rows.Add(nueva_fila);
            }
        }

        private void dg_consumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
