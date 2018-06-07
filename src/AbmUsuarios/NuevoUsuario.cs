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
            Combos.cargarComboRoles(cmb_rol);
        }

        private void txb_pas_TextChanged(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("SELECT denver.existe_usuario ('" + txb_user.Text + "')", db.Connection);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            // Si existe
            if (Convert.ToInt32(dt.Rows[0][0]) == 1)
            {
                lbl_userRepetido.Visible = true;
            }
            else {
                lbl_userRepetido.Visible = false;
            }
        }

    }
}
