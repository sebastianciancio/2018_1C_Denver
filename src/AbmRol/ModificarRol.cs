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
    public partial class ModificarRol : Form
    {
        public string rol;
        private DataBase db;
        public ModificarRol()
        {
            db = DataBase.GetInstance();
            InitializeComponent();
        }

        private void ModificarRol_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.buscar_rol", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@rol", SqlDbType.VarChar).Value = rol;

            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            txb_nombre.Text = rol;


        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

        }
    }
}
