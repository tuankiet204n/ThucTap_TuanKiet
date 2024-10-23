using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ThucTap_TuanKiet.Model
{
    public class Job
    {
        [Key]
        public int IdJob { get; set; }
        public string Title { get; set; } 
        public string Describe { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public int IdViSc { get; set; }
        public int IdImplementer { get; set; }
        public int IdCreator { get; set; }
        public VisitSchedule? VisitSchedule { get; set; }
        public Account? Implementer { get; set; }
        public Account? Creator { get; set; }
        public ICollection<JobImage>? JobImages { get; set; }
    }
}
