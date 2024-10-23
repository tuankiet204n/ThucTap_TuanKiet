using ThucTap_TuanKiet.Model;

namespace ThucTap_TuanKiet.Services
{
    public interface IDistributor
    {
        public IEnumerable<Distributor> DistributorList();
        public Distributor GetDistributor(int id);
        public Distributor AddDistributor(string name, string address, string phone, int? idArea, int? idManager, string status);
        public Distributor UpdateDistributor(int id, string name, string address, string phone, int? idArea, int? idManager, string status);
        public string DeleteDistributor(int id);

    }
}
