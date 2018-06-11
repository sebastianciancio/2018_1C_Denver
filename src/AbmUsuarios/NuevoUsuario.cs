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

namespace FrbaHotel.AbmUsuarios
{
    public partial class NuevoUsuario : Form
    {
        private DataBase db;
        public NuevoUsuario()
        {
            db = DataBase.GetInstance();
            InitializeComponent();
            Combos.cargarComboTipoDocumento(cmb_tipoDoc);
            Combos.cargarComboRoles(cmb_rol);
        }

        private void txb_pas_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT denver.existe_usuario ('" + txb_user.Text + "')", db.Connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            // Si existe
            if (Convert.ToInt32(dt.Rows[0][0]) == 1)
            {
                lbl_userRepetido.Visible = true;
            }
            else {
                lbl_userRepetido.Visible = false;
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
            if (validarFormulario())
            {
                SqlCommand cmd = new SqlCommand("denver.cargar_usuario", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@usuario_user", SqlDbType.VarChar).Value = txb_user.Text;
                cmd.Parameters.AddWithValue("@usuario_pass", SqlDbType.VarChar).Value = txb_pas.Text;
                cmd.Parameters.AddWithValue("@usuario_tipo_documento_id", SqlDbType.Int).Value = Convert.ToInt32(cmb_tipoDoc.SelectedValue);
                cmd.Parameters.AddWithValue("@usuario_nro_documento", SqlDbType.VarChar).Value = txb_numDni.Text;
                cmd.Parameters.AddWithValue("@usuario_apellido", SqlDbType.VarChar).Value = txb_apellido.Text;
                cmd.Parameters.AddWithValue("@usuario_nombre", SqlDbType.VarChar).Value = txb_nombre.Text;
                cmd.Parameters.AddWithValue("@usuario_fecha_nac", SqlDbType.DateTime).Value = cmb_nacimiento.Value;
                cmd.Parameters.AddWithValue("@usuario_email", SqlDbType.VarChar).Value = txb_mail.Text;
                cmd.Parameters.AddWithValue("@usuario_direccion", SqlDbType.VarChar).Value = txb_calle.Text;
                cmd.Parameters.AddWithValue("@usuario_telefono", SqlDbType.VarChar).Value = txb_telefono.Text;
                cmd.Parameters.AddWithValue("@usuario_rol", SqlDbType.VarChar).Value = cmb_rol.SelectedValue;
                cmd.Parameters.AddWithValue("@usuario_hotel", SqlDbType.Int).Value = Convert.ToInt32(accesoSistema.HotelIdActual);

                cmd.ExecuteNonQuery();



                MessageBox.Show("Se ha cargado el Usuario " + txb_user.Text, "Mensaje");
                this.Close();


            } else {
                MessageBox.Show("Debe completar todos los campos obligatorios", "Advertencia");
            }

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validarFormulario()
        {
            return (!Validacion.esInicial(txb_user.Text) &
                    !Validacion.esInicial(txb_pas.Text) &
                    !Validacion.esInicial(txb_apellido.Text) &
                    !Validacion.esInicial(txb_nombre.Text) &
                    !Validacion.esInicial(txb_mail.Text) &
                    !Validacion.esInicial(txb_calle.Text) &
                    !Validacion.esInicial(txb_telefono.Text) &
                    !Validacion.esInicial(cmb_nacimiento.Value.ToString()));

        }


    }
}
