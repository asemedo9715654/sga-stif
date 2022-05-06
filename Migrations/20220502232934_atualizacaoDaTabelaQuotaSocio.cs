using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class atualizacaoDaTabelaQuotaSocio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataQueFoiConfirmadaPagamento",
                table: "QuotaSocio",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataQueFoiEfectuadaPagamento",
                table: "QuotaSocio",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UtilizadorQueConfirmouPagamento",
                table: "QuotaSocio",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UtilizadorQueEfectuouPagamento",
                table: "QuotaSocio",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9490), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9500), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9500), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9500), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6620), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6620), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6630), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6630), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6640), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6640), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6640), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6650), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6650), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6650), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6660), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6660), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6660), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6680), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6680), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6690), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6690), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6700), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6700), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6700), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6710), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6710), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6710), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6720), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6720), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6730), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6730), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6730), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6740), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6740), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6740), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6750), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6750), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6750), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6760), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6760), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6760), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6770), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6770), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6770), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6780), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6780), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6790), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6790), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6800), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6800), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6800), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6810), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6810), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6810), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6820), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6820), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6830), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6830), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6830), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6840), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6840), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6840), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6850), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6850), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6850), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6860), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6860), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6870), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6880), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6880), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6890), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6890), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6890), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6900), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6910), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6910), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6910), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6920), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6920), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6920), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6930), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6930), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6930), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6940), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6940), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6940), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6950), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6950), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6960), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6960), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6960), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6970), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6970), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6970), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6980), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6980), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6980), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6990), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6990), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7000), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7000), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7000), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7010), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7010), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7020), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7020), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7020), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7030), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7030), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7030), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7040), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7040), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7040), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7050), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7050), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7050), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7060), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7060), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7060), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7070), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7080), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7080), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7090), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7090), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7090), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7100), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7100), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7110), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6410), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6420), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6420), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6430), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6430), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6430), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6440), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6440), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6450), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6460), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6460), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6470), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6470), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6470), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6470) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6480), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6480), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6480), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6480) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6490), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6350), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6350), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6360), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6360), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6370), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6370), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6370), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6380), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6380), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6380), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6570), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6560) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6570), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6580), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6580), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6580), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6580) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6590), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6590), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Joia",
                keyColumn: "IdJoia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9670), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9670), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9710), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9730), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9730), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9740), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9740), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9740) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9760), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9760), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9760), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9770), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9770), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9770), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9770) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9780), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9780), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9780), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9790), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9790), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9790), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9790) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9800), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9800), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9800) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9870), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9890), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9890), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9890) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9940), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9940), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9950), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9940) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9950), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9950), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9950), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9960), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9960), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9960), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9960), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9960) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9970), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9970), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9970), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9980), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9970) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9980), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9980), new DateTime(2022, 5, 2, 22, 29, 33, 131, DateTimeKind.Local).AddTicks(9980) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6520), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6520) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6530), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6540), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(70), new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(70) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(80), new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(90), new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(80) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(90), new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(90), new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(90), new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(100), new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(100), new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(100), new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(100), new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(110), new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(110), new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(110), new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(110), new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(110) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(120), new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(120), new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(120), new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(120), new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(120) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(130), new DateTime(2022, 5, 2, 22, 29, 33, 132, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6270), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6270), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6270) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6280), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6280), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6280), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(5870), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(5830), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(5880), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(5880), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(5880), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(5890), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7170), new DateTime(2022, 5, 2, 22, 29, 32, 391, DateTimeKind.Local).AddTicks(7170), "$2a$11$jlgm.jiyRShNc2Z/K5lSZe6oZjs9x54ANuGvCQHBqU8719DM9qXbu" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 579, DateTimeKind.Local).AddTicks(5040), new DateTime(2022, 5, 2, 22, 29, 32, 579, DateTimeKind.Local).AddTicks(5030), "$2a$11$OAcPkhTeJ9cYe5NQWYzZmOwcljAynTa7Ek0GEwrHA9JS/V2T8Lclq" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 768, DateTimeKind.Local).AddTicks(1930), new DateTime(2022, 5, 2, 22, 29, 32, 768, DateTimeKind.Local).AddTicks(1910), "$2a$11$g5BOydI6laBu8dsD0DRCQe2zCTJJXqlcrCiVXLG.UzEC878TgDUgu" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 5, 2, 22, 29, 32, 948, DateTimeKind.Local).AddTicks(8300), new DateTime(2022, 5, 2, 22, 29, 32, 948, DateTimeKind.Local).AddTicks(8280), "$2a$11$wtzMk55qpDAinVXs5RlpIukAT4Tug2uJ0fwmeIvOPQw65AKkZaWIu" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataQueFoiConfirmadaPagamento",
                table: "QuotaSocio");

            migrationBuilder.DropColumn(
                name: "DataQueFoiEfectuadaPagamento",
                table: "QuotaSocio");

            migrationBuilder.DropColumn(
                name: "UtilizadorQueConfirmouPagamento",
                table: "QuotaSocio");

            migrationBuilder.DropColumn(
                name: "UtilizadorQueEfectuouPagamento",
                table: "QuotaSocio");

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
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5650), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5640) });

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
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5670), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5670) });

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
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5680), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5680) });

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
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5690), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5690) });

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
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5700), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5700) });

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
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5720), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5720) });

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
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5750), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5740) });

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
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5780), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5780), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5780) });

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
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5790), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5800), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5800), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5800), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5800) });

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
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5830), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5830) });

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
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5850), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5850) });

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
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5870), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5870) });

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
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5900), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5890) });

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
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5990), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6000), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6000), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6000), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6000), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6000) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6040), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6030) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6040), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6040) });

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
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6060), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(6060) });

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
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5570), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5580), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5580), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5580), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5590), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5590), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5600), new DateTime(2022, 5, 2, 10, 25, 53, 731, DateTimeKind.Local).AddTicks(5590) });

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
    }
}
