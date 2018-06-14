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

namespace FrbaHotel.AbmHabitacion
{
    public partial class Habitacion_alta : Form
    {
        private DataBase db;
        public Habitacion_alta()
        {
            InitializeComponent();
            db =  DataBase.GetInstance();
            Combos.cargarComboTipoHabitacion(cmb_tipo);
            Combos.cargarComboHotel(cmb_hotel, false);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarFormulario())
            {
                //
                // Verifico que si existe la habitacion en el nuevo hotel
                SqlCommand hhu = new SqlCommand("denver.existe_habitacion_hotel", db.Connection);
                hhu.CommandType = CommandType.StoredProcedure;

                hhu.Parameters.AddWithValue("@habitacion_nro", SqlDbType.Int).Value = Convert.ToInt32(txb_numero.Text);
                hhu.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = Convert.ToInt32(cmb_hotel.SelectedValue);

                DataTable dt = new DataTable();

                using (var da = new SqlDataAdapter(hhu))
                {
                    da.Fill(dt);
                }

                if (dt.Rows.Count != 0)
                {
                    MessageBox.Show("Ya existe una habitacion con el numero " + Convert.ToInt32(txb_numero.Text) + " en el hotel " + cmb_hotel.Text, "Mensaje");
                }
                else
                {
                    //
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < txb_desc.Lines.Count(); i++)
                    {
                        sb.Append(txb_desc.Lines[i].ToString());
                    }
                    string desc = sb.ToString();

                    SqlCommand cmd = new SqlCommand("denver.cargar_habitacion", db.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@habitacion_nro", SqlDbType.Int).Value = Convert.ToInt32(txb_numero.Text);
                    cmd.Parameters.AddWithValue("@habitacion_piso", SqlDbType.Int).Value = Convert.ToInt32(txb_piso.Text);
                    if (cb_vista.Checked == true)
                    { cmd.Parameters.AddWithValue("@habitacion_frente", SqlDbType.VarChar).Value = 'S'; }
                    else { cmd.Parameters.AddWithValue("@habitacion_frente", SqlDbType.VarChar).Value = 'N'; }
                    cmd.Parameters.AddWithValue("@habitacion_tipo_habitacion_id", SqlDbType.Int).Value = cmb_tipo.SelectedValue;
                    cmd.Parameters.AddWithValue("@habitacion_hotel_id", SqlDbType.Int).Value = cmb_hotel.SelectedValue;
                    cmd.Parameters.AddWithValue("@habitacion_descripcion", SqlDbType.NText).Value = desc;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se ha cargado la habitación " + txb_numero.Text, "Mensaje");

                    Close();
                }
            }
            else { MessageBox.Show("Debe completar todos los campos obligatorios", "Error"); }
        }

        private void btn__volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool validarFormulario()
        {
            return (!Validacion.esInicial(txb_numero.Text) &
                    !Validacion.esInicial(txb_piso.Text));

        }
    }
}
