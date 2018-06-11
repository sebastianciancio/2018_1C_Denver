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
        }

        private void Hotel_modificacion_Load(object sender, EventArgs e)
        {

            
            //
            SqlCommand cmd = new SqlCommand("dbo.buscar_hotel_completo", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = hotel_id;

            // Creo el DataTable para obtener los resultados del SP
            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            //Accedo a lo que encontre en la BD
            DataRow row = dt.Rows[0];

            //Mando los datos al form Modificar_cliente
           
    }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("dbo.modificar_hotel", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@hotel_nombre", SqlDbType.VarChar).Value = txb_nombre.Text;
            cmd.Parameters.AddWithValue("@hotel_mail", SqlDbType.VarChar).Value = txb_mail.Text;
            cmd.Parameters.AddWithValue("@hotel_telefono", SqlDbType.VarChar).Value = txb_telefono.Text;
            cmd.Parameters.AddWithValue("@hotel_direccion", SqlDbType.VarChar).Value = txb_calle.Text;
            cmd.Parameters.AddWithValue("@hotel_estrellas", SqlDbType.VarChar).Value = cmb_estrellas.Text;
            cmd.Parameters.AddWithValue("@hotel_ciudad", SqlDbType.VarChar).Value = txb_ciudad.Text;
            cmd.Parameters.AddWithValue("@hotel_pais", SqlDbType.VarChar).Value = txb_pais.Text;
           // cmd.Parameters.AddWithValue("@hotel_regimenes", SqlDbType.VarChar).Value = cmb_regimenes.Text;
           // cmd.Parameters.AddWithValue("@hotel_creacion", SqlDbType.VarChar).Value = cmb_creacion.Text;


            cmd.ExecuteNonQuery();

            MessageBox.Show("El hotel " + txb_nombre.Text + " se modifico correctamente", "Mensaje");
        }

        private void btn__volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Hotel_modificacion_Load_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.buscar_hotel_completo", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.VarChar).Value = hotel_id;

            // Creo el DataTable para obtener los resultados del SP
            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            //Accedo a lo que encontre en la BD
            DataRow row = dt.Rows[0];
            

            txb_nombre.Text = row["hotel_nombre"].ToString();
            txb_calle.Text = row["otel_calle"].ToString();
            txb_nro.Text = row["hotel_nro_calle"].ToString();
            txb_ciudad.Text = row["hotel_ciudad"].ToString();
            txb_pais.Text = row["hotel_pais"].ToString();
            txb_mail.Text = row["Hotel_mail"].ToString();
            txb_telefono.Text = row["hotel_telefono"].ToString();
            cmb_estrellas.SelectedValue = Convert.ToInt32(row["hotel_estrellas"]);

        }
    }
    }