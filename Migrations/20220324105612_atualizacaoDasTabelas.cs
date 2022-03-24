using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class atualizacaoDasTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataDeNascimento",
                table: "Socio",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Sexo",
                table: "Socio",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Apelido",
                table: "Beneficiario",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataDeNascimento",
                table: "Beneficiario",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "GrauDeParentesco",
                table: "Beneficiario",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3064), new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3071), new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3074), new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1595), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1455), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1460), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1462), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1465), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1467), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1466) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1469), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1468) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1472), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1474), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1477), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1479), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1482), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1484), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1486), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1489), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1491), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1493), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1495), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1498), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1398), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1397) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1404), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1406), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1409), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1411), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1414), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1416), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1418), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1417) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1421), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1423), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1572), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3122), new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3125), new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3128), new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3131), new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1540), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1545), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1273), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1289), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1348), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1351), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1361), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1045), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1026), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1059), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1063), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1062), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1065), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1666), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1665), "$2a$11$C2aYvy2Hi7LaB4JTalyqzeW0pHxGeHSX/1pFJRPNW/AOfpac9UBm6" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 790, DateTimeKind.Local).AddTicks(7061), new DateTime(2022, 3, 24, 9, 56, 10, 790, DateTimeKind.Local).AddTicks(7041), "$2a$11$7kucCii4hxS0UH4bzqXJqecWz6CweGyrlEUbhhMuK2yEESmajrDI." });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 11, 96, DateTimeKind.Local).AddTicks(2042), new DateTime(2022, 3, 24, 9, 56, 11, 96, DateTimeKind.Local).AddTicks(2023), "$2a$11$XMd6Bacqvn0wua0pEgLklOjuvi4m16NCqPFMPhFb1rGrCUnY63x3K" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataDeNascimento",
                table: "Socio");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Socio");

            migrationBuilder.DropColumn(
                name: "Apelido",
                table: "Beneficiario");

            migrationBuilder.DropColumn(
                name: "DataDeNascimento",
                table: "Beneficiario");

            migrationBuilder.DropColumn(
                name: "GrauDeParentesco",
                table: "Beneficiario");

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 55, 386, DateTimeKind.Local).AddTicks(1882), new DateTime(2022, 3, 23, 16, 24, 55, 386, DateTimeKind.Local).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 55, 386, DateTimeKind.Local).AddTicks(1892), new DateTime(2022, 3, 23, 16, 24, 55, 386, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 55, 386, DateTimeKind.Local).AddTicks(1896), new DateTime(2022, 3, 23, 16, 24, 55, 386, DateTimeKind.Local).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5606), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5319), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5328), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5326) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5334), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5332) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5339), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5343), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5349), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5354), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5358), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5357) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5363), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5367), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5366) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5372), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5376), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5375) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5381), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5385), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5384) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5390), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5394), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5392) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5399), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5403), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5402) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5130), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5210), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5217), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5222), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5226), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5231), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5236), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5240), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5245), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5250), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5557), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 55, 386, DateTimeKind.Local).AddTicks(2073), new DateTime(2022, 3, 23, 16, 24, 55, 386, DateTimeKind.Local).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 55, 386, DateTimeKind.Local).AddTicks(2081), new DateTime(2022, 3, 23, 16, 24, 55, 386, DateTimeKind.Local).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 55, 386, DateTimeKind.Local).AddTicks(2088), new DateTime(2022, 3, 23, 16, 24, 55, 386, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 55, 386, DateTimeKind.Local).AddTicks(2091), new DateTime(2022, 3, 23, 16, 24, 55, 386, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5498), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5496) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5506), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5003), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5020), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5047), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5045) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5052), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5064), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(4597), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(4573), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(4614), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(4623), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(4621), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(4627), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5666), new DateTime(2022, 3, 23, 16, 24, 54, 376, DateTimeKind.Local).AddTicks(5665), "$2a$11$9W5lkLBaPWN2z2gD1qJ82.n4CJPdBxMNTzZzCZ94bwbXXWvGfaAbe" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 54, 713, DateTimeKind.Local).AddTicks(3818), new DateTime(2022, 3, 23, 16, 24, 54, 713, DateTimeKind.Local).AddTicks(3797), "$2a$11$fS5gjCs1U8GiTcqwFZf5BOVWhx6YUXhxH/72aGnqmgD.ZLdmhucza" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 23, 16, 24, 55, 52, DateTimeKind.Local).AddTicks(9435), new DateTime(2022, 3, 23, 16, 24, 55, 52, DateTimeKind.Local).AddTicks(9413), "$2a$11$JyiiN99kf0ZLr48NyUf.SO.LW2Gb3p/RvXP0VX6pTgvoWUbxtbMbW" });
        }
    }
}
