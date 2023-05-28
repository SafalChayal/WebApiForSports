using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System.Composition;
using WebSportsAPI.Models;

namespace WebSportsAPI.SportRepository
{
    public class PlayerClass:IPlayers
    {
        private readonly MainDbContext _context;

        public PlayerClass(MainDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Player> GetPlayers()
        {
            return _context.Players.ToList();

        }

        public Player GetById(int id)
        {

            Player player = _context.Players.Find(id);
              
            
            return player;
        }

        public void Insert(Player player)
        {
            var sport =  _context.Sports.Find(player.Sport_Id);
            _context.Players.Add(player);
             Save();
        }

        public void Update(Player player)
        {
            _context.Entry(player).State = EntityState.Modified;
            Save();
        }

        public Player Delete(int Player_Id)
        {
            Player player = _context.Players.Find(Player_Id);
            try
            {
                if (player != null)
                {
                    _context.Remove(player);
                    Save();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return player;
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
