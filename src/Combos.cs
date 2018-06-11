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

        private static void agregarTodosCombo(ComboBox combo, DataTable dt)
        {
            DataRow dr = dt.NewRow();
            dr[combo.ValueMember] = 0;
            dr[combo.DisplayMember] = "Todos";

            dt.Rows.InsertAt(dr, 0);
            combo.SelectedIndex = 0;
        }

        public static void cargarComboPais(ComboBox combo, bool agregarTodos = false)
        {
            SqlCommand cmd = new SqlCommand("denver.obtener_paises", DataBase.GetInstance().Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("pais_id", typeof(int));
            dt.Columns.Add("pais_nombre", typeof(string));
            dt.Load(reader);

            combo.ValueMember = "pais_id";
            combo.DisplayMember = "pais_nombre";
            combo.DataSource = dt;

            if (agregarTodos)
                agregarTodosCombo(combo, dt);

        }

        public static void cargarComboTipoHabitacion(ComboBox combo, bool agregarTodos = false)
        {
            SqlCommand cmd = new SqlCommand("denver.obtener_tipo_habitaciones", DataBase.GetInstance().Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("tipo_habitacion_id", typeof(int));
            dt.Columns.Add("tipo_habitacion_descripcion", typeof(string));
            dt.Load(reader);

            combo.ValueMember = "tipo_habitacion_id";
            combo.DisplayMember = "tipo_habitacion_descripcion";
            combo.DataSource = dt;

            if (agregarTodos)
                agregarTodosCombo(combo, dt);

        }

        public static void cargarComboTipoRegimen(ComboBox combo, bool agregarTodos = false)
        {
            SqlCommand cmd = new SqlCommand("denver.obtener_regimenes", DataBase.GetInstance().Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.VarChar).Value = accesoSistema.HotelIdActual;
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("regimen_id", typeof(int));
            dt.Columns.Add("regimen_descripcion", typeof(string));
            dt.Load(reader);

            combo.ValueMember = "regimen_id";
            combo.DisplayMember = "regimen_descripcion";
            combo.DataSource = dt;

            if (agregarTodos)
                agregarTodosCombo(combo, dt);

        }

        public static void cargarComboTipoDocumento(ComboBox combo, bool agregarTodos = false)
        {
            SqlCommand cmd = new SqlCommand("denver.obtener_tipo_documento", DataBase.GetInstance().Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("tipo_documento_id", typeof(int));
            dt.Columns.Add("tipo_documento_nombre", typeof(string));
            dt.Load(reader);

            combo.ValueMember = "tipo_documento_id";
            combo.DisplayMember = "tipo_documento_nombre";
            combo.DataSource = dt;

            if (agregarTodos)
                agregarTodosCombo(combo, dt);

        }

        public static void cargarComboHotel(ComboBox combo, bool agregarTodos = false)
        {
            SqlCommand cmd = new SqlCommand("denver.obtener_hoteles", DataBase.GetInstance().Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (accesoSistema.UsuarioLogueado.Id.ToString() != "")
                cmd.Parameters.AddWithValue("@usuario_user", SqlDbType.VarChar).Value = accesoSistema.UsuarioLogueado.Id;

            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("hotel_id", typeof(int));
            dt.Columns.Add("hotel_nombre", typeof(string));
            dt.Load(reader);

            combo.ValueMember = "hotel_id";
            combo.DisplayMember = "hotel_nombre";
            combo.DataSource = dt;

            if (agregarTodos)
                agregarTodosCombo(combo, dt);

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

        public static void cargarComboEstado(ComboBox combo, bool agregarTodos = false)
        {
            // Cargo los Combos
            combo.DisplayMember = "Text";
            combo.ValueMember = "Value";

            if (agregarTodos)
            {
                combo.Items.Add(new { Text = "Todos", Value = "-1" });
            }

            combo.Items.Add(new { Text = "Activo", Value = "1" });
            combo.Items.Add(new { Text = "No Activo", Value = "0" });

            // Seteo el Item por default
            if (agregarTodos)
            {
                combo.SelectedIndex = -1;
            }
            else
            {
                combo.SelectedIndex = 1;
            }
        }

        public static void cargarComboCantidad(ComboBox combo, int desde = 1, int hasta = 50, bool agregarTodos = false)
        {
            // Cargo los Combos
            combo.DisplayMember = "Text";
            combo.ValueMember = "Value";

            if (agregarTodos)
            {
                combo.Items.Add(new { Text = "Todos", Value = 0 });
            }


            for (int i = desde; i <= hasta; i++)
            {
                combo.Items.Add(new { Text = i.ToString(), Value = i.ToString() });
            }

            // Seteo el Item por default
            combo.SelectedIndex = 0;
        }

        public static void cargarComboHabitacion(int id_hotel, ComboBox combo, bool agregarTodos = false)
        {
            SqlCommand cmd = new SqlCommand("denver.obtener_habitaciones", DataBase.GetInstance().Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.VarChar).Value = accesoSistema.HotelIdActual;
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("habitacion_nro", typeof(int));
            dt.Load(reader);

            combo.ValueMember = "habitacion_nro";
            combo.DisplayMember = "habitacion_nro";
            combo.DataSource = dt;

            if (agregarTodos)
                agregarTodosCombo(combo, dt);

        }

        public static void cargarComboConsumibles(ComboBox combo, bool agregarTodos = false)
        {
            SqlCommand cmd = new SqlCommand("denver.obtener_consumibles", DataBase.GetInstance().Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("consumible_id", typeof(int));
            dt.Columns.Add("consumible_descripcion", typeof(string));
            dt.Load(reader);

            combo.ValueMember = "consumible_id";
            combo.DisplayMember = "consumible_descripcion";
            combo.DataSource = dt;

            if (agregarTodos)
                agregarTodosCombo(combo, dt);

        }

        public static void cargarComboRoles(ComboBox combo, bool agregarTodos = false)
        {
            SqlCommand cmd = new SqlCommand("denver.obtener_roles", DataBase.GetInstance().Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader;

            reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add("rol_nombre", typeof(string));
            dt.Load(reader);

            combo.ValueMember = "rol_nombre";
            combo.DisplayMember = "rol_nombre";
            combo.DataSource = dt;

            if (agregarTodos)
                agregarTodosCombo(combo, dt);

        }

    }
}
