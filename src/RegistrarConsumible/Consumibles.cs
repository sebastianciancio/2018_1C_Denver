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
    public partial class Consumibles : Form
    {
        private DataBase db;
        public Consumibles()
        {
            db = DataBase.GetInstance();
            InitializeComponent();

            // Cargo los Combos
            Combos.cargarComboCantidad(cmb_cantidad);
            Combos.cargarComboConsumibles(cmb_productos);
            Combos.cargarComboHabitacion(accesoSistema.HotelIdActual, cmb_habitaciones);
        }
    }
}
