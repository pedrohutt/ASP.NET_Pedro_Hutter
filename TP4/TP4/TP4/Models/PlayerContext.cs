using Microsoft.EntityFrameworkCore;

namespace TP4.Models
{
    public class PlayerContext : DbContext
    {
        private string connectionString;

        public PlayerContext(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Player>? Player { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<Player>().ToTable("Player");
        }
    }
}
