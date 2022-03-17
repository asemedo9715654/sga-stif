using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class AtualizaTabelaUtilizadorFazeOOOOOOOOOOOOOOOOOOOOOOOO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Utilizador_Perfil_IdPerfil",
                table: "Utilizador");

            migrationBuilder.AlterColumn<int>(
                name: "IdPerfil",
                table: "Utilizador",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Utilizador_Perfil_IdPerfil",
                table: "Utilizador",
                column: "IdPerfil",
                principalTable: "Perfil",
                principalColumn: "IdPerfil");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Utilizador_Perfil_IdPerfil",
                table: "Utilizador");

            migrationBuilder.AlterColumn<int>(
                name: "IdPerfil",
                table: "Utilizador",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Utilizador_Perfil_IdPerfil",
                table: "Utilizador",
                column: "IdPerfil",
                principalTable: "Perfil",
                principalColumn: "IdPerfil",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
