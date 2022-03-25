using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class atualizacaoNumSocio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NumeroDeSocio",
                table: "Socio",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 45, 494, DateTimeKind.Local).AddTicks(3661), new DateTime(2022, 3, 25, 15, 6, 45, 494, DateTimeKind.Local).AddTicks(3655) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 45, 494, DateTimeKind.Local).AddTicks(3668), new DateTime(2022, 3, 25, 15, 6, 45, 494, DateTimeKind.Local).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 45, 494, DateTimeKind.Local).AddTicks(3781), new DateTime(2022, 3, 25, 15, 6, 45, 494, DateTimeKind.Local).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1518), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1523), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1526), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1525) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1528), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1527) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1531), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1530) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1533), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1536), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1538), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1538) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1541), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1543), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1546), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1548), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1551), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1553), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1555), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1558), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1560), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1563), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1565), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1568), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1571), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1574), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1576), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1579), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1581), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1584), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1586), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1588), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1591), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1593), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1595), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1598), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1597) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1600), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1603), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1605), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1608), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1610), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1613), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1615), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1618), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1620), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1622), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1676), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1679), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1678) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1682), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1684), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1688), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1690), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1692), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1695), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1697), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1700), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1702), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1704), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1707), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1709), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1712), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1716), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1719), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1721), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1724), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1726), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1728), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1731), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1734), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1738), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1742), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1741) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1744), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1743) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1746), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1749), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1751), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1754), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1757), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1760), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1762), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1766), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1769), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1774), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1777), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1780), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1782), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1784), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1787), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1789), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1792), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1794), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1797), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1799), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1798) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1801), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1804), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1806), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1805) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1808), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1808) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1811), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1810) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1859), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1862), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1864), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1867), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1869), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1873), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1875), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1877), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1880), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1882), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1885), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1887), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1889), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1892), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1894), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1897), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1899), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1901), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1904), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1906), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1908), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1911), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1913), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1916), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1918), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1920), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1923), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1925), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1928), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1930), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1932), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1932) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1305), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1305) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1316), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1315) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1319), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1321), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1320) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1324), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1323) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1326), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1328), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1331), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1330) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1333), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1335), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1335) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1338), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1337) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1340), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1342), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1348), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1350), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1352), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1352) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1355), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1357), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1227), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1226) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1230), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1233), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1235), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1238), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1240), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1242), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1244), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1247), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1249), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1425), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1429), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1432), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1431) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1434), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1436), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1439), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1441), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 45, 494, DateTimeKind.Local).AddTicks(3852), new DateTime(2022, 3, 25, 15, 6, 45, 494, DateTimeKind.Local).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 45, 494, DateTimeKind.Local).AddTicks(3856), new DateTime(2022, 3, 25, 15, 6, 45, 494, DateTimeKind.Local).AddTicks(3855) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 45, 494, DateTimeKind.Local).AddTicks(3859), new DateTime(2022, 3, 25, 15, 6, 45, 494, DateTimeKind.Local).AddTicks(3858) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 45, 494, DateTimeKind.Local).AddTicks(3861), new DateTime(2022, 3, 25, 15, 6, 45, 494, DateTimeKind.Local).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1397), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1402), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(907), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(929), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(928) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1174), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1174) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1188), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1190), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(1190) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(542), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(525), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(554), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(555) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(559), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(558), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(567), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(2014), new DateTime(2022, 3, 25, 15, 6, 44, 200, DateTimeKind.Local).AddTicks(2013), "$2a$11$l.EESkeNVKt4F3uyfpWCr.xcnXt74kLVxXPmgViONCZ7rHsgEPCaS" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 499, DateTimeKind.Local).AddTicks(5405), new DateTime(2022, 3, 25, 15, 6, 44, 499, DateTimeKind.Local).AddTicks(5388), "$2a$11$JotDoBDN4SVE86GvkDHAve2t63bEr8JN5Iii6QwczMbxAvVNzS/vO" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 44, 843, DateTimeKind.Local).AddTicks(2180), new DateTime(2022, 3, 25, 15, 6, 44, 843, DateTimeKind.Local).AddTicks(2165), "$2a$11$Z9QY94E5hziepf.OaTOiXOoHo7/dYBscmW97WOFMWqJhT.0E5Sp82" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 25, 15, 6, 45, 181, DateTimeKind.Local).AddTicks(5420), new DateTime(2022, 3, 25, 15, 6, 45, 181, DateTimeKind.Local).AddTicks(5390), "$2a$11$LK8TvI6Z8z2O1dZs.vWSM.nwoMCQK0KN8NlTEOART8GssOJY/079a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroDeSocio",
                table: "Socio");

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(44), new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(56), new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(60), new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3371), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3375), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3377), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3379), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3381), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3383), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3385), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3387), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3388), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3390), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3392), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3394), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3396), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3398), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3400), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3403), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3404), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3406), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3408), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3410), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3412), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3414), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3416), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3418), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3419), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3421), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3423), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3425), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3427), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3429), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3431), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3432), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3434), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3436), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3436) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3438), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3440), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3442), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3441) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3444), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3445), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3447), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3449), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3449) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3452), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3454), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3456), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3487), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3489), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3491), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3493), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3492) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3495), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3497), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3496) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3499), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3498) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3500), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3502), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3504), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3506), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3505) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3508), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3507) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3510), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3509) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3511), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3511) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3513), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3513) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3515), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3517), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3517) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3519), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3519) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3521), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3523), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3525), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3524) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3527), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3526) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3528), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3531), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3533), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3535), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3537), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3539), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3541), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3543), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3544), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3546), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3548), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3547) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3550), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3552), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3554), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3556), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3558), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3560), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3562), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3564), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3566), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3567), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3567) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3569), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3571), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3573), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3575), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3578), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3577) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3579), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3579) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3582), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3584), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3659), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3661), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3663), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3665), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3668), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3670), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3672), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3671) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3675), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3677), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3679), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3681), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3683), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3685), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3687), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3689), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3688) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3693), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3695), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3696), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3698), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3700), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3702), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3704), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3703) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3706), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3708), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3710), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3712), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3712) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3714), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3713) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3716), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3718), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3223), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3227), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3229), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3231), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3233), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3235), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3236), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3238), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3240), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3242), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3244), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3246), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3247), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3249), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3251), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3254), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3255), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3257), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3176), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3179), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3182), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3181) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3184), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3186), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3191), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3194), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3196), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3197), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3199), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3307), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3310), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3311), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3313), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3315), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3317), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3319), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(159), new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(166), new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(165) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(171), new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(174), new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3287), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3290), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3086), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3103), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3105), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3111), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3149), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(2870), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(2850), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(2880), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(2883), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(2882), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(2889), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(4142), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(4141), "$2a$11$6p8hOUGmBYzbGNQKWNPvyO2eT.5OK4bPUOw9gAMkoy.wmdOO08/f2" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 37, 327, DateTimeKind.Local).AddTicks(8607), new DateTime(2022, 3, 25, 11, 41, 37, 327, DateTimeKind.Local).AddTicks(8590), "$2a$11$ftbGhP35UI7.eTGFjSB4g.qBwbry/1IkPzH2QjGtZkzzYODd/1Rfi" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 37, 659, DateTimeKind.Local).AddTicks(5610), new DateTime(2022, 3, 25, 11, 41, 37, 659, DateTimeKind.Local).AddTicks(5590), "$2a$11$wvxfpnwD7uEKhAwa8es/ZuVmSC42bdglKN0Sf0QAFspRExqCPlqKO" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 38, 9, DateTimeKind.Local).AddTicks(1412), new DateTime(2022, 3, 25, 11, 41, 38, 9, DateTimeKind.Local).AddTicks(1393), "$2a$11$D8gqd3VfALSM4nARwyvO2eTh9R31fYMX7xCmEUMXznt9zzaPTT9V2" });
        }
    }
}
