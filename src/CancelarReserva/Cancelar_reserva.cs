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

namespace FrbaHotel.CancelarReserva
{
    public partial class Cancelar_reserva : Form
    {
        public int cod_reserva;
        private DataBase db;

        public Cancelar_reserva()
        {
            db = DataBase.GetInstance();
            InitializeComponent();
        }

        private void btn_canc_rec_confirm_Click(object sender, EventArgs e)
        {

            SqlDataAdapter sda = new SqlDataAdapter("SELECT denver.existe_reserva ('" + txb_canc_rec_codigo.Text + "')", db.Connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            // Si existe
            if (Convert.ToInt32(dt.Rows[0][0]) == 0)
            {
                MessageBox.Show("No existe la reserva", "Mensaje");
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < txb_motivo.Lines.Count(); i++)
                {
                    sb.Append(txb_motivo.Lines[i].ToString());
                }
                string desc = sb.ToString();

                SqlCommand cmd = new SqlCommand("denver.cancelar_reserva", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@cod_reserva", SqlDbType.Int).Value = Convert.ToInt32(txb_canc_rec_codigo.Text);
                cmd.Parameters.AddWithValue("@motivo", SqlDbType.VarChar).Value = desc;
                if (accesoSistema.UsuarioLogueado.Nombre == "")
                {
                    cmd.Parameters.AddWithValue("@user", SqlDbType.VarChar).Value = "GUEST";
                    cmd.Parameters.AddWithValue("@estado", SqlDbType.Int).Value = 4;
                }
                else
                {
                    cmd.Parameters.AddWithValue("@user", SqlDbType.VarChar).Value = accesoSistema.UsuarioLogueado.Nombre;
                    cmd.Parameters.AddWithValue("@estado", SqlDbType.Int).Value = 3;
                }
                cmd.Parameters.AddWithValue("@fecha_sistema", SqlDbType.DateTime).Value = accesoSistema.fechaSistema;

                cmd.ExecuteNonQuery();

                MessageBox.Show("La reserva se cancelo con exito", "Mensaje");

                Close();
            }
        }

        private void Cancelar_reserva_Load(object sender, EventArgs e)
        {
            //txb_canc_rec_codigo.Text = cod_reserva.ToString();
        }

        private void btn_canc_res_volver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
