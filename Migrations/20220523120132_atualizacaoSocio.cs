﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class atualizacaoSocio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ValidadePassaporte",
                table: "Socio",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroPassaporte",
                table: "Socio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "RakingSocioResultado",
                columns: table => new
                {
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroDeSocio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdSocio = table.Column<int>(type: "int", nullable: false),
                    IFS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgenciaNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MesesPago = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalMontantePago = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(1820), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(1830), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(1830), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(1830), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2520), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2530), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2530), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2540), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2540), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2540), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2550), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2550), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2550), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2560), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2560), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2610), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2610), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2610), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2620), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2620), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2620), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2630), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2630), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2630), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2640), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2640), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2640), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2650), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2650), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2650), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2660), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2660), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2660), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2670), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2670), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2670), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2680), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2680), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2680), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2690), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2690), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2700), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2700), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2700), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2710), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2710), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2710), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2720), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2720), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2720), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2730), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2730), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2730), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2740), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2740), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2740), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2750), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2750), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2750), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2760), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2760), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2760), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2770), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2770), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2770), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2780), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2800), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2790) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2800), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2800), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2810), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2810), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2810), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2810) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2820), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2820), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2820), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2830), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2830), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2830), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2840), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2840), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2840), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2850), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2850), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2850), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2860), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2860), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2870), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2870), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2870), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2880), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2880), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2880), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2890), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2890), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2900), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2900), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2900), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2910), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2910), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2910), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2920), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2920), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2920), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2930), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2930), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2930), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2940), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2940), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2940), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2950), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2950), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2950), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2960), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2960), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2960), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2970), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2970), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2980), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2980), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2990), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2990), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2990), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(3000), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(3000), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(3010), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(3010), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(3010), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(3020), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2230), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2240), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2240), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2250), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2250), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2250), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2260), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2380), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2380), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2380), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2390), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2390), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2390), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2400), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2400), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2410), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2410), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2410), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2410) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2180), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2180), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2190), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2190), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2190), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2200), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2200), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2200), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2210), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2210), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2480), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2480), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2490), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2490), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2500), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2500), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2500), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Joia",
                keyColumn: "IdJoia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(1970), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(1970), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2000), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2030), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "NomeDaAction", "NomeDoController" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2030), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2030), "RakingSocio", "Socio" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2030), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2040), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2040), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2040), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2050), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2080), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2090), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2090), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2090), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2100), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2100), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2100), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2110), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2110), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2120), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2120), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2190), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2200), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2200), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2200), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2210), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2210), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2210), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2220), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2220), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2220), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2230), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2230), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2230), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2230), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2240), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2240), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2240), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2250), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2250), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2450), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2450), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2460), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2460) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2300), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2310), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2310), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2310), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2310), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2330), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2330), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2330), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2330) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2340), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2340), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2340), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2350), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2350), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2350), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2350), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2350), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2350) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2360), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2360), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2360), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2130), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2140), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2140), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2150), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2150), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(1910), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(1890), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(1920), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(1930), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(1930), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(1930), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(3080), new DateTime(2022, 5, 23, 11, 1, 29, 900, DateTimeKind.Local).AddTicks(3070), "$2a$11$XP6XUYunUBS8RYqmjbrfJ.o/MArCFWNMTEl4ANZQ4kV1qpRypA7qm" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 82, DateTimeKind.Local).AddTicks(9740), new DateTime(2022, 5, 23, 11, 1, 30, 82, DateTimeKind.Local).AddTicks(9720), "$2a$11$QYuswX2Y1EuCpHslgYOhlOA3u2u7D837INSBHmgej3F93yoKr2iSe" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 265, DateTimeKind.Local).AddTicks(9940), new DateTime(2022, 5, 23, 11, 1, 30, 265, DateTimeKind.Local).AddTicks(9920), "$2a$11$zEe5yCZs0RGkjkastfl0iuOdrCifh1BYTm5TehfnkytHy5I.Koo7S" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 447, DateTimeKind.Local).AddTicks(1180), new DateTime(2022, 5, 23, 11, 1, 30, 447, DateTimeKind.Local).AddTicks(1160), "$2a$11$a31ndSadgE.gWiUI7cLvzeQk9OlLqdQ2.huGFFVMS/xoYKdmXTWNK" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 633, DateTimeKind.Local).AddTicks(7500), new DateTime(2022, 5, 23, 11, 1, 30, 633, DateTimeKind.Local).AddTicks(7480), "$2a$11$k52EYATLoFbg6m8KE0BdiOg8h3nW8dYZ.7BOOlWfS56o2WfNK5DF6" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 815, DateTimeKind.Local).AddTicks(8780), new DateTime(2022, 5, 23, 11, 1, 30, 815, DateTimeKind.Local).AddTicks(8760), "$2a$11$S65U.y.3bDEsTePA4PJjt.PIZdp7rZS9x7fPsqgzIyvpLYOiyJhDa" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RakingSocioResultado");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ValidadePassaporte",
                table: "Socio",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NumeroPassaporte",
                table: "Socio",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(3720), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(3730), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(3730), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(3740), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8660), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8660), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8670), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8670), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8680), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8680), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8680), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8710), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8710), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8770), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8770), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8780), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8780), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8780), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8790), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8790), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8790), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8800), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8800), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8810), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8810), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8810), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8820), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8820), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8840), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8840), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8840), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8850), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8850), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8850), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8860), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8860), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8870), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8870), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8870), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8890), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8890), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8890), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8910), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8910), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8910), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8920), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8920), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8920), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8930), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8930), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8940), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8940), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8960), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8960), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8960), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8970), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8970), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8990), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8990), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9000), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9000), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9000), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9020), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9020), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9020), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9030), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9030), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9040), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9040), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9040), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9050), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9050), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9050), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9060), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9060), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9060), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9070), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9070), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9070), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9080), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9080), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9090), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9090), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9090), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9110), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9110), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9110), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9120), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9120), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9120), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9130), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9130), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9130), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9140), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9140), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9150), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9150), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9150), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9160), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8450), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8460), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8460), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8500), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8500), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8500), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8510), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8510), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8510), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8520), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8520), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8520), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8530), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8530), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8390), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8390), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8400), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8400), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8400), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8410), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8410), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8410), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8420), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8420), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8600), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Joia",
                keyColumn: "IdJoia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4120), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4110), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4170), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4210), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "NomeDaAction", "NomeDoController" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4210), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4210), "", "" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4220), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4220), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4230), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4230), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4280), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4280), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4290), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4290), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4290), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4300), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4300), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4300), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4310), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4310), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4310), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4320), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4550), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4550) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4570), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4570), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4570), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4580), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4580), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4580), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4580), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4590), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4590), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4590), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4600), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4600), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4600), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4600), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4610), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4610), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4610), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4620), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8570), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8580), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8580), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4680), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4700), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4700), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4700), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4700), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4710), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4710), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4710), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4710), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4710) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4720), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4720), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4720), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4720) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4730), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4730), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4730), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4730), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4740), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4740), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4740), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8320), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8330), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8330), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8340), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8340), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8000), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(7960), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8010), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8010), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8010), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8010), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9230), new DateTime(2022, 5, 20, 10, 55, 27, 980, DateTimeKind.Local).AddTicks(9220), "$2a$11$7OOfs67uB6HRzH9FezQaFu9630ZCfjPW3nKLoDq75JoDvCWdDaQUe" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 28, 164, DateTimeKind.Local).AddTicks(4470), new DateTime(2022, 5, 20, 10, 55, 28, 164, DateTimeKind.Local).AddTicks(4460), "$2a$11$hCwDBZSeg4bAJvT.GPnF/enPwKHSqa9jKHVJIKox8zlgKwoH3A6FK" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 28, 347, DateTimeKind.Local).AddTicks(2200), new DateTime(2022, 5, 20, 10, 55, 28, 347, DateTimeKind.Local).AddTicks(2180), "$2a$11$YGvz.TrI4Dn1.oFDVMxMlels7Qf40NtD/Ar1FdW9yylQ3VmwxpIxi" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 28, 531, DateTimeKind.Local).AddTicks(7940), new DateTime(2022, 5, 20, 10, 55, 28, 531, DateTimeKind.Local).AddTicks(7920), "$2a$11$3Vlv/p7Pavi/wMfgL6Uu5OWCBr0Df6JmHEBexQXn5a6x9CRf.dYPS" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 28, 715, DateTimeKind.Local).AddTicks(1370), new DateTime(2022, 5, 20, 10, 55, 28, 715, DateTimeKind.Local).AddTicks(1350), "$2a$11$Cpg/C9lYzFVLWxP1PYx8buzPf74mnw.dolCod8/Csp.ME81HXxwDS" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 28, 895, DateTimeKind.Local).AddTicks(6790), new DateTime(2022, 5, 20, 10, 55, 28, 895, DateTimeKind.Local).AddTicks(6780), "$2a$11$ySTWuCxBNwlNP2ZsI83xz./XklOvO/rvXlzgx6BImeXZmlkYguIX2" });
        }
    }
}
