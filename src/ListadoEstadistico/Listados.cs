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
    public partial class Listados : Form
    {
        private DataBase db;
        public Listados()
        {
            db = DataBase.GetInstance();
            InitializeComponent();

            // Cargo el Combo Tipo de Reporte
            Combos.cargarComboListados(cmb_tipo_reporte);
            Combos.cargarComboCantidad(cmb_anio, 2010, 2020);
            Combos.cargarComboCantidad(cmb_trimestre, 1, 4);
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();

            switch(cmb_tipo_reporte.Text){
                case "Hoteles con mayor cantidad de reservas canceladas":
                    cmd = new SqlCommand("denver.listado1", db.Connection);
                    break;
                case "Hoteles con mayor cantidad de consumibles facturados": 
                    cmd = new SqlCommand("denver.listado2", db.Connection);
                    break;
                case "Hoteles con mayor cantidad de días fuera de servicio": 
                    cmd = new SqlCommand("denver.listado3", db.Connection);
                    break;
                case "Habitaciones con mayor cantidad de días y veces que fueron ocupados": 
                    cmd = new SqlCommand("denver.listado4", db.Connection);
                    break;
                case "Cliente con mayor cantidad de puntos": 
                    cmd = new SqlCommand("denver.listado5", db.Connection);
                    break;
            }

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@anio", SqlDbType.Int).Value = Convert.ToInt32(cmb_anio.Text);
            cmd.Parameters.AddWithValue("@trimestre", SqlDbType.Int).Value = Convert.ToInt32(cmb_trimestre.Text);

            // Creo el DataTable para obtener los resultados del SP
            DataTable dt = new DataTable();
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            // Cargo la Grilla con los datos obtenidos
            dg_reporte.DataSource = dt;

            Container_reporte.Visible = true;
        }
    }
}
