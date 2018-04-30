﻿using System;
using System.Collections.Generic;
using System.IO;
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

            // Leo el Archivo de Configuracion
            String[] config = File.ReadAllLines("../../Config.txt");

            // Extraigo los valores del Archivo de Configuracion
            String instancia = DataBase.GetConfigValue(config[0]);
            String db_name = DataBase.GetConfigValue(config[1]);
            String db_user = DataBase.GetConfigValue(config[2]);
            String db_pass = DataBase.GetConfigValue(config[3]);

            string connectionString = @"Data Source=" + instancia + ";Initial Catalog=" + db_name + ";Persist Security Info=True;User ID=" + db_user + ";Password=" + db_pass;
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
