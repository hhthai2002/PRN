using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AiLaTrieuPhu.DTO
{
    internal class Questions
    {
        public string QID { get; set; }
        public string ques { get; set; }

        public Questions(string qID, string ques)
        {
            QID = qID;
            this.ques = ques;
        }

        public Questions() { }
    }
}
