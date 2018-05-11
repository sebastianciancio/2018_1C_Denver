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

namespace FrbaHotel.AbmCliente
{
    public partial class Cliente_alta : Form
    {
        private DataBase db;

        public static Cliente_alta Cli_alta;
        public string cliente_apellido;
        public string cliente_nombre;
        public int    cliente_tipo_documento_id;
        public int    cliente_pasaporte_nro;
        public string cliente_email;
        public string cliente_telefono;
        public string cliente_dom_calle;
        public string cliente_dom_nro;
      //  public string cliente_piso;
      //  public string cliente_dpto;
        public string cliente_dom_localidad;
        public string cliente_pais_id;
        public string cliente_nacionalidad;
        public string cliente_fecha_nac;


        public Cliente_alta()
        {
            InitializeComponent();
            db = DataBase.GetInstance();
            Cliente_alta.Cli_alta = this;
        }

        private void btn_cli_new_guardar_Click(object sender, EventArgs e)
        {
       /*     SqlCommand cmd = new SqlCommand("dbo.cargar_cliente", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            if (txb_cl_new_dni.Text != "" || ) ;


            //Guardo los datos ingesados en pantalla en las variables disponibles para el SP
            if (Cli_alta.ValidacionDatos() )
          /*      (txb_cliente_apellido.Text != "")
                cmd.Parameters.AddWithValue("@cliente_apellido", SqlDbType.VarChar).Value = txb_cliente_apellido.Text;

            if (txb_cliente_nombre.Text != "")
                cmd.Parameters.AddWithValue("@cliente_nombre", SqlDbType.VarChar).Value = txb_cliente_nombre.Text;

            if (txb_cliente_dni.Text != "")
                cmd.Parameters.AddWithValue("@cliente_dni", SqlDbType.Int).Value = txb_cliente_dni.Text;*/

        }

  

    }
}
