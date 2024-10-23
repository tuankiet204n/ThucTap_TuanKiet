using ThucTap_TuanKiet.Model;

namespace ThucTap_TuanKiet.Services
{
    public interface IAccountAnswer
    {
        public IEnumerable<AccountAnswer> GetByIdQuestion(int idQuestion);

        public AccountAnswer AddAccountAnswer(int idQuestion, int idAnswer, int idAccount);
    }
}
