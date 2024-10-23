using ThucTap_TuanKiet.Model;

namespace ThucTap_TuanKiet.Services
{
    public interface IArticleImage
    {
        public IEnumerable<ArticleImage> ArticleImageList();
        public ArticleImage Add(IFormFile image, int idCreator);
        public string Delete(int id);

    }
}
