using ThucTap_TuanKiet.Model;

namespace ThucTap_TuanKiet.Services
{
    public interface IQuestion
    {
        public string GetQuestionsByIdSuAr(int idSuAr);
        public string GetQuestion(int id);
        public Question AddQuestion(string content, bool isMultipleChoice, int idSuAr);
        public Question UpdateQuestion(int id, string content, bool isMultipleChoice);
        public string DeleteQuestion(int id);

    }
}
