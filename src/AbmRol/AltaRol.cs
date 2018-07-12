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
    public partial class AltaRol : Form
    {
        private DataBase db;

        public AltaRol()
        {
            db = DataBase.GetInstance();
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
           
            if (Validacion.esInicial(txb_nombre.Text)){
                MessageBox.Show("Debe ingresar el nombre del nuevo Rol", "Error");
            }
            else if (Validacion.rolExistente(txb_nombre.Text)){
                  MessageBox.Show("Ya existe un rol con ese nombre", "Error"); 
                
            }
            else if (Validacion.checkListVacia(clb_funcionalidades))
            {
                MessageBox.Show("Debe seleccionar almenos una funcionalidad", "Error");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("denver.crear_rol", db.Connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@rol", SqlDbType.VarChar).Value = txb_nombre.Text;

                cmd.Parameters.AddWithValue("@fecha_sistema", SqlDbType.DateTime).Value = accesoSistema.fechaSistemaSQL;
                cmd.ExecuteNonQuery();

                int sum;
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

                MessageBox.Show("El rol " + txb_nombre.Text + " se creo correctamente", "Mensaje");
                Close();
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AltaRol_Load(object sender, EventArgs e)
        {
            //clb_funcionalidades.Items[0] = true;
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
             
            
        }

        private void clb_funcionalidades_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
