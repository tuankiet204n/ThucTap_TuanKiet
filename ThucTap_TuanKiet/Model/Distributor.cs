using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ThucTap_TuanKiet.Model
{
    public class Distributor
    {

        [Key]
        public int IdDis { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string? Phone { get; set; }
        public int? IdArea { get; set; }
        //public int? IdManager { get; set; }
        public string Status { get; set; }
        public Area? Area { get; set; }
        public Account? Account { get; set; }
        public ICollection<Account>? accounts { get; set; }
        public ICollection<VisitSchedule>? visitSchedules { get; set; }
        public int? IdManager { get; internal set; }
    }
}
