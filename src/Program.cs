using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            string connectionString = @"Data Source=localhost\SQLSERVER2012;Initial Catalog=GD1C2018;
                                      Persist Security Info=True;User ID=gdHotel2018;Password=gd2018";                               
            connectionString += "; MultipleActiveResultSets=True";
            try
            {
                DataBase.GetInstance().Conectar(connectionString);
            }
            catch
            {
                MessageBox.Show("No se pudo conectar con " + DataBase.GetInstance().ConnectionString);
                Application.Exit();
            }
        /*    Application.SetCompatibleTextRenderingDefault(false);*/
            Application.Run(new Form1());
        }
    }
}
