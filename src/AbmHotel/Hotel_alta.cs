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
using System.Text.RegularExpressions;

namespace FrbaHotel.AbmHotel
{
    public partial class Hotel_alta : Form
    {
        private DataBase db;
        public Hotel_alta()
        {
            InitializeComponent();
            db = DataBase.GetInstance();

            // Cargo el Combo Pais
            Combos.cargarComboPais(combo_pais);
            Combos.cargarComboTipoRegimen(cmb_regimenes);
            Combos.cargarComboCantidad(cmb_estrellas, 1, 5);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Regex reg = new Regex("[A-z]");

            if (validarFormulario())
            {
                SqlCommand cmd = new SqlCommand("denver.cargar_hotel", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@hotel_nombre", SqlDbType.VarChar).Value = txb_nombre.Text;
                cmd.Parameters.AddWithValue("@hotel_email", SqlDbType.VarChar).Value = txb_mail.Text;
                cmd.Parameters.AddWithValue("@hotel_telefono", SqlDbType.VarChar).Value = txb_telefono.Text;
                cmd.Parameters.AddWithValue("@hotel_calle", SqlDbType.VarChar).Value = txb_calle.Text;
                if (!reg.IsMatch(txb_nro.Text))
                {
                    cmd.Parameters.AddWithValue("@hotel_nro_calle", SqlDbType.Int).Value = Convert.ToInt32(txb_nro.Text);
                } else
                {
                    MessageBox.Show("El numero no puede contener caracteres", "Error");
                    return;

                }
                cmd.Parameters.AddWithValue("@hotel_estrellas", SqlDbType.SmallInt).Value = Convert.ToInt32(cmb_estrellas.Text);
                cmd.Parameters.AddWithValue("@hotel_ciudad", SqlDbType.VarChar).Value = txb_ciudad.Text;
                cmd.Parameters.AddWithValue("@hotel_pais_id", SqlDbType.SmallInt).Value = combo_pais.SelectedValue;
                cmd.Parameters.AddWithValue("@hotel_regimen", SqlDbType.VarChar).Value = cmb_regimenes.SelectedValue;
                cmd.Parameters.AddWithValue("@user_creador", SqlDbType.VarChar).Value = accesoSistema.UsuarioLogueado.Id;
                cmd.Parameters.AddWithValue("@fecha_sistema", SqlDbType.DateTime).Value = accesoSistema.fechaSistema;


                cmd.ExecuteNonQuery();

                Close();

                MessageBox.Show("Se ha cargado el Hotel " + txb_nombre.Text, "Mensaje");
            }
            else { MessageBox.Show("Debe completar todos los campos obligatorios", "Mensaje"); }
        }

        private void btn__volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validarFormulario()
        {
            return (!Validacion.esInicial(txb_nombre.Text) &
                    !Validacion.esInicial(txb_mail.Text) &
                    !Validacion.esInicial(txb_telefono.Text) &
                    !Validacion.esInicial(txb_calle.Text) &
                    !Validacion.esInicial(txb_nro.Text) &
                    !Validacion.esInicial(txb_ciudad.Text));

        }

    }
}
