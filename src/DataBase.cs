using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FrbaHotel
{
    public class DataBase
    {
        private string _connectionString;
        private SqlConnection sql2012;
        private static DataBase gd1c2018;
        private SqlTransaction tran;

        public static DataBase GetInstance()
        {
            if (gd1c2018 == null)
                gd1c2018 = new DataBase();

            return gd1c2018;
        }

        public SqlTransaction Transaccion
        {
            get { return tran; }
            set { tran = value; }
        }

        public SqlConnection Connection
        {
            get { return sql2012; }
            set { sql2012 = value; }
        }

        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        public DataBase()
        {
        }

        public void Conectar(string cs)
        {
            ConnectionString = cs;
            sql2012 = new SqlConnection(ConnectionString);
            sql2012.Open();

        }

        public void Desconectar()
        {
            sql2012.Close();
        }

        public void Transaccion_Comenzar()
        {
            tran = sql2012.BeginTransaction();
        }

        public void Transaccion_Commit()
        {
            tran.Commit();
            tran = null;
        }

        public void Transaccion_Rollback()
        {
            if (tran != null)
            {
                tran.Rollback();
                tran = null;
            }
        }
    }
}
