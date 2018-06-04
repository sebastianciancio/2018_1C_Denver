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

namespace FrbaHotel.AbmRegimen
{
    public partial class Regimen_buscador : Form
    {
        private DataBase db;
        public Regimen_buscador()
        {
            db = DataBase.GetInstance();
            InitializeComponent();

            // Cargo los combos
            Combos.cargarComboEstado(cmb_estado, true);
        }
    }
}
