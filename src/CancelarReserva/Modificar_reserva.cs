﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.CancelarReserva
{
    public partial class Modificar_reserva : Form
    {
        public int cod_reserva;
        private DataBase db;
        public Modificar_reserva()
        {
            InitializeComponent();
            db = DataBase.GetInstance();
        }

        private void Modificar_reserva_Load(object sender, EventArgs e)
        {

        }
    }
}
