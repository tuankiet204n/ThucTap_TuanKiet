using System.ComponentModel.DataAnnotations;

namespace ThucTap_TuanKiet.Model
{
    public class AccountSurveyRequest
    {
        [Key]
        public int IdAcSu { get; set; }
        public int IdSuRe { get; set; }
        public int IdAcc { get; set; }
        public SurveyRequest? SurveyRequest { get; set; }
        public Account? Account { get; set; }
    }
}
