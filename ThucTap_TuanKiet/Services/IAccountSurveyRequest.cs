using ThucTap_TuanKiet.Model;

namespace ThucTap_TuanKiet.Services
{
    public interface IAccountSurveyRequest
    {
        public IEnumerable<AccountSurveyRequest> List();
        public AccountSurveyRequest Add(int idSurveyRequest, int idAccount);
    }
}
