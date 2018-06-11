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

namespace FrbaHotel
{
    public partial class Principal : Form
    {
        private DataBase db;
        public Principal()
        {
            InitializeComponent();
            db = DataBase.GetInstance();

            // Muestro el Usuario Logueado
            this.label_usuario_logueado.Text = accesoSistema.UsuarioLogueado.Apellido + " " + accesoSistema.UsuarioLogueado.Nombre + " - " + accesoSistema.HotelNombreActual;

            label_rol_usuario_logueado.Text = accesoSistema.UsuarioLogueado.Rol;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente frm = new Cliente();
            frm.Show();
        }

        private void roles_Click(object sender, EventArgs e)
        {

            AbmRol.GestionRoles frm = new AbmRol.GestionRoles();
            frm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbmUsuarios.Usuarios_buscador frm = new AbmUsuarios.Usuarios_buscador();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            AbmHabitacion.Habitaciones_buscador frm = new AbmHabitacion.Habitaciones_buscador();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbmHotel.BuscarHotel frm = new AbmHotel.BuscarHotel();
            frm.Show();

        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea salir de la Aplicacion?", "Mensaje", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                // Finalizo la ejecucion de la Application
                if (System.Windows.Forms.Application.MessageLoop)
                {
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    System.Environment.Exit(1);
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Listados frm = new Listados();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Reserva frm = new Reserva();
            frm.Show();
        }

        private void btn_consumibles_Click(object sender, EventArgs e)
        {
            Consumibles frm = new Consumibles();
            frm.Show();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            Estadia frm = new Estadia();
            frm.Show();
        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            Facturar frm = new Facturar();
            frm.Show();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            AbmRegimen.Regimen_buscador frm = new AbmRegimen.Regimen_buscador();
            frm.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.funcionalidades_rol", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@usuario_rol", SqlDbType.VarChar).Value = accesoSistema.UsuarioLogueado.Rol;

            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
              {  
                int result = Convert.ToInt32(dt.Rows[i][0]);
                switch (result)
                {
                    case 1:
                        btn_roles.Visible = true;
                        break;
                    case 2:
                        btn_usurios.Visible = true;
                        break;
                    case 3:
                        btn_clientes.Visible = true;
                        break;
                    case 4:
                        btn_hoteles.Visible = true;
                        break;
                    case 5:
                        btn_habitaciones.Visible = true;
                        break;
                    case 6:
                        btn_estadia.Visible = true;
                        break;
                    case 7:
                        btn_reserva.Visible = true;
                        break;
                    case 8:
                        // no hay boton cancelar reserva
                        break;
                    case 9:
                        btn_check.Visible = true;
                        break;
                    case 10:
                        btn_consumibles.Visible = true;
                        break;
                    case 11:
                        btn_facturar.Visible = true;
                        break;
                    case 12:
                        btn_listados.Visible = true;
                        break;
                }

                      
                      
                      
            }


        }



    }
}
