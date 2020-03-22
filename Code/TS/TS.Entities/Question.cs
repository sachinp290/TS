using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS.Entities
{
    public class Question
    {
        public int ID { get; set; }
        public int TopicID { get; set; }
        public string Text  { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string CorrectAnswer { get; set; }
        public string Reason { get; set; }
        public int ComplexityID { get; set; }
        public string Language { get; set; }
        public bool IsReady { get; set; }
    }
}
