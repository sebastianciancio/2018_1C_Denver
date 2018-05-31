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

namespace FrbaHotel.AbmRol
{
    public partial class AltaRol : Form
    {
        private DataBase db;

        public AltaRol()
        {
            db = DataBase.GetInstance();
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txb_nombre.Text == "" ) {
                MessageBox.Show("Debe ingresar el nombre del nuevo Rol", "Error");
            }
            if (clb_funcionalidades.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar almenos una funcionalidad", "Error");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("denver.crear_rol", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@cliente_tipo_documento", SqlDbType.VarChar).Value = txb_nombre.Text;


            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
