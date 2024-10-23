using ThucTap_TuanKiet.Model;

namespace ThucTap_TuanKiet.Services
{
    public interface IPosition
    {
        public IEnumerable<Position> PositionList();
        public Position GetPosition(int id);
        public Position AddPostion(string name, int idPostionGroup);
        public Position UpdatePosition(int id, string name);
    }
}
