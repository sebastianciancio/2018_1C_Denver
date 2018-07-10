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

    public partial class Cliente_modificacion : Form
    {
        private DataBase db;
        public string tipoDocumento;
        public string nroDocumento;

        public Cliente_modificacion()
        {
            InitializeComponent();
            db = DataBase.GetInstance();
            Combos.cargarComboPais(combo_pais);
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void Cliente_modificacion_Load(object sender, EventArgs e)
        {
            //
            SqlCommand cmd = new SqlCommand("denver.buscar_cliente_completo", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@cliente_doc", SqlDbType.VarChar).Value = tipoDocumento;
            cmd.Parameters.AddWithValue("@cliente_dni", SqlDbType.Int).Value = nroDocumento;

            // Creo el DataTable para obtener los resultados del SP
            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            //Accedo a lo que encontre en la BD
            DataRow row = dt.Rows[0];

            //Mando los datos al form Modificar_cliente
            txb_tipoDoc.Text = tipoDocumento;
            txb_cli_mod_dni.Text = nroDocumento;

            txb_cli_mod_apellidos.Text    = row["cliente_apellido"].ToString();
            txb_cli_mod_nombres.Text      = row["cliente_nombre"].ToString();
            cmb_cli_mod_fec_nac.Value = Convert.ToDateTime(row["cliente_fecha_nac"]);
            txb_cli_mod_mail.Text         = row["cliente_email"].ToString();
            txb_cli_mod_calle.Text        = row["cliente_dom_calle"].ToString();
            txb_cli_mod_nro.Text          = row["cliente_dom_nro"].ToString();
            txb_cli_mod_piso.Text         = row["cliente_piso"].ToString();
            txb_cli_mod_dpto.Text         = row["cliente_dpto"].ToString();
            txb_cli_mod_localidad.Text    = row["cliente_dom_localidad"].ToString();
            txb_cli_mod_telefono.Text     = row["cliente_telefono"].ToString();
            txb_cli_mod_nacionalidad.Text = row["cliente_nacionalidad"].ToString();
            combo_pais.SelectedValue = row["cliente_pais_id"];
        }

        private void btn_cli_mod_guardar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                SqlCommand cmd = new SqlCommand("denver.modificar_cliente", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@cliente_tipo_documento", SqlDbType.VarChar).Value = txb_tipoDoc.Text;
                cmd.Parameters.AddWithValue("@cliente_pasaporte_nro", SqlDbType.Int).Value = Convert.ToInt32(txb_cli_mod_dni.Text);
                cmd.Parameters.AddWithValue("@cliente_apellido", SqlDbType.VarChar).Value = txb_cli_mod_apellidos.Text;
                cmd.Parameters.AddWithValue("@cliente_nombre", SqlDbType.VarChar).Value = txb_cli_mod_nombres.Text;
                cmd.Parameters.AddWithValue("@cliente_fecha_nac", SqlDbType.DateTime).Value = Convert.ToDateTime(cmb_cli_mod_fec_nac.Value);
                cmd.Parameters.AddWithValue("@cliente_email", SqlDbType.VarChar).Value = txb_cli_mod_mail.Text;
                cmd.Parameters.AddWithValue("@cliente_dom_calle", SqlDbType.VarChar).Value = txb_cli_mod_calle.Text;
                cmd.Parameters.AddWithValue("@cliente_dom_nro", SqlDbType.VarChar).Value = txb_cli_mod_nro.Text;
                cmd.Parameters.AddWithValue("@cliente_piso", SqlDbType.Int).Value = Convert.ToInt32(txb_cli_mod_piso.Text);
                cmd.Parameters.AddWithValue("@cliente_dpto", SqlDbType.VarChar).Value = txb_cli_mod_dpto.Text;
                cmd.Parameters.AddWithValue("@cliente_dom_localidad", SqlDbType.VarChar).Value = txb_cli_mod_localidad.Text;
                cmd.Parameters.AddWithValue("@cliente_telefono", SqlDbType.VarChar).Value = txb_cli_mod_telefono.Text;
                cmd.Parameters.AddWithValue("@cliente_nacionalidad", SqlDbType.VarChar).Value = txb_cli_mod_nacionalidad.Text;
                cmd.Parameters.AddWithValue("@cliente_pais_id", SqlDbType.SmallInt).Value = Convert.ToInt32(combo_pais.SelectedValue);

                cmd.ExecuteNonQuery();

                // Cierro la Ventana
                Close();

                // Muestro resultado de la operacion
                MessageBox.Show("Se ha modificado el cliente " + txb_cli_mod_apellidos.Text + " " + txb_cli_mod_nombres.Text, "Mensaje");
            }
            else
            {
                MessageBox.Show("Debe ingresar todos los campos obligatorios", "Mensaje");
            }
        }


    private void btn_cli_mod_volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validarFormulario()
        {
            return (!Validacion.esInicial(txb_cli_mod_apellidos.Text) &
                    !Validacion.esInicial(txb_cli_mod_nombres.Text) &
                    !Validacion.esInicial(txb_cli_mod_mail.Text) &
                    !Validacion.esInicial(txb_cli_mod_nacionalidad.Text) &
                    !Validacion.esInicial(txb_cli_mod_localidad.Text) &
                    !Validacion.esInicial(txb_cli_mod_telefono.Text));

        }


    }
}
