using ThucTap_TuanKiet.Data;
using ThucTap_TuanKiet.Model;

namespace ThucTap_TuanKiet.Services
{
    public interface IPositionGroup
    {
        public IEnumerable<PositionGroup> PositionGroupList();
        public PositionGroup GetPositionGroupById(int id);
        public PositionGroup AddPositionGroup(string name);
        public PositionGroup UpdatePositionGroup(int id, string name);
        public string DeletePositionGroup(int id);
    }
}
