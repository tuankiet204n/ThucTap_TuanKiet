using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ThucTap_TuanKiet.Model
{
    public class Notification
    {
        [Key]
        public int IdNoti { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string Status { get; set; }
        public int IdCreator { get; set; }
        public Account? Account { get; set; }
        public ICollection<AccountNotification>? accountNotifications { get; set; }
    }
}
