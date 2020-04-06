
namespace TS.Entities
{
    public class TestConfiguration
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TestTypeID { get; set; }
        public string TestTypeName { get; set; }
        public int ComplexityID { get; set; }
        public string ComplexityName { get; set; }
        public int NoOfTotalQuestions { get; set; }
        public int NoOfQuestions { get; set; }
        public int CorrectAnswersToPass { get; set; }
        public int TotalMarks { get; set; }
        public int TotalTime { get; set; }
    }
}
