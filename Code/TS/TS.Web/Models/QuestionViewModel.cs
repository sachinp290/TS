using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TS.Web.Models
{
    public class QuestionViewModel
    {
        public int ID { get; set; }
        public int TopicID { get; set; }
        public string TopicName { get; set; }
        [AllowHtml]
        [UIHint("tinymce_full_compressed")]
        public string Text { get; set; }
        [AllowHtml]
        [UIHint("tinymce_full_compressed")]
        public string Option1 { get; set; }
        [AllowHtml]
        [UIHint("tinymce_full_compressed")]
        public string Option2 { get; set; }
        [AllowHtml]
        [UIHint("tinymce_full_compressed")]
        public string Option3 { get; set; }
        [AllowHtml]
        [UIHint("tinymce_full_compressed")]
        public string Option4 { get; set; }
        public string CorrectAnswer { get; set; }
        [AllowHtml]
        [UIHint("tinymce_full_compressed")]
        public string Reason { get; set; }
        public int ComplexityID { get; set; }
        public string ComplexityName { get; set; }
        public string Language { get; set; }
        public bool IsReady { get; set; }
    }
}