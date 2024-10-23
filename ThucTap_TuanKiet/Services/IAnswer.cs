using ThucTap_TuanKiet.Model;

namespace ThucTap_TuanKiet.Services
{
    public interface IAnswer
    {
        public IEnumerable<Answer> GetAnsersByIdQuestion(int idQuestion);
        public Answer AddAnswer(string content, int idQuestion);
        public Answer UpdateAnswer(int id, string content);
        public string DeleteAnswer(int id);
    }
}
