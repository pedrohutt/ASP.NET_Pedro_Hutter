using Microsoft.EntityFrameworkCore;

namespace AT.Models
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

        public DbSet<Team>? teams { get; set; }
        public DbSet<Player>? players { get; set; }

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

            modelBuilder.Entity<Player>()
                .Property(p => p.Nome)
                .HasColumnType("VARCHAR(80)")
                .IsRequired();

            modelBuilder.Entity<Player>()
                .Property(p => p.Sobrenome)
                .HasColumnType("VARCHAR(80)")
                .IsRequired();

            modelBuilder.Entity<Player>()
                .Property(p => p.TitulosBrasileiros)
                .HasColumnType("int")
                .IsRequired();

            modelBuilder.Entity<Player>()
                .Property(p => p.Nascimento)
                .HasColumnType("datetime")
                .IsRequired();

        }
    }
}

