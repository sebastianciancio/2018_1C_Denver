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
    
    public partial class GestionRoles : Form
    {   private DataBase db;

        public GestionRoles()
        {
            db = DataBase.GetInstance();
            InitializeComponent();
        }

        private void GestionRoles_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.obtener_roles", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }
            dgv_roles.DataSource = dt;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Hide();
            AbmRol.ModificarRol frm = new AbmRol.ModificarRol();
            frm.Show();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Hide();

            AbmRol.AltaRol frm = new AbmRol.AltaRol();
            frm.Show();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
