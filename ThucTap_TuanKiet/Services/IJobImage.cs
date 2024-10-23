using ThucTap_TuanKiet.Model;

namespace ThucTap_TuanKiet.Services
{
    public interface IJobImage
    {
        public IEnumerable<JobImage> GetImageByIdJob(int idJob);
        public JobImage Add(IFormFile image, string describe, int idJob);
    }
}
