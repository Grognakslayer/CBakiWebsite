using CBakiWebsite.Models;
using Microsoft.EntityFrameworkCore;
using MvcGame.Models;

namespace CBakiWebsite.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options)
            : base(options) { }

        public DbSet<Player> Players { get; set; } = default!;
        public DbSet<Style> Styles { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Player>()
                .HasOne(p => p.Style)
                .WithMany()
                .HasForeignKey(p => p.StyleId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
