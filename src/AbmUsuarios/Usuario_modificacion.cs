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
    public partial class Usuario_modificacion : Form
    {
        public string user;
        //Parametro para cuando el usuario logueado desea modificarse
        public string user_logueado;
        private DataBase db;
        public Usuario_modificacion()
        {
            db = DataBase.GetInstance();
            InitializeComponent();
            Combos.cargarComboRoles(cmb_rol);
            Combos.cargarComboTipoDocumento(cmb_tipoDoc);
        }

        private void Usuario_modificacion_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.buscar_usuario_completo", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (user != null)
            {
                cmd.Parameters.AddWithValue("@usuario_user", SqlDbType.VarChar).Value = user;
            }
            else { cmd.Parameters.AddWithValue("@usuario_user", SqlDbType.VarChar).Value = user_logueado; }
            // Creo el DataTable para obtener los resultados del SP
            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            //Accedo a lo que encontre en la BD
            DataRow row = dt.Rows[0];

            //Mando los datos al form Modificar_cliente
            //txb_user.Text = user;
            txb_user.Text = row["usuario_user"].ToString();
            //cmb_tipoDoc.SelectedValue = row["usuario_tipo_documento_id"].ToString();
            txb_numDni.Text = row["usuario_nro_documento"].ToString();
            txb_apellido.Text = row["usuario_apellido"].ToString();
            txb_nombre.Text = row["usuario_nombre"].ToString();
            txb_mail.Text = row["usuario_email"].ToString();
            txb_calle.Text = row["usuario_direccion"].ToString();
            txb_telefono.Text = row["usuario_telefono"].ToString();
            if (row["usuario_tipo_documento_id"].ToString() != "")
            {
                cmb_tipoDoc.SelectedValue = Convert.ToInt32(row["usuario_tipo_documento_id"]);
            }
            cmb_rol.SelectedValue = row["usuario_rol_rol_nombre"];
            if (row["usuario_fecha_nac"].ToString() != "")
            { cmb_nacimiento.Value = Convert.ToDateTime(row["usuario_fecha_nac"]); }

            if (row["usuario_activo"].ToString() == "N") { btn_habilitar.Visible = true; }
            if (txb_user.Text == accesoSistema.UsuarioLogueado.Id ) { btn_off.Visible = true; } 
               
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarFormulario()) { 
            SqlCommand cmd = new SqlCommand("denver.modificar_usuario", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@usuario_user", SqlDbType.VarChar).Value = txb_user.Text;
          //  cmd.Parameters.AddWithValue("@usuario_pass", SqlDbType.VarChar).Value = txb_pas.Text;
            cmd.Parameters.AddWithValue("@usuario_tipo_documento_id", SqlDbType.Int).Value = cmb_tipoDoc.SelectedValue;
            cmd.Parameters.AddWithValue("@usuario_nro_documento", SqlDbType.Int).Value = Convert.ToInt32(txb_numDni.Text);
            cmd.Parameters.AddWithValue("@usuario_apellido", SqlDbType.VarChar).Value = txb_apellido.Text;
            cmd.Parameters.AddWithValue("@usuario_nombre", SqlDbType.VarChar).Value = txb_nombre.Text;
            cmd.Parameters.AddWithValue("@usuario_fecha_nac", SqlDbType.DateTime).Value = Convert.ToDateTime(cmb_nacimiento.Value);
            cmd.Parameters.AddWithValue("@usuario_email", SqlDbType.VarChar).Value = txb_mail.Text;
            cmd.Parameters.AddWithValue("@usuario_direccion", SqlDbType.VarChar).Value = txb_calle.Text;
            cmd.Parameters.AddWithValue("@usuario_telefono", SqlDbType.VarChar).Value = txb_telefono.Text;
            cmd.Parameters.AddWithValue("@usuario_rol", SqlDbType.VarChar).Value = cmb_rol.SelectedValue;
            cmd.Parameters.AddWithValue("@fecha_sistema", SqlDbType.DateTime).Value = accesoSistema.fechaSistemaSQL;

            cmd.ExecuteNonQuery();

            // Cierro la Ventana
            Close();


            MessageBox.Show("Se ha cargado el Usuario " + txb_user.Text, "Mensaje");
        }
         else {
                    MessageBox.Show("Debe completar todos los campos obligatorios", "Advertencia");
                } }

        private bool validarFormulario()
        {
            return (!Validacion.esInicial(txb_user.Text) &
                   // !Validacion.esInicial(txb_pas.Text) &
                    !Validacion.esInicial(txb_apellido.Text) &
                    !Validacion.esInicial(txb_nombre.Text) &
                    !Validacion.esInicial(txb_mail.Text) &
                    !Validacion.esInicial(txb_calle.Text) &
                    !Validacion.esInicial(txb_telefono.Text) &
                    !Validacion.esInicial(cmb_nacimiento.Value.ToString()));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            cmb_rol.Enabled = true;
            btn_guardar.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.habilitar_usuario", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario_user", SqlDbType.VarChar).Value = txb_user.Text;
            cmd.ExecuteNonQuery();

            MessageBox.Show("El usuario se habilito correctamente", "Mensaje");
            btn_habilitar.Visible = false;
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_contra_Click(object sender, EventArgs e)
        {
            Hide();
            AbmUsuarios.Cambiar_pass frm = new AbmUsuarios.Cambiar_pass();
            frm.user = txb_user.Text;
            frm.Show();
        }

        private void btn_off_Click(object sender, EventArgs e)
        {
            accesoSistema.UsuarioLogueado.Apellido = "";
            accesoSistema.UsuarioLogueado.Nombre = "";
            accesoSistema.UsuarioLogueado.Id = "";
            accesoSistema.UsuarioLogueado.Rol = "";
            accesoSistema.HotelIdActual = 0;
            accesoSistema.HotelNombreActual = "";
            accesoSistema.pass = "";
            accesoSistema.UsuarioLogueado.Rol = "";

            Hide();
            Principal.ActiveForm.Hide();

            accesoSistema frm = new accesoSistema();
            frm.Show();
        }
    }
    
}
