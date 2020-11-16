using Microsoft.EntityFrameworkCore;
using StephenKingFanSite.Models;

namespace StephenKingFanSite.Data
{
    public class KingContext : DbContext
    {
        public KingContext(DbContextOptions<KingContext> options) : base(options)
        {
        }

        public DbSet<Forum> Forums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Novel> Novels { get; set; }
        public DbSet<Score> Scores { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Forum>().ToTable("Forum");
            modelBuilder.Entity<Genre>().ToTable("Genre");
            modelBuilder.Entity<Movie>().ToTable("Movie");
            modelBuilder.Entity<Novel>().ToTable("Novel");
            modelBuilder.Entity<Score>().ToTable("Score");
            modelBuilder.Entity<User>().ToTable("User");
        }

    }
}
