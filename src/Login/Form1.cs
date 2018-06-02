using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FrbaHotel
{
    public partial class Login : Form
    {
        private DataBase db;
        public Login()
        {
            db = DataBase.GetInstance();
            InitializeComponent();

            // Cargo los Combos
            Combos.cargarComboHotel(cmb_hotel);
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
            SqlDataAdapter sda = new SqlDataAdapter("SELECT count(*), usuario_apellido, usuario_nombre, usuario_user, usuario_login_fallidos, denver.cant_roles_usuario(usuario_user) FROM denver.usuarios AS u JOIN denver.usuarios_hoteles AS uh ON u.usuario_user = uh.usuario_usuario_user WHERE u.usuario_user = UPPER('" + login_usuario.Text + "') AND u.usuario_pass = HASHBYTES('SHA2_256',UPPER('" + login_password.Text + "')) AND uh.usuario_hotel_id = '" + cmb_hotel.SelectedValue + "' AND u.usuario_activo = 'S' GROUP BY usuario_apellido, usuario_nombre, usuario_user, usuario_login_fallidos;", db.Connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                // Si tuvo menos de 3 intentos fallidos
                if (Convert.ToInt32(dt.Rows[0][4]) < 3)
                {
                    // Cierro este Formulario
                    this.Hide();

                    // Guardo el Usuario Logueado
                    accesoSistema.UsuarioLogueado.Apellido = dt.Rows[0][1].ToString();
                    accesoSistema.UsuarioLogueado.Nombre = dt.Rows[0][2].ToString();
                    accesoSistema.UsuarioLogueado.Id = dt.Rows[0][3].ToString();
                    accesoSistema.HotelIdActual = Convert.ToInt32(cmb_hotel.SelectedValue);
                    accesoSistema.HotelNombreActual = cmb_hotel.Text;

                    // Si tiene solo 1 Rol
                    if (dt.Rows[0][5].ToString() == "1")
                    {
                        // TODO
                    }
                    else // Si tiene mas de un Rol
                    {
                        // TODO
                        // Mostrar el combo de los Roles
                    }
                    

                    // Reseteo los intentos fallidos
                    SqlCommand cmd = new SqlCommand("denver.reset_intentos_loguin_fallidos", db.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@usuario_user", SqlDbType.VarChar).Value = login_usuario.Text;
                    cmd.ExecuteNonQuery();

                    // Abro el Menu Principal
                    Principal frm = new Principal();
                    frm.Show();
                }
                else
                {
                    // Si tuvo 3 intentos fallidos
                    MessageBox.Show("Usuario bloqueado por más de 3 intentos fallidos.", "Mensaje");

                    // Bloqueo al Usuario
                    SqlCommand cmd = new SqlCommand("denver.inhabilitar_usuario", db.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@usuario_user", SqlDbType.VarChar).Value = login_usuario.Text;
                    cmd.ExecuteNonQuery();
                }

            }
            else
            {
                MessageBox.Show("Acceso no permitido.", "Mensaje");

                // Incremento los Intentos Fallidos
                SqlCommand cmd = new SqlCommand("denver.marcar_intentos_loguin_fallidos", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario_user", SqlDbType.VarChar).Value = login_usuario.Text;
                cmd.ExecuteNonQuery();
            }


        }
    }
}
