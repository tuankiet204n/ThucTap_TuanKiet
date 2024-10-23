﻿using ThucTap_TuanKiet.Data;
using ThucTap_TuanKiet.Model;

namespace ThucTap_TuanKiet.Services
{
    public class DateVisitResponse : IDateVisit
    {
        private readonly ApplicationDBContext _context;
        public DateVisitResponse(ApplicationDBContext context) => _context = context;

        public DateVisit Add(DateTime date, int idViSc)
        {
            try
            {
                var dateVisit = new DateVisit()
                {
                    Date = date,
                    IdViSc = idViSc
                };
                _context.DateVisits.Add(dateVisit);
                _context.SaveChanges();
                return dateVisit;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public IEnumerable<DateVisit> dateVisitByIdViSc(int idViSc)
        {
            return _context.DateVisits.Where(x => x.IdViSc == idViSc);
        }
    }
}
