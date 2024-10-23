using System.ComponentModel.DataAnnotations;

namespace ThucTap_TuanKiet.Model
{
    public class JobImage
    {
        [Key]
        public int IdJoIm { get; set; }
        public string Image { get; set; }
        public string Descibe { get; set; }
        public int IdJob { get; set; }
        public Job? Job { get; set; }
    }
}
