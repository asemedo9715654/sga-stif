using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class adicaoDoCampoSigla : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sigla",
                table: "InstituicaoFinanceira",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6500), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6500), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6500), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6510), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5620), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5620), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5630), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5630), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5630), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5640), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5640), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5640), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5650), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5640), 3 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5650), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5650), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5660), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5660), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5670), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5670), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5670), 12 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5680), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5680), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5680), 14 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5690), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5690), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5690), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5690), 8 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5700), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5700), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5700), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5700), 16 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5710), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5710), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5710), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5720), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5720), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5720), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5720), 5 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5730), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5730), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5730), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5740), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5740), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5740), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5750), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5740), 4 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5750), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5750), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5750), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5760), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5760), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5770), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5770), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5770), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5780), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5780), 5 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5780), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5780), 6 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5780), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5790), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5790), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5790), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5790), 3 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5800), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5800), 3 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5800), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5800), 4 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5800), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5800), 16 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5810), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5810), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5810), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5820), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5820), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5820), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5820), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5830), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5830), 4 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5830), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5830), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5840), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5850), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5850), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5850), 4 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5850), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5860), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5860), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5870), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5870), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5870), 3 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5870), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5870), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5880), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5880), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5880), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5890), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5890), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5890), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5900), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5890), 5 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5900), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5900), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5900), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5910), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5910), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5910), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5920), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5920), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5920), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5930), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5930), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5930), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5940), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5940), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5940), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5950), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5950), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5950), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5960), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5960), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5960), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5970), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5970), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5970), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5980), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5980), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5980), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5980), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5990), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5990), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5990), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5990), 4 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6000), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5990), 4 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6000), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6000), 4 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6000), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6000), 4 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6000), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6000), 4 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6040), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6030), 4 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6040), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6040), 4 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6040), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6050), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6050), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6050), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6060), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6060), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6060), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6060), 3 });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5450), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5450), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5450), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5460), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5460), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5460), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5470), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5470), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5470), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5490), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5490), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5490), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5500), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5500), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5500), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5500), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5510), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5510), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5390), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5400), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5400), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5400), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5410), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5410), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5410), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5420), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5420), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5420), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "Sigla" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5570), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5570), "CECV" });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "Sigla" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5580), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5580), "BCA" });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "Sigla" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5580), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5580), "BCN" });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao", "Sigla" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5580), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5580), "BI" });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao", "Sigla" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5590), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5590), "BAI" });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao", "Sigla" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5590), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5590), "IIB" });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao", "Sigla" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5600), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5590), "ECV" });

            migrationBuilder.UpdateData(
                table: "Joia",
                keyColumn: "IdJoia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6550), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6540), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6580), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6600), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6600), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6600), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6610), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6620), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6620), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6630), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6630), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6630), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6640), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6640), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6640), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6650), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6650), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6650), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6660), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6660), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6660), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6740), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6750), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6780), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6790), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6790), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6790), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6800), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6800), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6800), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6810), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6810), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6810), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6810), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6820), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6820), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6820), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6820), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6830), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6830), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5540), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5550), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5550), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6880), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6890), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6900), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6900), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6900), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6900), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6910), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6910), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6910), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6910), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6920), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6920), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6920), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6920), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6930), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6930), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6930), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6930), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6940), new DateTime(2022, 5, 2, 10, 25, 54, 462, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5330), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5340), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5340), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5340), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5350), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5050), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5020), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5070), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5070), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5070), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5070), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6120), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6120), "$2a$11$bcznRSlDOb.5HWopAzE/Ou9DoqTVU1fJjPp8uFm2sigVrckafwHHS" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 912, DateTimeKind.Local).AddTicks(320), new DateTime(2022, 5, 2, 10, 25, 53, 912, DateTimeKind.Local).AddTicks(310), "$2a$11$JzAgzOQ8FQPDpNxuU/WHIuLcbtYYCM8Nl3mYtE2utHqhhctu66eOW" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 94, DateTimeKind.Local).AddTicks(5340), new DateTime(2022, 5, 2, 10, 25, 54, 94, DateTimeKind.Local).AddTicks(5330), "$2a$11$q1YPpoQlnwht.93CFdYSH.SMdbHyldtQpeHjWZG92fde/NhBV2jEG" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 54, 279, DateTimeKind.Local).AddTicks(6550), new DateTime(2022, 5, 2, 10, 25, 54, 279, DateTimeKind.Local).AddTicks(6540), "$2a$11$nGa3eV3e8vF0fnovdHCkKuI6sPyiVBkF/X4Ah944k0HiL8d4OZCoy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sigla",
                table: "InstituicaoFinanceira");

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2610), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2620), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2620), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2630), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9870), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9870), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9880), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9880), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9880), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9890), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9890), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9890), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9900), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9900), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9900), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9910), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9910), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9920), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9920), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9920), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9920), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9930), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9930), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9930), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9930), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9940), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9940), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9940), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9940), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9950), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9950), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9950), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9960), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9960), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9960), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9970), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9970), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9970), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9970), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9980), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9990), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(10), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(10) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(10), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(10), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(20), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(20), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(20), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(30), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(30), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(40), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(40), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(40), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(50), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(40), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(50), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(50), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(50), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(50) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(60), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(60), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(60), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(60), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(70), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(70), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(70), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(70), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(70), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(70), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(80), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(80), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(80), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(90), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(90), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(100), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(100), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(110), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(100), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(110), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(110), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(120), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(120), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(120), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(120), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(130), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(130), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(130), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(140), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(140), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(140), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(150), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(150), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(150), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(160), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(160), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(170), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(160) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(170), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(170), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(180), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(180), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(180), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(190), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(200), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(200), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(200), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(200) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(210), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(220), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(220), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(220), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(230), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(230), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(230), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(240), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(240), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(240), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(250), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(250), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(250), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(260), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(260), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(270), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(270), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(270), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(280), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(280), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(280), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(290), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(290), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(300), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(290) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(300), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(300), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(300), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(310), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(300), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(310), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(310), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(310), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(310), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(320), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(310), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(320), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(320), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(320), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(320), 1 });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(330), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(330), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(330), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(340), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(340), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(340), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(350), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(350), 1 });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9650), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9650), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9660), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9660), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9660), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9670), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9670), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9670), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9680), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9680), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9690), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9690), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9700), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9690) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9700), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9700), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9700) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9710), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9710), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9720), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9570), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9570), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9580), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9580), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9590), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9590), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9590), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9590) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9600), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9600), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9610), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9810), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9810) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9820), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9820), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9820) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9830), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9830), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9840), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9840), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9840) });

            migrationBuilder.UpdateData(
                table: "Joia",
                keyColumn: "IdJoia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataInicio" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2670), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2670), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2740), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2760), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2760), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2770), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2770), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2780), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2790), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2790), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2790), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2800), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2800), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2810), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2810), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2810), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2820), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2820), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2820), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2830), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2830), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2910), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2930), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2930), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2930), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2940), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2940), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2940), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2950), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2950), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2950), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2960), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2960), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2960), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2970), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2970), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2970), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2980), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2990), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3000), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9760), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9770), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9790), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3050), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3060), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3070), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3070), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3070), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3080), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3080), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3080), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3090), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3090), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3090), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3100), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3100), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3100), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3110), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3110), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3110), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3110), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3120), new DateTime(2022, 4, 25, 14, 45, 0, 123, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9510), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9520), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9520), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9530), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9530), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9530) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9210), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9170), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9230), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9240), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9230), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9240), new DateTime(2022, 4, 25, 14, 44, 59, 270, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(420), new DateTime(2022, 4, 25, 14, 44, 59, 271, DateTimeKind.Local).AddTicks(420), "$2a$11$LblNvI0IxFNNKTRLEfKMa.AWY9KJsXdKqJBgmIj5gZ4K/7cE/Z2n2" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 472, DateTimeKind.Local).AddTicks(6370), new DateTime(2022, 4, 25, 14, 44, 59, 472, DateTimeKind.Local).AddTicks(6350), "$2a$11$wlyFO63wsyJLHWhGsXAeGud9/RJFHFtzmM3i/3fcIkeb1GTqhdC7K" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 700, DateTimeKind.Local).AddTicks(70), new DateTime(2022, 4, 25, 14, 44, 59, 700, DateTimeKind.Local).AddTicks(50), "$2a$11$7nEfNPpgksDvitCIoFPvrenHUQ187bUSFpdw.pD9EY36jsoILRFsK" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 25, 14, 44, 59, 921, DateTimeKind.Local).AddTicks(5490), new DateTime(2022, 4, 25, 14, 44, 59, 921, DateTimeKind.Local).AddTicks(5480), "$2a$11$eEVc3kL81CQDPRP5w3.tQeVJ7C2Z3KB82eHYUH9dFMHrc8YRTwRX2" });
        }
    }
}
