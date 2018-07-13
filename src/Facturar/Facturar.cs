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
        int total_factura;
        DataTable dt_facturable;

        public Facturar()
        {
            db = DataBase.GetInstance();
            InitializeComponent();

            // Cargo los combos
            Combos.cargarComboTipoDocumento(cmb_tipo_doc, false);
            Combos.cargarComboFormaPago(cmb_forma_pago,false);

            // Defino las fechas por default segun archivo config
            fecha_hasta.Value = accesoSistema.fechaSistema;

            total_factura = 0;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {

            if (validarFormulario())
            {
                // Valido que se haya realizado el checkout previamente
                SqlDataAdapter sda = new SqlDataAdapter("SELECT denver.checkout_realizado ('" + Convert.ToDateTime(fecha_hasta.Value) + "', " + cmb_tipo_doc.SelectedValue + ", " + nro_documento.Text + ", " + accesoSistema.HotelIdActual + ")", db.Connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Si existe
                if (Convert.ToInt32(dt.Rows[0][0]) == 0)
                {

                    SqlCommand cmd = new SqlCommand("denver.obtener_facturable", db.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@fecha_salida", SqlDbType.DateTime).Value = Convert.ToDateTime(fecha_hasta.Value);
                    cmd.Parameters.AddWithValue("@tipo_documento", SqlDbType.Int).Value = Convert.ToInt32(cmb_tipo_doc.SelectedValue);
                    cmd.Parameters.AddWithValue("@nro_documento", SqlDbType.Int).Value = Convert.ToInt32(nro_documento.Text);
                    cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = Convert.ToInt32(accesoSistema.HotelIdActual);
                    cmd.Parameters.AddWithValue("@total_factura", SqlDbType.Int).Direction = ParameterDirection.Output;

                    dt_facturable = new DataTable();

                    // Creo el DataTable para obtener los resultados del SP
                    using (var da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt_facturable);
                    }

                    // Cargo la Grilla con los datos obtenidos
                    dg_consumos_facturar.DataSource = dt_facturable;

                    // Oculto Columnas del Resultado
                    dg_consumos_facturar.Columns[0].Visible = false;

                    if (dt_facturable.Rows.Count > 0)
                    {
                        Container_facturacion.Visible = true;

                        // Obtengo el total de la factura
                        total_factura = Convert.ToInt32(cmd.Parameters["@total_factura"].Value);

                        label_total_facturar.Text = "$" + total_factura.ToString();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("No se encontraron registros con los datos ingresados", "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    DialogResult result = MessageBox.Show("Debe realizarse el checkout previamente", "Facturación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los campos para continuar", "Mensaje");
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
                SqlCommand cmd = new SqlCommand("denver.facturar_encabezado", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fecha_egreso", SqlDbType.DateTime).Value = Convert.ToDateTime(fecha_hasta.Value);
                cmd.Parameters.AddWithValue("@factura_total", SqlDbType.Int).Value = total_factura;
                cmd.Parameters.AddWithValue("@factura_forma_pago_id", SqlDbType.Int).Value = Convert.ToInt32(cmb_forma_pago.SelectedValue);
                cmd.Parameters.AddWithValue("@factura_detalle_pago", SqlDbType.VarChar).Value = txt_detalle_pago.Text;
                cmd.Parameters.AddWithValue("@factura_cliente_tipo_documento", SqlDbType.Int).Value = Convert.ToInt32(cmb_tipo_doc.SelectedValue);
                cmd.Parameters.AddWithValue("@factura_pasaporte_nro", SqlDbType.Int).Value = Convert.ToInt32(nro_documento.Text);
                cmd.Parameters.AddWithValue("@fecha_sistema", SqlDbType.DateTime).Value = accesoSistema.fechaSistemaSQL;
                cmd.Parameters.AddWithValue("@factura_hotel_id", SqlDbType.Int).Value = Convert.ToInt32(accesoSistema.HotelIdActual);
                cmd.Parameters.AddWithValue("@factura_nro", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.AddWithValue("@nro_reserva", SqlDbType.Int).Direction = ParameterDirection.Output;

                // Ejecuto el SP
                cmd.ExecuteNonQuery();

                // Obtengo el nro de factura
                int nro_factura_obtenida = Convert.ToInt32(cmd.Parameters["@factura_nro"].Value);

                // Obtengo el nro de reserva original
                int nro_reserva_original = Convert.ToInt32(cmd.Parameters["@nro_reserva"].Value);

                if (nro_factura_obtenida > 0)
                {
                    // Asocio los items a la factura
                    for (var indice = 0; indice < dg_consumos_facturar.RowCount; indice++)
                    {

                        cmd = new SqlCommand("denver.facturar_items", db.Connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@factura_nro", SqlDbType.Int).Value = nro_factura_obtenida.ToString();
                        cmd.Parameters.AddWithValue("@factura_item_cant", SqlDbType.Int).Value = 1;
                        cmd.Parameters.AddWithValue("@factura_item_monto", SqlDbType.Int).Value = dg_consumos_facturar.Rows[indice].Cells[2].Value;
                        cmd.Parameters.AddWithValue("@factura_item_descripcion", SqlDbType.VarChar).Value = dg_consumos_facturar.Rows[indice].Cells[1].Value;
                        cmd.Parameters.AddWithValue("@factura_consumible_id", SqlDbType.Int).Value = Convert.ToInt32(dg_consumos_facturar.Rows[indice].Cells[0].Value);
                        cmd.Parameters.AddWithValue("@factura_cliente_tipo_documento", SqlDbType.Int).Value = Convert.ToInt32(cmb_tipo_doc.SelectedValue);
                        cmd.Parameters.AddWithValue("@factura_pasaporte_nro", SqlDbType.Int).Value = Convert.ToInt32(nro_documento.Text);
                        cmd.Parameters.AddWithValue("@factura_hotel_id", SqlDbType.Int).Value = Convert.ToInt32(accesoSistema.HotelIdActual);
                        cmd.Parameters.AddWithValue("@fecha_sistema", SqlDbType.DateTime).Value = accesoSistema.fechaSistemaSQL;
                        cmd.Parameters.AddWithValue("@fecha_facturacion", SqlDbType.DateTime).Value = fecha_hasta.Value;

                        // Ejecuto el SP
                        cmd.ExecuteNonQuery();

                    }
                    // Muestro Mensaje
                    DialogResult result = MessageBox.Show("Se ha emitido la Factura Nro.: " + nro_factura_obtenida.ToString(), "Confirmacion de Facturación",
                             MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Cambio el estado de la Reserva Original a Facturada
                    cmd = new SqlCommand("denver.cambiar_estado_reserva", db.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@nro_reserva", SqlDbType.Int).Value = nro_reserva_original.ToString();
                    cmd.Parameters.AddWithValue("@nuevo_estado", SqlDbType.Int).Value = 7;

                    // Ejecuto el SP
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    // Muestro Mensaje Error
                    DialogResult result = MessageBox.Show("Se ha producido un error y no se pudo Facturar", "Confirmacion de Facturación",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Reseteo los datos
                dg_consumos_facturar.Visible = false;
                Container_facturacion.Visible = false;
                nro_documento.Text = "";
            }
        }


        private bool validarFormulario()
        {

            float numero_generico;

            return (!Validacion.esInicial(nro_documento.Text) & float.TryParse(nro_documento.Text, out numero_generico) &
                    !Validacion.esInicial(fecha_hasta.Value.ToString()) &
                    !Validacion.esInicial(cmb_tipo_doc.SelectedValue.ToString())
                    );

        }
    }
}
