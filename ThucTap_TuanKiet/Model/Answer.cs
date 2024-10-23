using System.ComponentModel.DataAnnotations;

namespace ThucTap_TuanKiet.Model
{
    public class Answer
    {
        [Key]
        public int IdAnswer { get; set; }
        public string Content { get; set; }
        public int IdQuestion { get; set; }
        public Question? Question { get; set; }
        public ICollection<AccountAnswer>? accountAnswers { get; set; }
    }
}
