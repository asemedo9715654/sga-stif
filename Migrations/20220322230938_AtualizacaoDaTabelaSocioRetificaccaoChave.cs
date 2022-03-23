using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class AtualizacaoDaTabelaSocioRetificaccaoChave : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socio_Agencia_IdICidade",
                table: "Socio");

            migrationBuilder.RenameColumn(
                name: "IdICidade",
                table: "Socio",
                newName: "IdAgencia");

            migrationBuilder.RenameIndex(
                name: "IX_Socio_IdICidade",
                table: "Socio",
                newName: "IX_Socio_IdAgencia");

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 37, 320, DateTimeKind.Local).AddTicks(5520), new DateTime(2022, 3, 22, 22, 9, 37, 320, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 37, 320, DateTimeKind.Local).AddTicks(5520), new DateTime(2022, 3, 22, 22, 9, 37, 320, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 37, 320, DateTimeKind.Local).AddTicks(5530), new DateTime(2022, 3, 22, 22, 9, 37, 320, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8520), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8530), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8530), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8540), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8540), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8540), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8550), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8550), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8550), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8550), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8560), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8560), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8560), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8570), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8570), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8570), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8580), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8580), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8470), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8500), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8500), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 37, 320, DateTimeKind.Local).AddTicks(5550), new DateTime(2022, 3, 22, 22, 9, 37, 320, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 37, 320, DateTimeKind.Local).AddTicks(5560), new DateTime(2022, 3, 22, 22, 9, 37, 320, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 37, 320, DateTimeKind.Local).AddTicks(5560), new DateTime(2022, 3, 22, 22, 9, 37, 320, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 37, 320, DateTimeKind.Local).AddTicks(5560), new DateTime(2022, 3, 22, 22, 9, 37, 320, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8330), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8340), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8380), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8380), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8390), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8120), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8090), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8130), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8140), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8140), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8140), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 3, 22, 22, 9, 36, 785, DateTimeKind.Local).AddTicks(8640), "$2a$11$fj1Eopg1D9XiLcAhFUWf1efUpVDgzyZb0nBp.iQCJUIuIyHAeQstS" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 36, 965, DateTimeKind.Local).AddTicks(8220), new DateTime(2022, 3, 22, 22, 9, 36, 965, DateTimeKind.Local).AddTicks(8180), "$2a$11$Rik3rieesfMZFr3wwYfLQOnvZpR/GYUE6c2b5kDgDeGGKGA5bCZB6" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 22, 22, 9, 37, 144, DateTimeKind.Local).AddTicks(3750), new DateTime(2022, 3, 22, 22, 9, 37, 144, DateTimeKind.Local).AddTicks(3720), "$2a$11$2QoOYE3cFHFvfr1UN2/sbOqlJLavgPLH9bZthPAgVCgKLLgQ6.beC" });

            migrationBuilder.AddForeignKey(
                name: "FK_Socio_Agencia_IdAgencia",
                table: "Socio",
                column: "IdAgencia",
                principalTable: "Agencia",
                principalColumn: "IdAgencia",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Socio_Agencia_IdAgencia",
                table: "Socio");

            migrationBuilder.RenameColumn(
                name: "IdAgencia",
                table: "Socio",
                newName: "IdICidade");

            migrationBuilder.RenameIndex(
                name: "IX_Socio_IdAgencia",
                table: "Socio",
                newName: "IX_Socio_IdICidade");

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

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8770), new DateTime(2022, 3, 22, 20, 33, 18, 486, DateTimeKind.Local).AddTicks(8760) });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Socio_Agencia_IdICidade",
                table: "Socio",
                column: "IdICidade",
                principalTable: "Agencia",
                principalColumn: "IdAgencia",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
