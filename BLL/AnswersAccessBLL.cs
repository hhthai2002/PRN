using AiLaTrieuPhu.DAL;
using AiLaTrieuPhu.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiLaTrieuPhu.BLL
{
    internal class AnswersAccessBLL
    {
        public AnswersAccess answersAccess = new AnswersAccess();
        public List<Answers> GetAllAnswers()
        {
            return answersAccess.GetAll();
        }
    }
}
