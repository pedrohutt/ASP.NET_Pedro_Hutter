using Microsoft.EntityFrameworkCore;

namespace TP4.Models
{
    public class TeamContext : DbContext
    {
        private string connectionString;

        public TeamContext(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Team>? Team { get; set; }
        public DbSet<Player>? Player { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<Team>().ToTable("Team");
        }
    }
}
