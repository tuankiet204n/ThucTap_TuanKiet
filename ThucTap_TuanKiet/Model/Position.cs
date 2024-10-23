using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ThucTap_TuanKiet.Model
{
    public class Position
    {
        [Key]
        public int IdPos { get; set; }
        public string PositionName { get; set; }
        public int IdPoGr { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public PositionGroup? positionGroup { get; set; }
        public ICollection<Account>? accounts { get; set; }
    }
}
