using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace FrbaHotel
{
    
    public class Validacion
    {
        private DataBase db;

        public string user_global;

        public Validacion()
        {
            db = DataBase.GetInstance();
        }

        public static bool esInicial(string texto)
        {

            return texto == "";

        }
        public static bool checkListVacia(CheckedListBox list)
        {

            return list.SelectedItems.Count == 0;
        }

        public static bool rolExistente(string texto){
            SqlDataAdapter sda = new SqlDataAdapter("SELECT denver.existe_usuario ('" + texto + "')", DataBase.GetInstance().Connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            
            // Si existe
            return Convert.ToInt32(dt.Rows[0][0]) == 1;
        }
    }
}