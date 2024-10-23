using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThucTap_TuanKiet.Model
{
    public class Article
    {
        [Key]
        public int IdArticle { get; set; }
        public string Title { get; set; }
        public string Describe { get; set; }
        public string PathArticle { get; set; }
        public string Image { get; set; }
        public int IdCreator { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string Status { get; set; }
        public Account? Account { get; set; }
    }
}
