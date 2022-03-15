using Microsoft.EntityFrameworkCore;

namespace sga_stif.Models
{
    public class ContextoBaseDados : DbContext
    {
        public ContextoBaseDados(DbContextOptions<ContextoBaseDados> options) : base(options)
        {
        }

        public DbSet<Utilizador> Utilizador { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utilizador>().ToTable("Utilizador");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("AppDb");
            //optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.UseSqlite("Filename=sga-stif.db");
        }

    }
       
}