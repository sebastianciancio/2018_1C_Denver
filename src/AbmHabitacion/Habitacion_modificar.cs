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
    public partial class Habitacion_modificar : Form
    {
        private DataBase db;
        public int hab_nro;
        public int hotel_id;
        public Habitacion_modificar()
        {
            db = DataBase.GetInstance();
            InitializeComponent();
            Combos.cargarComboHotel(cmb_hotel, false);
            Combos.cargarComboTipoHabitacion(cmb_tipo);
        }

        private void Habitacion_modificar_Load(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("denver.buscar_habitacion_completa", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@hab_nro", SqlDbType.Int).Value = hab_nro;
            cmd.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = hotel_id;

            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            //Accedo a lo que encontre en la BD
            DataRow row = dt.Rows[0];


            txb_piso.Text = row["habitacion_piso"].ToString();
            txb_numero.Text = row["habitacion_nro"].ToString();
            if (row["habitacion_frente"].ToString() == "S")
            {
                cb_vista.Checked = true;
            }
            txb_desc.Text = row["habitacion_descripcion"].ToString();
            cmb_hotel.SelectedValue = Convert.ToInt32(row["habitacion_hotel_id"].ToString());
        }

        private void btn__volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            // verifico que no hayan cambiado habitacion u hotel 
            int flag = 0;
            int existe = 0;
            if (hab_nro != Convert.ToInt32(txb_numero.Text) || Convert.ToInt32(cmb_hotel.SelectedValue) != hotel_id)
            {  // si se cambio, verifico que no haya reservas activas
                SqlCommand sda = new SqlCommand("denver.buscar_reserva_hab_hotel", db.Connection);
                sda.CommandType = CommandType.StoredProcedure;

                sda.Parameters.AddWithValue("@habitacion_nro", SqlDbType.Int).Value = hab_nro;
                sda.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = hotel_id;

                DataTable dt = new DataTable();

                using (var da = new SqlDataAdapter(sda))
                {
                    da.Fill(dt);
                }

                flag = dt.Rows.Count;
                if (flag != 0)
                {
                    MessageBox.Show("No se puede cambiar la ubicación de la habitacion número " + hab_nro + " ya que tiene reservas activas", "Mensaje"); }
                //verifico que no exista la combiacion habitacion-hotel
                else{
                    SqlCommand hhu = new SqlCommand("denver.existe_habitacion_hotel", db.Connection);
                    hhu.CommandType = CommandType.StoredProcedure;

                    hhu.Parameters.AddWithValue("@habitacion_nro", SqlDbType.Int).Value = Convert.ToInt32(txb_numero.Text);
                    hhu.Parameters.AddWithValue("@hotel_id", SqlDbType.Int).Value = Convert.ToInt32(cmb_hotel.SelectedValue);

                    DataTable hh = new DataTable();

                    using (var da = new SqlDataAdapter(hhu))
                    {
                        da.Fill(hh);
                    }

                    existe = hh.Rows.Count;
                    if (existe != 0)
                    {
                        MessageBox.Show("Ya existe una habitacion con el numero " + Convert.ToInt32(txb_numero.Text) + " en el hotel " + cmb_hotel.Text, "Mensaje");
                    };
                };
               };
            if ( existe == 0 & flag == 0) { 
                StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < txb_desc.Lines.Count(); i++)
                    {
                        sb.Append(txb_desc.Lines[i].ToString());
                    }
                    string desc = sb.ToString();

                    SqlCommand cmd = new SqlCommand("denver.modificar_habitacion", db.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@habitacion_nro", SqlDbType.Int).Value = Convert.ToInt32(txb_numero.Text);
                    cmd.Parameters.AddWithValue("@habitacion_piso", SqlDbType.Int).Value = Convert.ToInt32(txb_piso.Text);
                    if (cb_vista.Checked == true)
                    { cmd.Parameters.AddWithValue("@habitacion_frente", SqlDbType.VarChar).Value = 'S'; }
                    else { cmd.Parameters.AddWithValue("@habitacion_frente", SqlDbType.VarChar).Value = 'N'; }
                    cmd.Parameters.AddWithValue("@habitacion_hotel_id", SqlDbType.Int).Value = cmb_hotel.SelectedValue;
                    cmd.Parameters.AddWithValue("@habitacion_descripcion", SqlDbType.NText).Value = desc;
                    cmd.Parameters.AddWithValue("@fecha_sistema", SqlDbType.DateTime).Value = accesoSistema.fechaSistema;

                cmd.ExecuteNonQuery();

                    MessageBox.Show("Se ha modificado la habitación " + hab_nro, "Mensaje");
                }
           }
        }
    }


