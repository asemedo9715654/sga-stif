using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class sqlserverInicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acao",
                columns: table => new
                {
                    IdAcao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcaoMaster = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acao", x => x.IdAcao);
                });

            migrationBuilder.CreateTable(
                name: "Ilha",
                columns: table => new
                {
                    IdIlha = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilha", x => x.IdIlha);
                });

            migrationBuilder.CreateTable(
                name: "InstituicaoFinanceira",
                columns: table => new
                {
                    IdInstituicaoFinanceira = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstituicaoFinanceira", x => x.IdInstituicaoFinanceira);
                });

            migrationBuilder.CreateTable(
                name: "Joia",
                columns: table => new
                {
                    IdJoia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Montante = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joia", x => x.IdJoia);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    IdMenu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeDoController = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeDaAction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdMenuPai = table.Column<int>(type: "int", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.IdMenu);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    IdPerfil = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.IdPerfil);
                });

            migrationBuilder.CreateTable(
                name: "PeriodoQuota",
                columns: table => new
                {
                    IdPeriodoQuota = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Mes = table.Column<int>(type: "int", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeriodoQuota", x => x.IdPeriodoQuota);
                });

            migrationBuilder.CreateTable(
                name: "TipologiaSocio",
                columns: table => new
                {
                    IdTipologiaSocio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Montante = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Prioridicidade = table.Column<int>(type: "int", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipologiaSocio", x => x.IdTipologiaSocio);
                });

            migrationBuilder.CreateTable(
                name: "TipoQuota",
                columns: table => new
                {
                    IdTipoQuota = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priodicidade = table.Column<int>(type: "int", nullable: false),
                    Montante = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoQuota", x => x.IdTipoQuota);
                });

            migrationBuilder.CreateTable(
                name: "Cidade",
                columns: table => new
                {
                    IdCidade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdIlha = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
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
                    IdMenuAcao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAcao = table.Column<int>(type: "int", nullable: true),
                    IdMenu = table.Column<int>(type: "int", nullable: true),
                    MenuAcaoMaster = table.Column<bool>(type: "bit", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
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
                    IdUtilizador = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeUtilizador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apelido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PalavraPasse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPerfil = table.Column<int>(type: "int", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
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
                    IdAgencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdCidade = table.Column<int>(type: "int", nullable: false),
                    IdInstituicaoFinanceira = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
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
                    IdPerfilMenuAcao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdMenuAcao = table.Column<int>(type: "int", nullable: false),
                    IdPPerfil = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
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
                    IdSocio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroDeSocio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apelido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CinBi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValidadeCinBi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroPassaporte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValidadePassaporte = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sexo = table.Column<int>(type: "int", nullable: false),
                    EstadoCivil = table.Column<int>(type: "int", nullable: false),
                    NumeroDeTelefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroDeTelemovel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdAgencia = table.Column<int>(type: "int", nullable: false),
                    IdTipologiaSocio = table.Column<int>(type: "int", nullable: false),
                    IdTipoQuota = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
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
                    IdBeneficiario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apelido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrauDeParentesco = table.Column<int>(type: "int", nullable: false),
                    Nif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CinBi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroPassaporte = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdSocio = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
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
                    IdEstadoSocio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdSocio = table.Column<int>(type: "int", nullable: false)
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
                    IdJoiaSocio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Montante = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdSocio = table.Column<int>(type: "int", nullable: false),
                    IdJoia = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
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
                    IdQuotaSocio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Montante = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    IdSocio = table.Column<int>(type: "int", nullable: false),
                    IdPeriodoQuota = table.Column<int>(type: "int", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
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
                values: new object[,]
                {
                    { 1, false, new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2690), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2681), false, "Criar" },
                    { 2, false, new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2695), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2694), false, "Editar" },
                    { 3, false, new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2699), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2696), false, "Eliminar" }
                });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6954), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6953), false, "Santo Antão" },
                    { 2, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6957), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6956), false, "São Vicente" },
                    { 3, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6958), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6958), false, "Santa Luzia" },
                    { 4, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6960), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6959), false, "São Nicolau" },
                    { 5, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6961), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6961), false, "Sal" },
                    { 6, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6963), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6962), false, "Boavista" },
                    { 7, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6964), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6963), false, "Maio" },
                    { 8, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6965), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6965), false, "Santiago" },
                    { 9, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6967), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6966), false, "Fogo" },
                    { 10, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6968), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6968), false, "Brava" }
                });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7106), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7106), false, "Caixa Económica de Cabo Verde" },
                    { 3, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7109), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7108), false, "Banco Comercial do Atlântico" },
                    { 4, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7110), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7109), false, "Banco Caboverdiano de Negócios" },
                    { 5, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7111), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7111), false, "Banco Interatlântico" },
                    { 8, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7113), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7112), false, "Banco Angolano de Investimentos" },
                    { 9, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7114), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7113), false, "International Investment Bank" },
                    { 11, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7115), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7115), false, "Ecobank Cabo Verde SA" }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2739), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2739), "Administração do Sistema SGA-STIF", false, "", null, "Administração", "", "" },
                    { 2, new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2749), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2748), "Gestão dos utilizadores", false, "k", 1, "Utilizador", "ListaUtilizador", "Utilizador" },
                    { 3, new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2751), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2751), "Gestão dos utilizadores", false, "k", 1, "Perfil", "ListaPerfil", "Perfil" },
                    { 4, new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2753), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2753), "Gestão dos utilizadores", false, "k", 1, "Menu", "ListaMenu", "MenuAcao" },
                    { 5, new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2755), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2755), "Gestao de Socios", false, "", null, "Gestao de Socios", "ListaSocio", "Socio" },
                    { 6, new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2757), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2756), "Estatística", false, "", null, "Parametrização", "Inicio", "Estatistica" },
                    { 7, new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2759), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2758), "Instituição Financeira", false, "", 6, "Instituição Financeira", "ListaInstituicaoFinanceira", "InstituicaoFinanceira" },
                    { 8, new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2761), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2760), "Agência", false, "", 6, "Agência", "ListaAgencia", "Agencia" },
                    { 9, new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2763), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2762), "Tipo Quotas", false, "", 6, "Tipo Quotas", "ListaTipoQuota", "TipoQuota" },
                    { 10, new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2764), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2764), "Estatística", false, "", 6, "Tipologia Sócio", "ListaTipologiaSocio", "TipologiaSocio" },
                    { 11, new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2766), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2766), "Estatística", false, "", null, "Estatística", "Inicio", "Estatistica" },
                    { 12, new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2768), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2767), "Sga-Stif", false, "", null, "Sga-Stif", "Inicio", "Estatistica" },
                    { 13, new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2769), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2769), "Sobre", false, "", 12, "Sobre", "Inicio", "Estatistica" }
                });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "IdPerfil", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7086), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7086), "Perfil de Administrador", false, "Administrador" },
                    { 2, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7090), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7090), "Perfil de Operador", false, "Operado" }
                });

            migrationBuilder.InsertData(
                table: "TipoQuota",
                columns: new[] { "IdTipoQuota", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Montante", "Priodicidade", "Tipo" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6927), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6926), "Quinzenal", false, 500m, 1, 0 },
                    { 2, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6930), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6929), "Mensal", false, 1000m, 2, 0 },
                    { 3, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6932), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6931), "Trimestral", false, 3000m, 3, 0 },
                    { 4, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6933), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6933), "Semestral", false, 6000m, 4, 1 },
                    { 5, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6935), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6934), "Anual", false, 12000m, 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "TipologiaSocio",
                columns: new[] { "IdTipologiaSocio", "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio", "Descricao", "Eliminado", "Montante", "Prioridicidade", "Tipo" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6771), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6759), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6781), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6781), "Normal", false, 4000m, 2, 0 },
                    { 2, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6783), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6782), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6784), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6785), "Honorário", false, 5000m, 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6986), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6986), false, 8, "Praia" },
                    { 2, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6989), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6989), false, 8, "Outro" },
                    { 3, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6991), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6991), false, 2, "Mindelo" },
                    { 4, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6992), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6992), false, 5, "Santa Maria" },
                    { 5, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6994), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6993), false, 7, "Vila do Maio" },
                    { 6, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6995), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6995), false, 8, "Santa Cruz" },
                    { 7, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6996), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6996), false, 6, "Sal Rei" },
                    { 8, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6998), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6997), false, 1, "Porto Novo" },
                    { 9, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6999), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6999), false, 8, "Ribeira Grande" },
                    { 10, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7000), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7000), false, 10, "Ribeira Brava" },
                    { 11, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7002), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7001), false, 1, "Tarrafal" },
                    { 12, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7003), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7003), false, 5, "Espargos" },
                    { 13, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7004), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7004), false, 8, "Assomada" },
                    { 14, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7049), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7048), false, 8, "São Domingos" },
                    { 15, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7051), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7051), false, 9, "São Filipe" },
                    { 16, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7053), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7052), false, 9, "Mosteiros" },
                    { 17, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7054), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7054), false, 1, "Nova Sintra" },
                    { 18, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7056), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7055), false, 8, "Tarrafal (Santiano)" }
                });

            migrationBuilder.InsertData(
                table: "Utilizador",
                columns: new[] { "IdUtilizador", "Apelido", "DataAtualizacao", "DataCriacao", "Eliminado", "Email", "Foto", "IdPerfil", "Nome", "NomeUtilizador", "PalavraPasse" },
                values: new object[,]
                {
                    { 1, "Semedo", new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7428), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7427), false, "angelosemedo@sgastif.cv", null, 1, "Angelo", "angelosemedo", "$2a$11$kh38DbAL/BeTuuy6XNve/.uSTNsDPJn5cAXMU4kT.8KRI5MVCmoJW" },
                    { 2, "Veiga", new DateTime(2022, 4, 12, 9, 32, 57, 637, DateTimeKind.Local).AddTicks(3003), new DateTime(2022, 4, 12, 9, 32, 57, 637, DateTimeKind.Local).AddTicks(2995), false, "odailtonveiga@sgastif.cv", null, 1, "Odailton", "odailtonveiga", "$2a$11$hRM9JdiIR6zF3l2Hkg2btuMVsOriJvBXWZvc2r4Wj01yLvyg0a6Qu" },
                    { 3, "Varela", new DateTime(2022, 4, 12, 9, 32, 57, 810, DateTimeKind.Local).AddTicks(1404), new DateTime(2022, 4, 12, 9, 32, 57, 810, DateTimeKind.Local).AddTicks(1396), false, "manuelvarela@sgastif.cv", null, 1, "Manuel", "manuelvarela", "$2a$11$FuzdfAv3Aijf1Boi5RflYeZoDtcAvoNn8Pn2NVjlQmUcfGAuwbaFa" },
                    { 4, "Tavares", new DateTime(2022, 4, 12, 9, 32, 57, 990, DateTimeKind.Local).AddTicks(3081), new DateTime(2022, 4, 12, 9, 32, 57, 990, DateTimeKind.Local).AddTicks(3073), false, "jair@sgastif.cv", null, 1, "Jair", "jair", "$2a$11$IBhd9/.1QN.ejkQlFu0BEuQTu/zBcUv6uCZVpOoGuoxsE9Q6.McKK" }
                });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7132), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7132), false, 1, 2, "Ag. Fazenda" },
                    { 2, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7136), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7135), false, 1, 2, "Ag. Mindelo" },
                    { 3, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7137), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7137), false, 1, 2, "Ag. ASA" },
                    { 4, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7139), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7138), false, 13, 2, "Ag. Assomada" },
                    { 5, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7141), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7140), false, 1, 2, "Ag. Espargos" },
                    { 6, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7142), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7142), false, 9, 2, "Ag. Rª Grande" },
                    { 7, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7143), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7143), false, 1, 2, "Ag. St. Maria" },
                    { 8, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7145), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7144), false, 1, 2, "Ag. Plateau" },
                    { 9, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7146), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7146), false, 1, 2, "Ag. Monte Sossego" },
                    { 10, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7148), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7147), false, 1, 2, "Ag. Palmarejo" },
                    { 11, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7149), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7149), false, 1, 2, "Ag. São Filipe" },
                    { 12, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7150), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7150), false, 1, 2, "Ag. Calheta S. Miguel" },
                    { 13, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7152), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7151), false, 1, 2, "Ag. Aeroporto da Praia" },
                    { 14, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7154), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7154), false, 7, 2, "Ag. Boavista" },
                    { 15, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7156), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7155), false, 1, 2, "Ag. Aeroporto do Sal" },
                    { 16, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7157), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7157), false, 1, 2, "Ag. Sucupira" },
                    { 17, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7159), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7158), false, 1, 2, "Ag. CCV – São Domingos" },
                    { 18, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7160), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7159), false, 18, 2, "Ag. Tarrafal" },
                    { 19, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7161), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7161), false, 1, 2, "Ag. Santa Cruz" },
                    { 20, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7163), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7162), false, 1, 2, "Ag. CCV – Porto Novo" },
                    { 21, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7164), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7164), false, 1, 2, "Ag. CCV - Plateau" },
                    { 22, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7189), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7189), false, 1, 2, "Ag. A. São Filipe" },
                    { 23, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7191), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7190), false, 1, 2, "Ag. Mosteiros" },
                    { 24, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7192), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7192), false, 1, 2, "Ag. Caixa Empresas" },
                    { 25, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7194), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7193), false, 1, 2, "Ag. Coculi" },
                    { 26, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7195), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7194), false, 1, 2, "Ag. Paul" },
                    { 27, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7196), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7196), false, 1, 2, "Ag. Fonte Cónego" },
                    { 28, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7198), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7197), false, 7, 2, "Ag. Aeroporto Boavista" },
                    { 29, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7199), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7199), false, 1, 2, "Ag. Maio" },
                    { 30, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7200), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7200), false, 1, 2, "Ag. Porto Novo" },
                    { 31, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7202), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7201), false, 1, 2, "Ag. Ribeira Brava" },
                    { 32, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7203), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7203), false, 1, 2, "Ag. Ribeira Brava" },
                    { 33, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7205), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7204), false, 18, 2, "Ag. Tarrafal" },
                    { 34, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7206), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7206), false, 1, 3, "Ag. Praia" },
                    { 35, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7207), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7207), false, 1, 3, "Ag. S. Vicente " },
                    { 36, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7209), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7208), false, 1, 3, "Ag. Sal" },
                    { 37, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7210), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7210), false, 1, 3, "Ag. S. Filipe" },
                    { 38, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7212), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7211), false, 18, 3, "Ag. Tarrafal" },
                    { 39, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7213), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7213), false, 1, 3, "Ag. S. Catarina" },
                    { 40, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7214), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7214), false, 1, 3, "Ag. Porto Novo" },
                    { 41, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7217), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7216), false, 9, 3, "Ag. Rª Grande" },
                    { 42, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7218), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7218), false, 1, 3, "Ag. Brava" }
                });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[,]
                {
                    { 43, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7219), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7219), false, 1, 3, "Ag. Boavista" },
                    { 44, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7221), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7220), false, 1, 3, "Ag. S. Nicolau" },
                    { 45, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7222), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7222), false, 1, 3, "Ag. Maio" },
                    { 46, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7223), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7223), false, 1, 3, "Ag. Santa Cruz" },
                    { 47, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7225), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7224), false, 1, 3, "Ag. Praça Nova" },
                    { 48, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7226), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7226), false, 1, 3, "Ag. ASA" },
                    { 49, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7228), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7227), false, 1, 3, "Ag. Avenida" },
                    { 50, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7229), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7229), false, 1, 3, "Ag. Monte Sossego" },
                    { 51, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7231), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7230), false, 1, 3, "Ag. Fonte Filipe" },
                    { 52, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7232), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7231), false, 1, 3, "Ag. Santa Maria" },
                    { 53, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7233), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7233), false, 1, 3, "Ag. Mosteiros" },
                    { 54, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7235), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7234), false, 11, 3, "Ag. Tarrafal S. Nicolau" },
                    { 55, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7236), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7235), false, 1, 3, "Ag. ASA II" },
                    { 56, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7237), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7237), false, 1, 3, "Gabinete Empresas Sul" },
                    { 57, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7239), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7238), false, 1, 3, "Gabinete Empresas Norte" },
                    { 58, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7240), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7240), false, 1, 3, "Ag. S. Domingos" },
                    { 59, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7242), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7241), false, 1, 3, "Ag. Palmarejo" },
                    { 60, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7243), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7242), false, 1, 3, "Gabinete Empresas Sul II" },
                    { 61, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7244), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7244), false, 1, 3, "Gabinete Empresas Sal" },
                    { 62, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7246), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7245), false, 1, 3, "Prol. Ach. São Filipe" },
                    { 63, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7247), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7247), false, 1, 4, "Ag. Praia" },
                    { 64, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7249), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7248), false, 1, 4, "Ag. Mindelo" },
                    { 65, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7250), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7250), false, 13, 4, "Ag. Assomada" },
                    { 66, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7251), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7251), false, 1, 4, "Ag. Aeroporto do Sal" },
                    { 67, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7254), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7253), false, 1, 4, "Ag. Boavista" },
                    { 68, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7255), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7255), false, 1, 4, "Ag. Porto Novo" },
                    { 69, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7257), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7256), false, 1, 4, "Ag. Terra Branca" },
                    { 70, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7258), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7257), false, 1, 4, "Ag. Palmarejo" },
                    { 71, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7259), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7259), false, 1, 4, "Ag. Monte Sossego" },
                    { 72, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7261), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7260), false, 1, 4, "Ag. Santa Maria" },
                    { 73, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7262), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7262), false, 1, 4, "Ag. São Filipe" },
                    { 74, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7286), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7285), false, 9, 4, "Ag. Rª Grande" },
                    { 75, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7288), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7287), false, 1, 4, "ASA – Private Banking" },
                    { 76, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7289), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7288), false, 1, 4, "Ag. Fazenda" },
                    { 77, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7290), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7290), false, 1, 4, "Ag. Órgãos" },
                    { 78, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7292), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7291), false, 1, 4, "Ag. Santa Cruz" },
                    { 79, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7293), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7293), false, 1, 4, "Ag. Ponta do Sol" },
                    { 80, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7295), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7294), false, 1, 4, "Ag. Maio" },
                    { 81, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7296), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7295), false, 1, 4, "Centro de empresas" },
                    { 82, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7297), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7297), false, 1, 4, "Centro de empresas II" },
                    { 83, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7299), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7298), false, 1, 4, "Ag. Sede" },
                    { 84, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7300), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7300), false, 1, 4, "Núcleo N/ Residentes" }
                });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[,]
                {
                    { 85, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7302), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7302), false, 1, 5, "Ag. Sede" },
                    { 86, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7303), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7303), false, 1, 5, "Ag. ASA" },
                    { 87, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7305), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7304), false, 1, 5, "Ag. Mindelo" },
                    { 88, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7306), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7306), false, 1, 5, "Ag. Plateau" },
                    { 89, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7308), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7307), false, 1, 5, "Ag. Espargos" },
                    { 90, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7309), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7309), false, 1, 5, "Ag. Santa Maria" },
                    { 91, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7310), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7310), false, 7, 5, "ag. Sal Rei – Boavista" },
                    { 92, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7312), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7311), false, 13, 5, "Ag. Assomada" },
                    { 93, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7314), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7314), false, 1, 5, "Ag. Achada Grande Trás" },
                    { 94, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7315), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7315), false, 1, 5, "Gab. Particulares (Praia)" },
                    { 95, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7317), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7316), false, 1, 5, "Gab. Empresas (Praia)" },
                    { 96, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7318), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7318), false, 1, 8, "Ag. Sede" },
                    { 97, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7320), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7319), false, 1, 8, "Ag. Plateau" },
                    { 98, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7321), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7320), false, 1, 8, "Ag ASA" },
                    { 99, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7322), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7322), false, 1, 8, "Ag. Mindelo" },
                    { 100, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7324), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7323), false, 1, 8, "Ag. Espargos" },
                    { 101, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7325), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7325), false, 1, 9, "Ag. Sede" },
                    { 102, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7326), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7326), false, 1, 9, "Serviços Centrais" },
                    { 103, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7328), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7327), false, 1, 9, "Emigrantes" },
                    { 104, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7329), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7329), false, 1, 9, "Particulares Classic" },
                    { 105, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7331), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7330), false, 1, 9, "Afluentes" },
                    { 106, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7332), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7332), false, 1, 9, "Private" },
                    { 107, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7333), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7333), false, 1, 9, "Institucionais" },
                    { 108, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7335), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7334), false, 1, 9, "PME Nacionais" },
                    { 109, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7336), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7336), false, 1, 9, "Grandes Empresas Nacionais" },
                    { 110, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7338), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7337), false, 1, 9, "Corporate Internacional" },
                    { 111, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7339), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7338), false, 1, 9, "Ag. Sal" },
                    { 112, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7340), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7340), false, 1, 9, "Emigrantes Sal" },
                    { 113, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7342), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7341), false, 1, 9, "Particulares Classic Sal" },
                    { 114, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7343), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7343), false, 1, 9, "Afluentes Sal" },
                    { 115, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7345), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7344), false, 1, 9, "Private Sal" },
                    { 116, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7346), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7346), false, 1, 9, "Institucionais Sal" },
                    { 117, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7347), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7347), false, 1, 9, "PME Nacionais Sal" },
                    { 118, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7349), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7348), false, 1, 9, "Grandes Empresas Nacionais Sal" },
                    { 119, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7351), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7350), false, 1, 11, "Ag. Sede - Praia" },
                    { 120, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7352), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7352), false, 13, 8, "Ag. Assomada" },
                    { 121, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7354), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7353), false, 1, 8, "Ag. Sta Maria " },
                    { 122, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7355), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7354), false, 1, 8, "Agencia Sal-Rei " },
                    { 123, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7356), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7356), false, 1, 8, "Agencia S.Filipe " },
                    { 124, new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7358), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7357), false, 1, 8, "Ag. Montsu " }
                });

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
