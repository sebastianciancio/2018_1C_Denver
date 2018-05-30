using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace FrbaHotel
{
    public class Combos
    {
        private DataBase db;

        public Combos()
        {
            db = DataBase.GetInstance();
        }

        public static void cargarComboPais(ComboBox combo)
        {
           
            SqlCommand cmd = new SqlCommand("SELECT pais_id, pais_nombre FROM denver.paises ORDER BY pais_nombre", DataBase.GetInstance().Connection);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("pais_id", typeof(int));
            dt.Columns.Add("pais_nombre", typeof(string));
            dt.Load(reader);

            combo.ValueMember = "pais_id";
            combo.DisplayMember = "pais_nombre";
            combo.DataSource = dt;

        }

        public static void cargarComboTipoHabitacion(ComboBox combo)
        {

            SqlCommand cmd = new SqlCommand("SELECT tipo_habitacion_id,tipo_habitacion_descripcion FROM denver.tipo_habitaciones ORDER BY tipo_habitacion_descripcion", DataBase.GetInstance().Connection);
            SqlDataReader reader;            

            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("tipo_habitacion_id", typeof(int));
            dt.Columns.Add("tipo_habitacion_descripcion", typeof(string));
            dt.Load(reader);

            combo.ValueMember = "tipo_habitacion_id";
            combo.DisplayMember = "tipo_habitacion_descripcion";
            combo.DataSource = dt;

        }

        public static void cargarComboTipoRegimen(ComboBox combo)
        {
            SqlCommand cmd = new SqlCommand("SELECT regimen_id,regimen_descripcion FROM denver.regimenes ORDER BY regimen_descripcion", DataBase.GetInstance().Connection);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("regimen_id", typeof(int));
            dt.Columns.Add("regimen_descripcion", typeof(string));
            dt.Load(reader);

            combo.ValueMember = "regimen_id";
            combo.DisplayMember = "regimen_descripcion";
            combo.DataSource = dt;

        }

        public static void cargarComboTipoDocumento(ComboBox combo)
        {
            SqlCommand cmd = new SqlCommand("SELECT tipo_documento_id,tipo_documento_nombre FROM denver.tipo_documentos ORDER BY tipo_documento_nombre", DataBase.GetInstance().Connection);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("tipo_documento_id", typeof(int));
            dt.Columns.Add("tipo_documento_nombre", typeof(string));
            dt.Load(reader);

            combo.ValueMember = "tipo_documento_id";
            combo.DisplayMember = "tipo_documento_nombre";
            combo.DataSource = dt;

        }

        public static void cargarComboHotel(ComboBox combo)
        {
            SqlCommand cmd = new SqlCommand("SELECT hotel_id,hotel_nombre FROM denver.hoteles ORDER BY hotel_nombre", DataBase.GetInstance().Connection);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("hotel_id", typeof(int));
            dt.Columns.Add("hotel_nombre", typeof(string));
            dt.Load(reader);

            combo.ValueMember = "hotel_id";
            combo.DisplayMember = "hotel_nombre";
            combo.DataSource = dt;

        }

        public static void cargarComboListados(ComboBox combo)
        {
            // Cargo los Combos
            combo.DisplayMember = "Text";
            combo.ValueMember = "Value";
            combo.Items.Add(new { Text = "Hoteles con mayor cantidad de reservas canceladas", Value = "1" });
            combo.Items.Add(new { Text = "Hoteles con mayor cantidad de consumibles facturados", Value = "2" });
            combo.Items.Add(new { Text = "Hoteles con mayor cantidad de días fuera de servicio", Value = "3" });
            combo.Items.Add(new { Text = "Habitaciones con mayor cantidad de días y veces que fueron ocupados", Value = "4" });
            combo.Items.Add(new { Text = "Cliente con mayor cantidad de puntos", Value = "5" });

            // Seteo el Item por default
            combo.SelectedIndex = 1;
        }

        public static void cargarComboCantidad(ComboBox combo)
        {
            // Cargo los Combos
            combo.DisplayMember = "Text";
            combo.ValueMember = "Value";

            for(int i=1; i<=50;i++)
            {
                combo.Items.Add(new { Text = i.ToString(), Value = i.ToString() });
            }

            // Seteo el Item por default
            combo.SelectedIndex = 0;
        }

        public static void cargarComboHabitacion(int id_hotel, ComboBox combo)
        {
            SqlCommand cmd = new SqlCommand("SELECT habitacion_nro FROM denver.habitaciones WHERE habitacion_hotel_id = "+id_hotel+" ORDER BY habitacion_nro", DataBase.GetInstance().Connection);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("habitacion_nro", typeof(string));
            dt.Columns.Add("habitacion_detalle", typeof(string));
            dt.Load(reader);

            combo.ValueMember = "habitacion_nro";
            combo.DisplayMember = "habitacion_detalle";
            combo.DataSource = dt;

        }

		public static void cargarComboConsumibles(ComboBox combo)
        {
            SqlCommand cmd = new SqlCommand("SELECT consumible_id, consumible_descripcion FROM denver.consumibles ORDER BY consumible_descripcion", DataBase.GetInstance().Connection);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("consumible_id", typeof(int));
            dt.Columns.Add("consumible_descripcion", typeof(string));
            dt.Load(reader);

            combo.ValueMember = "consumible_id";
            combo.DisplayMember = "consumible_descripcion";
            combo.DataSource = dt;

        }

        public static void cargarComboRoles(ComboBox combo)
        {
            SqlCommand cmd = new SqlCommand("SELECT consumible_id, consumible_descripcion FROM denver.consumibles ORDER BY consumible_descripcion", DataBase.GetInstance().Connection);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("consumible_id", typeof(int));
            dt.Columns.Add("consumible_descripcion", typeof(string));
            dt.Load(reader);

            combo.ValueMember = "consumible_id";
            combo.DisplayMember = "consumible_descripcion";
            combo.DataSource = dt;

        }
    }
}
