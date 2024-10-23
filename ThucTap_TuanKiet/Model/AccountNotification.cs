using System.ComponentModel.DataAnnotations;

namespace ThucTap_TuanKiet.Model
{
    public class AccountNotification
    {
        [Key]
        public int IdAcNo { get; set; }
        public int IdNoti { get; set; }
        public int IdReceiver { get; set; }
        public Notification? Notification { get; set; }
        public Account? Account { get; set; }
    }
}
