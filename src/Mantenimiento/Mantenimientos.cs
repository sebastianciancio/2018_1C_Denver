﻿using System;
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
    public partial class Mantenimientos : Form
    {
        private DataBase db;
        public Mantenimientos()
        {
            db = DataBase.GetInstance();
            InitializeComponent();
        }
    }
}
