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
        public DbSet<Ilha> Ilha { get; set; }
        public DbSet<Cidade> Cidade { get; set; }
        public DbSet<Agencia> Agencia { get; set; }
        public DbSet<InstituicaoFinanceira> InstituicaoFinanceira { get; set; }
        public DbSet<TipoQuota> TipoQuota { get; set; }
        public DbSet<PeriodoQuota> PeriodoQuota { get; set; }
        public DbSet<Joia> Joia { get; set; }
        public DbSet<Socio> Socio { get; set; }
        public DbSet<JoiaSocio> JoiaSocio { get; set; }
        public DbSet<Beneficiario> Beneficiario { get; set; }
        public DbSet<EstadoSocio> EstadoSocio { get; set; }
        public DbSet<PerfilMenuAcao> PerfilMenuAcao { get; set; }
        public DbSet<TipologiaSocio> TipologiaSocio { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Utilizador>().ToTable("Utilizador");
            modelBuilder.Entity<Perfil>().ToTable("Perfil");
            modelBuilder.Entity<Menu>().ToTable("Menu");
            modelBuilder.Entity<Acao>().ToTable("Acao");
            modelBuilder.Entity<MenuAcao>().ToTable("MenuAcao");
            modelBuilder.Entity<Ilha>().ToTable("Ilha");
            modelBuilder.Entity<Cidade>().ToTable("Cidade");
            modelBuilder.Entity<Agencia>().ToTable("Agencia");
            modelBuilder.Entity<InstituicaoFinanceira>().ToTable("InstituicaoFinanceira");
            modelBuilder.Entity<TipoQuota>().ToTable("TipoQuota");
            modelBuilder.Entity<PeriodoQuota>().ToTable("PeriodoQuota");
            modelBuilder.Entity<Joia>().ToTable("Joia");
            modelBuilder.Entity<JoiaSocio>().ToTable("JoiaSocio");
            modelBuilder.Entity<Socio>().ToTable("Socio");
            modelBuilder.Entity<Beneficiario>().ToTable("Beneficiario");
            modelBuilder.Entity<EstadoSocio>().ToTable("EstadoSocio");
            modelBuilder.Entity<PerfilMenuAcao>().ToTable("PerfilMenuAcao");
            modelBuilder.Entity<TipologiaSocio>().ToTable("TipologiaSocio");


            #region seed dados de inicializacao do sistema





            modelBuilder.Entity<TipologiaSocio>().HasData(
              new TipologiaSocio { Descricao = "Normal", Montante = 0, Prioridicidade = 1, DataFim = DateTime.Now, DataInicio = DateTime.Now, Tipo = TipoTipologiaSocio.Normal, IdTipologiaSocio = 1 },
              new TipologiaSocio { Descricao = "Honorário", Montante = 0, Prioridicidade = 1, DataFim = DateTime.Now, DataInicio = DateTime.Now, Tipo = TipoTipologiaSocio.Honorario, IdTipologiaSocio = 2 }


             );



            modelBuilder.Entity<TipoQuota>().HasData(
            new TipoQuota { Priodicidade = 1, Descricao = "Quinzenal", Montante = 0, IdTipoQuota = 1, Tipo = TipoTipoQuota.TipoQutoA },
            new TipoQuota { Priodicidade = 1, Descricao = "Mensal", Montante = 0, IdTipoQuota = 2, Tipo = TipoTipoQuota.TipoQutoA },
            new TipoQuota { Priodicidade = 1, Descricao = "Trimestral", Montante = 0, IdTipoQuota = 3, Tipo = TipoTipoQuota.TipoQutoA },
            new TipoQuota { Priodicidade = 1, Descricao = "Semestral", Montante = 0, IdTipoQuota = 4, Tipo = TipoTipoQuota.TipoQutoA },
            new TipoQuota { Priodicidade = 1, Descricao = "Anual", Montante = 0, IdTipoQuota = 5, Tipo = TipoTipoQuota.TipoQutoA }

           );


            modelBuilder.Entity<Ilha>().HasData(
            new Ilha { Nome = "Santo Antão", IdIlha = 1 },
            new Ilha { Nome = "São Vicente", IdIlha = 2 },
            new Ilha { Nome = "Santa Luzia", IdIlha = 3 },
            new Ilha { Nome = "São Nicolau", IdIlha = 4 },
            new Ilha { Nome = "Sal", IdIlha = 5 },
            new Ilha { Nome = "Boavista", IdIlha = 6 },
            new Ilha { Nome = "Maio", IdIlha = 7 },
            new Ilha { Nome = "Santiago", IdIlha = 8 },
            new Ilha { Nome = "Fogo", IdIlha = 9 },
            new Ilha { Nome = "Brava", IdIlha = 10 }

           );


            modelBuilder.Entity<Cidade>().HasData(
            new Cidade { IdCidade = 1, IdIlha = 8, Nome = "Praia" },
            new Cidade { IdCidade = 2, IdIlha = 8, Nome = "Outro" },
            new Cidade { IdCidade = 3, IdIlha = 2, Nome = "Mindelo" },
            new Cidade { IdCidade = 4, IdIlha = 5, Nome = "Santa Maria" },
            new Cidade { IdCidade = 5, IdIlha = 7, Nome = "Vila do Maio" },
            new Cidade { IdCidade = 6, IdIlha = 8, Nome = "Santa Cruz" },
            new Cidade { IdCidade = 7, IdIlha = 6, Nome = "Sal Rei" },
            new Cidade { IdCidade = 8, IdIlha = 1, Nome = "Porto Novo" },
            new Cidade { IdCidade = 9, IdIlha = 8, Nome = "Ribeira Grande" },
            new Cidade { IdCidade = 10, IdIlha = 10, Nome = "Ribeira Brava" },
            new Cidade { IdCidade = 11, IdIlha = 1, Nome = "Tarrafal" },
            new Cidade { IdCidade = 12, IdIlha = 5, Nome = "Espargos" },
            new Cidade { IdCidade = 13, IdIlha = 8, Nome = "Assomada" },
            new Cidade { IdCidade = 14, IdIlha = 8, Nome = "São Domingos" },
            new Cidade { IdCidade = 15, IdIlha = 9, Nome = "São Filipe" },
            new Cidade { IdCidade = 16, IdIlha = 9, Nome = "Mosteiros" },
            new Cidade { IdCidade = 17, IdIlha = 1, Nome = "Nova Sintra" },
            new Cidade { IdCidade = 18, IdIlha = 8, Nome = "Tarrafal (Santiano)" }

           );


            modelBuilder.Entity<Perfil>().HasData(
             new Perfil { Descricao = "Administrador", IdPerfil = 1 },
             new Perfil { Descricao = "Operador", IdPerfil = 2 }

           );



            modelBuilder.Entity<Utilizador>().HasData(
             new Utilizador { Nome = "Angelo", Apelido = "Semedo", Foto = null, Email = "angelosemedo@sgastif.cv", NomeUtilizador = "angelosemedo", PalavraPasse = BCrypt.Net.BCrypt.HashPassword("1234"), IdPerfil = 1, IdUtilizador = 1 },
             new Utilizador { Nome = "Odailton", Apelido = "Veiga", Foto = null, Email = "odailtonveiga@sgastif.cv", NomeUtilizador = "odailtonveiga", PalavraPasse = BCrypt.Net.BCrypt.HashPassword("1234"), IdPerfil = 1, IdUtilizador = 2 },
             new Utilizador { Nome = "Manuel", Apelido = "Varela", Foto = null, Email = "manuelvarela@sgastif.cv", NomeUtilizador = "manuelvarela", PalavraPasse = BCrypt.Net.BCrypt.HashPassword("1234"), IdPerfil = 1, IdUtilizador = 3 }

           );


            modelBuilder.Entity<Acao>().HasData(
             new Acao { Nome = "Criar", IdAcao = 1 },
             new Acao { Nome = "Editar", IdAcao = 2 },
             new Acao { Nome = "Eliminar", IdAcao = 3 }
           );


            modelBuilder.Entity<Menu>().HasData(
              new Menu { IdMenu = 1, Nome = "Administração", Descricao = "Administração do Sistema SGA-STIF", IdMenuPai = null },
              new Menu { IdMenu = 2, Nome = "Utilizador", Descricao = "Gestão dos utilizadores", IdMenuPai = 1 },
              new Menu { IdMenu = 3, Nome = "Perfil", Descricao = "Gestão dos utilizadores", IdMenuPai = 1 },
              new Menu { IdMenu = 4, Nome = "Menu", Descricao = "Gestão dos utilizadores", IdMenuPai = 1 }

            );

            #endregion


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