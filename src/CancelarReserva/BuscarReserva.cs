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

namespace FrbaHotel.CancelarReserva
{
    public partial class BuscarReserva : Form
    {
        private DataBase db;
        public BuscarReserva()
        {
            
            InitializeComponent();
            db = DataBase.GetInstance();
            Combos.cargarComboTipoDocumento(cmb_tipo_doc, false);

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_canc_Click(object sender, EventArgs e)
        {
            CancelarReserva.Cancelar_reserva frm = new CancelarReserva.Cancelar_reserva();
             DataGridViewRow row = dgv_reserva.CurrentRow;
             frm.cod_reserva = Convert.ToInt32(row.Cells[0].Value.ToString());
            frm.Show();
        }

        private void BuscarReserva_Load(object sender, EventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.buscar_reserva", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            if(txb_dni.Text != "")
                cmd.Parameters.AddWithValue("@cliente_nro_doc", SqlDbType.Int).Value = Convert.ToInt32(txb_dni.Text);

            if (cmb_tipo_doc.SelectedValue.ToString().CompareTo("0") > 0)
                cmd.Parameters.AddWithValue("@cliente_tipo_doc", SqlDbType.Int).Value = Convert.ToInt32(cmb_tipo_doc.SelectedValue);

            // Creo el DataTable para obtener los resultados del SP
            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }


            // Cargo la Grilla con los datos obtenidos
            dgv_reserva.DataSource = dt;

            // Muestro los objetos ocultos
            dgv_reserva.Visible = true;
            btn_mod.Visible = true;
            bt_canc.Visible = true;
        }

        private void btn_mod_Click(object sender, EventArgs e)
        {

        }
    }
}
