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

namespace FrbaHotel.AbmRegimen
{
    public partial class Regimen_alta : Form
    {
        private DataBase db;
        public Regimen_alta()
        {
            db = DataBase.GetInstance();
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!Validacion.esInicial(txb_nombre.Text) & !Validacion.esInicial(txb_precio.Text))
            {
                SqlCommand cmd = new SqlCommand("denver.alta_regimen", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre_regimen", SqlDbType.VarChar).Value = txb_nombre.Text;
                if (cb_activar.Checked == true)
                { cmd.Parameters.AddWithValue("@estado", SqlDbType.VarChar).Value = 'S'; }
                else { cmd.Parameters.AddWithValue("@estado", SqlDbType.VarChar).Value = 'N'; }
                cmd.Parameters.AddWithValue("@precio", SqlDbType.Decimal).Value = Convert.ToDecimal(txb_precio.Text);

                //dice que no se permite un varchar en numeric
             //   cmd.ExecuteNonQuery();

                MessageBox.Show("EL regimen" + txb_nombre.Text + "se creó correctamente", "Mensaje");
            }
        }
    }
}
