using WebSportsAPI.Models;

namespace WebSportsAPI.SportRepository
{
    public interface IPlayers
    {
       public IEnumerable<Player> GetPlayers();

        public Player GetById(int Player_Id);
        public void Insert(Player player);
        public void Update(Player player);
        public Player Delete(int Player_iD);
        public void Save();


    }

}
