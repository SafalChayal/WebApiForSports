using WebSportsAPI.Models;

namespace WebSportsAPI.SportRepository
{
    public interface ISports
    {
       public IEnumerable<Sport> GetSports();

        public Sport GetById(int Sport_Id);
        public void Insert(Sport sport);
        public void Update(Sport sport);
        public Sport Delete(int Sport_Id);
        public void Save();

    }
}
