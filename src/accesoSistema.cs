﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel
{
    public partial class accesoSistema : Form
    {
        // Declaro las variables Globales
        static public int HotelIdActual = 0;
        static public string HotelNombreActual;
        static public Usuario UsuarioLogueado = new Usuario();
        static public Cliente ClienteSeleccionado = new Cliente();
        static public bool habilitarSeleccionCliente = false;
        static public DateTime fechaSistema;
        static public string pass;
        static public string fechaSistemaSQL;

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accesoSistema));

        public accesoSistema()
        {
            ClienteSeleccionado.cliente_apellido = "";

            // Leo el Archivo de Configuracion y seteo la Hora del Sistema
            String[] config = File.ReadAllLines("../../Config.txt");
            fechaSistema = DateTime.Parse(DataBase.GetConfigValue(config[4]) + " 00:00:00 AM");

            // Cargo la Fecha en formato Universal para SQL YYYYMMDD
            fechaSistemaSQL = fechaSistema.Year.ToString();

            if (fechaSistema.Month < 10)
            {
                fechaSistemaSQL += "0" + fechaSistema.Month.ToString();
            }
            else
            {
                fechaSistemaSQL += fechaSistema.Month.ToString();
            }

            if (fechaSistema.Day < 10)
            {
                fechaSistemaSQL += "0" + fechaSistema.Day.ToString();
            }
            else
            {
                fechaSistemaSQL += fechaSistema.Day.ToString();
            }
            
            InitializeComponent();
        }

        private void btn_reserva_Click(object sender, EventArgs e)
        {
            btn_canc.Enabled = true;
            btn_canc.Visible = true;

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

            btn_canc.Enabled = false;
            btn_canc.Visible = false;
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

        private void btn_nueva_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Reserva frm = new Reserva();

            frm.Show();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ModificacionReserva frm = new ModificacionReserva();
            frm.Show();

        }

        private void btn_canc_Click(object sender, EventArgs e)
        {
            //this.Hide();
            CancelacionReserva frm = new CancelacionReserva();
            frm.Show();

        }


    }
}
