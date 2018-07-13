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
    
    public partial class GestionRoles : Form
    {   private DataBase db;

        public GestionRoles()
        {
            db = DataBase.GetInstance();
            InitializeComponent();
        }

        private void GestionRoles_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.cargar_tabla_roles", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            using (var da = new SqlDataAdapter(cmd))
            {
                da.Fill(dt);
            }
            dgv_roles.DataSource = dt;

            foreach (DataGridViewRow row in dgv_roles.Rows){
                if (row.Cells[1].Value.ToString()  == "ACTIVO")
                { row.DefaultCellStyle.BackColor = Color.LightBlue; }
                
                else {
                    row.DefaultCellStyle.BackColor = Color.Aquamarine;
                }
           
            }
   
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Hide();
            AbmRol.Modificar_rol frm = new AbmRol.Modificar_rol();
            

            DataGridViewRow row = dgv_roles.CurrentRow;

            string rol = row.Cells[0].Value.ToString();
            frm.txb_nombre.Text = rol;
            frm.modRol = rol;
            frm.Show();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Hide();

            AbmRol.AltaRol frm = new AbmRol.AltaRol();
            frm.Show();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("denver.actualizar_estado_rol", db.Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            //Levanto la linea seleccionada
            DataGridViewRow row = dgv_roles.CurrentRow;

            // Si existen datos
            if (row != null)
            {
                    string estado; 
                    string rol = row.Cells[0].Value.ToString();
                     if (row.Cells[1].Value.ToString() == "ACTIVO")
                            {  estado = "N"; } else {  estado = "S"; };
                    //paso los parametros al SP
                    cmd.Parameters.AddWithValue("@rol_nombre", SqlDbType.VarChar).Value = rol;
                    cmd.Parameters.AddWithValue("@rol_estado", SqlDbType.VarChar).Value = estado;
                    // Ejecuto el SP
                    cmd.ExecuteNonQuery();

                    // Muestro resultado de la operacion
                    MessageBox.Show("El rol " + rol +  " se actualizó con éxito", "Mensaje");

                    this.GestionRoles_Load(null, null);

                }
            }
        }



                }

