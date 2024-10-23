using System.ComponentModel.DataAnnotations;

namespace ThucTap_TuanKiet.Model
{
    public class VisitSchedule
    {
        [Key]
        public int IdViSc { get; set; }
        public string Session { get; set; }
        public string Purpose { get; set; }
        public string Status { get; set; }
        public int? IdDistributor { get; set; }
        public int IdCreator { get; set; }
        public Distributor? Distributor { get; set; }
        public Account? Account { get; set; }
        public ICollection<DateVisit>? dateVisits { get; set; }
        public ICollection<Job>? jobs { get; set; }
        public ICollection<Visitor>? visitors { get; set; }
    }
}
