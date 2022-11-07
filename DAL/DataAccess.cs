using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiLaTrieuPhu.DAL
{
    internal class DataAccess
    {
        SqlConnection conn = null;
        string sql = "Data Source=HUYNHHIEUTHAI;Initial Catalog=WhoWantToBeAMillionaire;Persist Security Info=True;User ID=sa;Password=10032002";

        public SqlConnection OpenConnection()
        {
            try
            {
                if(conn == null) conn = new SqlConnection(sql);
                if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
                return conn;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public void CloseConnection()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
