using AiLaTrieuPhu.DAL;
using AiLaTrieuPhu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiLaTrieuPhu.BLL
{
    internal class QuestionsAccessBLL
    {
        public QuestionsAccess questionsAccess = new QuestionsAccess();
        public List<Questions> GetAllQuestions()
        {
            return questionsAccess.GetAll();
        }
    } 
}
