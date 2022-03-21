using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class inicioDoComit : Migration
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

            migrationBuilder.InsertData(
                table: "Acao",
                columns: new[] { "IdAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 1, new DateTime(2022, 3, 19, 22, 16, 34, 781, DateTimeKind.Local).AddTicks(9020), new DateTime(2022, 3, 19, 22, 16, 34, 781, DateTimeKind.Local).AddTicks(8990), false, "Criar" });

            migrationBuilder.InsertData(
                table: "Acao",
                columns: new[] { "IdAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 2, new DateTime(2022, 3, 19, 22, 16, 34, 781, DateTimeKind.Local).AddTicks(9040), new DateTime(2022, 3, 19, 22, 16, 34, 781, DateTimeKind.Local).AddTicks(9030), false, "Editar" });

            migrationBuilder.InsertData(
                table: "Acao",
                columns: new[] { "IdAcao", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 3, new DateTime(2022, 3, 19, 22, 16, 34, 781, DateTimeKind.Local).AddTicks(9070), new DateTime(2022, 3, 19, 22, 16, 34, 781, DateTimeKind.Local).AddTicks(9070), false, "Eliminar" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "IdMenuPai", "Nome" },
                values: new object[] { 1, new DateTime(2022, 3, 19, 22, 16, 34, 781, DateTimeKind.Local).AddTicks(9100), new DateTime(2022, 3, 19, 22, 16, 34, 781, DateTimeKind.Local).AddTicks(9100), "Administração do Sistema SGA-STIF", false, null, "Administração" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "IdMenuPai", "Nome" },
                values: new object[] { 2, new DateTime(2022, 3, 19, 22, 16, 34, 781, DateTimeKind.Local).AddTicks(9110), new DateTime(2022, 3, 19, 22, 16, 34, 781, DateTimeKind.Local).AddTicks(9110), "Gestão dos utilizadores", false, 1, "Utilizador" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "IdMenuPai", "Nome" },
                values: new object[] { 3, new DateTime(2022, 3, 19, 22, 16, 34, 781, DateTimeKind.Local).AddTicks(9110), new DateTime(2022, 3, 19, 22, 16, 34, 781, DateTimeKind.Local).AddTicks(9110), "Gestão dos utilizadores", false, 1, "Perfil" });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "IdMenu", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado", "IdMenuPai", "Nome" },
                values: new object[] { 4, new DateTime(2022, 3, 19, 22, 16, 34, 781, DateTimeKind.Local).AddTicks(9120), new DateTime(2022, 3, 19, 22, 16, 34, 781, DateTimeKind.Local).AddTicks(9120), "Gestão dos utilizadores", false, 1, "Menu" });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "IdPerfil", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado" },
                values: new object[] { 1, new DateTime(2022, 3, 19, 22, 16, 34, 240, DateTimeKind.Local).AddTicks(7030), new DateTime(2022, 3, 19, 22, 16, 34, 240, DateTimeKind.Local).AddTicks(7000), "Administrador", false });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "IdPerfil", "DataAtualizacao", "DataCriacao", "Descricao", "Eliminado" },
                values: new object[] { 2, new DateTime(2022, 3, 19, 22, 16, 34, 240, DateTimeKind.Local).AddTicks(7050), new DateTime(2022, 3, 19, 22, 16, 34, 240, DateTimeKind.Local).AddTicks(7050), "Operador", false });

            migrationBuilder.InsertData(
                table: "Utilizador",
                columns: new[] { "IdUtilizador", "Apelido", "DataAtualizacao", "DataCriacao", "Eliminado", "Email", "Foto", "IdPerfil", "Nome", "NomeUtilizador", "PalavraPasse" },
                values: new object[] { 1, "Semedo", new DateTime(2022, 3, 19, 22, 16, 34, 240, DateTimeKind.Local).AddTicks(7210), new DateTime(2022, 3, 19, 22, 16, 34, 240, DateTimeKind.Local).AddTicks(7200), false, "angelosemedo@sgastif.cv", null, 1, "Angelo", "angelosemedo", "$2a$11$6cbodHrGQfY8GXu53Kd7g.voZ49pqI66K36py7TI1HWOMLl2qc4C." });

            migrationBuilder.InsertData(
                table: "Utilizador",
                columns: new[] { "IdUtilizador", "Apelido", "DataAtualizacao", "DataCriacao", "Eliminado", "Email", "Foto", "IdPerfil", "Nome", "NomeUtilizador", "PalavraPasse" },
                values: new object[] { 2, "Veiga", new DateTime(2022, 3, 19, 22, 16, 34, 420, DateTimeKind.Local).AddTicks(1320), new DateTime(2022, 3, 19, 22, 16, 34, 420, DateTimeKind.Local).AddTicks(1290), false, "odailtonveiga@sgastif.cv", null, 1, "Odailton", "odailtonveiga", "$2a$11$fX0yhLZ17JTouIHm9IpO4utW/wrOTziEREkY4uwq.wqbau0CKJz2K" });

            migrationBuilder.InsertData(
                table: "Utilizador",
                columns: new[] { "IdUtilizador", "Apelido", "DataAtualizacao", "DataCriacao", "Eliminado", "Email", "Foto", "IdPerfil", "Nome", "NomeUtilizador", "PalavraPasse" },
                values: new object[] { 3, "Varela", new DateTime(2022, 3, 19, 22, 16, 34, 600, DateTimeKind.Local).AddTicks(1890), new DateTime(2022, 3, 19, 22, 16, 34, 600, DateTimeKind.Local).AddTicks(1850), false, "manuelvarela@sgastif.cv", null, 1, "Manuel", "manuelvarela", "$2a$11$QLngQxQNs3rpsuivgaXx6e/ueMOLWlnaHEltlzBYBYB3u92GINj8G" });

            migrationBuilder.CreateIndex(
                name: "IX_MenuAcao_IdAcao",
                table: "MenuAcao",
                column: "IdAcao");

            migrationBuilder.CreateIndex(
                name: "IX_MenuAcao_IdMenu",
                table: "MenuAcao",
                column: "IdMenu");

            migrationBuilder.CreateIndex(
                name: "IX_Utilizador_IdPerfil",
                table: "Utilizador",
                column: "IdPerfil");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuAcao");

            migrationBuilder.DropTable(
                name: "Utilizador");

            migrationBuilder.DropTable(
                name: "Acao");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Perfil");
        }
    }
}
