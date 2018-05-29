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

            // Cargo el Combo Tipo de Reporte
            Combos.cargarComboListados(cmb_tipo_reporte);
        }
    }
}
