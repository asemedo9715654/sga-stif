using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class AdicaoDaRegiaoNaTabelaIlha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Regiao",
                table: "Ilha",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1712), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1720), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1722), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1723), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6395), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6392) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6399), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6398) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6401), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6403), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6404), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6406), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6405) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6408), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6407) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6409), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6409) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6411), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6413), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6412) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6414), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6416), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6417), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6419), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6421), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6422), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6424), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6426), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6428), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6427) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6429), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6431), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6432), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6432) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6434), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6433) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6435), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6437), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6436) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6439), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6438) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6440), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6442), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6443), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6443) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6445), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6446), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6446) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6448), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6447) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6449), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6449) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6451), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6452), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6452) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6454), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6455), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6457), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6457) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6459), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6458) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6460), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6462), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6463), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6465), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6464) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6467), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6469), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6468) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6470), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6472), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6471) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6473), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6473) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6503), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6501) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6505), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6507), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6506) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6509), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6508) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6510), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6512), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6511) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6513), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6515), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6514) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6516), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6518), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6517) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6519), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6519) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6521), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6522), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6522) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6524), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6523) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6525), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6527), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6528), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6530), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6532), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6533), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6533) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6535), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6534) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6537), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6539), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6540), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6542), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6543), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6545), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6546), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6548), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6549), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6549) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6551), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6552), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6554), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6553) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6555), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6555) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6557), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6559), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6558) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6560), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6562), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6561) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6563), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6565), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6566), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6566) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6568), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6569), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6571), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6572), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6574), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6575), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6578), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6580), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6581), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6581) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6583), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6582) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6612), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6615), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6616), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6618), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6617) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6619), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6619) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6621), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6623), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6622) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6624), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6626), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6627), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6627) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6629), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6630), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6632), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6633), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6633) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6636), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6638), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6639), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6641), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6642), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6642) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6644), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6643) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6645), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6645) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6648), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6647) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6650), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6649) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6651), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6271), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6275), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6275) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6277), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6279), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6281), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6282), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6281) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6284), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6286), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6287), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6289), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6291), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6292), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6292) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6294), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6293) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6296), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6297), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6296) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6299), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6298) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6300), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6302), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6301) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6189), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6193), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6195), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6194) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6196), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6196) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6198), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6199), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6199) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6201), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6202), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6202) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6204), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6205), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6204) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6339), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6344), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6346), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6348), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6350), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6352), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6354), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "Joia",
                keyColumn: "IdJoia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataInicio" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1828), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1827), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1928), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1946), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1949), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1951), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1952), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1955), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1957), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1958), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1960), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1962), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1964), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1966), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1967), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1971), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1972), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1974), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1973) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1976), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1978), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1980), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2148), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2157), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2159), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2160), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2162), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2164), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2165), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2165) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2167), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2168), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2170), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2171), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2172), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2174), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2175), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2176), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2178), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2179), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2212), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2214), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6319), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6319) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6324), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6328), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2257), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2268), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2269), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2270), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2272), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2273), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2275), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2276), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2277), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2279), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2280), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2281), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2282), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2283), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2284), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2286), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2287), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2288), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2289), new DateTime(2024, 10, 30, 10, 12, 18, 207, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6161), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6165), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6165) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6168), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6167) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6170), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6169) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6172), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6171) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6013), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(5999), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6020), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6021) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6023), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6022), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6024), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6024) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6686), new DateTime(2024, 10, 30, 10, 12, 17, 139, DateTimeKind.Local).AddTicks(6685), "$2a$11$tbxdfy0JXqXdOa07f7YrzO0NAynqFS5o4bn8mTQS7yVz85VCV/DY." });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 323, DateTimeKind.Local).AddTicks(9621), new DateTime(2024, 10, 30, 10, 12, 17, 323, DateTimeKind.Local).AddTicks(9617), "$2a$11$T1tDtQ3yqUM8QugTDGlkSOtho7ZUJYh.rC13JZVlVi1IKQHesKK.O" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 497, DateTimeKind.Local).AddTicks(731), new DateTime(2024, 10, 30, 10, 12, 17, 497, DateTimeKind.Local).AddTicks(726), "$2a$11$n8iYpVsR3Unid/UAsxolNO6L.EKY6cx/yM871sWLjKpg6lv9feNqa" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 670, DateTimeKind.Local).AddTicks(9051), new DateTime(2024, 10, 30, 10, 12, 17, 670, DateTimeKind.Local).AddTicks(9047), "$2a$11$bWcIdMlFIjUjjfQ3w9UL2eAprN0O23ibvz9RiW/KIUxk8X8Yr8mVO" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 17, 842, DateTimeKind.Local).AddTicks(7657), new DateTime(2024, 10, 30, 10, 12, 17, 842, DateTimeKind.Local).AddTicks(7653), "$2a$11$XUxuCsOXioAHqPcSdt8J3utJrlDAuyg4evbDTpsW1zVrsFNYpvNWG" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 12, 18, 22, DateTimeKind.Local).AddTicks(8851), new DateTime(2024, 10, 30, 10, 12, 18, 22, DateTimeKind.Local).AddTicks(8844), "$2a$11$h1IMWuGgpzwyqLv6dkvwEehvGlVkaCFSKUE5lJrApI0RkJbbq10y." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Regiao",
                table: "Ilha");

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5522), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5529), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5531), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5532), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5532) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7003), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7007), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7037), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7039), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7040), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7042), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7041) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7044), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7045), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7047), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7046) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7048), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7050), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7051), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7053), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7054), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7056), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7057), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7057) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7059), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7060), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7062), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7063), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7065), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7064) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7068), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7069), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7071), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7072), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7074), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7073) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7075), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7075) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7077), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7078), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7078) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7080), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7081), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7083), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7084), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7086), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7087), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7089), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7091), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7092), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7094), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7095), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7097), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7098), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7100), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7099) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7101), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7103), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7104), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7106), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7108), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7110), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7111), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7113), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7114), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7114) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7116), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7143), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7144), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7146), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7147), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7149), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7150), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7152), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7153), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7155), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7156), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7158), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7159), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7161), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7162), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7164), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7165), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7167), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7168), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7170), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7171), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7174), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7176), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7175) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7177), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7179), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7180), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7182), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7183), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7183) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7185), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7184) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7186), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7186) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7188), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7187) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7189), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7191), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7192), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7194), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7195), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7197), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7198), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7198) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7200), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7201), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7203), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7204), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7206), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7207), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7209), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7210), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7211), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7213), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7215), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7217), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7219), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7220), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7255), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7257), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7259), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7258) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7260), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7262), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7264), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7265), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7267), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7268), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7268) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7270), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7271), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7273), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7274), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7276), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7277), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7279), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7280), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7282), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7281) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7283), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7285), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6883), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6883) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6887), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6918), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6917) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6920), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6921), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6923), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6922) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6924), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6926), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6925) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6928), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6930), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6931), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6933), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6934), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6934) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6936), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6937), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6939), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6940), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6941), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6941) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6851), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6854), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6854) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6856), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6858), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6859), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6861), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6862), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6861) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6863), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6865), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6866), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6975), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6974) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6979), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6978) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6981), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6985), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6986), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6988), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6990), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "Joia",
                keyColumn: "IdJoia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataInicio" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5615), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5615), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5646), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5666), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5665) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5669), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5747), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5749), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5752), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5753), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5757), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5759), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5761), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5761) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5763), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5766), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5768), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5770), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5769) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5772), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5771) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5773), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5775), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5774) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5777), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5779), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5943), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5954), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5956), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5957), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5959), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5961), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5962), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5962) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5964), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5965), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5967), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5969), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5970), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5971), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5973), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5974), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5975), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5977), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5978), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5980), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6958), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6963), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6965), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6056), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6055) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6063), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6064), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6064) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6066), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6067), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6066) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6069), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6068) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6070), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6071), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6072), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6074), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6075), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6075) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6076), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6076) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6078), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6077) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6079), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6078) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6080), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6079) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6081), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6081) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6082), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6084), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6085), new DateTime(2024, 10, 30, 2, 17, 6, 830, DateTimeKind.Local).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6820), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6825), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6827), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6826) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6829), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6831), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6647), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6657), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6658) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6660), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6660), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6661), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(6662) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7316), new DateTime(2024, 10, 30, 2, 17, 5, 788, DateTimeKind.Local).AddTicks(7316), "$2a$11$ShkPEd5Pacuf6uAM.mPfMemK25UTosjR364VKwAb4F5WVjnlhICDu" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 5, 964, DateTimeKind.Local).AddTicks(1895), new DateTime(2024, 10, 30, 2, 17, 5, 964, DateTimeKind.Local).AddTicks(1891), "$2a$11$mNzj7apcAr4ltu2FUUErsO25AeGh4HQXqQptFFxlXlWx7f9ILInYy" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 136, DateTimeKind.Local).AddTicks(8188), new DateTime(2024, 10, 30, 2, 17, 6, 136, DateTimeKind.Local).AddTicks(8033), "$2a$11$JWUt2NVzHCRgIzuqnhR3HOncHU3wpF3EfWE7ExoN9oIs6xIDddD5y" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 309, DateTimeKind.Local).AddTicks(9451), new DateTime(2024, 10, 30, 2, 17, 6, 309, DateTimeKind.Local).AddTicks(9447), "$2a$11$8.rF7JFnoa9OMQIQ9OspkehiC5Pa2TU4ZOFGLvoR8UBJth2.rA7cy" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 482, DateTimeKind.Local).AddTicks(9056), new DateTime(2024, 10, 30, 2, 17, 6, 482, DateTimeKind.Local).AddTicks(9049), "$2a$11$I06qjEtGohxUqzI7NI9b5.KsTt7uP8ik7ratseM9yhIBEV5tYQFTK" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2024, 10, 30, 2, 17, 6, 656, DateTimeKind.Local).AddTicks(9669), new DateTime(2024, 10, 30, 2, 17, 6, 656, DateTimeKind.Local).AddTicks(9662), "$2a$11$MCm9QfQDTdLnJW1BzT6uRuf72n18TFCtzPuPRw3YsE1/Anz5V42ia" });
        }
    }
}
