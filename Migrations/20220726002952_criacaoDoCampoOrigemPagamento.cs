﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class criacaoDoCampoOrigemPagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrigemPagamento",
                table: "QuotaSocio",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6090), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6100), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6100), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6100), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8650), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8650), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8650), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8660), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8660), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8660), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8670), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8670), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8670), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8670), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8680), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8690), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8690), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8710), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8710), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8710), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8770), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8770), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8770), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8780), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8780), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8780), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8790), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8790), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8790), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8790), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8800), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8800), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8810), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8810), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8810), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8820), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8820), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8820), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8840), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8840), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8840), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8850), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8850), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8860), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8860), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8860), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8870), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8870), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8870), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8890), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8890), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8900), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8900), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8900), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8910), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8910), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8910), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8920), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8920), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8920), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8920), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8930), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8930), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8930), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8940), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8940), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8940), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8960), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8960), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8960), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8970), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8970), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8970), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8990), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8990), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8990), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9000), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9000), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9000), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8440), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8450), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8450), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8450), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8450), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8460), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8460), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8460), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8470), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8470), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8500), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8500), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8380), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8390), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8390), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8400), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8400), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8400), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8410), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8410), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8410), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8410), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8560), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8570), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8570), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8580), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8580), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8580), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8580), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Joia",
                keyColumn: "IdJoia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataInicio" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6230), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6230), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6270), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6290), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6290), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6290) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6300), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6300), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6310), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6310), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6310), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6320), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6310) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6320), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6320), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6330), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6330), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6330), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6340), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6340), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6340), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6350), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6390), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6540), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6550), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6560), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6560), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6560), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6570), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6570), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6570), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6580), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6580), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6580), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6590), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6590), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6590), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6590), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6600), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6600), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6600), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6610), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8540), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8540), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8540), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6660), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6670), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6670), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6670), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6680), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6680), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6680), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6690), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6690), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6690), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6690), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6700), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6700), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6700), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6710), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6710), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6710), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6710), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6720), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8340), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8340), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8350), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8350), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8350), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8110), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8080), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8120), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8130), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8130), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8130), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8130) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9070), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9070), "$2a$11$0LFPOKsE8YD2zNZInVBvGOKMhaVOKJuoqde4rPxgF3Pwor5Gve1vC" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 428, DateTimeKind.Local).AddTicks(2680), new DateTime(2022, 7, 25, 23, 29, 50, 428, DateTimeKind.Local).AddTicks(2660), "$2a$11$OH3StGw0PZBrw6tIPjH5DefMSnGXPOFwYkNmkGQtEDxe3qkvgNSsm" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 615, DateTimeKind.Local).AddTicks(3730), new DateTime(2022, 7, 25, 23, 29, 50, 615, DateTimeKind.Local).AddTicks(3710), "$2a$11$3Rd/lVrXY8cMu76N5aBueebHWUTclPmBznivwk4wyjDuVn1dWyOtu" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 803, DateTimeKind.Local).AddTicks(2840), new DateTime(2022, 7, 25, 23, 29, 50, 803, DateTimeKind.Local).AddTicks(2820), "$2a$11$n.IObooIf1XjK8X5RkRRSuxFdtPMfmO9RkqSYEhvmQX3PTzaR2mB2" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 990, DateTimeKind.Local).AddTicks(3660), new DateTime(2022, 7, 25, 23, 29, 50, 990, DateTimeKind.Local).AddTicks(3650), "$2a$11$WmjqQsWvQYEdzAdJRzKmX.F.0ioq/wrRrrNnwf9kpUp6Z3./TrGE6" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 175, DateTimeKind.Local).AddTicks(5720), new DateTime(2022, 7, 25, 23, 29, 51, 175, DateTimeKind.Local).AddTicks(5710), "$2a$11$zL9iJkj5XGe.qXNM/HtHueReSWgwSnGmeYI432tD7aTmYPW2hb5lq" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrigemPagamento",
                table: "QuotaSocio");

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(5790), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(5840), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(5850), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(5850), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7410), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7420), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7420), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7420), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7430), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7430), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7430), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7430), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7430) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7440), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7450), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7450), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7450), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7450) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7460), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7460), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7460), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7470), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7470), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7470), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7480), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7480), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7480), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7490), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7490), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7490), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7490), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7500), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7500), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7500), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7510), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7510), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7510), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7510), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7520), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7520), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7520), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7520) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7530), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7530), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7530), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7540), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7530) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7540), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7540), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7550), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7550), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7550), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7560), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7560), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7560), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7560), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7570), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7570), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7570), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7580), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7580), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7580), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7590), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7590), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7590), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7590), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7600), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7600), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7610), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7610), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7620), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7620), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7620), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7630), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7630), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7630), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7640), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7640), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7640), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7640), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7650), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7650), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7650), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7660), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7660), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7660), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7670), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7670), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7670), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7670), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7680), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7680), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7680), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7690), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7690), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7690), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7700), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7700), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7700), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7710), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7710), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7710), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7710), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7720), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7720), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7720), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7730), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7730), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7730), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7730), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7740), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7740), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7740), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7750), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7750), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7750), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7760), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7760), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7760), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7770), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7770), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7780), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7790), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7790), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7790), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7800), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7790) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7800), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7800), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7800), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7810), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7250), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7260), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7260), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7260), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7270), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7280), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7280), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7290), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7290), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7290), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7300), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7300), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7300), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7300), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7310), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7310), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7310), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7320), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7200), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7210), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7210), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7210), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7220), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7220), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7220), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7230), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7230), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7230), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7370), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7380), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7370) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7380), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7380), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7390), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7390), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7390), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Joia",
                keyColumn: "IdJoia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataInicio" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6000), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6000), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6030), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6020) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6040), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6040), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6040) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6050), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6050), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6060), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6060), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6060), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6070), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6070), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6080), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6080), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6080), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6080) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6090), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6090), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6090), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6100), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6100), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6100), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6150), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6150) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6160), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6160), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6160), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6170), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6170), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6170), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6230), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6240), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6240), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6250), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6250), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6260), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6270), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6270), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6270), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6280), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6280), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6280), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7340), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7350), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7350), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6320), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6320), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6330), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6330), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6330), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6340), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6340), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6340), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6340), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6350), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6350), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6350), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6360), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6360), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6360), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6370), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6370), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6370), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6370), new DateTime(2022, 6, 16, 10, 28, 4, 314, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7160), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7160), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7170), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7170), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7170), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(6900), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(6860), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(6900), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(6910), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(6910), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(6910), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7860), new DateTime(2022, 6, 16, 10, 28, 3, 52, DateTimeKind.Local).AddTicks(7860), "$2a$11$f8dUpiPl/lnQpWPYrSNEGeFifXOPp9a3AeDZUP84XGpjxbPFGArza" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 269, DateTimeKind.Local).AddTicks(4500), new DateTime(2022, 6, 16, 10, 28, 3, 269, DateTimeKind.Local).AddTicks(3640), "$2a$11$KFcbZMuwp6VlUAqC8rcYnO9UqtotM6etiSMg8OARj.5SKacL0nSGK" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 490, DateTimeKind.Local).AddTicks(5640), new DateTime(2022, 6, 16, 10, 28, 3, 490, DateTimeKind.Local).AddTicks(5620), "$2a$11$MTc7.wMdju4h0WqmOvLBm.XdtpXiUQpjlmBR51Bbr2ihXoCxb3lAm" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 680, DateTimeKind.Local).AddTicks(4010), new DateTime(2022, 6, 16, 10, 28, 3, 680, DateTimeKind.Local).AddTicks(3990), "$2a$11$tSJFWigtbVR7qdfZrV.aP.x85sB5/pFB1/0.9gtvBeu8VbUey1bgG" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 3, 870, DateTimeKind.Local).AddTicks(1790), new DateTime(2022, 6, 16, 10, 28, 3, 870, DateTimeKind.Local).AddTicks(1770), "$2a$11$K79gupRwJKVzvh29I8Wc4Og/i8BmKBWF75o6bcdoR.y5G8UE.jVem" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 6, 16, 10, 28, 4, 103, DateTimeKind.Local).AddTicks(7090), new DateTime(2022, 6, 16, 10, 28, 4, 103, DateTimeKind.Local).AddTicks(7070), "$2a$11$3shhiS7buJtMTvvu8rE4m.kEKsOnUTTWeS84feyqpahUOA9NsiM36" });
        }
    }
}
