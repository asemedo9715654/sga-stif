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
                    EstadoQuotaNum = table.Column<int>(type: "int", nullable: false),
                    IdQuotaSocio = table.Column<int>(type: "int", nullable: false),
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
                    EstadoQuota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoQuotaNum = table.Column<int>(type: "int", nullable: false),
                    IdQuotaSocio = table.Column<int>(type: "int", nullable: false)
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
                    Sigla = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataAtivacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumeroColaborador = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoSocio = table.Column<int>(type: "int", nullable: false),
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
                    UtilizadorQueEfectuouPagamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataQueFoiEfectuadaPagamento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UtilizadorQueConfirmouPagamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataQueFoiConfirmadaPagamento = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    { 1, true, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9240), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9220), false, "Administração" },
                    { 2, false, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9250), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9250), false, "Criar" },
                    { 3, false, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9250), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9250), false, "Editar" },
                    { 4, false, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9250), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9250), false, "Eliminar" }
                });

            migrationBuilder.InsertData(
                table: "Ilha",
                columns: new[] { "IdIlha", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8410), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8400), false, "Santo Antão" },
                    { 2, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8410), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8410), false, "São Vicente" },
                    { 3, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8420), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8410), false, "Santa Luzia" },
                    { 4, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8420), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8420), false, "São Nicolau" },
                    { 5, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8420), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8420), false, "Sal" },
                    { 6, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8430), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8430), false, "Boavista" },
                    { 7, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8430), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8430), false, "Maio" },
                    { 8, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8440), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8430), false, "Santiago" },
                    { 9, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8440), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8440), false, "Fogo" },
                    { 10, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8440), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8440), false, "Brava" }
                });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome", "Sigla" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8600), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8590), false, "Caixa Económica de Cabo Verde", "CECV" },
                    { 3, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8600), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8600), false, "Banco Comercial do Atlântico", "BCA" },
                    { 4, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8600), false, "Banco Caboverdiano de Negócios", "BCN" },
                    { 5, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8620), false, "Banco Interatlântico", "BI" },
                    { 8, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8620), false, "Banco Angolano de Investimentos", "BAI" },
                    { 9, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8620), false, "International Investment Bank", "IIB" },
                    { 11, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8630), false, "Ecobank Cabo Verde SA", "ECV" }
                });

            migrationBuilder.InsertData(
                table: "Joia",
                columns: new[] { "IdJoia", "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio", "Descricao", "Eliminado", "Montante" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9400), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9400), null, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9410), "Jóia STIF", false, 1000m });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Icone", "IdMenuPai", "Nome", "NomeDaAction", "NomeDoController" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9440), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9440), "Gestão de Sócios", false, "fas fa-user", null, "Gestão de Sócios", "", "" },
                    { 2, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9460), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9460), "Lista de Sócios", false, "far fa-circle", 1, "Lista  Sócios", "ListaSocio", "Socio" },
                    { 3, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9460), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9460), "Ranquing de Sócios", false, "far fa-circle", 1, "Ranking Sócios", "", "" },
                    { 4, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9470), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9470), "Contas Correntes", false, "fas fa-book", null, "Contas Correntes", "", "" },
                    { 5, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9470), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9470), "Quotas Pendentes", false, "far fa-circle", 4, "Quotas Pendentes", "ListaQuotasPendente", "ContaCorrentes" },
                    { 6, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9480), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9480), "Quotas Por Pagar", false, "far fa-circle", 4, "Quotas Por Pagar", "ListaQuotasPorPagar", "ContaCorrentes" },
                    { 7, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9480), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9480), "Quotas Paga", false, "far fa-circle", 4, "Quotas Pagas", "ListaQuotasPagas", "ContaCorrentes" },
                    { 8, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9480), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9480), "Quotas Vencidas", false, "far fa-circle", 4, "Quotas Vencidas", "ListaQuotasVencidas", "ContaCorrentes" },
                    { 9, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9490), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9490), "Posição de IF", false, "fas fa-search", null, "Posição de IF", "", "" },
                    { 10, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9490), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9490), "Projeção de Quotas", false, "fas fa-table", null, "Projeção de Quotas", "", "" },
                    { 11, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9490), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9490), "Estatística", false, "fas fa-chart-pie", null, "Estatística", "Inicio", "Estatistica" },
                    { 12, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9500), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9500), "Configurações", false, "far fa-edit", null, "Configurações", "", "" },
                    { 13, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9500), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9500), "Instituição Financeira", false, "far fa-circle", 12, "Utilizadores", "ListaUtilizador", "Utilizador" },
                    { 14, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9500), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9500), "Instituição Financeira", false, "far fa-circle", 12, "Perfil", "ListaPerfil", "Perfil" },
                    { 15, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9510), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9500), "Gestão de Menu", false, "far fa-circle", 12, "Menu", "ListaMenu", "MenuAcao" },
                    { 16, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9510), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9510), "Instituição Financeira", false, "far fa-circle", 12, "Instituição Financeira", "ListaInstituicaoFinanceira", "InstituicaoFinanceira" },
                    { 17, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9510), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9510), "Agência", false, "far fa-circle", 12, "Agência", "ListaAgencia", "Agencia" },
                    { 18, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9520), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9520), "Tipo Quotas", false, "far fa-circle", 12, "Tipo Quotas", "ListaTipoQuota", "TipoQuota" },
                    { 19, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9520), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9520), "Tipologia Sócio", false, "far fa-circle", 12, "Tipologia Sócio", "ListaTipologiaSocio", "TipologiaSocio" }
                });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "IdPerfil", "DataAtualizacao", "DataCriacao", "Descricao", "Editavel", "Eliminado", "Nome" },
                values: new object[] { 1, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8560), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8560), "Perfil de Administrador", false, false, "Administrador" });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "IdPerfil", "DataAtualizacao", "DataCriacao", "Descricao", "Editavel", "Eliminado", "Nome" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8570), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8570), "Perfil de Operador", true, false, "Auditor" },
                    { 3, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8570), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8570), "Perfil de Operador", true, false, "Operador Teste" }
                });

            migrationBuilder.InsertData(
                table: "TipoQuota",
                columns: new[] { "IdTipoQuota", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "Montante", "Priodicidade", "Tipo" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8320), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8320), "Quinzenal", true, 0m, 0, 1 },
                    { 2, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8330), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8320), "Mensal", false, 0m, 1, 0 },
                    { 3, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8340), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8340), "Trimestral", true, 0m, 3, 1 },
                    { 4, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8350), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8340), "Semestral", true, 0m, 6, 1 },
                    { 5, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8350), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8350), "Anual", true, 0m, 12, 1 }
                });

            migrationBuilder.InsertData(
                table: "TipologiaSocio",
                columns: new[] { "IdTipologiaSocio", "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio", "Descricao", "Eliminado", "Tipo" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8090), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8060), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8100), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8100), "Normal", false, 0 },
                    { 2, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8110), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8110), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8110), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8110), "Honorário", true, 1 }
                });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8470), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8470), false, 8, "Praia" },
                    { 2, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8470), false, 8, "Outro" },
                    { 3, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8480), false, 2, "Mindelo" },
                    { 4, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8480), false, 5, "Santa Maria" },
                    { 5, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8490), false, 7, "Vila do Maio" },
                    { 6, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8490), false, 8, "Santa Cruz" },
                    { 7, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8490), false, 6, "Sal Rei" },
                    { 8, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8500), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8500), false, 1, "Porto Novo" },
                    { 9, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8500), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8500), false, 8, "Ribeira Grande" },
                    { 10, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8510), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8500), false, 10, "Ribeira Brava" },
                    { 11, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8510), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8510), false, 1, "Tarrafal" },
                    { 12, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8510), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8510), false, 5, "Espargos" },
                    { 13, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8520), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8510), false, 8, "Assomada" },
                    { 14, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8520), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8520), false, 8, "São Domingos" },
                    { 15, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8520), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8520), false, 9, "São Filipe" },
                    { 16, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8530), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8520), false, 9, "Mosteiros" },
                    { 17, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8530), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8530), false, 1, "Nova Sintra" },
                    { 18, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8530), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8530), false, 8, "Tarrafal (Santiano)" }
                });

            migrationBuilder.InsertData(
                table: "MenuAcao",
                columns: new[] { "IdMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdAcao", "IdMenu", "MenuAcaoMaster" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9600), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9600), false, 1, 1, true },
                    { 2, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9610), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9610), false, 1, 2, true },
                    { 3, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9610), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9610), false, 1, 3, true },
                    { 4, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9610), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9610), false, 1, 4, true },
                    { 5, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9620), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9620), false, 1, 5, true },
                    { 6, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9620), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9620), false, 1, 6, true },
                    { 7, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9620), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9620), false, 1, 7, true },
                    { 8, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9630), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9630), false, 1, 8, true },
                    { 9, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9640), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9640), false, 1, 9, true },
                    { 10, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9640), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9640), false, 1, 10, true },
                    { 11, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9650), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9650), false, 1, 11, true },
                    { 12, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9650), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9650), false, 1, 12, true },
                    { 13, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9650), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9650), false, 1, 13, true },
                    { 14, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9660), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9650), false, 1, 14, true },
                    { 15, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9660), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9660), false, 1, 15, true },
                    { 16, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9660), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9660), false, 1, 16, true },
                    { 17, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9660), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9660), false, 1, 17, true },
                    { 18, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9670), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9670), false, 1, 18, true },
                    { 19, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9670), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9670), false, 1, 19, true }
                });

            migrationBuilder.InsertData(
                table: "Utilizador",
                columns: new[] { "IdUtilizador", "Apelido", "DataAtualizacao", "DataCriacao", "Eliminado", "Email", "Foto", "IdPerfil", "Nome", "NomeUtilizador", "PalavraPasse" },
                values: new object[,]
                {
                    { 1, "Semedo", new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9200), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9200), false, "asemedo@sgastif.cv", null, 1, "Angelo", "asemedo", "$2a$11$D.dfJkQDzQHfOZUX4TvElugrlpGapbHzEhcFg.2KRbrMt7zM.7jPi" },
                    { 2, "Veiga", new DateTime(2022, 5, 11, 21, 5, 51, 804, DateTimeKind.Local).AddTicks(4050), new DateTime(2022, 5, 11, 21, 5, 51, 804, DateTimeKind.Local).AddTicks(4040), false, "oveiga@sgastif.cv", null, 1, "Odailton", "oveiga", "$2a$11$q.8n7q.dOS8oVBztBM2n8e.P1iVwvYbVb1R8ifprV4iP/DRUYKEr6" },
                    { 3, "Varela", new DateTime(2022, 5, 11, 21, 5, 51, 991, DateTimeKind.Local).AddTicks(7930), new DateTime(2022, 5, 11, 21, 5, 51, 991, DateTimeKind.Local).AddTicks(7910), false, "mvarela@sgastif.cv", null, 1, "Manuel", "mvarela", "$2a$11$B4ncAS8oOj/FPUA3GZ/npenvjoUcSSp2j85n0iKrIlirk1XrzoLlK" },
                    { 4, "Tavares", new DateTime(2022, 5, 11, 21, 5, 52, 175, DateTimeKind.Local).AddTicks(1320), new DateTime(2022, 5, 11, 21, 5, 52, 175, DateTimeKind.Local).AddTicks(1310), false, "jgoncalves@sgastif.cv", null, 1, "Jair", "jgoncalves", "$2a$11$7AC23tM.fdhZrw6fI77X2.ubX9pKUx67G7xRBrBBaDYgmdaZRPLiu" },
                    { 5, "Teixeira", new DateTime(2022, 5, 11, 21, 5, 52, 363, DateTimeKind.Local).AddTicks(4100), new DateTime(2022, 5, 11, 21, 5, 52, 363, DateTimeKind.Local).AddTicks(4080), false, "jteixeira@sgastif.cv", null, 1, "Jose", "jteixeira", "$2a$11$PQAnZ1A9HbDtmrMYAqvSeelMy3n8ILs4zQ1eEmedqJSloRGhSEEIq" }
                });

            migrationBuilder.InsertData(
                table: "Utilizador",
                columns: new[] { "IdUtilizador", "Apelido", "DataAtualizacao", "DataCriacao", "Eliminado", "Email", "Foto", "IdPerfil", "Nome", "NomeUtilizador", "PalavraPasse" },
                values: new object[] { 6, "Trigueiros", new DateTime(2022, 5, 11, 21, 5, 52, 544, DateTimeKind.Local).AddTicks(7640), new DateTime(2022, 5, 11, 21, 5, 52, 544, DateTimeKind.Local).AddTicks(7630), false, "jtrigueiros@sgastif.cv", null, 1, "Jose", "jtrigueiros", "$2a$11$.TxeOQ.Lwc6NGlJ0hZZ2a.qWeXZMPR6m1HxoSp9qvwsTT4PGHof9C" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8650), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8650), false, 1, 2, "Ag. Fazenda" },
                    { 2, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8660), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8660), false, 1, 2, "Ag. Mindelo" },
                    { 3, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8670), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8660), false, 1, 2, "Ag. ASA" },
                    { 4, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8670), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8670), false, 13, 2, "Ag. Assomada" },
                    { 5, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8670), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8670), false, 1, 2, "Ag. Espargos" },
                    { 6, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8680), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8670), false, 9, 2, "Ag. Rª Grande" },
                    { 7, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8680), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8680), false, 1, 2, "Ag. St. Maria" },
                    { 8, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8680), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8680), false, 1, 2, "Ag. Plateau" },
                    { 9, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8690), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8690), false, 3, 2, "Ag. Monte Sossego" },
                    { 10, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8690), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8690), false, 1, 2, "Ag. Palmarejo" },
                    { 11, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8690), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8690), false, 1, 2, "Ag. São Filipe" },
                    { 12, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8700), false, 1, 2, "Ag. Calheta S. Miguel" },
                    { 13, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8700), false, 1, 2, "Ag. Aeroporto da Praia" },
                    { 14, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8710), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8700), false, 7, 2, "Ag. Boavista" },
                    { 15, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8710), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8710), false, 12, 2, "Ag. Aeroporto do Sal" },
                    { 16, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8710), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8710), false, 1, 2, "Ag. Sucupira" },
                    { 17, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8720), false, 14, 2, "Ag. CCV – São Domingos" },
                    { 18, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8720), false, 18, 2, "Ag. Tarrafal" },
                    { 19, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8720), false, 1, 2, "Ag. Santa Cruz" },
                    { 20, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8730), false, 8, 2, "Ag. CCV – Porto Novo" },
                    { 21, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8730), false, 1, 2, "Ag. CCV - Plateau" },
                    { 22, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8730), false, 1, 2, "Ag. A. São Filipe" },
                    { 23, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8740), false, 16, 2, "Ag. Mosteiros" },
                    { 24, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8740), false, 1, 2, "Ag. Caixa Empresas" },
                    { 25, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8750), false, 1, 2, "Ag. Coculi" },
                    { 26, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8750), false, 1, 2, "Ag. Paul" },
                    { 27, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8750), false, 1, 2, "Ag. Fonte Cónego" },
                    { 28, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8760), false, 7, 2, "Ag. Aeroporto Boavista" },
                    { 29, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8760), false, 5, 2, "Ag. Maio" },
                    { 30, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8760), false, 1, 2, "Ag. Porto Novo" },
                    { 31, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8770), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8770), false, 1, 2, "Ag. Ribeira Brava" },
                    { 32, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8770), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8770), false, 1, 2, "Ag. Ribeira Brava" },
                    { 33, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8780), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8770), false, 18, 2, "Ag. Tarrafal" },
                    { 34, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8780), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8780), false, 1, 3, "Ag. Praia" },
                    { 35, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8780), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8780), false, 1, 3, "Ag. S. Vicente " },
                    { 36, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8790), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8780), false, 4, 3, "Ag. Sal" },
                    { 37, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8790), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8790), false, 1, 3, "Ag. S. Filipe" },
                    { 38, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8800), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8800), false, 18, 3, "Ag. Tarrafal" },
                    { 39, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8810), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8800), false, 1, 3, "Ag. S. Catarina" },
                    { 40, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8810), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8810), false, 1, 3, "Ag. Porto Novo" },
                    { 41, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8810), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8810), false, 9, 3, "Ag. Rª Grande" },
                    { 42, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8820), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8820), false, 1, 3, "Ag. Brava" }
                });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[,]
                {
                    { 43, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8820), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8820), false, 1, 3, "Ag. Boavista" },
                    { 44, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8820), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8820), false, 1, 3, "Ag. S. Nicolau" },
                    { 45, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8830), false, 5, 3, "Ag. Maio" },
                    { 46, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8830), false, 6, 3, "Ag. Santa Cruz" },
                    { 47, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8830), false, 1, 3, "Ag. Praça Nova" },
                    { 48, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8840), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8840), false, 1, 3, "Ag. ASA" },
                    { 49, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8840), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8840), false, 1, 3, "Ag. Avenida" },
                    { 50, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8850), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8850), false, 3, 3, "Ag. Monte Sossego" },
                    { 51, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8850), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8850), false, 3, 3, "Ag. Fonte Filipe" },
                    { 52, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8850), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8850), false, 4, 3, "Ag. Santa Maria" },
                    { 53, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8860), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8860), false, 16, 3, "Ag. Mosteiros" },
                    { 54, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8860), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8860), false, 11, 3, "Ag. Tarrafal S. Nicolau" },
                    { 55, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8860), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8860), false, 1, 3, "Ag. ASA II" },
                    { 56, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8870), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8870), false, 1, 3, "Gabinete Empresas Sul" },
                    { 57, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8870), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8870), false, 1, 3, "Gabinete Empresas Norte" },
                    { 58, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8870), false, 1, 3, "Ag. S. Domingos" },
                    { 59, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8880), false, 1, 3, "Ag. Palmarejo" },
                    { 60, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8880), false, 1, 3, "Gabinete Empresas Sul II" },
                    { 61, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8890), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8880), false, 4, 3, "Gabinete Empresas Sal" },
                    { 62, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8890), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8890), false, 1, 3, "Prol. Ach. São Filipe" },
                    { 63, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8890), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8890), false, 1, 4, "Ag. Praia" },
                    { 64, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8900), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8900), false, 1, 4, "Ag. Mindelo" },
                    { 65, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8900), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8900), false, 13, 4, "Ag. Assomada" },
                    { 66, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8900), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8900), false, 4, 4, "Ag. Aeroporto do Sal" },
                    { 67, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8910), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8910), false, 1, 4, "Ag. Boavista" },
                    { 68, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8910), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8910), false, 1, 4, "Ag. Porto Novo" },
                    { 69, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8920), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8910), false, 1, 4, "Ag. Terra Branca" },
                    { 70, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8920), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8920), false, 1, 4, "Ag. Palmarejo" },
                    { 71, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8920), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8920), false, 3, 4, "Ag. Monte Sossego" },
                    { 72, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8930), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8920), false, 1, 4, "Ag. Santa Maria" },
                    { 73, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8930), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8930), false, 1, 4, "Ag. São Filipe" },
                    { 74, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8930), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8930), false, 9, 4, "Ag. Rª Grande" },
                    { 75, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8940), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8940), false, 1, 4, "ASA – Private Banking" },
                    { 76, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8940), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8940), false, 1, 4, "Ag. Fazenda" },
                    { 77, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8940), false, 1, 4, "Ag. Órgãos" },
                    { 78, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8950), false, 1, 4, "Ag. Santa Cruz" },
                    { 79, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8950), false, 1, 4, "Ag. Ponta do Sol" },
                    { 80, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8960), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8950), false, 5, 4, "Ag. Maio" },
                    { 81, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8960), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8960), false, 1, 4, "Centro de empresas" },
                    { 82, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8960), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8960), false, 1, 4, "Centro de empresas II" },
                    { 83, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8970), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8970), false, 1, 4, "Ag. Sede" },
                    { 84, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8970), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8970), false, 1, 4, "Núcleo N/ Residentes" }
                });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[,]
                {
                    { 85, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8970), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8970), false, 1, 5, "Ag. Sede" },
                    { 86, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8980), false, 1, 5, "Ag. ASA" },
                    { 87, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8980), false, 1, 5, "Ag. Mindelo" },
                    { 88, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8980), false, 1, 5, "Ag. Plateau" },
                    { 89, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8990), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8990), false, 1, 5, "Ag. Espargos" },
                    { 90, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9000), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9000), false, 1, 5, "Ag. Santa Maria" },
                    { 91, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9000), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9000), false, 7, 5, "ag. Sal Rei – Boavista" },
                    { 92, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9010), false, 13, 5, "Ag. Assomada" },
                    { 93, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9010), false, 1, 5, "Ag. Achada Grande Trás" },
                    { 94, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9020), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9010), false, 1, 5, "Gab. Particulares (Praia)" },
                    { 95, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9020), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9020), false, 1, 5, "Gab. Empresas (Praia)" },
                    { 96, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9020), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9020), false, 1, 8, "Ag. Sede" },
                    { 97, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9030), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9020), false, 1, 8, "Ag. Plateau" },
                    { 98, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9030), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9030), false, 1, 8, "Ag ASA" },
                    { 99, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9030), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9030), false, 1, 8, "Ag. Mindelo" },
                    { 100, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9040), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9040), false, 1, 8, "Ag. Espargos" },
                    { 101, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9040), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9040), false, 1, 9, "Ag. Sede" },
                    { 102, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9050), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9040), false, 1, 9, "Serviços Centrais" },
                    { 103, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9050), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9050), false, 1, 9, "Emigrantes" },
                    { 104, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9050), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9050), false, 1, 9, "Particulares Classic" },
                    { 105, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9060), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9050), false, 1, 9, "Afluentes" },
                    { 106, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9060), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9060), false, 1, 9, "Private" },
                    { 107, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9060), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9060), false, 1, 9, "Institucionais" },
                    { 108, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9070), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9070), false, 1, 9, "PME Nacionais" },
                    { 109, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9070), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9070), false, 1, 9, "Grandes Empresas Nacionais" },
                    { 110, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9070), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9070), false, 1, 9, "Corporate Internacional" },
                    { 111, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9080), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9080), false, 4, 9, "Ag. Sal" },
                    { 112, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9080), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9080), false, 4, 9, "Emigrantes Sal" },
                    { 113, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9080), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9080), false, 4, 9, "Particulares Classic Sal" },
                    { 114, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9090), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9090), false, 4, 9, "Afluentes Sal" },
                    { 115, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9090), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9090), false, 4, 9, "Private Sal" },
                    { 116, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9100), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9090), false, 4, 9, "Institucionais Sal" },
                    { 117, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9100), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9100), false, 4, 9, "PME Nacionais Sal" },
                    { 118, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9100), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9100), false, 1, 9, "Grandes Empresas Nacionais Sal" },
                    { 119, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9110), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9100), false, 1, 11, "Ag. Sede - Praia" },
                    { 120, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9110), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9110), false, 13, 8, "Ag. Assomada" },
                    { 121, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9110), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9110), false, 1, 8, "Ag. Sta Maria " },
                    { 122, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9120), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9120), false, 1, 8, "Agencia Sal-Rei " },
                    { 123, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9120), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9120), false, 1, 8, "Agencia S.Filipe " },
                    { 124, new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9120), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9120), false, 3, 8, "Ag. Montsu " }
                });

            migrationBuilder.InsertData(
                table: "PerfilMenuAcao",
                columns: new[] { "IdPerfilMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdMenuAcao", "IdPPerfil" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9710), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9710), false, 1, 1 },
                    { 2, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9720), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9720), false, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "PerfilMenuAcao",
                columns: new[] { "IdPerfilMenuAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "IdMenuAcao", "IdPPerfil" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9730), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9730), false, 3, 1 },
                    { 4, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9730), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9730), false, 4, 1 },
                    { 5, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9730), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9730), false, 5, 1 },
                    { 6, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9740), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9730), false, 6, 1 },
                    { 7, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9740), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9740), false, 7, 1 },
                    { 8, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9740), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9740), false, 8, 1 },
                    { 9, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9740), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9740), false, 9, 1 },
                    { 10, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9750), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9750), false, 10, 1 },
                    { 11, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9750), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9750), false, 11, 1 },
                    { 12, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9750), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9750), false, 12, 1 },
                    { 13, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9750), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9750), false, 13, 1 },
                    { 14, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9760), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9750), false, 14, 1 },
                    { 15, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9760), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9760), false, 15, 1 },
                    { 16, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9760), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9760), false, 16, 1 },
                    { 17, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9760), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9760), false, 17, 1 },
                    { 18, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9770), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9770), false, 18, 1 },
                    { 19, new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9770), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9770), false, 19, 1 }
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
