using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TS.Web.Models
{
    public class TopicViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }
    }
}