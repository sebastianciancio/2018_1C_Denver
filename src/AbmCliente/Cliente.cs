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
    public partial class Cliente : Form
    {

        private DataBase db;

        public static Cliente c1;
        public string cliente_apellido;
        public string cliente_nombre;
        public int cliente_dni;
        public string cliente_tipo_documento;
        public int cliente_tipo_documento_id;

        public Cliente()
        {

            InitializeComponent();
            db = DataBase.GetInstance();
            Cliente.c1 = this;

            // Cargo el Combo
            Combos.cargarComboTipoDocumento(cmb_tipo_doc, true);
        }



        private void btn_buscar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.buscar_cliente", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            if (txb_cliente_apellido.Text != "")
                cmd.Parameters.AddWithValue("@cliente_apellido", SqlDbType.VarChar).Value = txb_cliente_apellido.Text;

            if (txb_cliente_nombre.Text != "")
                cmd.Parameters.AddWithValue("@cliente_nombre", SqlDbType.VarChar).Value = txb_cliente_nombre.Text;

            if (txb_cliente_dni.Text != "")
                cmd.Parameters.AddWithValue("@cliente_nro_doc", SqlDbType.Int).Value = Convert.ToInt32(txb_cliente_dni.Text);

            if (cmb_tipo_doc.SelectedValue.ToString().CompareTo("0") > 0)
                cmd.Parameters.AddWithValue("@cliente_tipo_doc", SqlDbType.Int).Value = Convert.ToInt32(cmb_tipo_doc.SelectedValue);

            // Creo el DataTable para obtener los resultados del SP
            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }
 

            // Cargo la Grilla con los datos obtenidos
            dgv_tablaCliente.DataSource = dt;

            // Muestro los objetos ocultos
            dgv_tablaCliente.Visible = true;

            // Oculto Columnas del Resultado
            dgv_tablaCliente.Columns[6].Visible = false;

            // Si solo es para seleccionar clientes, por ej. Reservas
            if (accesoSistema.habilitarSeleccionCliente)
            {
                panel_botones.Visible = false;
                btn_seleccionar.Visible = true;
            }
            else
            {
                panel_botones.Visible = true;
                btn_seleccionar.Visible = false;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbmCliente.Cliente_modificacion frm = new AbmCliente.Cliente_modificacion();
            DataGridViewRow row = dgv_tablaCliente.CurrentRow;

            //por el numero obtiene la columna
            // Obtenés los valores caves de la tabla Cliente 
            string tipoDni = row.Cells[0].Value.ToString();
            string numDni = row.Cells[1].Value.ToString();

            //Paso el valor de las claves al nuevo formulario de modificación
            //para poder consultar la base de datos y traer los campos que se quieran modificar
            frm.tipoDocumento = tipoDni;
            frm.nroDocumento = numDni;


            frm.Show();

        }

        private void btt_add_client_Click(object sender, EventArgs e)
        {
            FrbaHotel.AbmCliente.Cliente_alta cli_mod = new FrbaHotel.AbmCliente.Cliente_alta();

            cli_mod.Show();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            // SP eliminar cliente
            SqlCommand cmd = new SqlCommand("denver.eliminar_cliente", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            //Levanto la linea seleccionada
            DataGridViewRow row = dgv_tablaCliente.CurrentRow;

            // Si existen datos
            if (row != null)
            {
                DialogResult result = MessageBox.Show("Esta seguro de que desea eliminar?", "Confirmar eliminación",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {

                    //por el numero obtiene la columna
                    // Obtenés los valores caves de la tabla Cliente 
                    string tipoDni = row.Cells[0].Value.ToString();
                    string numDni = row.Cells[1].Value.ToString();

                    //paso los parametros al SP
                    cmd.Parameters.AddWithValue("@cliente_tipo_documento_id", SqlDbType.VarChar).Value = tipoDni;
                    cmd.Parameters.AddWithValue("@cliente_pasaporte_nro", SqlDbType.VarChar).Value = numDni;

                    // Ejecuto el SP
                    cmd.ExecuteNonQuery();

                    // Muestro resultado de la operacion
                    MessageBox.Show("Se ha eliminado el cliente " + row.Cells[2].Value.ToString() + " " + row.Cells[2].Value.ToString(), "Mensaje");

                    dgv_tablaCliente.Visible = false;

                    // Actualizo la Tabla del Resultado de la Busqueda
                    btn_buscar_Click(new object(), new EventArgs());
                }
            }

        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            //Levanto la linea seleccionada
            DataGridViewRow row = dgv_tablaCliente.CurrentRow;

            accesoSistema.ClienteSeleccionado.cliente_apellido = row.Cells[2].Value.ToString();
            accesoSistema.ClienteSeleccionado.cliente_nombre = row.Cells[3].Value.ToString();
            accesoSistema.ClienteSeleccionado.cliente_dni = Convert.ToInt32(row.Cells[1].Value.ToString());
            accesoSistema.ClienteSeleccionado.cliente_tipo_documento = row.Cells[0].Value.ToString();
            accesoSistema.ClienteSeleccionado.cliente_tipo_documento_id = Convert.ToInt32(row.Cells[6].Value.ToString());

            // Deshabilito la seleccion de Clientes
            accesoSistema.habilitarSeleccionCliente = false;

            // Cierro el Form
            this.Close();
        }
    }
}
