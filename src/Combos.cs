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

            dt.Dispose();
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

            dt.Dispose();
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

            dt.Dispose();
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

            dt.Dispose();
        }

        public static void cargarComboHotel(ComboBox combo)
        {
            SqlCommand cmd = new SqlCommand("SELECT hotel_id,ltrim(concat(hotel_nombre,' ',hotel_calle)) as nombre_hotel FROM denver.hoteles ORDER BY tipo_documento_nombre", DataBase.GetInstance().Connection);
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("hotel_id", typeof(int));
            dt.Columns.Add("nombre_hotel", typeof(string));
            dt.Load(reader);

            combo.ValueMember = "hotel_id";
            combo.DisplayMember = "nombre_hotel";
            combo.DataSource = dt;

            dt.Dispose();
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

    }
}
