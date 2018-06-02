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
            SqlCommand cmd = new SqlCommand("denver.cargar_hotel", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@hotel_nombre", SqlDbType.VarChar).Value = txb_nombre.Text;
            cmd.Parameters.AddWithValue("@hotel_email", SqlDbType.VarChar).Value = txb_mail.Text;
            cmd.Parameters.AddWithValue("@hotel_telefono", SqlDbType.VarChar).Value = txb_telefono.Text;
            cmd.Parameters.AddWithValue("@hotel_calle", SqlDbType.VarChar).Value = txb_calle.Text;
            cmd.Parameters.AddWithValue("@hotel_nro_calle", SqlDbType.Int).Value = Convert.ToInt32(txb_nro.Text);
            cmd.Parameters.AddWithValue("@hotel_estrellas", SqlDbType.SmallInt).Value = Convert.ToInt32(cmb_estrellas.Text);
            cmd.Parameters.AddWithValue("@hotel_ciudad", SqlDbType.VarChar).Value = txb_ciudad.Text;
            cmd.Parameters.AddWithValue("@hotel_pais_id", SqlDbType.SmallInt).Value = combo_pais.SelectedValue;
        //    cmd.Parameters.AddWithValue("@hotel_regimenes", SqlDbType.VarChar).Value = cmb_regimenes.Text;



            cmd.ExecuteNonQuery();
            MessageBox.Show("Se ha cargado el Hotel " + txb_nombre.Text, "Mensaje");
        }

        private void btn__volver_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
