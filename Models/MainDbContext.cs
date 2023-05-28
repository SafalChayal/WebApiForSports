using Microsoft.EntityFrameworkCore;

namespace WebSportsAPI.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options) { }
       public DbSet<Player> Players { get; set; }

        public DbSet<Sport> Sports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasOne(e => e.Sport)
                .WithMany(d => d.Players)
                .HasForeignKey(e => e.Sport_Id);
        }


    }
}
