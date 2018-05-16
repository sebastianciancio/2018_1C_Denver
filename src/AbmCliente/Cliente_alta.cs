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
        }

        private void btn_cli_new_guardar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("dbo.creae_cliente", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cliente_apellido", SqlDbType.VarChar).Value = txb_cli_new_apellidos.Text;
            cmd.Parameters.AddWithValue("@cliente_nombre", SqlDbType.VarChar).Value = txb_cli_new_nombres.Text;
            cmd.Parameters.AddWithValue("@cliente_email", SqlDbType.VarChar).Value = txb_cli_new_mail.Text;
            cmd.Parameters.AddWithValue("@cliente_calle", SqlDbType.VarChar).Value = txb_cli_new_calle.Text;
            cmd.Parameters.AddWithValue("@cliente_nro", SqlDbType.VarChar).Value = txb_cli_new_nro.Text;
            cmd.Parameters.AddWithValue("@cliente_piso", SqlDbType.Int).Value = txb_cli_new_piso.Text;
            cmd.Parameters.AddWithValue("@cliente_dpto", SqlDbType.VarChar).Value = txb_cli_new_dpto.Text;
            //FAltan parametros


            cmd.ExecuteNonQuery();
           //     BeginExecuteNonQuery();

        }



  

    }
}
