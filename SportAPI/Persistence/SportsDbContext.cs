using Microsoft.EntityFrameworkCore;
using SportAPI.Domain;

namespace SportAPI.Persistence
{
    public class SportsDbContext : DbContext
    {

        public SportsDbContext(DbContextOptions<SportsDbContext> options) : base(options) 
        {
        }

        #region DbSets

        public DbSet<Team> Teams { get; set; }

        public DbSet<Player> Players { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
            .HasOne(p => p.Team)
            .WithMany(t => t.Players)
            .HasForeignKey(p => p.TeamId);


        }

    }
}