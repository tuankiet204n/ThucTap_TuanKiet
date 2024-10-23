using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ThucTap_TuanKiet.Model
{
    public class DateVisit
    {
        [Key]
        public int IdDaVi { get; set; }
        public DateTime Date { get; set; }
        public int IdViSc { get; set; }
        public VisitSchedule? VisitSchedule { get; set; }
    }
}
