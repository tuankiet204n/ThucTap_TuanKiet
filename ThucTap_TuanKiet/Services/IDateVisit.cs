using ThucTap_TuanKiet.Model;

namespace ThucTap_TuanKiet.Services
{
    public interface IDateVisit
    {
        public IEnumerable<DateVisit> dateVisitByIdViSc(int idViSc);
        public DateVisit Add(DateTime date, int idViSc);
    }
}
