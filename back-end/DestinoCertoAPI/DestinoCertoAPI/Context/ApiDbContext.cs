using DestinoCertoAPI.Data;
using DestinoCertoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DestinoCertoAPI.Context
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Destino> Destinos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Contato> Contatos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("DefaultConnection")
                    .UseLazyLoadingProxies()
                    .EnableSensitiveDataLogging();

                // Verifica se o banco de dados existe e o cria se não existir
                this.Database.EnsureCreated();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SeedDataConfiguration());
            modelBuilder.ApplyConfiguration(new SeedDataConfigurationCliente());
            modelBuilder.ApplyConfiguration(new SeedDataConfigurationContato());
            base.OnModelCreating(modelBuilder);
        }
    }
}