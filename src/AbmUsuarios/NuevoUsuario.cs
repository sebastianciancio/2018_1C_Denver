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

namespace FrbaHotel.AbmUsuarios
{
    public partial class NuevoUsuario : Form
    {
        private DataBase db;
        public NuevoUsuario()
        {
            db = DataBase.GetInstance();
            InitializeComponent();
            Combos.cargarComboHotel(cmb_hoteles);
            Combos.cargarComboTipoDocumento(cmb_tipoDoc);
        }

        private void txb_pas_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("dbo.cargar_cliente", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@usuario_user", SqlDbType.VarChar).Value = txb_user.Text;

            //Necesito que me devuelva true or false.
            // si es true
            // lbl_userRepetido.VISIBBLE = TRUE;
        }

    }
}
