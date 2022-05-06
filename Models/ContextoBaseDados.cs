using Microsoft.EntityFrameworkCore;
using sga_stif.Models.ResultadoStoredProcedure;
using System.Collections.Generic;

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
    public DbSet<LogAtividade> LogAtividade { get; set; }
    public DbSet<InstituicaoFinanceiraColaboradores> InstituicaoFinanceiraColaboradores { get; set; }
    public DbSet<QuotaSocio> QuotaSocio { get; set; }

    //resultado storedd procedure
    public DbSet<ContaCorrenteIFResultado> ContaCorrenteIFResultado { get; set; }
    public DbSet<ContaCorrenteSocioResultado> ContaCorrenteSocioResultado { get; set; }


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
      modelBuilder.Entity<InstituicaoFinanceiraColaboradores>().ToTable("InstituicaoFinanceiraColaboradores");
      modelBuilder.Entity<QuotaSocio>().ToTable("QuotaSocio");


      //nao vai ser criado na base de dados

      modelBuilder.Entity<ContaCorrenteIFResultado>().HasNoKey();
      modelBuilder.Entity<ContaCorrenteSocioResultado>().HasNoKey();

      // modelBuilder.Entity<ContaCorrenteIFResultado>().ToView("Dummy view name");
      // modelBuilder.Entity<ContaCorrenteSocioResultado>().ToView("Dummy view name");
      


      #region seed dados de inicializacao do sistema





      modelBuilder.Entity<TipologiaSocio>().HasData(
        new TipologiaSocio { Descricao = "Normal", DataFim = DateTime.Now, DataInicio = DateTime.Now, Tipo = TipoTipologiaSocio.Normal, IdTipologiaSocio = 1 },
        new TipologiaSocio { Descricao = "Honorário", DataFim = DateTime.Now, DataInicio = DateTime.Now, Tipo = TipoTipologiaSocio.Honorario, IdTipologiaSocio = 2 }


       );



      modelBuilder.Entity<TipoQuota>().HasData(
      new TipoQuota { Priodicidade = 0, Descricao = "Quinzenal", Montante = 0, IdTipoQuota = 1, Tipo = TipoTipoQuota.Fixo },
      new TipoQuota { Priodicidade = 1, Descricao = "Mensal", Montante = 0, IdTipoQuota = 2, Tipo = TipoTipoQuota.Variavel },
      new TipoQuota { Priodicidade = 3, Descricao = "Trimestral", Montante = 0, IdTipoQuota = 3, Tipo = TipoTipoQuota.Fixo },
      new TipoQuota { Priodicidade = 6, Descricao = "Semestral", Montante = 0, IdTipoQuota = 4, Tipo = TipoTipoQuota.Fixo },
      new TipoQuota { Priodicidade = 12, Descricao = "Anual", Montante = 0, IdTipoQuota = 5, Tipo = TipoTipoQuota.Fixo }

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
       new Perfil { Nome = "Administrador", Descricao = "Perfil de Administrador", IdPerfil = 1, Editavel = false },
       new Perfil { Nome = "Auditor", Descricao = "Perfil de Operador", IdPerfil = 2, Editavel = true },
       new Perfil { Nome = "Operador Teste", Descricao = "Perfil de Operador", IdPerfil = 3, Editavel = true }

     );


      modelBuilder.Entity<InstituicaoFinanceira>().HasData(
            new InstituicaoFinanceira() { IdInstituicaoFinanceira = 2, Nome = "Caixa Económica de Cabo Verde", Sigla="CECV" },
            new InstituicaoFinanceira() { IdInstituicaoFinanceira = 3, Nome = "Banco Comercial do Atlântico", Sigla="BCA"},
            new InstituicaoFinanceira() { IdInstituicaoFinanceira = 4, Nome = "Banco Caboverdiano de Negócios", Sigla="BCN" },
            new InstituicaoFinanceira() { IdInstituicaoFinanceira = 5, Nome = "Banco Interatlântico", Sigla="BI" },
            new InstituicaoFinanceira() { IdInstituicaoFinanceira = 8, Nome = "Banco Angolano de Investimentos", Sigla="BAI" },
            new InstituicaoFinanceira() { IdInstituicaoFinanceira = 9, Nome = "International Investment Bank", Sigla="IIB" },
            new InstituicaoFinanceira() { IdInstituicaoFinanceira = 11, Nome = "Ecobank Cabo Verde SA", Sigla="ECV" }

       );


      modelBuilder.Entity<Agencia>().HasData(
           new Agencia { IdAgencia = 1, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. Fazenda" },
           new Agencia { IdAgencia = 2, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. Mindelo" },
           new Agencia { IdAgencia = 3, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. ASA" },
           new Agencia { IdAgencia = 4, IdCidade = 13, IdInstituicaoFinanceira = 2, Nome = "Ag. Assomada" },
           new Agencia { IdAgencia = 5, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. Espargos" },
           new Agencia { IdAgencia = 6, IdCidade = 9, IdInstituicaoFinanceira = 2, Nome = "Ag. Rª Grande" },
           new Agencia { IdAgencia = 7, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. St. Maria" },
           new Agencia { IdAgencia = 8, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. Plateau" },
           new Agencia { IdAgencia = 9, IdCidade = 3, IdInstituicaoFinanceira = 2, Nome = "Ag. Monte Sossego" },
           new Agencia { IdAgencia = 10, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. Palmarejo" },
           new Agencia { IdAgencia = 11, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. São Filipe" },
           new Agencia { IdAgencia = 12, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. Calheta S. Miguel" },
           new Agencia { IdAgencia = 13, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. Aeroporto da Praia" },
           new Agencia { IdAgencia = 14, IdCidade = 7, IdInstituicaoFinanceira = 2, Nome = "Ag. Boavista" },
           new Agencia { IdAgencia = 15, IdCidade = 12, IdInstituicaoFinanceira = 2, Nome = "Ag. Aeroporto do Sal" },
           new Agencia { IdAgencia = 16, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. Sucupira" },
           new Agencia { IdAgencia = 17, IdCidade = 14, IdInstituicaoFinanceira = 2, Nome = "Ag. CCV – São Domingos" },
           new Agencia { IdAgencia = 18, IdCidade = 18, IdInstituicaoFinanceira = 2, Nome = "Ag. Tarrafal" },
           new Agencia { IdAgencia = 19, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. Santa Cruz" },
           new Agencia { IdAgencia = 20, IdCidade = 8, IdInstituicaoFinanceira = 2, Nome = "Ag. CCV – Porto Novo" },
           new Agencia { IdAgencia = 21, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. CCV - Plateau" },
           new Agencia { IdAgencia = 22, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. A. São Filipe" },
           new Agencia { IdAgencia = 23, IdCidade = 16, IdInstituicaoFinanceira = 2, Nome = "Ag. Mosteiros" },
           new Agencia { IdAgencia = 24, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. Caixa Empresas" },
           new Agencia { IdAgencia = 25, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. Coculi" },
           new Agencia { IdAgencia = 26, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. Paul" },
           new Agencia { IdAgencia = 27, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. Fonte Cónego" },
           new Agencia { IdAgencia = 28, IdCidade = 7, IdInstituicaoFinanceira = 2, Nome = "Ag. Aeroporto Boavista" },
           new Agencia { IdAgencia = 29, IdCidade = 5, IdInstituicaoFinanceira = 2, Nome = "Ag. Maio" },
           new Agencia { IdAgencia = 30, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. Porto Novo" },
           new Agencia { IdAgencia = 31, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. Ribeira Brava" },
           new Agencia { IdAgencia = 32, IdCidade = 1, IdInstituicaoFinanceira = 2, Nome = "Ag. Ribeira Brava" },
           new Agencia { IdAgencia = 33, IdCidade = 18, IdInstituicaoFinanceira = 2, Nome = "Ag. Tarrafal" },
           new Agencia { IdAgencia = 34, IdCidade = 1, IdInstituicaoFinanceira = 3, Nome = "Ag. Praia" },
           new Agencia { IdAgencia = 35, IdCidade = 1, IdInstituicaoFinanceira = 3, Nome = "Ag. S. Vicente " },
           new Agencia { IdAgencia = 36, IdCidade = 4, IdInstituicaoFinanceira = 3, Nome = "Ag. Sal" },
           new Agencia { IdAgencia = 37, IdCidade = 1, IdInstituicaoFinanceira = 3, Nome = "Ag. S. Filipe" },
           new Agencia { IdAgencia = 38, IdCidade = 18, IdInstituicaoFinanceira = 3, Nome = "Ag. Tarrafal" },
           new Agencia { IdAgencia = 39, IdCidade = 1, IdInstituicaoFinanceira = 3, Nome = "Ag. S. Catarina" },
           new Agencia { IdAgencia = 40, IdCidade = 1, IdInstituicaoFinanceira = 3, Nome = "Ag. Porto Novo" },
           new Agencia { IdAgencia = 41, IdCidade = 9, IdInstituicaoFinanceira = 3, Nome = "Ag. Rª Grande" },
           new Agencia { IdAgencia = 42, IdCidade = 1, IdInstituicaoFinanceira = 3, Nome = "Ag. Brava" },
           new Agencia { IdAgencia = 43, IdCidade = 1, IdInstituicaoFinanceira = 3, Nome = "Ag. Boavista" },
           new Agencia { IdAgencia = 44, IdCidade = 1, IdInstituicaoFinanceira = 3, Nome = "Ag. S. Nicolau" },
           new Agencia { IdAgencia = 45, IdCidade = 5, IdInstituicaoFinanceira = 3, Nome = "Ag. Maio" },
           new Agencia { IdAgencia = 46, IdCidade = 6, IdInstituicaoFinanceira = 3, Nome = "Ag. Santa Cruz" },
           new Agencia { IdAgencia = 47, IdCidade = 1, IdInstituicaoFinanceira = 3, Nome = "Ag. Praça Nova" },
           new Agencia { IdAgencia = 48, IdCidade = 1, IdInstituicaoFinanceira = 3, Nome = "Ag. ASA" },
           new Agencia { IdAgencia = 49, IdCidade = 1, IdInstituicaoFinanceira = 3, Nome = "Ag. Avenida" },
           new Agencia { IdAgencia = 50, IdCidade = 3, IdInstituicaoFinanceira = 3, Nome = "Ag. Monte Sossego" },
           new Agencia { IdAgencia = 51, IdCidade = 3, IdInstituicaoFinanceira = 3, Nome = "Ag. Fonte Filipe" },
           new Agencia { IdAgencia = 52, IdCidade = 4, IdInstituicaoFinanceira = 3, Nome = "Ag. Santa Maria" },
           new Agencia { IdAgencia = 53, IdCidade = 16, IdInstituicaoFinanceira = 3, Nome = "Ag. Mosteiros" },
           new Agencia { IdAgencia = 54, IdCidade = 11, IdInstituicaoFinanceira = 3, Nome = "Ag. Tarrafal S. Nicolau" },
           new Agencia { IdAgencia = 55, IdCidade = 1, IdInstituicaoFinanceira = 3, Nome = "Ag. ASA II" },
           new Agencia { IdAgencia = 56, IdCidade = 1, IdInstituicaoFinanceira = 3, Nome = "Gabinete Empresas Sul" },
           new Agencia { IdAgencia = 57, IdCidade = 1, IdInstituicaoFinanceira = 3, Nome = "Gabinete Empresas Norte" },
           new Agencia { IdAgencia = 58, IdCidade = 1, IdInstituicaoFinanceira = 3, Nome = "Ag. S. Domingos" },
           new Agencia { IdAgencia = 59, IdCidade = 1, IdInstituicaoFinanceira = 3, Nome = "Ag. Palmarejo" },
           new Agencia { IdAgencia = 60, IdCidade = 1, IdInstituicaoFinanceira = 3, Nome = "Gabinete Empresas Sul II" },
           new Agencia { IdAgencia = 61, IdCidade = 4, IdInstituicaoFinanceira = 3, Nome = "Gabinete Empresas Sal" },
           new Agencia { IdAgencia = 62, IdCidade = 1, IdInstituicaoFinanceira = 3, Nome = "Prol. Ach. São Filipe" },
           new Agencia { IdAgencia = 63, IdCidade = 1, IdInstituicaoFinanceira = 4, Nome = "Ag. Praia" },
           new Agencia { IdAgencia = 64, IdCidade = 1, IdInstituicaoFinanceira = 4, Nome = "Ag. Mindelo" },
           new Agencia { IdAgencia = 65, IdCidade = 13, IdInstituicaoFinanceira = 4, Nome = "Ag. Assomada" },
           new Agencia { IdAgencia = 66, IdCidade = 4, IdInstituicaoFinanceira = 4, Nome = "Ag. Aeroporto do Sal" },
           new Agencia { IdAgencia = 67, IdCidade = 1, IdInstituicaoFinanceira = 4, Nome = "Ag. Boavista" },
           new Agencia { IdAgencia = 68, IdCidade = 1, IdInstituicaoFinanceira = 4, Nome = "Ag. Porto Novo" },
           new Agencia { IdAgencia = 69, IdCidade = 1, IdInstituicaoFinanceira = 4, Nome = "Ag. Terra Branca" },
           new Agencia { IdAgencia = 70, IdCidade = 1, IdInstituicaoFinanceira = 4, Nome = "Ag. Palmarejo" },
           new Agencia { IdAgencia = 71, IdCidade = 3, IdInstituicaoFinanceira = 4, Nome = "Ag. Monte Sossego" },
           new Agencia { IdAgencia = 72, IdCidade = 1, IdInstituicaoFinanceira = 4, Nome = "Ag. Santa Maria" },
           new Agencia { IdAgencia = 73, IdCidade = 1, IdInstituicaoFinanceira = 4, Nome = "Ag. São Filipe" },
           new Agencia { IdAgencia = 74, IdCidade = 9, IdInstituicaoFinanceira = 4, Nome = "Ag. Rª Grande" },
           new Agencia { IdAgencia = 75, IdCidade = 1, IdInstituicaoFinanceira = 4, Nome = "ASA – Private Banking" },
           new Agencia { IdAgencia = 76, IdCidade = 1, IdInstituicaoFinanceira = 4, Nome = "Ag. Fazenda" },
           new Agencia { IdAgencia = 77, IdCidade = 1, IdInstituicaoFinanceira = 4, Nome = "Ag. Órgãos" },
           new Agencia { IdAgencia = 78, IdCidade = 1, IdInstituicaoFinanceira = 4, Nome = "Ag. Santa Cruz" },
           new Agencia { IdAgencia = 79, IdCidade = 1, IdInstituicaoFinanceira = 4, Nome = "Ag. Ponta do Sol" },
           new Agencia { IdAgencia = 80, IdCidade = 5, IdInstituicaoFinanceira = 4, Nome = "Ag. Maio" },
           new Agencia { IdAgencia = 81, IdCidade = 1, IdInstituicaoFinanceira = 4, Nome = "Centro de empresas" },
           new Agencia { IdAgencia = 82, IdCidade = 1, IdInstituicaoFinanceira = 4, Nome = "Centro de empresas II" },
           new Agencia { IdAgencia = 83, IdCidade = 1, IdInstituicaoFinanceira = 4, Nome = "Ag. Sede" },
           new Agencia { IdAgencia = 84, IdCidade = 1, IdInstituicaoFinanceira = 4, Nome = "Núcleo N/ Residentes" },
           new Agencia { IdAgencia = 85, IdCidade = 1, IdInstituicaoFinanceira = 5, Nome = "Ag. Sede" },
           new Agencia { IdAgencia = 86, IdCidade = 1, IdInstituicaoFinanceira = 5, Nome = "Ag. ASA" },
           new Agencia { IdAgencia = 87, IdCidade = 1, IdInstituicaoFinanceira = 5, Nome = "Ag. Mindelo" },
           new Agencia { IdAgencia = 88, IdCidade = 1, IdInstituicaoFinanceira = 5, Nome = "Ag. Plateau" },
           new Agencia { IdAgencia = 89, IdCidade = 1, IdInstituicaoFinanceira = 5, Nome = "Ag. Espargos" },
           new Agencia { IdAgencia = 90, IdCidade = 1, IdInstituicaoFinanceira = 5, Nome = "Ag. Santa Maria" },
           new Agencia { IdAgencia = 91, IdCidade = 7, IdInstituicaoFinanceira = 5, Nome = "ag. Sal Rei – Boavista" },
           new Agencia { IdAgencia = 92, IdCidade = 13, IdInstituicaoFinanceira = 5, Nome = "Ag. Assomada" },
           new Agencia { IdAgencia = 93, IdCidade = 1, IdInstituicaoFinanceira = 5, Nome = "Ag. Achada Grande Trás" },
           new Agencia { IdAgencia = 94, IdCidade = 1, IdInstituicaoFinanceira = 5, Nome = "Gab. Particulares (Praia)" },
           new Agencia { IdAgencia = 95, IdCidade = 1, IdInstituicaoFinanceira = 5, Nome = "Gab. Empresas (Praia)" },
           new Agencia { IdAgencia = 96, IdCidade = 1, IdInstituicaoFinanceira = 8, Nome = "Ag. Sede" },
           new Agencia { IdAgencia = 97, IdCidade = 1, IdInstituicaoFinanceira = 8, Nome = "Ag. Plateau" },
           new Agencia { IdAgencia = 98, IdCidade = 1, IdInstituicaoFinanceira = 8, Nome = "Ag ASA" },
           new Agencia { IdAgencia = 99, IdCidade = 1, IdInstituicaoFinanceira = 8, Nome = "Ag. Mindelo" },
           new Agencia { IdAgencia = 100, IdCidade = 1, IdInstituicaoFinanceira = 8, Nome = "Ag. Espargos" },
           new Agencia { IdAgencia = 101, IdCidade = 1, IdInstituicaoFinanceira = 9, Nome = "Ag. Sede" },
           new Agencia { IdAgencia = 102, IdCidade = 1, IdInstituicaoFinanceira = 9, Nome = "Serviços Centrais" },
           new Agencia { IdAgencia = 103, IdCidade = 1, IdInstituicaoFinanceira = 9, Nome = "Emigrantes" },
           new Agencia { IdAgencia = 104, IdCidade = 1, IdInstituicaoFinanceira = 9, Nome = "Particulares Classic" },
           new Agencia { IdAgencia = 105, IdCidade = 1, IdInstituicaoFinanceira = 9, Nome = "Afluentes" },
           new Agencia { IdAgencia = 106, IdCidade = 1, IdInstituicaoFinanceira = 9, Nome = "Private" },
           new Agencia { IdAgencia = 107, IdCidade = 1, IdInstituicaoFinanceira = 9, Nome = "Institucionais" },
           new Agencia { IdAgencia = 108, IdCidade = 1, IdInstituicaoFinanceira = 9, Nome = "PME Nacionais" },
           new Agencia { IdAgencia = 109, IdCidade = 1, IdInstituicaoFinanceira = 9, Nome = "Grandes Empresas Nacionais" },
           new Agencia { IdAgencia = 110, IdCidade = 1, IdInstituicaoFinanceira = 9, Nome = "Corporate Internacional" },
           new Agencia { IdAgencia = 111, IdCidade = 4, IdInstituicaoFinanceira = 9, Nome = "Ag. Sal" },
           new Agencia { IdAgencia = 112, IdCidade = 4, IdInstituicaoFinanceira = 9, Nome = "Emigrantes Sal" },
           new Agencia { IdAgencia = 113, IdCidade = 4, IdInstituicaoFinanceira = 9, Nome = "Particulares Classic Sal" },
           new Agencia { IdAgencia = 114, IdCidade = 4, IdInstituicaoFinanceira = 9, Nome = "Afluentes Sal" },
           new Agencia { IdAgencia = 115, IdCidade = 4, IdInstituicaoFinanceira = 9, Nome = "Private Sal" },
           new Agencia { IdAgencia = 116, IdCidade = 4, IdInstituicaoFinanceira = 9, Nome = "Institucionais Sal" },
           new Agencia { IdAgencia = 117, IdCidade = 4, IdInstituicaoFinanceira = 9, Nome = "PME Nacionais Sal" },
           new Agencia { IdAgencia = 118, IdCidade = 1, IdInstituicaoFinanceira = 9, Nome = "Grandes Empresas Nacionais Sal" },
           new Agencia { IdAgencia = 119, IdCidade = 1, IdInstituicaoFinanceira = 11, Nome = "Ag. Sede - Praia" },
           new Agencia { IdAgencia = 120, IdCidade = 13, IdInstituicaoFinanceira = 8, Nome = "Ag. Assomada" },
           new Agencia { IdAgencia = 121, IdCidade = 1, IdInstituicaoFinanceira = 8, Nome = "Ag. Sta Maria " },
           new Agencia { IdAgencia = 122, IdCidade = 1, IdInstituicaoFinanceira = 8, Nome = "Agencia Sal-Rei " },
           new Agencia { IdAgencia = 123, IdCidade = 1, IdInstituicaoFinanceira = 8, Nome = "Agencia S.Filipe " },
           new Agencia { IdAgencia = 124, IdCidade = 3, IdInstituicaoFinanceira = 8, Nome = "Ag. Montsu " }


      );



      modelBuilder.Entity<Utilizador>().HasData(
       new Utilizador { Nome = "Angelo", Apelido = "Semedo", Foto = null, Email = "angelosemedo@sgastif.cv", NomeUtilizador = "angelosemedo", PalavraPasse = BCrypt.Net.BCrypt.HashPassword("1234"), IdPerfil = 1, IdUtilizador = 1 },
       new Utilizador { Nome = "Odailton", Apelido = "Veiga", Foto = null, Email = "odailtonveiga@sgastif.cv", NomeUtilizador = "odailtonveiga", PalavraPasse = BCrypt.Net.BCrypt.HashPassword("1234"), IdPerfil = 1, IdUtilizador = 2 },
       new Utilizador { Nome = "Manuel", Apelido = "Varela", Foto = null, Email = "manuelvarela@sgastif.cv", NomeUtilizador = "manuelvarela", PalavraPasse = BCrypt.Net.BCrypt.HashPassword("1234"), IdPerfil = 1, IdUtilizador = 3 },
       new Utilizador { Nome = "Jair", Apelido = "Tavares", Foto = null, Email = "jair@sgastif.cv", NomeUtilizador = "jair", PalavraPasse = BCrypt.Net.BCrypt.HashPassword("1234"), IdPerfil = 1, IdUtilizador = 4 }

     );


      modelBuilder.Entity<Acao>().HasData(
        new Acao { Nome = "Administração", IdAcao = 1, AcaoMaster = true },
       new Acao { Nome = "Criar", IdAcao = 2 },
       new Acao { Nome = "Editar", IdAcao = 3 },
       new Acao { Nome = "Eliminar", IdAcao = 4 }


     );


      modelBuilder.Entity<Joia>().HasData(
        new Joia { IdJoia = 1, Montante = 1000, DataInicio = DateTime.Now, DataFim = null, Descricao = "Jóia STIF" }

     );


      var menus = new List<Menu>(){


               new Menu { IdMenu = 1, Nome = "Gestão de Sócios", Descricao = "Gestão de Sócios", IdMenuPai = null, NomeDaAction = "", NomeDoController = "", Icone = "fas fa-user" },
               new Menu { IdMenu = 2, Nome = "Lista  Sócios", Descricao = "Lista de Sócios", IdMenuPai = 1, NomeDaAction = "ListaSocio", NomeDoController = "Socio", Icone = "far fa-circle" },
               new Menu { IdMenu = 3, Nome = "Ranking Sócios", Descricao = "Ranquing de Sócios", IdMenuPai = 1, NomeDaAction = "", NomeDoController = "", Icone = "far fa-circle" },



              new Menu { IdMenu = 4, Nome = "Contas Correntes", Descricao = "Contas Correntes", IdMenuPai = null, NomeDaAction = "", NomeDoController = "", Icone = "fas fa-book" },
               new Menu { IdMenu = 5, Nome = "Quotas Pendentes", Descricao = "Quotas Pendentes", IdMenuPai = 4, NomeDaAction = "ListaQuotasPendente", NomeDoController = "ContaCorrentes", Icone = "far fa-circle" },
              new Menu { IdMenu = 6, Nome = "Quotas Por Pagar", Descricao = "Quotas Por Pagar", IdMenuPai = 4, NomeDaAction = "ListaQuotasPorPagar", NomeDoController = "ContaCorrentes", Icone = "far fa-circle" },
              new Menu { IdMenu = 7, Nome = "Quotas Pagas", Descricao = "Quotas Paga", IdMenuPai = 4, NomeDaAction = "ListaQuotasPagas", NomeDoController = "ContaCorrentes", Icone = "far fa-circle" },
              new Menu { IdMenu = 8, Nome = "Quotas Vencidas", Descricao = "Quotas Vencidas", IdMenuPai = 4, NomeDaAction = "ListaQuotasVencidas", NomeDoController = "ContaCorrentes", Icone = "far fa-circle" },



              new Menu { IdMenu = 9, Nome = "Posição de IF", Descricao = "Posição de IF", IdMenuPai = null, NomeDaAction = "", NomeDoController = "", Icone = "fas fa-search" },

              new Menu { IdMenu = 10, Nome = "Projeção de Quotas", Descricao = "Projeção de Quotas", IdMenuPai = null, NomeDaAction = "", NomeDoController = "", Icone = "fas fa-table" },

              new Menu { IdMenu = 11, Nome = "Estatística", Descricao = "Estatística", IdMenuPai = null, NomeDaAction = "Inicio", NomeDoController = "Estatistica", Icone = "fas fa-chart-pie" },




              new Menu { IdMenu = 12, Nome = "Configurações", Descricao = "Configurações", IdMenuPai = null, NomeDaAction = "", NomeDoController = "", Icone = "far fa-edit" },
              new Menu { IdMenu = 13, Nome = "Utilizadores", Descricao = "Instituição Financeira", IdMenuPai = 12, NomeDaAction = "ListaUtilizador", NomeDoController = "Utilizador", Icone = "far fa-circle" },
              new Menu { IdMenu = 14, Nome = "Perfil", Descricao = "Instituição Financeira", IdMenuPai = 12, NomeDaAction = "ListaPerfil", NomeDoController = "Perfil", Icone = "far fa-circle" },
              new Menu { IdMenu = 15, Nome = "Menu", Descricao = "Gestão de Menu", IdMenuPai = 12, NomeDaAction = "ListaMenu", NomeDoController = "MenuAcao", Icone = "far fa-circle" },
              new Menu { IdMenu = 16, Nome = "Instituição Financeira", Descricao = "Instituição Financeira", IdMenuPai = 12, NomeDaAction = "ListaInstituicaoFinanceira", NomeDoController = "InstituicaoFinanceira", Icone = "far fa-circle" },
              new Menu { IdMenu = 17, Nome = "Agência", Descricao = "Agência", IdMenuPai = 12, NomeDaAction = "ListaAgencia", NomeDoController = "Agencia", Icone = "far fa-circle" },
              new Menu { IdMenu = 18, Nome = "Tipo Quotas", Descricao = "Tipo Quotas", IdMenuPai = 12, NomeDaAction = "ListaTipoQuota", NomeDoController = "TipoQuota", Icone = "far fa-circle" },
              new Menu { IdMenu = 19, Nome = "Tipologia Sócio", Descricao = "Tipologia Sócio", IdMenuPai = 12, NomeDaAction = "ListaTipologiaSocio", NomeDoController = "TipologiaSocio", Icone = "far fa-circle" },


          };

      modelBuilder.Entity<Menu>().HasData(menus);

      var menuAcaos = new List<MenuAcao>();

      var contador = 1;

      foreach (var item in menus)
      {
        menuAcaos.Add(new MenuAcao() { IdMenuAcao = contador, IdAcao = 1, IdMenu = item.IdMenu, MenuAcaoMaster = true });
        contador++;
      }

      modelBuilder.Entity<MenuAcao>().HasData(menuAcaos);



      var perfilMenuAcaos = new List<PerfilMenuAcao>();
      contador = 1;


      foreach (var item in menuAcaos)
      {

        perfilMenuAcaos.Add(new PerfilMenuAcao { IdPerfilMenuAcao = contador, IdMenuAcao = item.IdMenuAcao, IdPPerfil = 1 });
        contador++;

      }

      modelBuilder.Entity<PerfilMenuAcao>().HasData(perfilMenuAcaos);

      #endregion


    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      var configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var connectionString = configuration.GetConnectionString("sgastif-remote");
      optionsBuilder.UseSqlServer(connectionString);
      //optionsBuilder.UseSqlite("Filename=sga-stif.db");
    }

  }

}