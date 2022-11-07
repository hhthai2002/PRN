using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiLaTrieuPhu.DTO
{
    internal class Answers
    {
        public string QID { get; set; }
        public string AID { get; set; }
        public string ans { get; set; }
        public string isCorrect { get; set; }

        public Answers(string qID, string aID, string ans, string isCorrect)
        {
            QID = qID;
            AID = aID;
            this.ans = ans;
            this.isCorrect = isCorrect;
        }

        public Answers() { }
    }
}
