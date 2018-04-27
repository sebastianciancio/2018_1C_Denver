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

        public Cliente()
        {
        
            InitializeComponent();
            db = DataBase.GetInstance();
            Cliente.c1 = this;
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("dbo.buscar_cliente", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            /*cmd.Parameters.AddWithValue("@apellido_cliente", SqlDbType.VarChar ).Value = "González";*/

            cmd.Parameters.AddWithValue("@cliente_apellido", SqlDbType.VarChar ).Value = txb_cliente_apellido.Text;
            cmd.Parameters.AddWithValue("@cliente_nombre", SqlDbType.VarChar ).Value = txb_cliente_nombre.Text;
            cmd.Parameters.AddWithValue("@cliente_dni", SqlDbType.Int ).Value = txb_cliente_dni.Text;
            cmd.ExecuteNonQuery(); 
      
            btn_eliminar.Visible = true;
            btn_modif.Visible = true;
            dgv_tablaCliente.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbmCliente.Cliente_modificacion frm = new  AbmCliente.Cliente_modificacion();
            frm.Show();
        }


    }
}
