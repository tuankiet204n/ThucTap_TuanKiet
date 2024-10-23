using ThucTap_TuanKiet.Data;
using ThucTap_TuanKiet.Model;

namespace ThucTap_TuanKiet.Services
{
    public class VisitorResponse : IVisitor
    {
        private readonly ApplicationDBContext _context;
        public VisitorResponse(ApplicationDBContext context) => _context = context;

        public Visitor Add(int idAcc, int idViSc)
        {
            try
            {
                var visitor = new Visitor()
                {
                    IdAcc = idAcc,
                    IdViSc = idViSc
                };
                _context.Visitors.Add(visitor);
                _context.SaveChanges();
                return visitor;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public IEnumerable<Visitor> GetVisitorByIdViSc(int idViSc)
        {
            return _context.Visitors.Where(x => x.IdViSc == idViSc);
        }
    }
}
