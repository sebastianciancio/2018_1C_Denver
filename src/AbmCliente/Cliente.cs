﻿using System;
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

            if (txb_cliente_apellido.Text != "")
                cmd.Parameters.AddWithValue("@cliente_apellido", SqlDbType.VarChar ).Value = txb_cliente_apellido.Text;

            if (txb_cliente_nombre.Text != "")
                cmd.Parameters.AddWithValue("@cliente_nombre", SqlDbType.VarChar ).Value = txb_cliente_nombre.Text;

            if (txb_cliente_dni.Text != "")
                cmd.Parameters.AddWithValue("@cliente_dni", SqlDbType.Int ).Value = txb_cliente_dni.Text;

            //cmd.ExecuteNonQuery();

            // Creo el DataTable para obtener los resultados del SP
            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            // Cargo la Grilla con los datos obtenidos
            dgv_tablaCliente.DataSource = dt;

            // Muestro los objetos ocultos
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
            //AbmCliente.Cliente_modificacion frm = new  AbmCliente.Cliente_modificacion();
            //frm.Show();
        }


    }
}