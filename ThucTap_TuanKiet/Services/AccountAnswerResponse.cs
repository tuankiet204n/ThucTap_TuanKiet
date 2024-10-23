using ThucTap_TuanKiet.Data;
using ThucTap_TuanKiet.Model;

namespace ThucTap_TuanKiet.Services
{
    public class AccountAnswerResponse : IAccountAnswer
    {
        private readonly ApplicationDBContext _context;
        public AccountAnswerResponse(ApplicationDBContext context) => _context = context;
        public AccountAnswer AddAccountAnswer(int idQuestion, int idAnswer, int idAccount)
        {
            try
            {
                var acAn = new AccountAnswer()
                {
                    IdQuestion = idQuestion,
                    IdAnswer = idAnswer,
                    IdAcc = idAccount
                };
                _context.AccountAnswers.Add(acAn);
                _context.SaveChanges();
                return acAn;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public IEnumerable<AccountAnswer> GetByIdQuestion(int idQuestion)
        {
            var acAn = _context.AccountAnswers.Where(x => x.IdQuestion == idQuestion).ToList();
            return acAn;
        }
    }
}
