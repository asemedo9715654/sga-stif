using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class atualizacaoSocioAAdicionandoNifComoNulable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nif",
                table: "Socio",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<double>(
                name: "TotalQuoataMesAtual",
                table: "PosicaoIFsResultado",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "TotalQuoataMesAnterior",
                table: "PosicaoIFsResultado",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IdInstituicaoFinanceira",
                table: "PosicaoIFsResultado",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Estado",
                table: "PosicaoIFsResultado",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nif",
                table: "Socio",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TotalQuoataMesAtual",
                table: "PosicaoIFsResultado",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "TotalQuoataMesAnterior",
                table: "PosicaoIFsResultado",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "IdInstituicaoFinanceira",
                table: "PosicaoIFsResultado",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "PosicaoIFsResultado",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2030), new DateTime(2022, 5, 23, 11, 1, 30, 999, DateTimeKind.Local).AddTicks(2030) });

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
    }
}
