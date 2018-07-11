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

namespace FrbaHotel.AbmUsuarios
{
    public partial class Cambiar_pass : Form
    {
        public string user;
        private DataBase db;
        public Cambiar_pass()
        {
            db = DataBase.GetInstance();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cambiar_pass_Load(object sender, EventArgs e)
        {

            if (user == null || user == "")
            {
                lbl_actual.Visible = true;
                txb_actual.Visible = true;

                lbl_user.Visible = false;
                txb_user.Visible = false;
            }
            else {
                lbl_actual.Visible = false;
                txb_actual.Visible = false;

                lbl_user.Visible = true;
                txb_user.Visible = true;

                txb_user.Text = user;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user == null || user == "")
            {
                if (txb_actual.Text != accesoSistema.pass)
                {
                    MessageBox.Show("La contraseña ingresada no es correcta", "Error");
                } else
                {
                        if (!Validacion.esInicial(txb_nueva.Text) ||
                            !Validacion.esInicial(txb_repetir.Text))
                        {
                            if (txb_nueva.Text == txb_repetir.Text)
                            {
                                SqlCommand cmd = new SqlCommand("denver.cambiar_contrasena", db.Connection);
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.Parameters.AddWithValue("@usuario_user", SqlDbType.VarChar).Value = accesoSistema.UsuarioLogueado.Id;
                                cmd.Parameters.AddWithValue("@pass", SqlDbType.VarChar).Value = txb_nueva.Text;
                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Se modifico la contraseña correctamente", "Contraseña modificada");
                            }
                            else
                            {
                                MessageBox.Show("Las Contraseñas no coinciden", "Error");
                                txb_repetir.Text = "";
                                txb_nueva.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe completar las contraseñas", "Mensaje");
                        }

                    }
                
            }
            else
            {
                if (!Validacion.esInicial(txb_nueva.Text) ||
                   !Validacion.esInicial(txb_repetir.Text))
                {
                    if (txb_nueva.Text == txb_repetir.Text)
                    {
                        SqlCommand cmd = new SqlCommand("denver.cambiar_contrasena", db.Connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@usuario_user", SqlDbType.VarChar).Value = txb_user.Text;
                        cmd.Parameters.AddWithValue("@pass", SqlDbType.VarChar).Value = txb_nueva.Text;
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Se modifico la contraseña correctamente", "Contraseña modificada");
                    }
                    else
                    {
                        MessageBox.Show("Las Contraseñas no coinciden", "Error");
                        txb_repetir.Text = "";
                        txb_nueva.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar las contraseñas", "Mensaje");
                }
            }
        }
    }
}
