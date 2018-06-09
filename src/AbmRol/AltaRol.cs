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
            //Combos.cargarCheckedlist(clb_funcionalidades);
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
                cmd.ExecuteNonQuery();

                SqlCommand cmd2 = new SqlCommand("denver.crear_rol_funcionalidad", db.Connection);
                cmd2.Parameters.AddWithValue("@rol", SqlDbType.VarChar).Value = txb_nombre.Text;

                for (int i = 0; i < clb_funcionalidades.CheckedIndices.Count; i++)
                {
                   // int selection = clb_funcionalidades.CheckedIndices[i];

                    cmd2.Parameters.AddWithValue("@id_funcionlidad", SqlDbType.Int).Value = clb_funcionalidades.CheckedIndices[i];
                    cmd2.ExecuteNonQuery();
                }


            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
