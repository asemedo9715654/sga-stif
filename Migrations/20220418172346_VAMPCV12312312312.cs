using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class VAMPCV12312312312 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acao",
                columns: table => new
                {
                    IdAcao = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    AcaoMaster = table.Column<bool>(type: "INTEGER", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acao", x => x.IdAcao);
                });

            migrationBuilder.CreateTable(
                name: "Ilha",
                columns: table => new
                {
                    IdIlha = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilha", x => x.IdIlha);
                });

            migrationBuilder.CreateTable(
                name: "InstituicaoFinanceira",
                columns: table => new
                {
                    IdInstituicaoFinanceira = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstituicaoFinanceira", x => x.IdInstituicaoFinanceira);
                });

            migrationBuilder.CreateTable(
                name: "Joia",
                columns: table => new
                {
                    IdJoia = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    Montante = table.Column<decimal>(type: "TEXT", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataFim = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joia", x => x.IdJoia);
                });

            migrationBuilder.CreateTable(
                name: "LogAtividade",
                columns: table => new
                {
                    IdLogAtividades = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Dados = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    NomeUtilizador = table.Column<string>(type: "TEXT", nullable: false),
                    EnderecoIp = table.Column<string>(type: "TEXT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogAtividade", x => x.IdLogAtividades);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    IdMenu = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    NomeDoController = table.Column<string>(type: "TEXT", nullable: false),
                    NomeDaAction = table.Column<string>(type: "TEXT", nullable: false),
                    Icone = table.Column<string>(type: "TEXT", nullable: false),
                    IdMenuPai = table.Column<int>(type: "INTEGER", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.IdMenu);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    IdPerfil = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    Editavel = table.Column<bool>(type: "INTEGER", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.IdPerfil);
                });

            migrationBuilder.CreateTable(
                name: "PeriodoQuota",
                columns: table => new
                {
                    IdPeriodoQuota = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DataInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataFim = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Mes = table.Column<int>(type: "INTEGER", nullable: false),
                    Ano = table.Column<int>(type: "INTEGER", nullable: false),
                    CodigoPeriodo = table.Column<int>(type: "INTEGER", nullable: false),
                    Estado = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodoQuota", x => x.IdPeriodoQuota);
                });

            migrationBuilder.CreateTable(
                name: "TipologiaSocio",
                columns: table => new
                {
                    IdTipologiaSocio = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Montante = table.Column<decimal>(type: "TEXT", nullable: false),
                    Prioridicidade = table.Column<int>(type: "INTEGER", nullable: false),
                    Tipo = table.Column<int>(type: "INTEGER", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataFim = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipologiaSocio", x => x.IdTipologiaSocio);
                });

            migrationBuilder.CreateTable(
                name: "TipoQuota",
                columns: table => new
                {
                    IdTipoQuota = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    Priodicidade = table.Column<int>(type: "INTEGER", nullable: false),
                    Montante = table.Column<decimal>(type: "TEXT", nullable: false),
                    Tipo = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoQuota", x => x.IdTipoQuota);
                });

            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    IdCidade = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    IdIlha = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidade", x => x.IdCidade);
                    table.ForeignKey(
                        name: "FK_Cidade_Ilha_IdIlha",
                        column: x => x.IdIlha,
                        principalTable: "Ilha",
                        principalColumn: "IdIlha",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuAcao",
                columns: table => new
                {
                    IdMenuAcao = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdAcao = table.Column<int>(type: "INTEGER", nullable: true),
                    IdMenu = table.Column<int>(type: "INTEGER", nullable: true),
                    MenuAcaoMaster = table.Column<bool>(type: "INTEGER", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuAcao", x => x.IdMenuAcao);
                    table.ForeignKey(
                        name: "FK_MenuAcao_Acao_IdAcao",
                        column: x => x.IdAcao,
                        principalTable: "Acao",
                        principalColumn: "IdAcao");
                    table.ForeignKey(
                        name: "FK_MenuAcao_Menu_IdMenu",
                        column: x => x.IdMenu,
                        principalTable: "Menu",
                        principalColumn: "IdMenu");
                });

            migrationBuilder.CreateTable(
                name: "Utilizador",
                columns: table => new
                {
                    IdUtilizador = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    NomeUtilizador = table.Column<string>(type: "TEXT", nullable: false),
                    Apelido = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Foto = table.Column<byte[]>(type: "BLOB", nullable: true),
                    PalavraPasse = table.Column<string>(type: "TEXT", nullable: false),
                    IdPerfil = table.Column<int>(type: "INTEGER", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilizador", x => x.IdUtilizador);
                    table.ForeignKey(
                        name: "FK_Utilizador_Perfil_IdPerfil",
                        column: x => x.IdPerfil,
                        principalTable: "Perfil",
                        principalColumn: "IdPerfil");
                });

            migrationBuilder.CreateTable(
                name: "Agencia",
                columns: table => new
                {
                    IdAgencia = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    IdCidade = table.Column<int>(type: "INTEGER", nullable: false),
                    IdInstituicaoFinanceira = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencia", x => x.IdAgencia);
                    table.ForeignKey(
                        name: "FK_Agencia_Cidade_IdCidade",
                        column: x => x.IdCidade,
                        principalTable: "Cidade",
                        principalColumn: "IdCidade",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Agencia_InstituicaoFinanceira_IdInstituicaoFinanceira",
                        column: x => x.IdInstituicaoFinanceira,
                        principalTable: "InstituicaoFinanceira",
                        principalColumn: "IdInstituicaoFinanceira",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PerfilMenuAcao",
                columns: table => new
                {
                    IdPerfilMenuAcao = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdMenuAcao = table.Column<int>(type: "INTEGER", nullable: false),
                    IdPPerfil = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerfilMenuAcao", x => x.IdPerfilMenuAcao);
                    table.ForeignKey(
                        name: "FK_PerfilMenuAcao_MenuAcao_IdMenuAcao",
                        column: x => x.IdMenuAcao,
                        principalTable: "MenuAcao",
                        principalColumn: "IdMenuAcao",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PerfilMenuAcao_Perfil_IdPPerfil",
                        column: x => x.IdPPerfil,
                        principalTable: "Perfil",
                        principalColumn: "IdPerfil",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Socio",
                columns: table => new
                {
                    IdSocio = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumeroDeSocio = table.Column<string>(type: "TEXT", nullable: false),
                    Foto = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Apelido = table.Column<string>(type: "TEXT", nullable: false),
                    Nif = table.Column<string>(type: "TEXT", nullable: false),
                    CinBi = table.Column<string>(type: "TEXT", nullable: false),
                    ValidadeCinBi = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NumeroPassaporte = table.Column<string>(type: "TEXT", nullable: false),
                    ValidadePassaporte = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Sexo = table.Column<int>(type: "INTEGER", nullable: false),
                    EstadoCivil = table.Column<int>(type: "INTEGER", nullable: false),
                    NumeroDeTelefone = table.Column<string>(type: "TEXT", nullable: true),
                    NumeroDeTelemovel = table.Column<string>(type: "TEXT", nullable: true),
                    IdAgencia = table.Column<int>(type: "INTEGER", nullable: false),
                    IdTipologiaSocio = table.Column<int>(type: "INTEGER", nullable: false),
                    IdTipoQuota = table.Column<int>(type: "INTEGER", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtivacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    NumeroColaborador = table.Column<string>(type: "TEXT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socio", x => x.IdSocio);
                    table.ForeignKey(
                        name: "FK_Socio_Agencia_IdAgencia",
                        column: x => x.IdAgencia,
                        principalTable: "Agencia",
                        principalColumn: "IdAgencia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Socio_TipologiaSocio_IdTipologiaSocio",
                        column: x => x.IdTipologiaSocio,
                        principalTable: "TipologiaSocio",
                        principalColumn: "IdTipologiaSocio",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Socio_TipoQuota_IdTipoQuota",
                        column: x => x.IdTipoQuota,
                        principalTable: "TipoQuota",
                        principalColumn: "IdTipoQuota",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Beneficiario",
                columns: table => new
                {
                    IdBeneficiario = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Apelido = table.Column<string>(type: "TEXT", nullable: false),
                    GrauDeParentesco = table.Column<int>(type: "INTEGER", nullable: false),
                    Nif = table.Column<string>(type: "TEXT", nullable: false),
                    CinBi = table.Column<string>(type: "TEXT", nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NumeroPassaporte = table.Column<string>(type: "TEXT", nullable: false),
                    IdSocio = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiario", x => x.IdBeneficiario);
                    table.ForeignKey(
                        name: "FK_Beneficiario_Socio_IdSocio",
                        column: x => x.IdSocio,
                        principalTable: "Socio",
                        principalColumn: "IdSocio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EstadoSocio",
                columns: table => new
                {
                    IdEstadoSocio = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Estado = table.Column<int>(type: "INTEGER", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DataFim = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IdSocio = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoSocio", x => x.IdEstadoSocio);
                    table.ForeignKey(
                        name: "FK_EstadoSocio_Socio_IdSocio",
                        column: x => x.IdSocio,
                        principalTable: "Socio",
                        principalColumn: "IdSocio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JoiaSocio",
                columns: table => new
                {
                    IdJoiaSocio = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Montante = table.Column<decimal>(type: "TEXT", nullable: false),
                    IdSocio = table.Column<int>(type: "INTEGER", nullable: false),
                    IdJoia = table.Column<int>(type: "INTEGER", nullable: false),
                    Estado = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoiaSocio", x => x.IdJoiaSocio);
                    table.ForeignKey(
                        name: "FK_JoiaSocio_Joia_IdJoia",
                        column: x => x.IdJoia,
                        principalTable: "Joia",
                        principalColumn: "IdJoia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JoiaSocio_Socio_IdSocio",
                        column: x => x.IdSocio,
                        principalTable: "Socio",
                        principalColumn: "IdSocio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuotaSocio",
                columns: table => new
                {
                    IdQuotaSocio = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Montante = table.Column<decimal>(type: "TEXT", nullable: false),
                    Estado = table.Column<int>(type: "INTEGER", nullable: false),
                    IdSocio = table.Column<int>(type: "INTEGER", nullable: false),
                    IdPeriodoQuota = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuotaSocio", x => x.IdQuotaSocio);
                    table.ForeignKey(
                        name: "FK_QuotaSocio_PeriodoQuota_IdPeriodoQuota",
                        column: x => x.IdPeriodoQuota,
                        principalTable: "PeriodoQuota",
                        principalColumn: "IdPeriodoQuota",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuotaSocio_Socio_IdSocio",
                        column: x => x.IdSocio,
                        principalTable: "Socio",
                        principalColumn: "IdSocio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Acao",
                columns: new[] { "IdAcao", "AcaoMaster", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 1, true, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6206), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6202), false, "Administração" });

            migrationBuilder.InsertData(
                table: "Acao",
                columns: new[] { "IdAcao", "AcaoMaster", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 2, false, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6213), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6212), false, "Criar" });

            migrationBuilder.InsertData(
                table: "Acao",
                columns: new[] { "IdAcao", "AcaoMaster", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 3, false, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6215), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6214), false, "Editar" });

            migrationBuilder.InsertData(
                table: "Acao",
                columns: new[] { "IdAcao", "AcaoMaster", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 4, false, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6216), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6216), false, "Eliminar" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 1, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9139), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9138), false, "Santo Antão" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 2, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9168), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9167), false, "São Vicente" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 3, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9169), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9169), false, "Santa Luzia" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 4, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9171), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9170), false, "São Nicolau" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 5, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9172), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9172), false, "Sal" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 6, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9173), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9173), false, "Boavista" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 7, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9175), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9174), false, "Maio" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 8, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9176), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9176), false, "Santiago" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 9, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9177), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9177), false, "Fogo" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 10, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9179), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9178), false, "Brava" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 2, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9264), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9264), false, "Caixa Económica de Cabo Verde" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 3, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9266), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9266), false, "Banco Comercial do Atlântico" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 4, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9268), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9267), false, "Banco Caboverdiano de Negócios" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 5, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9269), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9269), false, "Banco Interatlântico" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 8, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9270), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9270), false, "Banco Angolano de Investimentos" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 9, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9272), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9271), false, "International Investment Bank" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 11, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9273), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9273), false, "Ecobank Cabo Verde SA" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 1, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6307), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6307), "Administração do Sistema SGA-STIF", false, "", null, "Administração", "", "" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 2, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6351), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6350), "Gestão dos utilizadores", false, "k", 1, "Utilizador", "ListaUtilizador", "Utilizador" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 3, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6353), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6353), "Gestão dos utilizadores", false, "k", 1, "Perfil", "ListaPerfil", "Perfil" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 4, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6355), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6355), "Gestão dos utilizadores", false, "k", 1, "Menu", "ListaMenu", "MenuAcao" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 5, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6357), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6357), "Gestao de Socios", false, "", null, "Gestao de Socios", "ListaSocio", "Socio" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 6, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6364), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6363), "Estatística", false, "", null, "Parametrização", "Inicio", "Estatistica" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 7, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6365), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6365), "Instituição Financeira", false, "", 6, "Instituição Financeira", "ListaInstituicaoFinanceira", "InstituicaoFinanceira" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 8, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6367), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6367), "Agência", false, "", 6, "Agência", "ListaAgencia", "Agencia" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 9, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6369), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6369), "Tipo Quotas", false, "", 6, "Tipo Quotas", "ListaTipoQuota", "TipoQuota" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 10, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6372), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6371), "Estatística", false, "", 6, "Tipologia Sócio", "ListaTipologiaSocio", "TipologiaSocio" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 11, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6374), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6373), "Monitor", false, "", null, "Monitor", "ListaQuotasVencidas", "Monitor" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 12, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6375), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6375), "Estatística", false, "", null, "Estatística", "Inicio", "Estatistica" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 13, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6529), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6528), "Sga-Stif", false, "", null, "Sga-Stif", "Inicio", "Estatistica" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 14, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6533), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6532), "Sobre", false, "", 13, "Sobre", "Inicio", "Estatistica" });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "IdPerfil", "DataAtualizacao", "DataCriacao", "Descricao", "Editavel", "Eliminado", "Nome" },
                values: new object[] { 1, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9243), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9243), "Perfil de Administrador", false, false, "Administrador" });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "IdPerfil", "DataAtualizacao", "DataCriacao", "Descricao", "Editavel", "Eliminado", "Nome" },
                values: new object[] { 2, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9246), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9246), "Perfil de Operador", true, false, "Auditor" });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "IdPerfil", "DataAtualizacao", "DataCriacao", "Descricao", "Editavel", "Eliminado", "Nome" },
                values: new object[] { 3, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9249), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9248), "Perfil de Operador", true, false, "Operador Teste" });

            migrationBuilder.InsertData(
                table: "TipoQuota",
                columns: new[] { "IdTipoQuota", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Montante", "Priodicidade", "Tipo" },
                values: new object[] { 1, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9104), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9103), "Quinzenal", false, 500m, 1, 1 });

            migrationBuilder.InsertData(
                table: "TipoQuota",
                columns: new[] { "IdTipoQuota", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Montante", "Priodicidade", "Tipo" },
                values: new object[] { 2, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9106), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9106), "Mensal", false, 1000m, 2, 1 });

            migrationBuilder.InsertData(
                table: "TipoQuota",
                columns: new[] { "IdTipoQuota", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Montante", "Priodicidade", "Tipo" },
                values: new object[] { 3, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9108), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9108), "Trimestral", false, 3000m, 3, 1 });

            migrationBuilder.InsertData(
                table: "TipoQuota",
                columns: new[] { "IdTipoQuota", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Montante", "Priodicidade", "Tipo" },
                values: new object[] { 4, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9110), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9110), "Semestral", false, 6000m, 4, 1 });

            migrationBuilder.InsertData(
                table: "TipoQuota",
                columns: new[] { "IdTipoQuota", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Montante", "Priodicidade", "Tipo" },
                values: new object[] { 5, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9112), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9111), "Anual", false, 12000m, 5, 0 });

            migrationBuilder.InsertData(
                table: "TipologiaSocio",
                columns: new[] { "IdTipologiaSocio", "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio", "Descricao", "Eliminado", "Montante", "Prioridicidade", "Tipo" },
                values: new object[] { 1, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(8960), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(8938), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(8972), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(8973), "Normal", false, 4000m, 2, 0 });

            migrationBuilder.InsertData(
                table: "TipologiaSocio",
                columns: new[] { "IdTipologiaSocio", "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio", "Descricao", "Eliminado", "Montante", "Prioridicidade", "Tipo" },
                values: new object[] { 2, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(8975), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(8974), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(8976), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(8977), "Honorário", false, 5000m, 3, 1 });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 1, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9198), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9197), false, 8, "Praia" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 2, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9201), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9200), false, 8, "Outro" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 3, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9202), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9202), false, 2, "Mindelo" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 4, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9204), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9203), false, 5, "Santa Maria" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 5, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9206), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9205), false, 7, "Vila do Maio" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 6, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9207), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9207), false, 8, "Santa Cruz" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 7, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9209), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9208), false, 6, "Sal Rei" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 8, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9210), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9209), false, 1, "Porto Novo" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 9, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9211), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9211), false, 8, "Ribeira Grande" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 10, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9213), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9212), false, 10, "Ribeira Brava" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 11, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9214), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9213), false, 1, "Tarrafal" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 12, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9215), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9215), false, 5, "Espargos" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 13, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9217), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9216), false, 8, "Assomada" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 14, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9218), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9217), false, 8, "São Domingos" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 15, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9219), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9219), false, 9, "São Filipe" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 16, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9221), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9220), false, 9, "Mosteiros" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 17, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9222), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9222), false, 1, "Nova Sintra" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 18, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9224), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9223), false, 8, "Tarrafal (Santiano)" });

            migrationBuilder.InsertData(
                table: "MenuAcao",
                columns: new[] { "IdMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdAcao", "IdMenu", "MenuAcaoMaster" },
                values: new object[] { 1, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6754), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6753), false, 1, 1, true });

            migrationBuilder.InsertData(
                table: "MenuAcao",
                columns: new[] { "IdMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdAcao", "IdMenu", "MenuAcaoMaster" },
                values: new object[] { 2, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6769), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6768), false, 1, 2, true });

            migrationBuilder.InsertData(
                table: "MenuAcao",
                columns: new[] { "IdMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdAcao", "IdMenu", "MenuAcaoMaster" },
                values: new object[] { 3, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6770), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6770), false, 1, 3, true });

            migrationBuilder.InsertData(
                table: "MenuAcao",
                columns: new[] { "IdMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdAcao", "IdMenu", "MenuAcaoMaster" },
                values: new object[] { 4, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6772), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6771), false, 1, 4, true });

            migrationBuilder.InsertData(
                table: "MenuAcao",
                columns: new[] { "IdMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdAcao", "IdMenu", "MenuAcaoMaster" },
                values: new object[] { 5, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6773), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6773), false, 1, 5, true });

            migrationBuilder.InsertData(
                table: "MenuAcao",
                columns: new[] { "IdMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdAcao", "IdMenu", "MenuAcaoMaster" },
                values: new object[] { 6, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6776), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6775), false, 1, 6, true });

            migrationBuilder.InsertData(
                table: "MenuAcao",
                columns: new[] { "IdMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdAcao", "IdMenu", "MenuAcaoMaster" },
                values: new object[] { 7, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6778), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6777), false, 1, 7, true });

            migrationBuilder.InsertData(
                table: "MenuAcao",
                columns: new[] { "IdMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdAcao", "IdMenu", "MenuAcaoMaster" },
                values: new object[] { 8, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6779), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6779), false, 1, 8, true });

            migrationBuilder.InsertData(
                table: "MenuAcao",
                columns: new[] { "IdMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdAcao", "IdMenu", "MenuAcaoMaster" },
                values: new object[] { 9, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6781), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6780), false, 1, 9, true });

            migrationBuilder.InsertData(
                table: "MenuAcao",
                columns: new[] { "IdMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdAcao", "IdMenu", "MenuAcaoMaster" },
                values: new object[] { 10, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6783), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6782), false, 1, 10, true });

            migrationBuilder.InsertData(
                table: "MenuAcao",
                columns: new[] { "IdMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdAcao", "IdMenu", "MenuAcaoMaster" },
                values: new object[] { 11, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6785), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6784), false, 1, 11, true });

            migrationBuilder.InsertData(
                table: "MenuAcao",
                columns: new[] { "IdMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdAcao", "IdMenu", "MenuAcaoMaster" },
                values: new object[] { 12, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6786), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6786), false, 1, 12, true });

            migrationBuilder.InsertData(
                table: "MenuAcao",
                columns: new[] { "IdMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdAcao", "IdMenu", "MenuAcaoMaster" },
                values: new object[] { 13, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6788), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6787), false, 1, 13, true });

            migrationBuilder.InsertData(
                table: "MenuAcao",
                columns: new[] { "IdMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdAcao", "IdMenu", "MenuAcaoMaster" },
                values: new object[] { 14, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6789), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6789), false, 1, 14, true });

            migrationBuilder.InsertData(
                table: "Utilizador",
                columns: new[] { "IdUtilizador", "Apelido", "DataAtualizacao", "DataCriacao", "Eliminado", "Email", "Foto", "IdPerfil", "Nome", "NomeUtilizador", "PalavraPasse" },
                values: new object[] { 1, "Semedo", new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9632), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9631), false, "angelosemedo@sgastif.cv", null, 1, "Angelo", "angelosemedo", "$2a$11$/X88rmUGxGTG1LVTicTHD./FZEuLzs0gK.EnOKrDEneEXInn4u1aK" });

            migrationBuilder.InsertData(
                table: "Utilizador",
                columns: new[] { "IdUtilizador", "Apelido", "DataAtualizacao", "DataCriacao", "Eliminado", "Email", "Foto", "IdPerfil", "Nome", "NomeUtilizador", "PalavraPasse" },
                values: new object[] { 2, "Veiga", new DateTime(2022, 4, 18, 16, 23, 45, 435, DateTimeKind.Local).AddTicks(7816), new DateTime(2022, 4, 18, 16, 23, 45, 435, DateTimeKind.Local).AddTicks(7810), false, "odailtonveiga@sgastif.cv", null, 1, "Odailton", "odailtonveiga", "$2a$11$0u8/INgwrFMLIP1l9SJNsehRd3pS26IZW1fEBCMvPyIED8lk3ccXm" });

            migrationBuilder.InsertData(
                table: "Utilizador",
                columns: new[] { "IdUtilizador", "Apelido", "DataAtualizacao", "DataCriacao", "Eliminado", "Email", "Foto", "IdPerfil", "Nome", "NomeUtilizador", "PalavraPasse" },
                values: new object[] { 3, "Varela", new DateTime(2022, 4, 18, 16, 23, 45, 615, DateTimeKind.Local).AddTicks(7129), new DateTime(2022, 4, 18, 16, 23, 45, 615, DateTimeKind.Local).AddTicks(7124), false, "manuelvarela@sgastif.cv", null, 1, "Manuel", "manuelvarela", "$2a$11$ezf5Wk/NmNACgeMKS8SaMe9fUW7cOHe8jiLMK4u4m/fRJAy8ckCkm" });

            migrationBuilder.InsertData(
                table: "Utilizador",
                columns: new[] { "IdUtilizador", "Apelido", "DataAtualizacao", "DataCriacao", "Eliminado", "Email", "Foto", "IdPerfil", "Nome", "NomeUtilizador", "PalavraPasse" },
                values: new object[] { 4, "Tavares", new DateTime(2022, 4, 18, 16, 23, 45, 798, DateTimeKind.Local).AddTicks(5413), new DateTime(2022, 4, 18, 16, 23, 45, 798, DateTimeKind.Local).AddTicks(5407), false, "jair@sgastif.cv", null, 1, "Jair", "jair", "$2a$11$A.ApStmoGe1hF9/yN49Bz.yDtVj.952wvHKGdXHYag2gqQ7UJ2T7O" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 1, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9339), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9339), false, 1, 2, "Ag. Fazenda" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 2, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9342), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9342), false, 1, 2, "Ag. Mindelo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 3, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9344), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9344), false, 1, 2, "Ag. ASA" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 4, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9346), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9345), false, 13, 2, "Ag. Assomada" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 5, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9347), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9347), false, 1, 2, "Ag. Espargos" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 6, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9349), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9348), false, 9, 2, "Ag. Rª Grande" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 7, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9350), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9350), false, 1, 2, "Ag. St. Maria" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 8, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9352), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9351), false, 1, 2, "Ag. Plateau" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 9, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9353), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9353), false, 1, 2, "Ag. Monte Sossego" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 10, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9355), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9354), false, 1, 2, "Ag. Palmarejo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 11, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9356), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9356), false, 1, 2, "Ag. São Filipe" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 12, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9358), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9357), false, 1, 2, "Ag. Calheta S. Miguel" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 13, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9359), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9359), false, 1, 2, "Ag. Aeroporto da Praia" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 14, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9360), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9360), false, 7, 2, "Ag. Boavista" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 15, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9362), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9361), false, 1, 2, "Ag. Aeroporto do Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 16, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9363), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9363), false, 1, 2, "Ag. Sucupira" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 17, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9365), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9364), false, 1, 2, "Ag. CCV – São Domingos" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 18, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9366), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9365), false, 18, 2, "Ag. Tarrafal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 19, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9368), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9368), false, 1, 2, "Ag. Santa Cruz" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 20, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9370), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9369), false, 1, 2, "Ag. CCV – Porto Novo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 21, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9371), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9371), false, 1, 2, "Ag. CCV - Plateau" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 22, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9372), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9372), false, 1, 2, "Ag. A. São Filipe" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 23, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9374), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9373), false, 1, 2, "Ag. Mosteiros" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 24, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9375), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9375), false, 1, 2, "Ag. Caixa Empresas" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 25, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9377), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9376), false, 1, 2, "Ag. Coculi" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 26, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9378), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9378), false, 1, 2, "Ag. Paul" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 27, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9380), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9379), false, 1, 2, "Ag. Fonte Cónego" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 28, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9381), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9380), false, 7, 2, "Ag. Aeroporto Boavista" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 29, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9382), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9382), false, 1, 2, "Ag. Maio" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 30, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9384), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9383), false, 1, 2, "Ag. Porto Novo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 31, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9385), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9385), false, 1, 2, "Ag. Ribeira Brava" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 32, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9386), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9386), false, 1, 2, "Ag. Ribeira Brava" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 33, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9388), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9387), false, 18, 2, "Ag. Tarrafal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 34, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9389), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9389), false, 1, 3, "Ag. Praia" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 35, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9391), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9390), false, 1, 3, "Ag. S. Vicente " });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 36, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9392), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9392), false, 1, 3, "Ag. Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 37, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9394), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9393), false, 1, 3, "Ag. S. Filipe" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 38, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9395), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9395), false, 18, 3, "Ag. Tarrafal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 39, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9396), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9396), false, 1, 3, "Ag. S. Catarina" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 40, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9398), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9397), false, 1, 3, "Ag. Porto Novo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 41, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9399), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9399), false, 9, 3, "Ag. Rª Grande" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 42, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9401), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9400), false, 1, 3, "Ag. Brava" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 43, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9402), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9401), false, 1, 3, "Ag. Boavista" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 44, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9403), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9403), false, 1, 3, "Ag. S. Nicolau" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 45, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9405), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9405), false, 1, 3, "Ag. Maio" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 46, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9407), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9406), false, 1, 3, "Ag. Santa Cruz" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 47, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9408), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9408), false, 1, 3, "Ag. Praça Nova" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 48, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9433), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9432), false, 1, 3, "Ag. ASA" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 49, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9434), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9434), false, 1, 3, "Ag. Avenida" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 50, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9436), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9436), false, 1, 3, "Ag. Monte Sossego" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 51, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9437), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9437), false, 1, 3, "Ag. Fonte Filipe" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 52, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9439), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9438), false, 1, 3, "Ag. Santa Maria" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 53, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9440), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9440), false, 1, 3, "Ag. Mosteiros" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 54, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9442), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9441), false, 11, 3, "Ag. Tarrafal S. Nicolau" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 55, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9443), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9443), false, 1, 3, "Ag. ASA II" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 56, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9444), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9444), false, 1, 3, "Gabinete Empresas Sul" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 57, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9446), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9446), false, 1, 3, "Gabinete Empresas Norte" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 58, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9447), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9447), false, 1, 3, "Ag. S. Domingos" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 59, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9449), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9448), false, 1, 3, "Ag. Palmarejo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 60, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9450), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9450), false, 1, 3, "Gabinete Empresas Sul II" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 61, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9452), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9451), false, 1, 3, "Gabinete Empresas Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 62, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9453), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9453), false, 1, 3, "Prol. Ach. São Filipe" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 63, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9454), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9454), false, 1, 4, "Ag. Praia" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 64, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9456), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9455), false, 1, 4, "Ag. Mindelo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 65, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9457), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9457), false, 13, 4, "Ag. Assomada" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 66, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9459), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9458), false, 1, 4, "Ag. Aeroporto do Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 67, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9460), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9460), false, 1, 4, "Ag. Boavista" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 68, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9461), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9461), false, 1, 4, "Ag. Porto Novo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 69, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9463), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9462), false, 1, 4, "Ag. Terra Branca" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 70, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9464), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9464), false, 1, 4, "Ag. Palmarejo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 71, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9467), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9466), false, 1, 4, "Ag. Monte Sossego" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 72, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9468), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9467), false, 1, 4, "Ag. Santa Maria" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 73, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9469), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9469), false, 1, 4, "Ag. São Filipe" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 74, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9471), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9470), false, 9, 4, "Ag. Rª Grande" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 75, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9472), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9472), false, 1, 4, "ASA – Private Banking" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 76, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9474), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9473), false, 1, 4, "Ag. Fazenda" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 77, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9475), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9474), false, 1, 4, "Ag. Órgãos" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 78, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9476), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9476), false, 1, 4, "Ag. Santa Cruz" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 79, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9478), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9477), false, 1, 4, "Ag. Ponta do Sol" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 80, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9479), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9479), false, 1, 4, "Ag. Maio" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 81, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9485), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9484), false, 1, 4, "Centro de empresas" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 82, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9486), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9486), false, 1, 4, "Centro de empresas II" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 83, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9488), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9487), false, 1, 4, "Ag. Sede" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 84, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9489), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9489), false, 1, 4, "Núcleo N/ Residentes" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 85, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9490), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9490), false, 1, 5, "Ag. Sede" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 86, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9492), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9491), false, 1, 5, "Ag. ASA" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 87, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9493), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9493), false, 1, 5, "Ag. Mindelo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 88, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9495), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9494), false, 1, 5, "Ag. Plateau" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 89, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9496), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9496), false, 1, 5, "Ag. Espargos" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 90, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9498), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9497), false, 1, 5, "Ag. Santa Maria" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 91, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9499), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9498), false, 7, 5, "ag. Sal Rei – Boavista" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 92, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9500), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9500), false, 13, 5, "Ag. Assomada" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 93, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9502), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9501), false, 1, 5, "Ag. Achada Grande Trás" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 94, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9503), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9503), false, 1, 5, "Gab. Particulares (Praia)" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 95, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9505), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9504), false, 1, 5, "Gab. Empresas (Praia)" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 96, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9506), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9505), false, 1, 8, "Ag. Sede" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 97, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9508), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9508), false, 1, 8, "Ag. Plateau" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 98, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9510), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9509), false, 1, 8, "Ag ASA" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 99, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9535), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9534), false, 1, 8, "Ag. Mindelo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 100, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9536), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9536), false, 1, 8, "Ag. Espargos" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 101, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9537), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9537), false, 1, 9, "Ag. Sede" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 102, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9539), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9538), false, 1, 9, "Serviços Centrais" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 103, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9540), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9540), false, 1, 9, "Emigrantes" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 104, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9542), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9541), false, 1, 9, "Particulares Classic" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 105, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9543), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9543), false, 1, 9, "Afluentes" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 106, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9544), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9544), false, 1, 9, "Private" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 107, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9546), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9545), false, 1, 9, "Institucionais" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 108, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9547), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9547), false, 1, 9, "PME Nacionais" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 109, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9549), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9548), false, 1, 9, "Grandes Empresas Nacionais" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 110, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9550), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9550), false, 1, 9, "Corporate Internacional" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 111, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9551), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9551), false, 1, 9, "Ag. Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 112, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9553), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9552), false, 1, 9, "Emigrantes Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 113, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9554), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9554), false, 1, 9, "Particulares Classic Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 114, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9556), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9555), false, 1, 9, "Afluentes Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 115, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9557), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9557), false, 1, 9, "Private Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 116, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9558), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9558), false, 1, 9, "Institucionais Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 117, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9560), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9559), false, 1, 9, "PME Nacionais Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 118, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9561), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9561), false, 1, 9, "Grandes Empresas Nacionais Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 119, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9562), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9562), false, 1, 11, "Ag. Sede - Praia" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 120, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9564), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9563), false, 13, 8, "Ag. Assomada" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 121, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9565), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9565), false, 1, 8, "Ag. Sta Maria " });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 122, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9567), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9566), false, 1, 8, "Agencia Sal-Rei " });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 123, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9568), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9568), false, 1, 8, "Agencia S.Filipe " });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 124, new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9570), new DateTime(2022, 4, 18, 16, 23, 45, 270, DateTimeKind.Local).AddTicks(9570), false, 1, 8, "Ag. Montsu " });

            migrationBuilder.InsertData(
                table: "PerfilMenuAcao",
                columns: new[] { "IdPerfilMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdMenuAcao", "IdPPerfil" },
                values: new object[] { 1, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6829), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6828), false, 1, 1 });

            migrationBuilder.InsertData(
                table: "PerfilMenuAcao",
                columns: new[] { "IdPerfilMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdMenuAcao", "IdPPerfil" },
                values: new object[] { 2, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6839), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6838), false, 2, 1 });

            migrationBuilder.InsertData(
                table: "PerfilMenuAcao",
                columns: new[] { "IdPerfilMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdMenuAcao", "IdPPerfil" },
                values: new object[] { 3, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6840), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6840), false, 3, 1 });

            migrationBuilder.InsertData(
                table: "PerfilMenuAcao",
                columns: new[] { "IdPerfilMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdMenuAcao", "IdPPerfil" },
                values: new object[] { 4, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6842), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6841), false, 4, 1 });

            migrationBuilder.InsertData(
                table: "PerfilMenuAcao",
                columns: new[] { "IdPerfilMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdMenuAcao", "IdPPerfil" },
                values: new object[] { 5, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6843), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6842), false, 5, 1 });

            migrationBuilder.InsertData(
                table: "PerfilMenuAcao",
                columns: new[] { "IdPerfilMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdMenuAcao", "IdPPerfil" },
                values: new object[] { 6, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6845), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6845), false, 6, 1 });

            migrationBuilder.InsertData(
                table: "PerfilMenuAcao",
                columns: new[] { "IdPerfilMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdMenuAcao", "IdPPerfil" },
                values: new object[] { 7, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6846), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6846), false, 7, 1 });

            migrationBuilder.InsertData(
                table: "PerfilMenuAcao",
                columns: new[] { "IdPerfilMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdMenuAcao", "IdPPerfil" },
                values: new object[] { 8, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6848), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6847), false, 8, 1 });

            migrationBuilder.InsertData(
                table: "PerfilMenuAcao",
                columns: new[] { "IdPerfilMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdMenuAcao", "IdPPerfil" },
                values: new object[] { 9, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6849), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6849), false, 9, 1 });

            migrationBuilder.InsertData(
                table: "PerfilMenuAcao",
                columns: new[] { "IdPerfilMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdMenuAcao", "IdPPerfil" },
                values: new object[] { 10, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6851), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6851), false, 10, 1 });

            migrationBuilder.InsertData(
                table: "PerfilMenuAcao",
                columns: new[] { "IdPerfilMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdMenuAcao", "IdPPerfil" },
                values: new object[] { 11, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6853), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6852), false, 11, 1 });

            migrationBuilder.InsertData(
                table: "PerfilMenuAcao",
                columns: new[] { "IdPerfilMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdMenuAcao", "IdPPerfil" },
                values: new object[] { 12, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6854), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6853), false, 12, 1 });

            migrationBuilder.InsertData(
                table: "PerfilMenuAcao",
                columns: new[] { "IdPerfilMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdMenuAcao", "IdPPerfil" },
                values: new object[] { 13, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6855), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6855), false, 13, 1 });

            migrationBuilder.InsertData(
                table: "PerfilMenuAcao",
                columns: new[] { "IdPerfilMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdMenuAcao", "IdPPerfil" },
                values: new object[] { 14, new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6857), new DateTime(2022, 4, 18, 16, 23, 45, 986, DateTimeKind.Local).AddTicks(6856), false, 14, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Agencia_IdCidade",
                table: "Agencia",
                column: "IdCidade");

            migrationBuilder.CreateIndex(
                name: "IX_Agencia_IdInstituicaoFinanceira",
                table: "Agencia",
                column: "IdInstituicaoFinanceira");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiario_IdSocio",
                table: "Beneficiario",
                column: "IdSocio");

            migrationBuilder.CreateIndex(
                name: "IX_Cidade_IdIlha",
                table: "Cidade",
                column: "IdIlha");

            migrationBuilder.CreateIndex(
                name: "IX_EstadoSocio_IdSocio",
                table: "EstadoSocio",
                column: "IdSocio");

            migrationBuilder.CreateIndex(
                name: "IX_JoiaSocio_IdJoia",
                table: "JoiaSocio",
                column: "IdJoia");

            migrationBuilder.CreateIndex(
                name: "IX_JoiaSocio_IdSocio",
                table: "JoiaSocio",
                column: "IdSocio");

            migrationBuilder.CreateIndex(
                name: "IX_MenuAcao_IdAcao",
                table: "MenuAcao",
                column: "IdAcao");

            migrationBuilder.CreateIndex(
                name: "IX_MenuAcao_IdMenu",
                table: "MenuAcao",
                column: "IdMenu");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilMenuAcao_IdMenuAcao",
                table: "PerfilMenuAcao",
                column: "IdMenuAcao");

            migrationBuilder.CreateIndex(
                name: "IX_PerfilMenuAcao_IdPPerfil",
                table: "PerfilMenuAcao",
                column: "IdPPerfil");

            migrationBuilder.CreateIndex(
                name: "IX_QuotaSocio_IdPeriodoQuota",
                table: "QuotaSocio",
                column: "IdPeriodoQuota");

            migrationBuilder.CreateIndex(
                name: "IX_QuotaSocio_IdSocio",
                table: "QuotaSocio",
                column: "IdSocio");

            migrationBuilder.CreateIndex(
                name: "IX_Socio_IdAgencia",
                table: "Socio",
                column: "IdAgencia");

            migrationBuilder.CreateIndex(
                name: "IX_Socio_IdTipologiaSocio",
                table: "Socio",
                column: "IdTipologiaSocio");

            migrationBuilder.CreateIndex(
                name: "IX_Socio_IdTipoQuota",
                table: "Socio",
                column: "IdTipoQuota");

            migrationBuilder.CreateIndex(
                name: "IX_Utilizador_IdPerfil",
                table: "Utilizador",
                column: "IdPerfil");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beneficiario");

            migrationBuilder.DropTable(
                name: "EstadoSocio");

            migrationBuilder.DropTable(
                name: "JoiaSocio");

            migrationBuilder.DropTable(
                name: "LogAtividade");

            migrationBuilder.DropTable(
                name: "PerfilMenuAcao");

            migrationBuilder.DropTable(
                name: "QuotaSocio");

            migrationBuilder.DropTable(
                name: "Utilizador");

            migrationBuilder.DropTable(
                name: "Joia");

            migrationBuilder.DropTable(
                name: "MenuAcao");

            migrationBuilder.DropTable(
                name: "PeriodoQuota");

            migrationBuilder.DropTable(
                name: "Socio");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropTable(
                name: "Acao");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Agencia");

            migrationBuilder.DropTable(
                name: "TipologiaSocio");

            migrationBuilder.DropTable(
                name: "TipoQuota");

            migrationBuilder.DropTable(
                name: "Cidade");

            migrationBuilder.DropTable(
                name: "InstituicaoFinanceira");

            migrationBuilder.DropTable(
                name: "Ilha");
        }
    }
}
