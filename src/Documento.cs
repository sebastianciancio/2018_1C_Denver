using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel
{
    public class Documento
    {
        private DataBase db;

        public Documento() {
            db = DataBase.GetInstance();
        }
        public static void cargarComboDoc(ComboBox combo)
        {
            // reemplazar dbo por denver
            SqlCommand cmd = new SqlCommand("SELECT tipo_documento_id, tipo_documento_nombre FROM dbo.tipo_documentos ORDER BY tipo_documento_nombre", DataBase.GetInstance().Connection);
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
        }

}
