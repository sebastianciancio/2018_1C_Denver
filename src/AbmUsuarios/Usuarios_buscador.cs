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
    public partial class Usuarios_buscador : Form
    {
        private DataBase db;
        public Usuarios_buscador()
        {
            db = DataBase.GetInstance();
            InitializeComponent();

            // Cargo los combos
            Combos.cargarComboHotel(cmb_hotel);
        }
    }
}
