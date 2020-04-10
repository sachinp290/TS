
using System.Collections.Generic;
namespace TS.Web.Models
{
    public class TestSubjectViewModel
    {
        public int ID { get; set; }
        public int TestID { get; set; }
        public string SubjectName { get; set; }
        public int SubjectID { get; set; }
        public int Weightage { get; set; }
    }

    public class TestSubjectListViewModel
    {
        public int TestID { get; set; }
        public IEnumerable<TestSubjectViewModel> TestSubjects { get; set; }
    }
}