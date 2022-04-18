using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class inicio : Migration
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
                values: new object[] { 1, false, new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5140), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5130), false, "Criar" });

            migrationBuilder.InsertData(
                table: "Acao",
                columns: new[] { "IdAcao", "AcaoMaster", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 2, false, new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5150), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5140), false, "Editar" });

            migrationBuilder.InsertData(
                table: "Acao",
                columns: new[] { "IdAcao", "AcaoMaster", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 3, false, new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5150), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5150), false, "Eliminar" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 1, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5290), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5290), false, "Santo Antão" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 2, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5300), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5290), false, "São Vicente" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 3, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5310), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5310), false, "Santa Luzia" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 4, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5310), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5310), false, "São Nicolau" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 5, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5320), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5310), false, "Sal" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 6, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5320), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5320), false, "Boavista" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 7, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5320), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5320), false, "Maio" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 8, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5320), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5320), false, "Santiago" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 9, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5330), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5330), false, "Fogo" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 10, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5330), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5330), false, "Brava" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 2, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5480), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5480), false, "Caixa Económica de Cabo Verde" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 3, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5490), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5480), false, "Banco Comercial do Atlântico" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 4, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5490), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5490), false, "Banco Caboverdiano de Negócios" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 5, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5490), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5490), false, "Banco Interatlântico" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 8, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5490), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5490), false, "Banco Angolano de Investimentos" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 9, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5500), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5500), false, "International Investment Bank" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 11, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5500), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5500), false, "Ecobank Cabo Verde SA" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 1, new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5190), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5180), "Administração do Sistema SGA-STIF", false, "", null, "Administração", "", "" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 2, new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5190), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5190), "Gestão dos utilizadores", false, "k", 1, "Utilizador", "ListaUtilizador", "Utilizador" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 3, new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5200), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5190), "Gestão dos utilizadores", false, "k", 1, "Perfil", "ListaPerfil", "Perfil" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 4, new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5200), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5200), "Gestão dos utilizadores", false, "k", 1, "Menu", "ListaMenu", "MenuAcao" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 5, new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5200), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5200), "Gestao de Socios", false, "", null, "Gestao de Socios", "ListaSocio", "Socio" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 6, new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5210), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5210), "Estatística", false, "", null, "Parametrização", "Inicio", "Estatistica" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 7, new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5210), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5210), "Instituição Financeira", false, "", 6, "Instituição Financeira", "ListaInstituicaoFinanceira", "InstituicaoFinanceira" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 8, new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5210), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5210), "Agência", false, "", 6, "Agência", "ListaAgencia", "Agencia" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 9, new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5220), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5220), "Tipo Quotas", false, "", 6, "Tipo Quotas", "ListaTipoQuota", "TipoQuota" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 10, new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5220), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5220), "Estatística", false, "", 6, "Tipologia Sócio", "ListaTipologiaSocio", "TipologiaSocio" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 11, new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5230), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5220), "Estatística", false, "", null, "Estatística", "Inicio", "Estatistica" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 12, new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5230), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5230), "Sga-Stif", false, "", null, "Sga-Stif", "Inicio", "Estatistica" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[] { 13, new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5230), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5230), "Sobre", false, "", 12, "Sobre", "Inicio", "Estatistica" });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "IdPerfil", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Nome" },
                values: new object[] { 1, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5460), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5450), "Perfil de Administrador", false, "Administrador" });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "IdPerfil", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Nome" },
                values: new object[] { 2, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5460), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5460), "Perfil de Operador", false, "Operado" });

            migrationBuilder.InsertData(
                table: "TipoQuota",
                columns: new[] { "IdTipoQuota", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Montante", "Priodicidade", "Tipo" },
                values: new object[] { 1, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5240), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5240), "Quinzenal", false, 500m, 1, 1 });

            migrationBuilder.InsertData(
                table: "TipoQuota",
                columns: new[] { "IdTipoQuota", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Montante", "Priodicidade", "Tipo" },
                values: new object[] { 2, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5250), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5250), "Mensal", false, 1000m, 2, 1 });

            migrationBuilder.InsertData(
                table: "TipoQuota",
                columns: new[] { "IdTipoQuota", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Montante", "Priodicidade", "Tipo" },
                values: new object[] { 3, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5250), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5250), "Trimestral", false, 3000m, 3, 1 });

            migrationBuilder.InsertData(
                table: "TipoQuota",
                columns: new[] { "IdTipoQuota", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Montante", "Priodicidade", "Tipo" },
                values: new object[] { 4, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5260), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5260), "Semestral", false, 6000m, 4, 1 });

            migrationBuilder.InsertData(
                table: "TipoQuota",
                columns: new[] { "IdTipoQuota", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Montante", "Priodicidade", "Tipo" },
                values: new object[] { 5, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5260), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5260), "Anual", false, 12000m, 5, 0 });

            migrationBuilder.InsertData(
                table: "TipologiaSocio",
                columns: new[] { "IdTipologiaSocio", "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio", "Descricao", "Eliminado", "Montante", "Prioridicidade", "Tipo" },
                values: new object[] { 1, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5010), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(4980), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5030), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5030), "Normal", false, 4000m, 2, 0 });

            migrationBuilder.InsertData(
                table: "TipologiaSocio",
                columns: new[] { "IdTipologiaSocio", "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio", "Descricao", "Eliminado", "Montante", "Prioridicidade", "Tipo" },
                values: new object[] { 2, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5030), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5030), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5030), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5040), "Honorário", false, 5000m, 3, 1 });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 1, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5360), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5350), false, 8, "Praia" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 2, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5360), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5360), false, 8, "Outro" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 3, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5360), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5360), false, 2, "Mindelo" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 4, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5370), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5370), false, 5, "Santa Maria" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 5, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5370), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5370), false, 7, "Vila do Maio" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 6, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5370), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5370), false, 8, "Santa Cruz" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 7, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5380), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5380), false, 6, "Sal Rei" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 8, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5380), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5380), false, 1, "Porto Novo" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 9, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5380), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5380), false, 8, "Ribeira Grande" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 10, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5390), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5390), false, 10, "Ribeira Brava" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 11, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5390), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5390), false, 1, "Tarrafal" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 12, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5390), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5390), false, 5, "Espargos" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 13, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5400), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5400), false, 8, "Assomada" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 14, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5400), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5400), false, 8, "São Domingos" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 15, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5410), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5410), false, 9, "São Filipe" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 16, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5410), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5410), false, 9, "Mosteiros" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 17, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5420), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5410), false, 1, "Nova Sintra" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 18, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5420), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5420), false, 8, "Tarrafal (Santiano)" });

            migrationBuilder.InsertData(
                table: "Utilizador",
                columns: new[] { "IdUtilizador", "Apelido", "DataAtualizacao", "DataCriacao", "Eliminado", "Email", "Foto", "IdPerfil", "Nome", "NomeUtilizador", "PalavraPasse" },
                values: new object[] { 1, "Semedo", new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(6030), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(6030), false, "angelosemedo@sgastif.cv", null, 1, "Angelo", "angelosemedo", "$2a$11$pAgWZeIMfbRsr/2mb.N5g.XBG0DMOhtWbg7Joq1jH8iA75.cADhJq" });

            migrationBuilder.InsertData(
                table: "Utilizador",
                columns: new[] { "IdUtilizador", "Apelido", "DataAtualizacao", "DataCriacao", "Eliminado", "Email", "Foto", "IdPerfil", "Nome", "NomeUtilizador", "PalavraPasse" },
                values: new object[] { 2, "Veiga", new DateTime(2022, 4, 14, 15, 31, 24, 458, DateTimeKind.Local).AddTicks(3890), new DateTime(2022, 4, 14, 15, 31, 24, 458, DateTimeKind.Local).AddTicks(3870), false, "odailtonveiga@sgastif.cv", null, 1, "Odailton", "odailtonveiga", "$2a$11$oRJxOwoiUf3l0XhfbBSh6OE5J2M0YZzq0OTPieX9fewUtLMXkZSPy" });

            migrationBuilder.InsertData(
                table: "Utilizador",
                columns: new[] { "IdUtilizador", "Apelido", "DataAtualizacao", "DataCriacao", "Eliminado", "Email", "Foto", "IdPerfil", "Nome", "NomeUtilizador", "PalavraPasse" },
                values: new object[] { 3, "Varela", new DateTime(2022, 4, 14, 15, 31, 24, 641, DateTimeKind.Local).AddTicks(9090), new DateTime(2022, 4, 14, 15, 31, 24, 641, DateTimeKind.Local).AddTicks(9070), false, "manuelvarela@sgastif.cv", null, 1, "Manuel", "manuelvarela", "$2a$11$VX1v4sTkAp5oPWviXt0kGu7FuymEdYtv0RYWXa.CVyXySQ21fqZW2" });

            migrationBuilder.InsertData(
                table: "Utilizador",
                columns: new[] { "IdUtilizador", "Apelido", "DataAtualizacao", "DataCriacao", "Eliminado", "Email", "Foto", "IdPerfil", "Nome", "NomeUtilizador", "PalavraPasse" },
                values: new object[] { 4, "Tavares", new DateTime(2022, 4, 14, 15, 31, 24, 823, DateTimeKind.Local).AddTicks(6140), new DateTime(2022, 4, 14, 15, 31, 24, 823, DateTimeKind.Local).AddTicks(6130), false, "jair@sgastif.cv", null, 1, "Jair", "jair", "$2a$11$fs8Ixm2w688EbtKbrgL9M.1eFcBBis.L1Z9jduCjcPu9TlY9wKjJS" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 1, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5530), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5530), false, 1, 2, "Ag. Fazenda" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 2, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5530), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5530), false, 1, 2, "Ag. Mindelo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 3, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5540), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5540), false, 1, 2, "Ag. ASA" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 4, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5540), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5540), false, 13, 2, "Ag. Assomada" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 5, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5540), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5540), false, 1, 2, "Ag. Espargos" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 6, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5550), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5550), false, 9, 2, "Ag. Rª Grande" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 7, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5550), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5550), false, 1, 2, "Ag. St. Maria" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 8, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5550), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5550), false, 1, 2, "Ag. Plateau" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 9, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5560), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5560), false, 1, 2, "Ag. Monte Sossego" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 10, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5560), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5560), false, 1, 2, "Ag. Palmarejo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 11, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5560), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5560), false, 1, 2, "Ag. São Filipe" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 12, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5570), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5560), false, 1, 2, "Ag. Calheta S. Miguel" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 13, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5570), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5570), false, 1, 2, "Ag. Aeroporto da Praia" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 14, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5580), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5570), false, 7, 2, "Ag. Boavista" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 15, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5580), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5580), false, 1, 2, "Ag. Aeroporto do Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 16, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5580), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5580), false, 1, 2, "Ag. Sucupira" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 17, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5590), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5590), false, 1, 2, "Ag. CCV – São Domingos" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 18, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5590), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5590), false, 18, 2, "Ag. Tarrafal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 19, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5590), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5590), false, 1, 2, "Ag. Santa Cruz" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 20, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5600), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5600), false, 1, 2, "Ag. CCV – Porto Novo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 21, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5600), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5600), false, 1, 2, "Ag. CCV - Plateau" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 22, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5600), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5600), false, 1, 2, "Ag. A. São Filipe" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 23, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5610), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5610), false, 1, 2, "Ag. Mosteiros" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 24, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5610), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5610), false, 1, 2, "Ag. Caixa Empresas" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 25, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5610), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5610), false, 1, 2, "Ag. Coculi" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 26, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5620), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5620), false, 1, 2, "Ag. Paul" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 27, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5620), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5620), false, 1, 2, "Ag. Fonte Cónego" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 28, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5620), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5620), false, 7, 2, "Ag. Aeroporto Boavista" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 29, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5630), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5620), false, 1, 2, "Ag. Maio" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 30, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5630), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5630), false, 1, 2, "Ag. Porto Novo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 31, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5630), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5630), false, 1, 2, "Ag. Ribeira Brava" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 32, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5640), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5630), false, 1, 2, "Ag. Ribeira Brava" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 33, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5640), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5640), false, 18, 2, "Ag. Tarrafal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 34, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5640), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5640), false, 1, 3, "Ag. Praia" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 35, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5650), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5640), false, 1, 3, "Ag. S. Vicente " });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 36, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5650), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5650), false, 1, 3, "Ag. Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 37, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5650), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5650), false, 1, 3, "Ag. S. Filipe" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 38, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5650), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5650), false, 18, 3, "Ag. Tarrafal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 39, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5660), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5660), false, 1, 3, "Ag. S. Catarina" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 40, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5660), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5660), false, 1, 3, "Ag. Porto Novo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 41, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5670), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5670), false, 9, 3, "Ag. Rª Grande" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 42, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5670), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5670), false, 1, 3, "Ag. Brava" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 43, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5670), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5670), false, 1, 3, "Ag. Boavista" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 44, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5680), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5680), false, 1, 3, "Ag. S. Nicolau" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 45, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5680), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5680), false, 1, 3, "Ag. Maio" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 46, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5690), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5680), false, 1, 3, "Ag. Santa Cruz" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 47, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5690), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5690), false, 1, 3, "Ag. Praça Nova" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 48, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5690), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5690), false, 1, 3, "Ag. ASA" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 49, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5690), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5690), false, 1, 3, "Ag. Avenida" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 50, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5700), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5700), false, 1, 3, "Ag. Monte Sossego" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 51, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5710), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5710), false, 1, 3, "Ag. Fonte Filipe" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 52, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5710), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5710), false, 1, 3, "Ag. Santa Maria" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 53, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5720), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5720), false, 1, 3, "Ag. Mosteiros" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 54, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5720), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5720), false, 11, 3, "Ag. Tarrafal S. Nicolau" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 55, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5730), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5720), false, 1, 3, "Ag. ASA II" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 56, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5730), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5730), false, 1, 3, "Gabinete Empresas Sul" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 57, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5730), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5730), false, 1, 3, "Gabinete Empresas Norte" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 58, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5740), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5740), false, 1, 3, "Ag. S. Domingos" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 59, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5740), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5740), false, 1, 3, "Ag. Palmarejo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 60, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5740), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5740), false, 1, 3, "Gabinete Empresas Sul II" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 61, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5750), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5750), false, 1, 3, "Gabinete Empresas Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 62, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5750), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5750), false, 1, 3, "Prol. Ach. São Filipe" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 63, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5750), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5750), false, 1, 4, "Ag. Praia" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 64, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5760), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5760), false, 1, 4, "Ag. Mindelo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 65, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5760), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5760), false, 13, 4, "Ag. Assomada" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 66, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5770), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5770), false, 1, 4, "Ag. Aeroporto do Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 67, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5770), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5770), false, 1, 4, "Ag. Boavista" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 68, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5770), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5770), false, 1, 4, "Ag. Porto Novo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 69, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5780), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5780), false, 1, 4, "Ag. Terra Branca" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 70, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5780), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5780), false, 1, 4, "Ag. Palmarejo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 71, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5780), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5780), false, 1, 4, "Ag. Monte Sossego" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 72, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5790), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5790), false, 1, 4, "Ag. Santa Maria" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 73, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5790), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5790), false, 1, 4, "Ag. São Filipe" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 74, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5790), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5790), false, 9, 4, "Ag. Rª Grande" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 75, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5800), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5800), false, 1, 4, "ASA – Private Banking" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 76, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5800), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5800), false, 1, 4, "Ag. Fazenda" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 77, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5810), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5800), false, 1, 4, "Ag. Órgãos" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 78, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5810), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5810), false, 1, 4, "Ag. Santa Cruz" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 79, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5810), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5810), false, 1, 4, "Ag. Ponta do Sol" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 80, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5820), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5810), false, 1, 4, "Ag. Maio" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 81, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5820), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5820), false, 1, 4, "Centro de empresas" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 82, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5820), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5820), false, 1, 4, "Centro de empresas II" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 83, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5830), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5820), false, 1, 4, "Ag. Sede" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 84, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5830), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5830), false, 1, 4, "Núcleo N/ Residentes" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 85, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5830), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5830), false, 1, 5, "Ag. Sede" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 86, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5840), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5840), false, 1, 5, "Ag. ASA" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 87, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5840), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5840), false, 1, 5, "Ag. Mindelo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 88, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5840), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5840), false, 1, 5, "Ag. Plateau" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 89, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5850), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5850), false, 1, 5, "Ag. Espargos" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 90, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5850), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5850), false, 1, 5, "Ag. Santa Maria" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 91, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5850), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5850), false, 7, 5, "ag. Sal Rei – Boavista" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 92, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5860), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5860), false, 13, 5, "Ag. Assomada" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 93, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5860), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5860), false, 1, 5, "Ag. Achada Grande Trás" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 94, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5870), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5870), false, 1, 5, "Gab. Particulares (Praia)" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 95, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5870), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5870), false, 1, 5, "Gab. Empresas (Praia)" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 96, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5870), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5870), false, 1, 8, "Ag. Sede" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 97, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5880), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5880), false, 1, 8, "Ag. Plateau" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 98, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5880), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5880), false, 1, 8, "Ag ASA" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 99, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5880), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5880), false, 1, 8, "Ag. Mindelo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 100, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5890), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5890), false, 1, 8, "Ag. Espargos" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 101, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5900), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5900), false, 1, 9, "Ag. Sede" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 102, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5900), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5900), false, 1, 9, "Serviços Centrais" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 103, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5910), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5900), false, 1, 9, "Emigrantes" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 104, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5910), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5910), false, 1, 9, "Particulares Classic" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 105, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5910), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5910), false, 1, 9, "Afluentes" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 106, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5920), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5910), false, 1, 9, "Private" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 107, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5920), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5920), false, 1, 9, "Institucionais" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 108, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5920), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5920), false, 1, 9, "PME Nacionais" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 109, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5930), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5920), false, 1, 9, "Grandes Empresas Nacionais" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 110, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5930), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5930), false, 1, 9, "Corporate Internacional" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 111, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5930), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5930), false, 1, 9, "Ag. Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 112, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5930), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5930), false, 1, 9, "Emigrantes Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 113, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5940), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5940), false, 1, 9, "Particulares Classic Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 114, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5940), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5940), false, 1, 9, "Afluentes Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 115, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5940), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5940), false, 1, 9, "Private Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 116, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5950), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5950), false, 1, 9, "Institucionais Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 117, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5950), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5950), false, 1, 9, "PME Nacionais Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 118, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5950), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5950), false, 1, 9, "Grandes Empresas Nacionais Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 119, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5960), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5960), false, 1, 11, "Ag. Sede - Praia" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 120, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5960), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5960), false, 13, 8, "Ag. Assomada" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 121, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5960), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5960), false, 1, 8, "Ag. Sta Maria " });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 122, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5970), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5960), false, 1, 8, "Agencia Sal-Rei " });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 123, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5970), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5970), false, 1, 8, "Agencia S.Filipe " });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 124, new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5970), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5970), false, 1, 8, "Ag. Montsu " });

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
