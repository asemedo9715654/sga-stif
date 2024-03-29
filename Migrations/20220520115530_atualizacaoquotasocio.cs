﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class atualizacaoquotasocio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UtilizadorQueEfectuouPagamento",
                table: "QuotaSocio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UtilizadorQueConfirmouPagamento",
                table: "QuotaSocio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "PosicaoIFsResultado",
                columns: table => new
                {
                    IFNome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdInstituicaoFinanceira = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalSocioAnterior = table.Column<int>(type: "int", nullable: false),
                    TotalSocioAtual = table.Column<int>(type: "int", nullable: false),
                    TotalColaboradoresAnterior = table.Column<int>(type: "int", nullable: false),
                    TotalColaboradoresAtual = table.Column<int>(type: "int", nullable: false),
                    TotalQuoataMesAnterior = table.Column<int>(type: "int", nullable: false),
                    TotalQuoataMesAtual = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

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
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4210), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4210) });

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
                columns: new[] { "DataAtualizacao", "DataCriacao", "NomeDaAction", "NomeDoController" },
                values: new object[] { new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4280), new DateTime(2022, 5, 20, 10, 55, 29, 78, DateTimeKind.Local).AddTicks(4280), "PosicaoDasInstituicoesFinanceiras", "PosicaoIFs" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PosicaoIFsResultado");

            migrationBuilder.AlterColumn<string>(
                name: "UtilizadorQueEfectuouPagamento",
                table: "QuotaSocio",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UtilizadorQueConfirmouPagamento",
                table: "QuotaSocio",
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
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9240), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9220) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9250), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9250), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9250), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8650), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8660), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8670), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8670), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8670), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8680), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8680), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8680), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8690), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8690), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8690), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8710), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8710), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8710), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8770), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8770), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8780), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8780), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8780), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8790), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8790), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8800), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8810), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8810), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8810), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8820), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8820), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8820), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8840), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8840), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8850), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8850), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8850), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8860), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8860), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8860), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8870), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8870), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8890), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8890), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8890), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8900), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8900), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8900), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8910), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8910), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8920), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8920), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8920), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8930), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8930), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8930), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8940), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8940), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8960), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8960), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8960), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8970), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8970), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8970), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8990), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9000), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9000), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9020), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9020), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9020), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9030), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9030), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9030), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9040), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9040), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9050), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9050), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9050), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9060), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9060), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9060), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9070), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9070), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9070), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9080), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9080), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9080), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9090), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9090), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9100), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9100), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9100), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9110), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9110), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9110), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9110) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9120), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9120), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9120), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8470), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8500), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8500), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8510), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8510), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8510), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8520), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8520), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8520), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8530), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8530), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8530), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8410), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8410), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8420), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8410) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8420), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8420), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8430), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8430), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8440), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8440), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8440), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8600), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8600), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Joia",
                keyColumn: "IdJoia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9400), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9400), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9440), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9460), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9460), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9460) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9470), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9470), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9480), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9480), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9480), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9480) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao", "NomeDaAction", "NomeDoController" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9490), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9490), "", "" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9490), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9490), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9500), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9500), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9500), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9510), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9510), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9510), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9510) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9520), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9520), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9600), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9600) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9610), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9610), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9610), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9620), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9620), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9620), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9630), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9630) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9640), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9640), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9650), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9650), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9650), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9660), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9650) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9660), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9660), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9660), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9660) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9670), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9670), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9670) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8560), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8570), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8570), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9710), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9720), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9720) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9730), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9730), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9730), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9740), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9740), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9740), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9740), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9750), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9750), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9750), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9750), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9760), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9760), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9760), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9760), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9770), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9770), new DateTime(2022, 5, 11, 21, 5, 52, 726, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8320), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8330), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8340), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8350), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8350), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8090), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8060), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8100), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8110), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8110), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8110), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9200), new DateTime(2022, 5, 11, 21, 5, 51, 616, DateTimeKind.Local).AddTicks(9200), "$2a$11$D.dfJkQDzQHfOZUX4TvElugrlpGapbHzEhcFg.2KRbrMt7zM.7jPi" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 804, DateTimeKind.Local).AddTicks(4050), new DateTime(2022, 5, 11, 21, 5, 51, 804, DateTimeKind.Local).AddTicks(4040), "$2a$11$q.8n7q.dOS8oVBztBM2n8e.P1iVwvYbVb1R8ifprV4iP/DRUYKEr6" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 51, 991, DateTimeKind.Local).AddTicks(7930), new DateTime(2022, 5, 11, 21, 5, 51, 991, DateTimeKind.Local).AddTicks(7910), "$2a$11$B4ncAS8oOj/FPUA3GZ/npenvjoUcSSp2j85n0iKrIlirk1XrzoLlK" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 175, DateTimeKind.Local).AddTicks(1320), new DateTime(2022, 5, 11, 21, 5, 52, 175, DateTimeKind.Local).AddTicks(1310), "$2a$11$7AC23tM.fdhZrw6fI77X2.ubX9pKUx67G7xRBrBBaDYgmdaZRPLiu" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 363, DateTimeKind.Local).AddTicks(4100), new DateTime(2022, 5, 11, 21, 5, 52, 363, DateTimeKind.Local).AddTicks(4080), "$2a$11$PQAnZ1A9HbDtmrMYAqvSeelMy3n8ILs4zQ1eEmedqJSloRGhSEEIq" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 11, 21, 5, 52, 544, DateTimeKind.Local).AddTicks(7640), new DateTime(2022, 5, 11, 21, 5, 52, 544, DateTimeKind.Local).AddTicks(7630), "$2a$11$.TxeOQ.Lwc6NGlJ0hZZ2a.qWeXZMPR6m1HxoSp9qvwsTT4PGHof9C" });
        }
    }
}
