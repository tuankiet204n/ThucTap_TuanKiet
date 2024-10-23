using System.ComponentModel.DataAnnotations;

namespace ThucTap_TuanKiet.Model
{
    public class ArticleImage
    {
        [Key]
        public int IdArIm { get; set; }
        public string Image { get; set; }
        public int IdCreator { get; set; }
        public Account? Account { get; set; }
    }
}
