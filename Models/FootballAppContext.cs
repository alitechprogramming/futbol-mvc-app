using AplicacionMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AplicacionMVC.Models
{
    public class FootballAppContext : DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Notice> Notices { get; set; }
        public FootballAppContext(DbContextOptions<FootballAppContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}
