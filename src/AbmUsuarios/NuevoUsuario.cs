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
            SqlCommand cmd = new SqlCommand("dbo.cargar_usuario", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@usuario_user", SqlDbType.VarChar).Value = txb_user.Text;
            cmd.Parameters.AddWithValue("@usuario_pass", SqlDbType.VarChar).Value = txb_pas.Text;
            cmd.Parameters.AddWithValue("@usuario_tipo_documento_id", SqlDbType.Int).Value = cmb_tipoDoc.SelectedValue;
            cmd.Parameters.AddWithValue("@usuario_nro_documento", SqlDbType.Int).Value = Convert.ToInt32(txb_numDni.Text);
            cmd.Parameters.AddWithValue("@usuario_apellido", SqlDbType.VarChar).Value = txb_apellido.Text;
            cmd.Parameters.AddWithValue("@usuario_nombre", SqlDbType.VarChar).Value = txb_nombre.Text;
            cmd.Parameters.AddWithValue("@usuario_fecha_nac", SqlDbType.DateTime).Value = "";
            cmd.Parameters.AddWithValue("@usuario_email", SqlDbType.VarChar).Value = txb_mail.Text;
            cmd.Parameters.AddWithValue("@usuario_direccion", SqlDbType.VarChar).Value = txb_calle.Text;
            cmd.Parameters.AddWithValue("@usuario_telefono", SqlDbType.VarChar).Value = txb_telefono.Text;
            cmd.Parameters.AddWithValue("@usuario_rol", SqlDbType.VarChar).Value = cmb_rol.SelectedValue;

            cmd.ExecuteNonQuery();

            Close();

            MessageBox.Show("Se ha cargado el Usuario " + txb_user.Text , "Mensaje");

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_userRepetido_Click(object sender, EventArgs e)
        {

        }

        private void cmb_rol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txb_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
