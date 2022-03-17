using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class atualizacaoTabelaUtilizadorEAcrescentacaoDaTabelaPerfil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Utilizador",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Utilizador",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Utilizador",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IdPerfil",
                table: "Utilizador",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PerfilIdPerfil",
                table: "Utilizador",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    IdPerfil = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.IdPerfil);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Utilizador_PerfilIdPerfil",
                table: "Utilizador",
                column: "PerfilIdPerfil");

            migrationBuilder.AddForeignKey(
                name: "FK_Utilizador_Perfil_PerfilIdPerfil",
                table: "Utilizador",
                column: "PerfilIdPerfil",
                principalTable: "Perfil",
                principalColumn: "IdPerfil",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Utilizador_Perfil_PerfilIdPerfil",
                table: "Utilizador");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropIndex(
                name: "IX_Utilizador_PerfilIdPerfil",
                table: "Utilizador");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Utilizador");

            migrationBuilder.DropColumn(
                name: "IdPerfil",
                table: "Utilizador");

            migrationBuilder.DropColumn(
                name: "PerfilIdPerfil",
                table: "Utilizador");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataCriacao",
                table: "Utilizador",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAtualizacao",
                table: "Utilizador",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
