using ThucTap_TuanKiet.Model;

namespace ThucTap_TuanKiet.Services
{
    public interface IAccountNotification
    {
        public AccountNotification Add(int IdNoti, int IdReceiver);
    }
}
