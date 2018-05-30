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
    public partial class accesoSistema : Form
    {
        // Declaro las variables Globales
        static public int HotelSeleccionado;
        static public Usuario UsuarioLogueado = new Usuario();

        public accesoSistema()
        {
            InitializeComponent();
        }

        private void btn_reserva_Click(object sender, EventArgs e)
        {
            btn_reserva.Enabled = false;
            btn_reserva.Visible = false;

            btn_sistema.Enabled = false;
            btn_sistema.Visible = false;

            btn_nueva.Enabled = true;
            btn_nueva.Visible = true;

            btn_modificar.Enabled = true;
            btn_modificar.Visible = true;

            btn_volver.Enabled = true;
            btn_volver.Visible = true;


        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
         
            btn_reserva.Enabled = true;
            btn_reserva.Visible = true;

            btn_sistema.Enabled = true;
            btn_sistema.Visible = true;

            btn_nueva.Enabled = false;
            btn_nueva.Visible = false;
            
            btn_modificar.Enabled = false;
            btn_modificar.Visible = false;

            btn_volver.Enabled = false;
            btn_volver.Visible = false;
        }

        private void btn_sistema_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Muestro el Login
            Login frm = new Login();
            frm.Show();
        }

        private void accesoSistema_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea salir de la Aplicacion?", "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
    }
}
