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
    public partial class Facturar : Form
    {
        private DataBase db;
        public Facturar()
        {
            db = DataBase.GetInstance();
            InitializeComponent();

            // Cargo los combos
            Combos.cargarComboHotel(cmb_hotel);
            Combos.cargarComboHabitacion(accesoSistema.HotelIdActual,cmb_habitacion);

        }
    }
}
