using AiLaTrieuPhu.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiLaTrieuPhu.DAL
{
    internal class QuestionsAccess
    {
        public DataAccess dataAccess = new DataAccess();
        public SqlConnection conn = null;
        public List<Questions> GetAll()
        {
            List<Questions> list = new List<Questions>();
            string sql = "select * from question";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Questions questions = new Questions(
                    reader.GetString(0),
                    reader.GetString(1)
                    );
                list.Add(questions);
            }
            dataAccess.CloseConnection();
            return list;
        }
    }
}
