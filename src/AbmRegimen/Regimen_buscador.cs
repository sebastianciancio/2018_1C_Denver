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
    public partial class Regimen_buscador : Form
    {
        private DataBase db;
        public Regimen_buscador()
        {
            db = DataBase.GetInstance();
            InitializeComponent();

            // Cargo los combos
            Combos.cargarComboEstado(cmb_estado, true);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.buscar_regimen", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (txb_nombre.Text != "")
                cmd.Parameters.AddWithValue("@nombre_regimen", SqlDbType.VarChar).Value = txb_nombre.Text;

            if (cmb_estado.SelectedIndex > 0 )
                cmd.Parameters.AddWithValue("@estado", SqlDbType.Int).Value = Convert.ToInt32(cmb_estado.SelectedValue);

            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            // Cargo la Grilla con los datos obtenidos
            dgv_regimen.DataSource = dt;

            dgv_regimen.Visible = true;

        }

        private void btt_add_usuario_Click(object sender, EventArgs e)
        {
            AbmRegimen.Regimen_alta frm = new AbmRegimen.Regimen_alta();
            frm.Show();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
