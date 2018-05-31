using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();

            // Muestro el Usuario Logueado
            this.label_usuario_logueado.Text = accesoSistema.UsuarioLogueado.Apellido + " " + accesoSistema.UsuarioLogueado.Nombre + " - " + accesoSistema.HotelNombreActual;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente frm = new Cliente();
            frm.Show();
        }

        private void roles_Click(object sender, EventArgs e)
        {
            this.Hide();

            AbmRol.GestionRoles frm = new AbmRol.GestionRoles();

            frm.Show();
 
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

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


    }
}
