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
            Combos.cargarComboHotel(cmb_hotel);
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
            Hide();
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
                    MessageBox.Show("Se ha eliminado el Usuario " + user , "Mensaje");

                    dgv_tablaUsuario.Visible = false;

                    // Actualizo la Tabla del Resultado de la Busqueda
                    btn_buscar_Click(new object(), new EventArgs());
                }
            }
        }

    }
}
