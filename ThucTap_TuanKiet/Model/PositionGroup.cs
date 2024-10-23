using System.ComponentModel.DataAnnotations;

namespace ThucTap_TuanKiet.Model
{
    public class PositionGroup
    {
        [Key]
        public int IdPoGr { get; set; }
        public string Name { get; set; }
        public ICollection<Position>? positions { get; set; }
    }
}
