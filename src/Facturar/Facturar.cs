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
            Combos.cargarComboTipoDocumento(cmb_tipo_doc, false);
            Combos.cargarComboFormaPago(cmb_forma_pago,false);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.obtener_facturable", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@fecha_salida", SqlDbType.DateTime).Value = Convert.ToDateTime(fecha_hasta.Value);
            cmd.Parameters.AddWithValue("@tipo_documento", SqlDbType.Int).Value = Convert.ToInt32(cmb_tipo_doc.SelectedValue);
            cmd.Parameters.AddWithValue("@nro_documento", SqlDbType.Int).Value = Convert.ToInt32(nro_documento.Text);
            cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = Convert.ToInt32(accesoSistema.HotelIdActual);
            cmd.Parameters.AddWithValue("@total_factura", SqlDbType.Int).Direction = ParameterDirection.Output;

            DataTable dt_facturable = new DataTable();

            // Creo el DataTable para obtener los resultados del SP
            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt_facturable);
            }

            // Cargo la Grilla con los datos obtenidos
            dg_consumos_facturar.DataSource = dt_facturable;


            if (dt_facturable.Rows.Count > 0)
            {
                Container_facturacion.Visible = true;

                // Obtengo el total de la factura
                int total_factura = Convert.ToInt32(cmd.Parameters["@total_factura"].Value);

                label_total_facturar.Text = total_factura.ToString();

            }

        }

        private void btn_facturar_Click(object sender, EventArgs e)
        {
            // Si la forma de Pago es TC, valido que se halla completado el detalle
            if (Convert.ToInt32(cmb_forma_pago.SelectedValue) == 2 & txt_detalle_pago.Text == "")
            {
                DialogResult result = MessageBox.Show("Completar los datos de la Tarjeta de Credito", "Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {

            }
        }
    }
}
