using System.ComponentModel.DataAnnotations;

namespace ThucTap_TuanKiet.Model
{
    public class Question
    {
        [Key]
        public int IdQuestion { get; set; }
        public string Content { get; set; }
        public bool IsMultipleChoice { get; set; } = false;
        public int IdSuAr { get; set; }
        public SurveyArticle? SurveyArticle { get; set; }
        public ICollection<AccountAnswer>? accountAnswers { get; set; }
        public ICollection<Answer>? answers { get; set; }
    }
}
