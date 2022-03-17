using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class AtualizaTabelaUtilizadorFazerCampoIdPerfilNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Utilizador_Perfil_PerfilIdPerfil",
                table: "Utilizador");

            migrationBuilder.DropIndex(
                name: "IX_Utilizador_PerfilIdPerfil",
                table: "Utilizador");

            migrationBuilder.DropColumn(
                name: "PerfilIdPerfil",
                table: "Utilizador");

            migrationBuilder.CreateIndex(
                name: "IX_Utilizador_IdPerfil",
                table: "Utilizador",
                column: "IdPerfil");

            migrationBuilder.AddForeignKey(
                name: "FK_Utilizador_Perfil_IdPerfil",
                table: "Utilizador",
                column: "IdPerfil",
                principalTable: "Perfil",
                principalColumn: "IdPerfil",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Utilizador_Perfil_IdPerfil",
                table: "Utilizador");

            migrationBuilder.DropIndex(
                name: "IX_Utilizador_IdPerfil",
                table: "Utilizador");

            migrationBuilder.AddColumn<int>(
                name: "PerfilIdPerfil",
                table: "Utilizador",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

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
    }
}
