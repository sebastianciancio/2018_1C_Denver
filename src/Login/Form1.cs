using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace FrbaHotel.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_acceder_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT count(*) FROM denver.usuarios AS u WHERE u.usuario_user = '" + login_usuario.Text + "' AND u.usuario_pass = HASHBYTES('SHA2_256','" + login_password.Text + "');", DataBase.GetInstance().Connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            
            if (dt.Rows[0][0].ToString() == "1")
            {
                // Cierro este Formulario
                this.Hide();

                // Abro el Menu Principal
                Principal frm = new Principal();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Acceso no permitido.", "Mensaje");
            }


        }
    }
}
