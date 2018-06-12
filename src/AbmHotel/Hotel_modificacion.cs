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
        public string hotel_nombre;
        public string hotel_ciudad;
        public string hotel_mail;
        public string hotel_pais_id;
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
            cmd.Parameters.AddWithValue("@hotel_nombre", SqlDbType.VarChar).Value = txb_nombre.Text;
            cmd.Parameters.AddWithValue("@hotel_mail", SqlDbType.VarChar).Value = txb_mail.Text;
            cmd.Parameters.AddWithValue("@hotel_telefono", SqlDbType.VarChar).Value = txb_telefono.Text;
            cmd.Parameters.AddWithValue("@hotel_direccion", SqlDbType.VarChar).Value = txb_calle.Text;
            cmd.Parameters.AddWithValue("@hotel_estrellas", SqlDbType.Int).Value = Convert.ToInt32(cmb_estrellas.Text);
            cmd.Parameters.AddWithValue("@hotel_ciudad", SqlDbType.VarChar).Value = txb_ciudad.Text;
            cmd.Parameters.AddWithValue("@hotel_pais", SqlDbType.VarChar).Value = cmb_pais;
            //levanta el ID
            cmd.Parameters.AddWithValue("@hotel_regimenes", SqlDbType.Int).Value = cmb_regimenes.SelectedValue;
            cmd.Parameters.AddWithValue("@hotel_creacion", SqlDbType.Int).Value = Convert.ToDateTime(cmb_creacion.Value);


            cmd.ExecuteNonQuery();

            MessageBox.Show("El hotel " + txb_nombre.Text + " se modificó correctamente", "Mensaje");
        }

        private void btn__volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Hotel_modificacion_Load_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.buscar_hotel_completo", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@hotel_nombre", SqlDbType.VarChar).Value = hotel_nombre;
            cmd.Parameters.AddWithValue("@hotel_mail", SqlDbType.VarChar).Value = hotel_mail;
            cmd.Parameters.AddWithValue("@hotel_pais", SqlDbType.VarChar).Value = hotel_pais_id;
            cmd.Parameters.AddWithValue("@hotel_ciudad", SqlDbType.VarChar).Value = hotel_ciudad;

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
            cmb_estrellas.SelectedValue = Convert.ToInt32(row["hotel_estrellas"]);
            cmb_regimenes.SelectedValue = row["hotel_regimen_regimen_id"].ToString();

        }


    }
    }