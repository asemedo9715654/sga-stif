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
                name: "ContaCorrenteIFResultado",
                columns: table => new
                {
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdSocio = table.Column<int>(type: "int", nullable: false),
                    IFS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgenciaNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Mes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesNum = table.Column<int>(type: "int", nullable: false),
                    Montante = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EstadoQuota = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ContaCorrenteSocioResultado",
                columns: table => new
                {
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdSocio = table.Column<int>(type: "int", nullable: false),
                    IFS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgenciaNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ano = table.Column<int>(type: "int", nullable: false),
                    Mes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesNum = table.Column<int>(type: "int", nullable: false),
                    Montante = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EstadoQuota = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
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
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joia", x => x.IdJoia);
                });

            migrationBuilder.CreateTable(
                name: "LogAtividade",
                columns: table => new
                {
                    IdLogAtividades = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dados = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeUtilizador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnderecoIp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogAtividade", x => x.IdLogAtividades);
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
                    Editavel = table.Column<bool>(type: "bit", nullable: false),
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
                    TipoQuota = table.Column<int>(type: "int", nullable: false),
                    CodigoPeriodo = table.Column<int>(type: "int", nullable: false),
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
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                name: "InstituicaoFinanceiraColaboradores",
                columns: table => new
                {
                    IdInstituicaoFinanceiraColaboradores = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdInstituicaoFinanceira = table.Column<int>(type: "int", nullable: false),
                    NumeroColaboradores = table.Column<int>(type: "int", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Eliminado = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstituicaoFinanceiraColaboradores", x => x.IdInstituicaoFinanceiraColaboradores);
                    table.ForeignKey(
                        name: "FK_InstituicaoFinanceiraColaboradores_InstituicaoFinanceira_IdInstituicaoFinanceira",
                        column: x => x.IdInstituicaoFinanceira,
                        principalTable: "InstituicaoFinanceira",
                        principalColumn: "IdInstituicaoFinanceira",
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
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdAgencia = table.Column<int>(type: "int", nullable: false),
                    IdTipologiaSocio = table.Column<int>(type: "int", nullable: false),
                    IdTipoQuota = table.Column<int>(type: "int", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtivacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumeroColaborador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoSocio = table.Column<int>(type: "int", nullable: false),
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
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    Estado = table.Column<int>(type: "int", nullable: false),
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
                    { 1, true, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2610), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2600), false, "Administração" },
                    { 2, false, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2620), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2620), false, "Criar" },
                    { 3, false, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2620), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2620), false, "Editar" },
                    { 4, false, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2630), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2630), false, "Eliminar" }
                });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9570), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9570), false, "Santo Antão" },
                    { 2, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9570), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9570), false, "São Vicente" },
                    { 3, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9580), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9580), false, "Santa Luzia" },
                    { 4, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9580), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9580), false, "São Nicolau" },
                    { 5, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9590), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9590), false, "Sal" },
                    { 6, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9590), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9590), false, "Boavista" },
                    { 7, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9590), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9590), false, "Maio" },
                    { 8, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9600), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9600), false, "Santiago" },
                    { 9, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9600), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9600), false, "Fogo" },
                    { 10, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9610), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9600), false, "Brava" }
                });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9810), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9810), false, "Caixa Económica de Cabo Verde" },
                    { 3, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9820), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9820), false, "Banco Comercial do Atlântico" },
                    { 4, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9820), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9820), false, "Banco Caboverdiano de Negócios" },
                    { 5, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9830), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9830), false, "Banco Interatlântico" },
                    { 8, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9830), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9830), false, "Banco Angolano de Investimentos" },
                    { 9, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9840), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9830), false, "International Investment Bank" },
                    { 11, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9840), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9840), false, "Ecobank Cabo Verde SA" }
                });

            migrationBuilder.InsertData(
                table: "Joia",
                columns: new[] { "IdJoia", "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio", "Descricao", "Eliminado", "Montante" },
                values: new object[] { 1, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2670), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2670), null, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2710), "Jóia STIF", false, 1000m });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2740), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2740), "Gestão de Sócios", false, "fas fa-user", null, "Gestão de Sócios", "", "" },
                    { 2, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2760), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2760), "Lista de Sócios", false, "far fa-circle", 1, "Lista  Sócios", "ListaSocio", "Socio" },
                    { 3, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2760), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2760), "Ranquing de Sócios", false, "far fa-circle", 1, "Ranking Sócios", "", "" },
                    { 4, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2770), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2770), "Contas Correntes", false, "fas fa-book", null, "Contas Correntes", "", "" },
                    { 5, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2770), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2770), "Quotas Pendentes", false, "far fa-circle", 4, "Quotas Pendentes", "ListaQuotasPendente", "ContaCorrentes" },
                    { 6, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2780), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2780), "Quotas Por Pagar", false, "far fa-circle", 4, "Quotas Por Pagar", "ListaQuotasPorPagar", "ContaCorrentes" },
                    { 7, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2790), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2780), "Quotas Paga", false, "far fa-circle", 4, "Quotas Paga", "ListaQuotasPagas", "ContaCorrentes" },
                    { 8, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2790), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2790), "Quotas Vencidas", false, "far fa-circle", 4, "Quotas Vencidas", "ListaQuotasVencidas", "ContaCorrentes" },
                    { 9, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2790), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2790), "Posição de IF", false, "fas fa-search", null, "Posição de IF", "", "" },
                    { 10, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2800), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2800), "Projeção de Quotas", false, "fas fa-table", null, "Projeção de Quotas", "", "" },
                    { 11, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2800), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2800), "Estatística", false, "fas fa-chart-pie", null, "Estatística", "Inicio", "Estatistica" },
                    { 12, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2810), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2800), "Configurações", false, "far fa-edit", null, "Configurações", "", "" },
                    { 13, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2810), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2810), "Instituição Financeira", false, "far fa-circle", 12, "Utilizadores", "ListaUtilizador", "Utilizador" },
                    { 14, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2810), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2810), "Instituição Financeira", false, "far fa-circle", 12, "Perfil", "ListaPerfil", "Perfil" },
                    { 15, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2820), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2820), "Gestão de Menu", false, "far fa-circle", 12, "Menu", "ListaMenu", "MenuAcao" },
                    { 16, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2820), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2820), "Instituição Financeira", false, "far fa-circle", 12, "Instituição Financeira", "ListaInstituicaoFinanceira", "InstituicaoFinanceira" },
                    { 17, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2820), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2820), "Agência", false, "far fa-circle", 12, "Agência", "ListaAgencia", "Agencia" },
                    { 18, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2830), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2830), "Tipo Quotas", false, "far fa-circle", 12, "Tipo Quotas", "ListaTipoQuota", "TipoQuota" },
                    { 19, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2830), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2830), "Tipologia Sócio", false, "far fa-circle", 12, "Tipologia Sócio", "ListaTipologiaSocio", "TipologiaSocio" }
                });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "IdPerfil", "DataAtualizacao", "DataCriacao", "Descricao", "Editavel", "Eliminado", "Nome" },
                values: new object[] { 1, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9760), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9760), "Perfil de Administrador", false, false, "Administrador" });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "IdPerfil", "DataAtualizacao", "DataCriacao", "Descricao", "Editavel", "Eliminado", "Nome" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9770), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9770), "Perfil de Operador", true, false, "Auditor" },
                    { 3, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9790), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9790), "Perfil de Operador", true, false, "Operador Teste" }
                });

            migrationBuilder.InsertData(
                table: "TipoQuota",
                columns: new[] { "IdTipoQuota", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Montante", "Priodicidade", "Tipo" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9510), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9510), "Quinzenal", false, 0m, 0, 1 },
                    { 2, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9520), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9520), "Mensal", false, 0m, 1, 0 },
                    { 3, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9520), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9520), "Trimestral", false, 0m, 3, 1 },
                    { 4, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9530), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9530), "Semestral", false, 0m, 6, 1 },
                    { 5, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9530), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9530), "Anual", false, 0m, 12, 1 }
                });

            migrationBuilder.InsertData(
                table: "TipologiaSocio",
                columns: new[] { "IdTipologiaSocio", "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio", "Descricao", "Eliminado", "Tipo" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9210), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9170), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9230), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9230), "Normal", false, 0 },
                    { 2, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9240), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9230), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9240), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9240), "Honorário", false, 1 }
                });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9650), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9640), false, 8, "Praia" },
                    { 2, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9650), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9650), false, 8, "Outro" },
                    { 3, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9660), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9650), false, 2, "Mindelo" },
                    { 4, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9660), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9660), false, 5, "Santa Maria" },
                    { 5, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9660), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9660), false, 7, "Vila do Maio" },
                    { 6, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9670), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9660), false, 8, "Santa Cruz" },
                    { 7, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9670), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9670), false, 6, "Sal Rei" },
                    { 8, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9670), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9670), false, 1, "Porto Novo" },
                    { 9, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9680), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9670), false, 8, "Ribeira Grande" },
                    { 10, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9680), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9680), false, 10, "Ribeira Brava" },
                    { 11, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9690), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9690), false, 1, "Tarrafal" },
                    { 12, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9690), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9690), false, 5, "Espargos" },
                    { 13, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9700), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9690), false, 8, "Assomada" },
                    { 14, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9700), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9700), false, 8, "São Domingos" },
                    { 15, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9700), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9700), false, 9, "São Filipe" },
                    { 16, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9710), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9710), false, 9, "Mosteiros" },
                    { 17, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9710), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9710), false, 1, "Nova Sintra" },
                    { 18, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9720), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9710), false, 8, "Tarrafal (Santiano)" }
                });

            migrationBuilder.InsertData(
                table: "MenuAcao",
                columns: new[] { "IdMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdAcao", "IdMenu", "MenuAcaoMaster" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2910), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2910), false, 1, 1, true },
                    { 2, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2930), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2920), false, 1, 2, true },
                    { 3, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2930), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2930), false, 1, 3, true },
                    { 4, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2930), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2930), false, 1, 4, true },
                    { 5, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2940), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2930), false, 1, 5, true },
                    { 6, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2940), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2940), false, 1, 6, true },
                    { 7, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2940), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2940), false, 1, 7, true },
                    { 8, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2950), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2950), false, 1, 8, true },
                    { 9, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2950), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2950), false, 1, 9, true },
                    { 10, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2950), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2950), false, 1, 10, true },
                    { 11, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2960), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2960), false, 1, 11, true },
                    { 12, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2960), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2960), false, 1, 12, true },
                    { 13, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2960), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2960), false, 1, 13, true },
                    { 14, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2970), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2970), false, 1, 14, true },
                    { 15, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2970), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2970), false, 1, 15, true },
                    { 16, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2970), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2970), false, 1, 16, true },
                    { 17, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2980), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2980), false, 1, 17, true },
                    { 18, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2990), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2990), false, 1, 18, true },
                    { 19, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3000), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2990), false, 1, 19, true }
                });

            migrationBuilder.InsertData(
                table: "Utilizador",
                columns: new[] { "IdUtilizador", "Apelido", "DataAtualizacao", "DataCriacao", "Eliminado", "Email", "Foto", "IdPerfil", "Nome", "NomeUtilizador", "PalavraPasse" },
                values: new object[,]
                {
                    { 1, "Semedo", new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(420), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(420), false, "angelosemedo@sgastif.cv", null, 1, "Angelo", "angelosemedo", "$2a$11$LblNvI0IxFNNKTRLEfKMa.AWY9KJsXdKqJBgmIj5gZ4K/7cE/Z2n2" },
                    { 2, "Veiga", new DateTime(2022, 4, 25, 14, 44, 59, 472, DateTimeKind.Local).AddTicks(6370), new DateTime(2022, 4, 25, 14, 44, 59, 472, DateTimeKind.Local).AddTicks(6350), false, "odailtonveiga@sgastif.cv", null, 1, "Odailton", "odailtonveiga", "$2a$11$wlyFO63wsyJLHWhGsXAeGud9/RJFHFtzmM3i/3fcIkeb1GTqhdC7K" },
                    { 3, "Varela", new DateTime(2022, 4, 25, 14, 44, 59, 700, DateTimeKind.Local).AddTicks(70), new DateTime(2022, 4, 25, 14, 44, 59, 700, DateTimeKind.Local).AddTicks(50), false, "manuelvarela@sgastif.cv", null, 1, "Manuel", "manuelvarela", "$2a$11$7nEfNPpgksDvitCIoFPvrenHUQ187bUSFpdw.pD9EY36jsoILRFsK" },
                    { 4, "Tavares", new DateTime(2022, 4, 25, 14, 44, 59, 921, DateTimeKind.Local).AddTicks(5490), new DateTime(2022, 4, 25, 14, 44, 59, 921, DateTimeKind.Local).AddTicks(5480), false, "jair@sgastif.cv", null, 1, "Jair", "jair", "$2a$11$eEVc3kL81CQDPRP5w3.tQeVJ7C2Z3KB82eHYUH9dFMHrc8YRTwRX2" }
                });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9870), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9860), false, 1, 2, "Ag. Fazenda" },
                    { 2, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9870), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9870), false, 1, 2, "Ag. Mindelo" },
                    { 3, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9880), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9870), false, 1, 2, "Ag. ASA" },
                    { 4, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9880), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9880), false, 13, 2, "Ag. Assomada" },
                    { 5, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9880), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9880), false, 1, 2, "Ag. Espargos" },
                    { 6, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9890), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9890), false, 9, 2, "Ag. Rª Grande" },
                    { 7, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9890), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9890), false, 1, 2, "Ag. St. Maria" },
                    { 8, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9890), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9890), false, 1, 2, "Ag. Plateau" },
                    { 9, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9900), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9900), false, 1, 2, "Ag. Monte Sossego" },
                    { 10, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9900), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9900), false, 1, 2, "Ag. Palmarejo" },
                    { 11, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9910), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9910), false, 1, 2, "Ag. São Filipe" },
                    { 12, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9910), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9910), false, 1, 2, "Ag. Calheta S. Miguel" },
                    { 13, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9920), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9910), false, 1, 2, "Ag. Aeroporto da Praia" },
                    { 14, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9920), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9920), false, 7, 2, "Ag. Boavista" },
                    { 15, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9920), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9920), false, 1, 2, "Ag. Aeroporto do Sal" },
                    { 16, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9930), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9930), false, 1, 2, "Ag. Sucupira" },
                    { 17, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9930), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9930), false, 1, 2, "Ag. CCV – São Domingos" },
                    { 18, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9930), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9930), false, 18, 2, "Ag. Tarrafal" },
                    { 19, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9940), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9940), false, 1, 2, "Ag. Santa Cruz" },
                    { 20, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9940), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9940), false, 1, 2, "Ag. CCV – Porto Novo" },
                    { 21, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9940), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9940), false, 1, 2, "Ag. CCV - Plateau" },
                    { 22, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9950), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9950), false, 1, 2, "Ag. A. São Filipe" },
                    { 23, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9950), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9950), false, 1, 2, "Ag. Mosteiros" },
                    { 24, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9960), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9950), false, 1, 2, "Ag. Caixa Empresas" },
                    { 25, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9960), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9960), false, 1, 2, "Ag. Coculi" },
                    { 26, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9960), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9960), false, 1, 2, "Ag. Paul" },
                    { 27, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9970), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9970), false, 1, 2, "Ag. Fonte Cónego" },
                    { 28, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9970), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9970), false, 7, 2, "Ag. Aeroporto Boavista" },
                    { 29, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9970), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9970), false, 1, 2, "Ag. Maio" },
                    { 30, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9980), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9980), false, 1, 2, "Ag. Porto Novo" },
                    { 31, new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9990), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9990), false, 1, 2, "Ag. Ribeira Brava" },
                    { 32, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9990), false, 1, 2, "Ag. Ribeira Brava" },
                    { 33, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local), false, 18, 2, "Ag. Tarrafal" },
                    { 34, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local), false, 1, 3, "Ag. Praia" },
                    { 35, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(10), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(10), false, 1, 3, "Ag. S. Vicente " },
                    { 36, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(10), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(10), false, 1, 3, "Ag. Sal" },
                    { 37, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(20), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(20), false, 1, 3, "Ag. S. Filipe" },
                    { 38, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(20), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(20), false, 18, 3, "Ag. Tarrafal" },
                    { 39, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(20), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(20), false, 1, 3, "Ag. S. Catarina" },
                    { 40, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(30), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(30), false, 1, 3, "Ag. Porto Novo" },
                    { 41, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(30), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(30), false, 9, 3, "Ag. Rª Grande" },
                    { 42, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(40), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(30), false, 1, 3, "Ag. Brava" }
                });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[,]
                {
                    { 43, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(40), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(40), false, 1, 3, "Ag. Boavista" },
                    { 44, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(40), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(40), false, 1, 3, "Ag. S. Nicolau" },
                    { 45, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(50), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(40), false, 1, 3, "Ag. Maio" },
                    { 46, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(50), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(50), false, 1, 3, "Ag. Santa Cruz" },
                    { 47, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(50), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(50), false, 1, 3, "Ag. Praça Nova" },
                    { 48, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(60), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(60), false, 1, 3, "Ag. ASA" },
                    { 49, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(60), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(60), false, 1, 3, "Ag. Avenida" },
                    { 50, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(60), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(60), false, 1, 3, "Ag. Monte Sossego" },
                    { 51, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(70), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(70), false, 1, 3, "Ag. Fonte Filipe" },
                    { 52, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(70), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(70), false, 1, 3, "Ag. Santa Maria" },
                    { 53, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(70), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(70), false, 1, 3, "Ag. Mosteiros" },
                    { 54, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(80), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(80), false, 11, 3, "Ag. Tarrafal S. Nicolau" },
                    { 55, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(80), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(80), false, 1, 3, "Ag. ASA II" },
                    { 56, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(80), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(80), false, 1, 3, "Gabinete Empresas Sul" },
                    { 57, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(90), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(90), false, 1, 3, "Gabinete Empresas Norte" },
                    { 58, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(90), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(90), false, 1, 3, "Ag. S. Domingos" },
                    { 59, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(100), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(90), false, 1, 3, "Ag. Palmarejo" },
                    { 60, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(100), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(100), false, 1, 3, "Gabinete Empresas Sul II" },
                    { 61, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(110), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(100), false, 1, 3, "Gabinete Empresas Sal" },
                    { 62, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(110), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(110), false, 1, 3, "Prol. Ach. São Filipe" },
                    { 63, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(110), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(110), false, 1, 4, "Ag. Praia" },
                    { 64, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(120), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(120), false, 1, 4, "Ag. Mindelo" },
                    { 65, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(120), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(120), false, 13, 4, "Ag. Assomada" },
                    { 66, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(120), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(120), false, 1, 4, "Ag. Aeroporto do Sal" },
                    { 67, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(130), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(130), false, 1, 4, "Ag. Boavista" },
                    { 68, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(130), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(130), false, 1, 4, "Ag. Porto Novo" },
                    { 69, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(130), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(130), false, 1, 4, "Ag. Terra Branca" },
                    { 70, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(140), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(140), false, 1, 4, "Ag. Palmarejo" },
                    { 71, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(140), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(140), false, 1, 4, "Ag. Monte Sossego" },
                    { 72, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(150), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(140), false, 1, 4, "Ag. Santa Maria" },
                    { 73, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(150), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(150), false, 1, 4, "Ag. São Filipe" },
                    { 74, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(150), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(150), false, 9, 4, "Ag. Rª Grande" },
                    { 75, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(160), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(160), false, 1, 4, "ASA – Private Banking" },
                    { 76, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(160), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(160), false, 1, 4, "Ag. Fazenda" },
                    { 77, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(170), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(160), false, 1, 4, "Ag. Órgãos" },
                    { 78, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(170), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(170), false, 1, 4, "Ag. Santa Cruz" },
                    { 79, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(170), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(170), false, 1, 4, "Ag. Ponta do Sol" },
                    { 80, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(180), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(180), false, 1, 4, "Ag. Maio" },
                    { 81, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(180), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(180), false, 1, 4, "Centro de empresas" },
                    { 82, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(190), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(190), false, 1, 4, "Centro de empresas II" },
                    { 83, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(200), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(200), false, 1, 4, "Ag. Sede" },
                    { 84, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(200), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(200), false, 1, 4, "Núcleo N/ Residentes" }
                });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[,]
                {
                    { 85, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(200), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(200), false, 1, 5, "Ag. Sede" },
                    { 86, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(210), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(210), false, 1, 5, "Ag. ASA" },
                    { 87, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(220), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(210), false, 1, 5, "Ag. Mindelo" },
                    { 88, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(220), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(220), false, 1, 5, "Ag. Plateau" },
                    { 89, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(220), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(220), false, 1, 5, "Ag. Espargos" },
                    { 90, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(230), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(220), false, 1, 5, "Ag. Santa Maria" },
                    { 91, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(230), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(230), false, 7, 5, "ag. Sal Rei – Boavista" },
                    { 92, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(230), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(230), false, 13, 5, "Ag. Assomada" },
                    { 93, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(240), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(230), false, 1, 5, "Ag. Achada Grande Trás" },
                    { 94, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(240), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(240), false, 1, 5, "Gab. Particulares (Praia)" },
                    { 95, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(240), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(240), false, 1, 5, "Gab. Empresas (Praia)" },
                    { 96, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(250), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(250), false, 1, 8, "Ag. Sede" },
                    { 97, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(250), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(250), false, 1, 8, "Ag. Plateau" },
                    { 98, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(250), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(250), false, 1, 8, "Ag ASA" },
                    { 99, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(260), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(260), false, 1, 8, "Ag. Mindelo" },
                    { 100, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(260), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(260), false, 1, 8, "Ag. Espargos" },
                    { 101, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(270), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(260), false, 1, 9, "Ag. Sede" },
                    { 102, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(270), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(270), false, 1, 9, "Serviços Centrais" },
                    { 103, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(270), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(270), false, 1, 9, "Emigrantes" },
                    { 104, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(280), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(280), false, 1, 9, "Particulares Classic" },
                    { 105, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(280), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(280), false, 1, 9, "Afluentes" },
                    { 106, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(280), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(280), false, 1, 9, "Private" },
                    { 107, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(290), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(290), false, 1, 9, "Institucionais" },
                    { 108, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(290), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(290), false, 1, 9, "PME Nacionais" },
                    { 109, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(300), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(290), false, 1, 9, "Grandes Empresas Nacionais" },
                    { 110, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(300), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(300), false, 1, 9, "Corporate Internacional" },
                    { 111, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(300), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(300), false, 1, 9, "Ag. Sal" },
                    { 112, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(310), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(300), false, 1, 9, "Emigrantes Sal" },
                    { 113, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(310), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(310), false, 1, 9, "Particulares Classic Sal" },
                    { 114, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(310), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(310), false, 1, 9, "Afluentes Sal" },
                    { 115, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(320), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(310), false, 1, 9, "Private Sal" },
                    { 116, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(320), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(320), false, 1, 9, "Institucionais Sal" },
                    { 117, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(320), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(320), false, 1, 9, "PME Nacionais Sal" },
                    { 118, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(330), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(330), false, 1, 9, "Grandes Empresas Nacionais Sal" },
                    { 119, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(330), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(330), false, 1, 11, "Ag. Sede - Praia" },
                    { 120, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(330), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(330), false, 13, 8, "Ag. Assomada" },
                    { 121, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(340), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(340), false, 1, 8, "Ag. Sta Maria " },
                    { 122, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(340), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(340), false, 1, 8, "Agencia Sal-Rei " },
                    { 123, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(340), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(340), false, 1, 8, "Agencia S.Filipe " },
                    { 124, new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(350), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(350), false, 1, 8, "Ag. Montsu " }
                });

            migrationBuilder.InsertData(
                table: "PerfilMenuAcao",
                columns: new[] { "IdPerfilMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdMenuAcao", "IdPPerfil" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3050), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3050), false, 1, 1 },
                    { 2, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3060), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3060), false, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "PerfilMenuAcao",
                columns: new[] { "IdPerfilMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdMenuAcao", "IdPPerfil" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3070), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3070), false, 3, 1 },
                    { 4, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3070), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3070), false, 4, 1 },
                    { 5, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3070), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3070), false, 5, 1 },
                    { 6, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3080), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3080), false, 6, 1 },
                    { 7, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3080), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3080), false, 7, 1 },
                    { 8, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3080), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3080), false, 8, 1 },
                    { 9, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3090), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3090), false, 9, 1 },
                    { 10, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3090), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3090), false, 10, 1 },
                    { 11, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3090), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3090), false, 11, 1 },
                    { 12, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3100), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3090), false, 12, 1 },
                    { 13, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3100), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3100), false, 13, 1 },
                    { 14, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3100), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3100), false, 14, 1 },
                    { 15, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3110), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3100), false, 15, 1 },
                    { 16, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3110), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3110), false, 16, 1 },
                    { 17, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3110), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3110), false, 17, 1 },
                    { 18, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3110), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3110), false, 18, 1 },
                    { 19, new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3120), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3120), false, 19, 1 }
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
                name: "IX_InstituicaoFinanceiraColaboradores_IdInstituicaoFinanceira",
                table: "InstituicaoFinanceiraColaboradores",
                column: "IdInstituicaoFinanceira");

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
                name: "ContaCorrenteIFResultado");

            migrationBuilder.DropTable(
                name: "ContaCorrenteSocioResultado");

            migrationBuilder.DropTable(
                name: "EstadoSocio");

            migrationBuilder.DropTable(
                name: "InstituicaoFinanceiraColaboradores");

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
