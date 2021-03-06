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
    public partial class Hotel_modificacion : Form
    {
        private DataBase db;
        public string hotel_id;
        public Hotel_modificacion()
        {
            InitializeComponent();
            db = DataBase.GetInstance();
            Combos.cargarComboPais(cmb_pais, true);
          //  Combos.cargarComboTipoRegimen(cmb_regimenes, accesoSistema.HotelIdActual, false);

        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
                Regex reg = new Regex("[A-z]");
                if (reg.IsMatch(txb_nro.Text))
                {
                    MessageBox.Show("El numero no puede contener caracteres", "Error");
                    return;
                }
                if (reg.IsMatch(txb_telefono.Text))
                {
                    MessageBox.Show("El telefono no puede contener caracteres", "Error");
                    return;
                }

                if (reg.IsMatch(txb_Recarga.Text))
                {
                    MessageBox.Show("La recarga no puede contener caracteres", "Error");
                    return;
                }

                if (validarFormulario())
                {

                    SqlCommand cmd = new SqlCommand("denver.modificar_hotel", db.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = Convert.ToInt32(hotel_id);
                    cmd.Parameters.AddWithValue("@hotel_nombre", SqlDbType.NVarChar).Value = txb_nombre.Text;
                    cmd.Parameters.AddWithValue("@hotel_mail", SqlDbType.NVarChar).Value = txb_mail.Text;
                    cmd.Parameters.AddWithValue("@hotel_telefono", SqlDbType.NVarChar).Value = txb_telefono.Text;
                    cmd.Parameters.AddWithValue("@hotel_direccion", SqlDbType.NVarChar).Value = txb_calle.Text;
                    cmd.Parameters.AddWithValue("@hotel_numero", SqlDbType.Int).Value = Convert.ToInt32(txb_nro.Text);
                    cmd.Parameters.AddWithValue("@hotel_estrellas", SqlDbType.Int).Value = Convert.ToInt32(cmb_estrellas.Text);
                    cmd.Parameters.AddWithValue("@hotel_ciudad", SqlDbType.NVarChar).Value = txb_ciudad.Text;
                    cmd.Parameters.AddWithValue("@hotel_pais", SqlDbType.Int).Value = cmb_pais.SelectedValue;
                    cmd.Parameters.AddWithValue("@recarga", SqlDbType.Int).Value = Convert.ToInt32(txb_Recarga.Text);

                    cmd.ExecuteNonQuery();


                    int sum;
                    for (int i = 0; i < clb_regimenes.CheckedIndices.Count; i++)
                    {
                        // int selection = clb_funcionalidades.CheckedIndices[i];
                        SqlCommand cmd2 = new SqlCommand("denver.cargar_hotel_regimen", db.Connection);
                        cmd2.CommandType = CommandType.StoredProcedure;
                        cmd2.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = Convert.ToInt32(hotel_id);
                        sum = clb_regimenes.CheckedIndices[i] + 1;
                        cmd2.Parameters.AddWithValue("@regimen", SqlDbType.SmallInt).Value = sum;
                        cmd2.ExecuteNonQuery();
                    }


                    MessageBox.Show("El hotel " + txb_nombre.Text + " se modificó correctamente", "Mensaje");
                    Close();
                }
                else 
                { 
                    MessageBox.Show("Debe completar todos los campos obligatorios", "Mensaje"); 
                }


        }

        private void btn__volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Hotel_modificacion_Load_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.buscar_hotel_completo", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = Convert.ToInt32(hotel_id);

            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            //Accedo a lo que encontre en la BD
            DataRow row = dt.Rows[0];


            txb_nombre.Text = row["hotel_nombre"].ToString();
            txb_calle.Text = row["hotel_calle"].ToString();
            txb_nro.Text = row["hotel_nro_calle"].ToString();
            txb_ciudad.Text = row["hotel_ciudad"].ToString();
            cmb_pais.SelectedValue = row["hotel_pais_id"].ToString();
            txb_mail.Text = row["hotel_email"].ToString();
            txb_telefono.Text = row["hotel_telefono"].ToString();
            txb_Recarga.Text = row["hotel_recarga_estrella"].ToString();
            cmb_estrellas.Text = row["hotel_estrellas"].ToString();
            //cmb_regimenes.SelectedValue = row["hotel_regimen_regimen_id"].ToString();

            SqlCommand cmd2 = new SqlCommand("denver.obtener_todos_regimenes", DataBase.GetInstance().Connection);
            cmd2.CommandType = CommandType.StoredProcedure;


            DataTable dt2 = new DataTable();

            using (var da2 = new SqlDataAdapter(cmd2))
            {
                da2.Fill(dt2);
            }

            for (int i = 0; i < dt2.Rows.Count; i++)
            {

                clb_regimenes.Items.Add(dt2.Rows[i][0], false);

            }

            SqlCommand cmd3 = new SqlCommand("denver.buscar_regimenes_hotel", DataBase.GetInstance().Connection);
            cmd3.CommandType = CommandType.StoredProcedure;

            cmd3.Parameters.AddWithValue("@hotel_id", SqlDbType.VarChar).Value = Convert.ToInt32(hotel_id);
            DataTable dt3 = new DataTable();

            using (var da3 = new SqlDataAdapter(cmd3))
            {
                da3.Fill(dt3);
            }

            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                clb_regimenes.SetItemChecked(Convert.ToInt32(dt3.Rows[i][0]) - 1, true);
            }

        }

    
        private bool validarFormulario()
        {
            return (!Validacion.esInicial(txb_nombre.Text) &
                    !Validacion.esInicial(txb_mail.Text) &
                    !Validacion.esInicial(txb_telefono.Text) &
                    !Validacion.esInicial(txb_calle.Text) &
                    !Validacion.esInicial(txb_nro.Text) &
                    !Validacion.esInicial(txb_ciudad.Text) &
                    !Validacion.esInicial(txb_Recarga.Text));

        }
    } }