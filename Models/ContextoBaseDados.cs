using Microsoft.EntityFrameworkCore;

namespace sga_stif.Models
{
    public class ContextoBaseDados : DbContext
    {
        public ContextoBaseDados(DbContextOptions<ContextoBaseDados> options) : base(options)
        {
        }

        public DbSet<Utilizador> Utilizador { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Acao> Acao { get; set; }
        public DbSet<MenuAcao> MenuAcao { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utilizador>().ToTable("Utilizador");
            modelBuilder.Entity<Perfil>().ToTable("Perfil");
            modelBuilder.Entity<Menu>().ToTable("Menu");
            modelBuilder.Entity<Acao>().ToTable("Acao");
            modelBuilder.Entity<MenuAcao>().ToTable("MenuAcao");


            modelBuilder.Entity<Acao>().HasData(
              new Acao { Nome = "Criar", IdAcao = 1 },
              new Acao { Nome = "Editar", IdAcao = 2 },
              new Acao { Nome = "Eliminar", IdAcao = 3 }
            );


            modelBuilder.Entity<Menu>().HasData(
              new Menu {IdMenu=1, Nome = "Administração", Descricao = "Administração do Sistema SGA-STIF", IdMenuPai = null },
              new Menu { IdMenu=2,Nome = "Utilizador", Descricao = "Gestão dos utilizadores", IdMenuPai = 1 },
              new Menu {IdMenu=3, Nome = "Perfil", Descricao = "Gestão dos utilizadores", IdMenuPai = 1 }

            );


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