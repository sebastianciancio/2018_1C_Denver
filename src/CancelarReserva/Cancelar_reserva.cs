using System;
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
    public partial class Cancelar_reserva : Form
    {
        public int cod_reserva;
        private DataBase db;

        public Cancelar_reserva()
        {
            db = DataBase.GetInstance();
            InitializeComponent();
        }

        private void btn_canc_rec_confirm_Click(object sender, EventArgs e)
        {

        }

        private void Cancelar_reserva_Load(object sender, EventArgs e)
        {
            txb_canc_rec_codigo.Text = cod_reserva.ToString();
        }

        private void btn_canc_res_volver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
