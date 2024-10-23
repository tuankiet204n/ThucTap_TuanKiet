using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ThucTap_TuanKiet.Model
{
    public class SurveyRequest
    {
        [Key]
        public int IdSuRe { get; set; }
        public string Title { get; set; }
        public int IdCreator { get; set; }
        public int IdSuAr { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Account? Account { get; set; }
        public SurveyArticle? SurveyArticle { get; set; }
        public ICollection<AccountSurveyRequest>? accountSurveyRequests { get; set; }
    }
}
