using Microsoft.EntityFrameworkCore;

namespace TP4.Models
{
    public class EFContext : DbContext
    {
        private string connectionString;
        public EFContext(IConfiguration configuration)
        { 
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Team>? Teams { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Team>()
                .ToTable("Teams")
                .HasKey(p => p.Id);

            modelBuilder.Entity<Team>()
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Team>()
                .Property(p => p.Nome)
                .HasColumnType("VARCHAR(80)")
                .IsRequired();

            modelBuilder.Entity<Team>()
                .Property(p => p.TitulosBrasileiros)
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<Team>()
                .Property(p => p.DataCriacao)
                .HasColumnType("datetime")
                .IsRequired();
        }
    }
}
