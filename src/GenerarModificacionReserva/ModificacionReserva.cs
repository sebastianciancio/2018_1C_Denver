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
using System.Globalization;

namespace FrbaHotel
{
    public partial class ModificacionReserva : Form
    {
        private DataBase db;
        public ModificacionReserva()
        {
            db = DataBase.GetInstance();
            InitializeComponent();

            // Cargo los Combos
            Combos.cargarComboHotel(cmb_hotel, false);

            // Si existe un usuario logueado
            if (accesoSistema.HotelIdActual != 0)
            {
                cmb_hotel.SelectedValue = accesoSistema.HotelIdActual;
                cmb_hotel.Enabled = false;
            }
        }
    }
}
