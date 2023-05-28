using Microsoft.EntityFrameworkCore;
using WebSportsAPI.Models;

namespace WebSportsAPI.SportRepository
{
    public class SportClass :ISports
    {
        private readonly MainDbContext _context;

        public SportClass(MainDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Sport> GetSports()
        {
            return _context.Sports.ToList();

        }

        public Sport GetById(int id)
        {
            return _context.Sports.Find(id);
        }

        public Sport Delete(int id)
        {
            Sport sport = _context.Sports.Find(id);
            try
            {
                if (sport != null)
                {
                    _context.Remove(sport);
                    Save();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return sport;
        }

        public void Insert(Sport sport)
        {
            _context.Sports.Add(sport);
            Save();
            
        }

        public void Update(Sport sport)
        {
            _context.Entry(sport).State = EntityState.Modified;
            Save();
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
