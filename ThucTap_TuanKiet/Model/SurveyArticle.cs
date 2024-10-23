using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ThucTap_TuanKiet.Model
{
    public class SurveyArticle
    {
        [Key]
        public int IdSuAr { get; set; }
        public string Title { get; set; }
        public int IdCreator { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string Status { get; set; }
        public Account? Account { get; set; }
        public ICollection<Question>? questions { get; set; }
        public ICollection<SurveyRequest>? surveyRequests { get; set; }
    }
}
