using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class AtualizacaoDaTabelaSocio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socio_TipoQuota_TipoQuotaIdTipoQuota",
                table: "Socio");

            migrationBuilder.DropIndex(
                name: "IX_Socio_TipoQuotaIdTipoQuota",
                table: "Socio");

            migrationBuilder.DropColumn(
                name: "TipoQuotaIdTipoQuota",
                table: "Socio");

            migrationBuilder.AddColumn<int>(
                name: "IdTipoQuota",
                table: "Socio",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 19, 32, DateTimeKind.Local).AddTicks(2370), new DateTime(2022, 3, 22, 20, 33, 19, 32, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 19, 32, DateTimeKind.Local).AddTicks(2380), new DateTime(2022, 3, 22, 20, 33, 19, 32, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 19, 32, DateTimeKind.Local).AddTicks(2380), new DateTime(2022, 3, 22, 20, 33, 19, 32, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 1, new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8700), false, 8, "Praia" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 2, new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8710), false, 8, "Outro" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 3, new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8720), false, 2, "Mindelo" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 4, new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8720), false, 5, "Santa Maria" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 5, new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8720), false, 7, "Vila do Maio" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 6, new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8730), false, 8, "Santa Cruz" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 7, new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8730), false, 6, "Sal Rei" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 8, new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8730), false, 1, "Porto Novo" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 9, new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8740), false, 8, "Ribeira Grande" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 10, new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8740), false, 10, "Ribeira Brava" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 11, new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8740), false, 1, "Tarrafal" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 12, new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8750), false, 5, "Espargos" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 13, new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8750), false, 8, "Assomada" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 14, new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8750), false, 8, "São Domingos" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 15, new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8760), false, 9, "São Filipe" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 16, new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8760), false, 9, "Mosteiros" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 17, new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8760), false, 1, "Nova Sintra" });

            migrationBuilder.InsertData(
                table: "Cidade",
                columns: new[] { "IdCidade", "DataAtualizacao", "DataCriacao", "Eliminado", "IdIlha", "Nome" },
                values: new object[] { 18, new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8770), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8760), false, 8, "Tarrafal (Santiano)" });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8600), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8600), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 19, 32, DateTimeKind.Local).AddTicks(2410), new DateTime(2022, 3, 22, 20, 33, 19, 32, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 19, 32, DateTimeKind.Local).AddTicks(2420), new DateTime(2022, 3, 22, 20, 33, 19, 32, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 19, 32, DateTimeKind.Local).AddTicks(2420), new DateTime(2022, 3, 22, 20, 33, 19, 32, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 19, 32, DateTimeKind.Local).AddTicks(2420), new DateTime(2022, 3, 22, 20, 33, 19, 32, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8800), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8810), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8510), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8520), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8560), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8560), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8570), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8290), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8260), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8300), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8310), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8310), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8310), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8830), "$2a$11$RBeb9.lY3sTCI9jYQ27LPu8b.h7iiie5hKyQFYLFARQNoBJGZijgG" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 669, DateTimeKind.Local).AddTicks(7110), new DateTime(2022, 3, 22, 20, 33, 18, 669, DateTimeKind.Local).AddTicks(7080), "$2a$11$yY.4rUHbQcjnTeh2qdSBuez4th0y224a//sF247moCqALgIQ24a.C" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 849, DateTimeKind.Local).AddTicks(9160), new DateTime(2022, 3, 22, 20, 33, 18, 849, DateTimeKind.Local).AddTicks(9130), "$2a$11$53HIp4.WrVvk63bJIfjcxu11goy7LIsQrvVGWzwJrTGfZxPyJmeIO" });

            migrationBuilder.CreateIndex(
                name: "IX_Socio_IdTipoQuota",
                table: "Socio",
                column: "IdTipoQuota");

            migrationBuilder.AddForeignKey(
                name: "FK_Socio_TipoQuota_IdTipoQuota",
                table: "Socio",
                column: "IdTipoQuota",
                principalTable: "TipoQuota",
                principalColumn: "IdTipoQuota",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socio_TipoQuota_IdTipoQuota",
                table: "Socio");

            migrationBuilder.DropIndex(
                name: "IX_Socio_IdTipoQuota",
                table: "Socio");

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18);

            migrationBuilder.DropColumn(
                name: "IdTipoQuota",
                table: "Socio");

            migrationBuilder.AddColumn<int>(
                name: "TipoQuotaIdTipoQuota",
                table: "Socio",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 46, 413, DateTimeKind.Local).AddTicks(5800), new DateTime(2022, 3, 21, 21, 57, 46, 413, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 46, 413, DateTimeKind.Local).AddTicks(5810), new DateTime(2022, 3, 21, 21, 57, 46, 413, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 46, 413, DateTimeKind.Local).AddTicks(5810), new DateTime(2022, 3, 21, 21, 57, 46, 413, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3640), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3650), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3650), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3650), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3660), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3660), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3660), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3670), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3670), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3670), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 46, 413, DateTimeKind.Local).AddTicks(5840), new DateTime(2022, 3, 21, 21, 57, 46, 413, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 46, 413, DateTimeKind.Local).AddTicks(5840), new DateTime(2022, 3, 21, 21, 57, 46, 413, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 46, 413, DateTimeKind.Local).AddTicks(5840), new DateTime(2022, 3, 21, 21, 57, 46, 413, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 46, 413, DateTimeKind.Local).AddTicks(5850), new DateTime(2022, 3, 21, 21, 57, 46, 413, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3700), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3700), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3420), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3430), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3600), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3600), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3610), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3210), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3180), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3220), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3230), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3220), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3230), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3730), new DateTime(2022, 3, 21, 21, 57, 45, 877, DateTimeKind.Local).AddTicks(3730), "$2a$11$fdndIgX2qqTcUkAKVQiMKOitqJlfoxGq9daEhyivY3xW/AQh01QJ." });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 46, 57, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 3, 21, 21, 57, 46, 57, DateTimeKind.Local).AddTicks(8920), "$2a$11$UtymJW9SXu5DAsBLjKjAY.mbA2m/uclCXhPsVPkMu2TAxjstd6sOy" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 21, 21, 57, 46, 236, DateTimeKind.Local).AddTicks(2140), new DateTime(2022, 3, 21, 21, 57, 46, 236, DateTimeKind.Local).AddTicks(2110), "$2a$11$1jLQV/wK.u3qhsFU0RTdXOB7lT/My5AxYTo6FbBXSiLTX6tJHMepa" });

            migrationBuilder.CreateIndex(
                name: "IX_Socio_TipoQuotaIdTipoQuota",
                table: "Socio",
                column: "TipoQuotaIdTipoQuota");

            migrationBuilder.AddForeignKey(
                name: "FK_Socio_TipoQuota_TipoQuotaIdTipoQuota",
                table: "Socio",
                column: "TipoQuotaIdTipoQuota",
                principalTable: "TipoQuota",
                principalColumn: "IdTipoQuota");
        }
    }
}
