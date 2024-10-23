﻿using ThucTap_TuanKiet.Data;
using ThucTap_TuanKiet.Model;

namespace ThucTap_TuanKiet.Services
{
    public class AccountNotificationResponse : IAccountNotification
    {
        private readonly ApplicationDBContext _context;
        public AccountNotificationResponse(ApplicationDBContext context) => _context = context;

        public AccountNotification Add(int IdNoti, int IdReceiver)
        {
            try
            {
                var acNo = new AccountNotification()
                {
                    IdNoti = IdNoti,
                    IdReceiver = IdReceiver
                };
                _context.AccountNotifications.Add(acNo);
                _context.SaveChanges();
                return acNo;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
