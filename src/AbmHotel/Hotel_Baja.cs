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
    public partial class Hotel_Baja : Form
    {
        private DataBase db;
        public string id_hotel;
        public Hotel_Baja()
        {
            InitializeComponent();
            db = DataBase.GetInstance();
        }
        private void Hotel_Baja_Load(object sender, EventArgs e)
        {


        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.baja_hotel", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_hotel", SqlDbType.Int).Value = id_hotel;

            cmd.Parameters.AddWithValue("@fecha_inicio", SqlDbType.DateTime).Value = Convert.ToDateTime(dtp_inicio.Value);
            cmd.Parameters.AddWithValue("@fecha_fin", SqlDbType.DateTime).Value = Convert.ToDateTime(dtp_fin.Value);

            cmd.Parameters.AddWithValue("@motivo", SqlDbType.VarChar).Value = cmb_motivo.SelectedValue;

            cmd.Parameters.AddWithValue("@fecha_sistema", SqlDbType.DateTime).Value = accesoSistema.fechaSistema;

            cmd.Parameters.AddWithValue("@result", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();

            int retunvalue = (int)cmd.Parameters["@result"].Value;

            /*SqlDataAdapter sda = new SqlDataAdapter("SELECT denver.hotel_en_mantenimiento ('" + id_hotel + "')", db.Connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            // Si esta en mantenimiento
            if (Convert.ToInt32(dt.Rows[0][0]) == 1)*/
            if (retunvalue == 0) 
           {
                MessageBox.Show("El hotel " + txb_nombre.Text + " se dio de baja correctamente", "Mensaje");
                Close();
            }
            else {
                MessageBox.Show("El hotel tiene reservas activas entre el " + dtp_inicio.Value + " y " + dtp_fin.Value , "Error");
                 } 

        }

        private void Hotel_Baja_Load_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.buscar_hotel_completo", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = id_hotel;
            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            DataRow row = dt.Rows[0];

            txb_nombre.Text = row["hotel_nombre"].ToString();
        }
    }
}
