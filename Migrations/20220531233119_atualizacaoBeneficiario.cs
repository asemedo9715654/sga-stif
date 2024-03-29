﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class atualizacaoBeneficiario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NumeroPassaporte",
                table: "Beneficiario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nif",
                table: "Beneficiario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CinBi",
                table: "Beneficiario",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(7940), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(7950), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(7960), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(7960), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4040), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4050), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4050), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4060), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4060), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4060), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4070), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4070), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4070), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4080), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4080), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4080), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4090), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4090), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4090) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4100), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4100), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4100), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4110), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4110), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4120), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4110) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4120), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4120), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4130), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4130), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4140), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4130) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4140), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4140), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4150), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4150), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4160), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4150) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4160), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4160), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4170), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4170), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4180), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4180), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4180), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4190), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4190), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4200), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4190) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4200), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4200), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4210), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4200) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4210), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4210), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4220), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4220), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4220), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4220) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4230), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4230), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4230), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4240), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4250), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4240) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4250), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4250), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4260), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4250) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4260), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4260), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4260) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4270), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4270), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4270), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4280), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4280), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4280), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4290), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4290), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4300), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4300), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4300), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4310), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4310), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4310), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4320), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4320), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4330), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4320) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4330), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4330), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4340), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4340), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4340), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4350), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4350), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4350), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4360), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4360), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4360), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4370), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4360) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4370), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4370), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4380), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4380), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4390), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4390), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4390), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4400), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4400), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4400), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4410), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4410), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4410), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4420), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4420), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4420), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4430), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4440), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4440), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4440), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4440) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4450), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4450), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4450), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4460), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4460), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4460), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4460) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4470), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4470), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4470), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4470) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4480), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4480), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4490), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4480) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4490), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4490), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4500), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4500), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4500), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4500) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3870), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3870), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3880), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3880), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3880), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3890), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3890), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3890), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3900), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3900), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3900), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3910), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3910), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3910), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3920), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3920), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3930), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3930), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3800), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3810), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3810), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3810), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3820), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3820), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3820), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3830), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3830), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3830), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3990), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4000), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4000), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4000), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4010), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4010), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4010), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "Joia",
                keyColumn: "IdJoia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8060), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8060), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8100), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8120), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8110) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8160), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8160), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8170), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8170), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8170), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8180), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8180), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8180), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8190), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8180) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8190), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8190), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8190), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8190) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8200), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8200), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8200), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8210), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8210), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8210) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8280), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8290), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8290), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8290), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8300), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8300), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8300), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8310), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8300) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8310), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8310), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8310), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8310) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8320), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8320), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8320), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8320), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8330), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8330), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8330), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8330), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3960), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3960), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3970), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8390), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8390) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8400), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8400), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8400), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8590), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8600), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8600), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8600), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 5, 31, 22, 31, 18, 51, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3750), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3760), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3760), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3770), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3770), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3490), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3460), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3500), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3510), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3500), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3510), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4560), new DateTime(2022, 5, 31, 22, 31, 16, 968, DateTimeKind.Local).AddTicks(4560), "$2a$11$.X7nR9FpUits3496ZSzMxuMuPUUBvFhxrl5i0KfLA0e3IAe4m6eMC" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 17, 146, DateTimeKind.Local).AddTicks(6210), new DateTime(2022, 5, 31, 22, 31, 17, 146, DateTimeKind.Local).AddTicks(6200), "$2a$11$3g/ISDHGTKminxgUk.B/t.gj0MxR.dycZ9iPGH8LcteOEr2MxiSfi" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 17, 329, DateTimeKind.Local).AddTicks(3550), new DateTime(2022, 5, 31, 22, 31, 17, 329, DateTimeKind.Local).AddTicks(3530), "$2a$11$lbFR9kjGfFXlGEzgAVl6DuEElizPPyxnQatG7oDgeKCiUWQ5lTsCa" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 17, 510, DateTimeKind.Local).AddTicks(3090), new DateTime(2022, 5, 31, 22, 31, 17, 510, DateTimeKind.Local).AddTicks(3080), "$2a$11$OM47TwwnK3fAb224Y.94KucYQH08rBfrN200gWIoBHYKiAYMPwcja" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 17, 692, DateTimeKind.Local).AddTicks(3590), new DateTime(2022, 5, 31, 22, 31, 17, 692, DateTimeKind.Local).AddTicks(3570), "$2a$11$VBjxW.milSYXsEMt/LU.sOASoe24vQ6p2hykUh8Fer1ptFhQlXWx6" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 31, 22, 31, 17, 872, DateTimeKind.Local).AddTicks(5800), new DateTime(2022, 5, 31, 22, 31, 17, 872, DateTimeKind.Local).AddTicks(5780), "$2a$11$2L6FhyM2ldOMmjy/UD.mNuo4IRhWV5h.cPbNWhkOvsJ7/sH0OCZxO" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NumeroPassaporte",
                table: "Beneficiario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nif",
                table: "Beneficiario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CinBi",
                table: "Beneficiario",
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
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8710), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8700) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5260), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5270), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5270), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5280), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5270) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5280), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5280), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5290), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5290), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5300), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5300), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5300), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5310), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5310), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5310), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5320), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5320), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5320), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5330), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5330), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5330), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5340), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5340), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5340), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5350), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5350), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5350), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5350), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5360), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5360), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5360), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5370), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5370), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5370), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5380), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5380), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5380), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5390), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5390), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5390), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5400), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5400), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5400), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5410), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5410), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5410), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5420), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5420), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5420), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5430), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5430), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5430), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5440), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5450), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5450), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5450), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5460), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5460), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5460), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5470), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5470), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5470), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5470) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5480), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5480), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5480), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5490), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5490), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5490), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5500), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5500), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5500), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5500), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5510), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5510), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5510), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5520), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5520), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5520), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5530), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5530), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5530), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5540), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5540), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5540), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5550), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5550), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5550), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5560), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5560), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5560), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5570), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5570), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5570), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5580), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5580), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5580), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5580), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5590), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5590), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5590), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5600), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5600), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5600), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5610), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5620), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5620), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5620), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5630), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5630), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5630), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5640), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5640), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5640), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5650), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5650), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5650), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5660), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5660), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5660), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5660), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5670), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5670), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5670), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5680), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5680), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5090), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5100), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5100), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5110), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5100) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5110), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5110), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5120), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5120), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5120), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5120), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5130), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5130), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5140), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5140), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5140), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5150), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5150), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5150), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5030), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5030), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5040), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5040), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5040), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5050), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5050), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5050), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5050), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5060), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5210), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5220), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5220), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5220), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5230), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5230), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5230), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Joia",
                keyColumn: "IdJoia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8870), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8870), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8910), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8920), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8970), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8970), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8970) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8990), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8990), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8990), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8990), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9000), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9000), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9000), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9020), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9020), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9020), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9130), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9140), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9140), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9140), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9150), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9150), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9150), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9160), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9160), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9160), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9160), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9170), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9170), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9170), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9170), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9180), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9180), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9180), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9190), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5180), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5190), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5190), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9240), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9250), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9260), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9260), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9260), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9260), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9270), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9270), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9270), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9280), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9280), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9280), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9280), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9290), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9290), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9290), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9290), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9300), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9300), new DateTime(2022, 5, 25, 9, 47, 26, 851, DateTimeKind.Local).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(4990), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(4980) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(4990), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(4990), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5000), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5000), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(4680), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(4650), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(4690), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(4690) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(4700), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(4700), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(4700), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5730), new DateTime(2022, 5, 25, 9, 47, 25, 758, DateTimeKind.Local).AddTicks(5730), "$2a$11$uGeKJergioB../aAFxHnfO1o9HkOqweWcy/woDM3jX/hm7QHQKfqu" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 25, 939, DateTimeKind.Local).AddTicks(6360), new DateTime(2022, 5, 25, 9, 47, 25, 939, DateTimeKind.Local).AddTicks(6340), "$2a$11$lJPiBJgkeVOA3/ZRXqBJ7eOGPvBj8Y.jnD/Ad2/LPuwnUjyskatbe" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 123, DateTimeKind.Local).AddTicks(220), new DateTime(2022, 5, 25, 9, 47, 26, 123, DateTimeKind.Local).AddTicks(210), "$2a$11$4Tq.DsszmMBOAxu6.5/ML.01WlWNOj/bwaF0jIP2XhHw2uteLU4sm" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 303, DateTimeKind.Local).AddTicks(8410), new DateTime(2022, 5, 25, 9, 47, 26, 303, DateTimeKind.Local).AddTicks(8400), "$2a$11$z0gK8JNmQKutlPzQpzjljubO.eyG2RsDcCjNou5pZfEa7W1joRYB." });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 488, DateTimeKind.Local).AddTicks(8770), new DateTime(2022, 5, 25, 9, 47, 26, 488, DateTimeKind.Local).AddTicks(8760), "$2a$11$P7LPt0czMSo55KoU1VsE2uB75J59XXDbtKk7bID5aZGCshtY6XYwW" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 25, 9, 47, 26, 671, DateTimeKind.Local).AddTicks(2280), new DateTime(2022, 5, 25, 9, 47, 26, 671, DateTimeKind.Local).AddTicks(2270), "$2a$11$4HaTgJzkj/8k4qiORaxSJOkG1XTtJ1Wj0MYC8drN1DS/Gvb3X8Kmq" });
        }
    }
}
