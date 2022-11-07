using AiLaTrieuPhu.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiLaTrieuPhu.DAL
{
    internal class AnswersAccess
    {
        DataAccess dataAccess = new DataAccess();
        public SqlConnection conn = null;
        public List<Answers> GetAll()
        {
            List<Answers> list = new List<Answers>();
            string sql = "select * from answer";
            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Answers answer = new Answers(
                    reader.GetString(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3)
                    );
                list.Add(answer);
            }
            dataAccess.CloseConnection();
            return list;
        }
    }
}
