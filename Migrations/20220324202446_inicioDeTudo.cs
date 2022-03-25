using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class inicioDeTudo : Migration
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
                    Foto = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Apelido = table.Column<string>(type: "TEXT", nullable: false),
                    Nif = table.Column<string>(type: "TEXT", nullable: false),
                    CinBi = table.Column<string>(type: "TEXT", nullable: false),
                    NumeroPassaporte = table.Column<string>(type: "TEXT", nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Sexo = table.Column<int>(type: "INTEGER", nullable: false),
                    NumeroDeTelefone = table.Column<string>(type: "TEXT", nullable: false),
                    IdAgencia = table.Column<int>(type: "INTEGER", nullable: false),
                    IdTipologiaSocio = table.Column<int>(type: "INTEGER", nullable: false),
                    IdTipoQuota = table.Column<int>(type: "INTEGER", nullable: false),
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
                    DataFim = table.Column<DateTime>(type: "TEXT", nullable: false),
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
                columns: new[] { "IdAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 1, new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1880), new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1850), false, "Criar" });

            migrationBuilder.InsertData(
                table: "Acao",
                columns: new[] { "IdAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 2, new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1890), new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1890), false, "Editar" });

            migrationBuilder.InsertData(
                table: "Acao",
                columns: new[] { "IdAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 3, new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1890), new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1890), false, "Eliminar" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 1, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8520), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8520), false, "Santo Antão" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 2, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8520), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8520), false, "São Vicente" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 3, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8530), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8530), false, "Santa Luzia" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 4, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8530), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8530), false, "São Nicolau" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 5, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8530), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8530), false, "Sal" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 6, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8540), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8540), false, "Boavista" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 7, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8540), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8540), false, "Maio" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 8, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8540), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8540), false, "Santiago" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 9, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8550), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8550), false, "Fogo" });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 10, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8550), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8550), false, "Brava" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 1, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8700), false, "BCA" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "IdMenuPai", "Nome" },
                values: new object[] { 1, new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1940), new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1940), "Administração do Sistema SGA-STIF", false, null, "Administração" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "IdMenuPai", "Nome" },
                values: new object[] { 2, new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1940), new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1940), "Gestão dos utilizadores", false, 1, "Utilizador" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "IdMenuPai", "Nome" },
                values: new object[] { 3, new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1950), new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1940), "Gestão dos utilizadores", false, 1, "Perfil" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "IdMenuPai", "Nome" },
                values: new object[] { 4, new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1950), new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1950), "Gestão dos utilizadores", false, 1, "Menu" });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "IdPerfil", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado" },
                values: new object[] { 1, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8680), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8680), "Administrador", false });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "IdPerfil", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado" },
                values: new object[] { 2, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8680), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8680), "Operador", false });

            migrationBuilder.InsertData(
                table: "TipoQuota",
                columns: new[] { "IdTipoQuota", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Montante", "Priodicidade", "Tipo" },
                values: new object[] { 1, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8430), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8420), "Quinzenal", false, 0m, 1, 0 });

            migrationBuilder.InsertData(
                table: "TipoQuota",
                columns: new[] { "IdTipoQuota", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Montante", "Priodicidade", "Tipo" },
                values: new object[] { 2, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8440), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8430), "Mensal", false, 0m, 1, 0 });

            migrationBuilder.InsertData(
                table: "TipoQuota",
                columns: new[] { "IdTipoQuota", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Montante", "Priodicidade", "Tipo" },
                values: new object[] { 3, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8470), "Trimestral", false, 0m, 1, 0 });

            migrationBuilder.InsertData(
                table: "TipoQuota",
                columns: new[] { "IdTipoQuota", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Montante", "Priodicidade", "Tipo" },
                values: new object[] { 4, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8480), "Semestral", false, 0m, 1, 0 });

            migrationBuilder.InsertData(
                table: "TipoQuota",
                columns: new[] { "IdTipoQuota", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Montante", "Priodicidade", "Tipo" },
                values: new object[] { 5, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8490), "Anual", false, 0m, 1, 0 });

            migrationBuilder.InsertData(
                table: "TipologiaSocio",
                columns: new[] { "IdTipologiaSocio", "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio", "Descricao", "Eliminado", "Montante", "Prioridicidade", "Tipo" },
                values: new object[] { 1, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8220), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8180), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8230), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8230), "Normal", false, 0m, 1, 0 });

            migrationBuilder.InsertData(
                table: "TipologiaSocio",
                columns: new[] { "IdTipologiaSocio", "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio", "Descricao", "Eliminado", "Montante", "Prioridicidade", "Tipo" },
                values: new object[] { 2, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8240), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8240), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8240), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8240), "Honorário", false, 0m, 1, 1 });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 1, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8580), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8580), false, 8, "Praia" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 2, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8580), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8580), false, 8, "Outro" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 3, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8590), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8590), false, 2, "Mindelo" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 4, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8590), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8590), false, 5, "Santa Maria" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 5, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8600), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8600), false, 7, "Vila do Maio" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 6, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8600), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8600), false, 8, "Santa Cruz" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 7, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8600), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8600), false, 6, "Sal Rei" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 8, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8610), false, 1, "Porto Novo" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 9, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8610), false, 8, "Ribeira Grande" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 10, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8610), false, 10, "Ribeira Brava" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 11, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8620), false, 1, "Tarrafal" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 12, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8620), false, 5, "Espargos" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 13, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8620), false, 8, "Assomada" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 14, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8630), false, 8, "São Domingos" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 15, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8630), false, 9, "São Filipe" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 16, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8640), false, 9, "Mosteiros" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 17, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8640), false, 1, "Nova Sintra" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 18, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8640), false, 8, "Tarrafal (Santiano)" });

            migrationBuilder.InsertData(
                table: "Utilizador",
                columns: new[] { "IdUtilizador", "Apelido", "DataAtualizacao", "DataCriacao", "Eliminado", "Email", "Foto", "IdPerfil", "Nome", "NomeUtilizador", "PalavraPasse" },
                values: new object[] { 1, "Semedo", new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8760), false, "angelosemedo@sgastif.cv", null, 1, "Angelo", "angelosemedo", "$2a$11$br5lE2IOlP/P9RyIO0PYkev/jpa2xzJoW.KZLHVvJPXskzqnHHu62" });

            migrationBuilder.InsertData(
                table: "Utilizador",
                columns: new[] { "IdUtilizador", "Apelido", "DataAtualizacao", "DataCriacao", "Eliminado", "Email", "Foto", "IdPerfil", "Nome", "NomeUtilizador", "PalavraPasse" },
                values: new object[] { 2, "Veiga", new DateTime(2022, 3, 24, 19, 24, 46, 170, DateTimeKind.Local).AddTicks(30), new DateTime(2022, 3, 24, 19, 24, 46, 170, DateTimeKind.Local), false, "odailtonveiga@sgastif.cv", null, 1, "Odailton", "odailtonveiga", "$2a$11$dQilmQZfGvY3PMGN4hIhsOZs1C9OLi167JpAtu1n0uFSONchSUlgC" });

            migrationBuilder.InsertData(
                table: "Utilizador",
                columns: new[] { "IdUtilizador", "Apelido", "DataAtualizacao", "DataCriacao", "Eliminado", "Email", "Foto", "IdPerfil", "Nome", "NomeUtilizador", "PalavraPasse" },
                values: new object[] { 3, "Varela", new DateTime(2022, 3, 24, 19, 24, 46, 353, DateTimeKind.Local).AddTicks(3880), new DateTime(2022, 3, 24, 19, 24, 46, 353, DateTimeKind.Local).AddTicks(3850), false, "manuelvarela@sgastif.cv", null, 1, "Manuel", "manuelvarela", "$2a$11$jY3uk1RoLV0cLMVMbPT9Uut69dBjFqAKdPRiloPPsdXa2V6yNDiOq" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 1, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8740), false, 8, 1, "BCA" });

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
