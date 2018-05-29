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
    public partial class Listados : Form
    {
        public Listados()
        {
            InitializeComponent();

            // Cargo los Combos
            cmb_tipo_reporte.DisplayMember = "Text";
            cmb_tipo_reporte.ValueMember = "Value";
            cmb_tipo_reporte.Items.Add(new { Text = "Hoteles con mayor cantidad de reservas canceladas", Value = "1" });
            cmb_tipo_reporte.Items.Add(new { Text = "Hoteles con mayor cantidad de consumibles facturados", Value = "2" });
            cmb_tipo_reporte.Items.Add(new { Text = "Hoteles con mayor cantidad de días fuera de servicio", Value = "3" });
            cmb_tipo_reporte.Items.Add(new { Text = "Habitaciones con mayor cantidad de días y veces que fueron ocupados", Value = "4" });
            cmb_tipo_reporte.Items.Add(new { Text = "Cliente con mayor cantidad de puntos", Value = "5" });

            // Seteo el Item por default
            cmb_tipo_reporte.SelectedIndex = 1;
        }
    }
}
