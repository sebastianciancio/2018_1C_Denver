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
            Combos.cargarComboTipoRegimen(cmb_regimenes, false);
            
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("denver.modificar_hotel", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = Convert.ToInt32(hotel_id);
            cmd.Parameters.AddWithValue("@hotel_nombre", SqlDbType.NVarChar).Value = txb_nombre.Text;
            cmd.Parameters.AddWithValue("@hotel_mail", SqlDbType.NVarChar).Value = txb_mail.Text;
            cmd.Parameters.AddWithValue("@hotel_telefono", SqlDbType.NVarChar).Value = txb_telefono.Text;
            cmd.Parameters.AddWithValue("@hotel_direccion", SqlDbType.NVarChar).Value = txb_calle.Text;
            cmd.Parameters.AddWithValue("@hotel_estrellas", SqlDbType.Int).Value = Convert.ToInt32(cmb_estrellas.Text);
            cmd.Parameters.AddWithValue("@hotel_ciudad", SqlDbType.NVarChar).Value = txb_ciudad.Text;
            cmd.Parameters.AddWithValue("@hotel_pais", SqlDbType.Int).Value = cmb_pais.SelectedValue;
            //levanta el ID
            cmd.Parameters.AddWithValue("@hotel_regimenes", SqlDbType.Int).Value = cmb_regimenes.SelectedValue;
            cmd.Parameters.AddWithValue("@hotel_creacion", SqlDbType.Int).Value = Convert.ToDateTime(cmb_creacion.Value);


            cmd.ExecuteNonQuery();

            MessageBox.Show("El hotel " + txb_nombre.Text + " se modificó correctamente", "Mensaje");
            Close();
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
            cmb_estrellas.Text = row["hotel_estrellas"].ToString();
            cmb_regimenes.SelectedValue = row["hotel_regimen_regimen_id"].ToString();

        }


    }
    }