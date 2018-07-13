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

namespace FrbaHotel.AbmRol
{
    public partial class Modificar_rol : Form
    {
        public string modRol;
        private DataBase db;
        public Modificar_rol()
        {
            db = DataBase.GetInstance();
            InitializeComponent();
        }

        private void Modificar_rol_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.obtener_funcionalidades", DataBase.GetInstance().Connection);
            cmd.CommandType = CommandType.StoredProcedure;


            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                clb_funcionalidades.Items.Add(dt.Rows[i][0], false);

            }

            if (txb_nombre.Text != null)
            {

                SqlCommand cmd3 = new SqlCommand("denver.buscar_funcionalidades_rol", DataBase.GetInstance().Connection);
                cmd3.CommandType = CommandType.StoredProcedure;

                cmd3.Parameters.AddWithValue("@rol_nombre", SqlDbType.VarChar).Value = txb_nombre.Text;
                DataTable dt2 = new DataTable();

                using (var da = new SqlDataAdapter(cmd3))
                {
                    da.Fill(dt2);
                }

                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    clb_funcionalidades.SetItemChecked(Convert.ToInt32(dt2.Rows[i][0]) - 1, true);
                }

            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            //ELIMINO EL ROL ANTERIOR (SI CORRESPONDE) Y CREO/MODIFICO EL NUEVO
            SqlCommand rol = new SqlCommand("denver.eliminar_rol_completo", db.Connection);
            rol.CommandType = CommandType.StoredProcedure;

            rol.Parameters.AddWithValue("@rol", SqlDbType.VarChar).Value = modRol;
            rol.Parameters.AddWithValue("@rol_nuevo", SqlDbType.VarChar).Value = txb_nombre.Text;
            rol.Parameters.AddWithValue("@fecha_sistema", SqlDbType.DateTime).Value = accesoSistema.fechaSistemaSQL;
            rol.ExecuteNonQuery();

            int sum;

            //CREO LAS NUEVAS FUNCIONALIDADES
            for (int i = 0; i < clb_funcionalidades.CheckedIndices.Count; i++)
            {
                // int selection = clb_funcionalidades.CheckedIndices[i];
                SqlCommand cmd2 = new SqlCommand("denver.crear_rol_funcionalidad", db.Connection);
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd2.Parameters.AddWithValue("@rol_nombre", SqlDbType.VarChar).Value = txb_nombre.Text;
                sum = clb_funcionalidades.CheckedIndices[i] + 1;
                cmd2.Parameters.AddWithValue("@rol_funcionalidad", SqlDbType.SmallInt).Value = sum;
                cmd2.ExecuteNonQuery();
            }

            MessageBox.Show("El rol " + txb_nombre.Text + " se modificó correctamente", "Mensaje");
            Close();



        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
