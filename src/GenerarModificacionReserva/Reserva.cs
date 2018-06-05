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

        private void Reserva_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.obtener_disponibilidad", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;


            //DateTime fecha = DateTime.ParseExact(fecha_desde.Text, "dd/mm/yyyy", CultureInfo.InvariantCulture);
            DateTime fecha = DateTime.ParseExact("01-02-2018","dd-MM-yyyy", null);

            if (fecha_desde.Text != "")
                cmd.Parameters.AddWithValue("@fecha_desde", SqlDbType.DateTime).Value = Convert.ToDateTime("01-01-2018");

            if (fecha_hasta.Text != "")
                cmd.Parameters.AddWithValue("@fecha_hasta", SqlDbType.DateTime).Value = Convert.ToDateTime("01-01-2018");

            if (cmb_tipo_hab.SelectedValue.ToString().CompareTo("0") > 0)
                cmd.Parameters.AddWithValue("@tipo_habitacion", SqlDbType.Int).Value = Convert.ToInt32(cmb_tipo_hab.SelectedValue);

            if (cmb_regimen.SelectedValue.ToString().CompareTo("0") > 0)
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

        }
    }
}
