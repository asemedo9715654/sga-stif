using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class AdicaoDaTabelaMenuAcao : Migration
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

            migrationBuilder.InsertData(
                table: "Acao",
                columns: new[] { "IdAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 1, new DateTime(2022, 3, 18, 10, 42, 41, 13, DateTimeKind.Local).AddTicks(1019), new DateTime(2022, 3, 18, 10, 42, 41, 13, DateTimeKind.Local).AddTicks(1002), false, "Criar" });

            migrationBuilder.InsertData(
                table: "Acao",
                columns: new[] { "IdAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 2, new DateTime(2022, 3, 18, 10, 42, 41, 13, DateTimeKind.Local).AddTicks(1030), new DateTime(2022, 3, 18, 10, 42, 41, 13, DateTimeKind.Local).AddTicks(1029), false, "Editar" });

            migrationBuilder.InsertData(
                table: "Acao",
                columns: new[] { "IdAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 3, new DateTime(2022, 3, 18, 10, 42, 41, 13, DateTimeKind.Local).AddTicks(1032), new DateTime(2022, 3, 18, 10, 42, 41, 13, DateTimeKind.Local).AddTicks(1031), false, "Eliminar" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "IdMenuPai", "Nome" },
                values: new object[] { 1, new DateTime(2022, 3, 18, 10, 42, 41, 13, DateTimeKind.Local).AddTicks(1306), new DateTime(2022, 3, 18, 10, 42, 41, 13, DateTimeKind.Local).AddTicks(1304), "Gestão dos utilizadores", false, null, "Utilizador" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "IdMenuPai", "Nome" },
                values: new object[] { 2, new DateTime(2022, 3, 18, 10, 42, 41, 13, DateTimeKind.Local).AddTicks(1312), new DateTime(2022, 3, 18, 10, 42, 41, 13, DateTimeKind.Local).AddTicks(1311), "Gestão dos utilizadores", false, 1, "Utilizador" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "IdMenuPai", "Nome" },
                values: new object[] { 3, new DateTime(2022, 3, 18, 10, 42, 41, 13, DateTimeKind.Local).AddTicks(1315), new DateTime(2022, 3, 18, 10, 42, 41, 13, DateTimeKind.Local).AddTicks(1314), "Gestão dos utilizadores", false, 1, "Perfil" });

            migrationBuilder.CreateIndex(
                name: "IX_MenuAcao_IdAcao",
                table: "MenuAcao",
                column: "IdAcao");

            migrationBuilder.CreateIndex(
                name: "IX_MenuAcao_IdMenu",
                table: "MenuAcao",
                column: "IdMenu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuAcao");

            migrationBuilder.DropTable(
                name: "Acao");

            migrationBuilder.DropTable(
                name: "Menu");
        }
    }
}
