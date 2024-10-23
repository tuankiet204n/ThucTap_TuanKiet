using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ThucTap_TuanKiet.Model
{
    public class Area
    {
        [Key]
        public int IdArea { get; set; }
        public string AreaCode { get; set; }
        public string AreaName { get; set; }
        public ICollection<Account>? accounts { get; set; }
        public ICollection<Distributor>? distributors { get; set; }
    }
}
