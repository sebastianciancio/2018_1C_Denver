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
    public class Pais
    {
        private DataBase db;

        public Pais()
        {
            db = DataBase.GetInstance();
        }

        public static void cargarCombo(ComboBox combo)
        {
           
            SqlCommand cmd = new SqlCommand("SELECT pais_id, pais_nombre FROM dbo.paises ORDER BY pais_nombre", DataBase.GetInstance().Connection);
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


    }
}
