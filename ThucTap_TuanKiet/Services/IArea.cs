using ThucTap_TuanKiet.Model;

namespace ThucTap_TuanKiet.Services
{
    public interface IArea
    {
        public IEnumerable<Area> AreaList();
        public Area GetAreaById(int id);
        public IEnumerable<Area> SearchArea(string keyword);
        public Area AddArea(string code, string name);
        public Area UpdateArea(int id, string name);
        public string DeleteArea(int id);   
    }
}
