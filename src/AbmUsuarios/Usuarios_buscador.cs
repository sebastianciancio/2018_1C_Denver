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
    public partial class Usuarios_buscador : Form
    {
        private DataBase db;
        public Usuarios_buscador()
        {
            db = DataBase.GetInstance();
            InitializeComponent();

            // Cargo los combos
            Combos.cargarComboHotel(cmb_hotel, true);
        }

        private void btn_modif_Click(object sender, EventArgs e)
        {
            AbmUsuarios.Usuario_modificacion frm = new AbmUsuarios.Usuario_modificacion();
            DataGridViewRow row = dgv_tablaUsuario.CurrentRow;

            string user = row.Cells[0].Value.ToString();

            //Paso el valor de las claves al nuevo formulario de modificación
            //para poder consultar la base de datos y traer los campos que se quieran modificar
            frm.user = user;


            frm.Show();
        }

        private void btt_add_usuario_Click(object sender, EventArgs e)
        {

            AbmUsuarios.NuevoUsuario frm = new AbmUsuarios.NuevoUsuario();

            frm.Show();

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.eliminar_usuario", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            //Levanto la linea seleccionada
            DataGridViewRow row = dgv_tablaUsuario.CurrentRow;

            // Si existen datos
            if (row != null)
            {
                DialogResult result = MessageBox.Show("Esta seguro de que desea eliminar?", "Confirmar eliminación",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    //por el numero obtiene la columna
                    // Obtenés los valores caves de la tabla Cliente 
                    string user = row.Cells[0].Value.ToString();

                    //paso los parametros al SP
                    cmd.Parameters.AddWithValue("@usuario_user", SqlDbType.VarChar).Value = user;

                    // Ejecuto el SP
                    cmd.ExecuteNonQuery();

                    // Muestro resultado de la operacion
                    MessageBox.Show("Se ha eliminado el Usuario " + user, "Mensaje");

                    dgv_tablaUsuario.Visible = false;

                    // Actualizo la Tabla del Resultado de la Busqueda
                    btn_buscar_Click(new object(), new EventArgs());
                }
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.buscar_usuario", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@usuario_nombre", SqlDbType.VarChar).Value = txb_nombre.Text;

            cmd.Parameters.AddWithValue("@usuario_apellido", SqlDbType.VarChar).Value = txb_apellido.Text;

            if (cmb_hotel.SelectedValue.ToString().CompareTo("0") > 0)
                cmd.Parameters.AddWithValue("@hotel", SqlDbType.Int).Value = Convert.ToInt32(cmb_hotel.SelectedValue);

            // Creo el DataTable para obtener los resultados del SP
            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }


            // Cargo la Grilla con los datos obtenidos
            dgv_tablaUsuario.DataSource = dt;
            dgv_tablaUsuario.Visible = true;

            if (Convert.ToInt32(cmb_hotel.SelectedValue) != accesoSistema.HotelIdActual)
            {
                // dgv_tablaUsuario.Enabled = false;
                btn_eliminar.Enabled = false;
                btn_modif.Enabled = false;
                btn_eliminar.Visible = true;
                btn_modif.Visible = true;

                btn_agregar.Visible = true;
            }
            else
            {
                btn_eliminar.Enabled = true;
                btn_modif.Enabled = true;
                btn_eliminar.Visible = true;
                btn_modif.Visible = true;

                btn_agregar.Visible = false;

            }
        }

        private void help_crear_Popup(object sender, PopupEventArgs e)
        {
            // help_crear.Tag = "El usuario seleccionado se habilitara en su hotel de logueo";        }
        }

        private void Usuarios_buscador_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgv_tablaUsuario.CurrentRow;

            string user = row.Cells[0].Value.ToString();

            //Paso el valor de las claves al nuevo formulario de modificación
            //para poder consultar la base de datos y traer los campos que se quieran modificar
            DialogResult result = MessageBox.Show("Desea agregar el usuario " + user + " al hotel " + accesoSistema.HotelNombreActual + "?", "Confirmar",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("denver.cargar_usuario_hotel", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@usuario_nombre", SqlDbType.VarChar).Value = user;

                cmd.Parameters.AddWithValue("@usuario_hotel", SqlDbType.Int).Value = accesoSistema.HotelIdActual;

                cmd.ExecuteNonQuery();

                MessageBox.Show("El usuario se agregó correctamente al hotel", "Mensaje");
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
