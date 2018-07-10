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

namespace FrbaHotel.AbmCliente
{
    public partial class Cliente_alta : Form
    {
        private DataBase db;

        public static Cliente_alta Cli_alta;

        public Cliente_alta()
        {
            InitializeComponent();
            db = DataBase.GetInstance();
            Cliente_alta.Cli_alta = this;
            Combos.cargarComboPais(combo_pais);
            Combos.cargarComboTipoDocumento(cmb_cli_new_tip_doc);
        }

        private void btn_cli_new_guardar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                SqlCommand cmd = new SqlCommand("denver.cargar_cliente", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@cliente_tipo_documento", SqlDbType.Int).Value = cmb_cli_new_tip_doc.SelectedValue;
                cmd.Parameters.AddWithValue("@cliente_pasaporte_nro", SqlDbType.Int).Value = Convert.ToInt32(txb_cl_new_dni.Text);
                cmd.Parameters.AddWithValue("@cliente_apellido", SqlDbType.VarChar).Value = txb_cli_new_apellidos.Text;
                cmd.Parameters.AddWithValue("@cliente_nombre", SqlDbType.VarChar).Value = txb_cli_new_nombres.Text;
                cmd.Parameters.AddWithValue("@cliente_fecha_nac", SqlDbType.DateTime).Value = cmb_cli_new_fec_nac.Value;
                cmd.Parameters.AddWithValue("@cliente_email", SqlDbType.VarChar).Value = txb_cli_new_mail.Text;
                cmd.Parameters.AddWithValue("@cliente_dom_calle", SqlDbType.VarChar).Value = txb_cli_new_calle.Text;
                cmd.Parameters.AddWithValue("@cliente_dom_nro", SqlDbType.VarChar).Value = txb_cli_new_nro.Text;
                cmd.Parameters.AddWithValue("@cliente_piso", SqlDbType.Int).Value = Convert.ToInt32(txb_cli_new_piso.Text);
                cmd.Parameters.AddWithValue("@cliente_dpto", SqlDbType.VarChar).Value = txb_cli_new_dpto.Text;
                cmd.Parameters.AddWithValue("@cliente_dom_localidad", SqlDbType.VarChar).Value = txb_cli_new_localidad.Text;
                cmd.Parameters.AddWithValue("@cliente_telefono", SqlDbType.VarChar).Value = txb_cli_new_telefono.Text;
                cmd.Parameters.AddWithValue("@cliente_nacionalidad", SqlDbType.VarChar).Value = txb_cli_new_nacionalidad.Text;
                cmd.Parameters.AddWithValue("@cliente_pais_id", SqlDbType.SmallInt).Value = combo_pais.SelectedValue;
                cmd.Parameters.AddWithValue("@fecha_sistema", SqlDbType.DateTime).Value = accesoSistema.fechaSistema;

                cmd.ExecuteNonQuery();

                // Cierro la Ventana
                Close();

                // Muestro resultado de la operacion
                MessageBox.Show("Se ha cargado el cliente " + txb_cli_new_apellidos.Text + " " + txb_cli_new_nombres.Text, "Mensaje");
            }else
            {
                MessageBox.Show("Debe ingresar todos los campos obligatorios", "Mensaje");
            }
        }

        private void cmb_cli_new_tip_doc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_cli_new_volver_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool validarFormulario()
        {
            return (!Validacion.esInicial(txb_cli_new_apellidos.Text) &
                    !Validacion.esInicial(txb_cli_new_nombres.Text) &
                    !Validacion.esInicial(txb_cli_new_calle.Text) &
                    !Validacion.esInicial(txb_cl_new_dni.Text) &
                    !Validacion.esInicial(txb_cli_new_mail.Text) &
                    !Validacion.esInicial(txb_cli_new_nacionalidad.Text) &
                    !Validacion.esInicial(txb_cli_new_localidad.Text) &
                    !Validacion.esInicial(txb_cli_new_telefono.Text) );

        }

    }
}
