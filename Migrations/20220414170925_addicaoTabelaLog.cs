using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class addicaoTabelaLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogAtividade",
                columns: table => new
                {
                    IdLogAtividades = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Dados = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    NomeUtilizador = table.Column<string>(type: "TEXT", nullable: false),
                    EnderecoIp = table.Column<string>(type: "TEXT", nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DataAtualizacao = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Eliminado = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogAtividade", x => x.IdLogAtividades);
                });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2090), new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2100), new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2100), new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3180), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3190), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3190), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3190), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3200), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3200), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3250), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3250), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3260), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3260), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3270), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3270), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3270), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3270), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3280), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3280), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3280), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3290), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3290), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3290), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3290), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3300), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3300), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3300), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3310), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3310), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3310), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3320), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3320), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3320), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3320), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3330), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3330), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3330), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3340), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3340), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3350), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3350), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3350), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3350), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3360), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3360), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3360), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3370), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3370), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3370), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3380), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3380), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3380), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3380), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3390), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3390), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3390), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3400), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3400), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3400), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3410), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3410), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3460), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3460), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3470), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3470), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3480), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3480), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3490), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3490), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3490), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3500), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3500), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3500), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3500) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3510), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3510), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3510), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3520), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3520), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3520), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3530), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3530), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3530), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3540), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3540), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3540), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3550), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3550), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3550), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3560), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3560) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3560), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3560) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3570), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3570), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3570), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3580), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3580), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3580), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3580), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3580) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3590), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3590), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3590), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3600), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3600), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3600), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3610), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3610), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3610), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3620), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3620), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3620), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3620), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3630), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3630), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3680), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3680), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3690), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3690), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3690), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3700), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3700), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3700), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3710), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3710), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3710), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3720), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3720), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3720), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3720), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3020), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3020), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3020), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3030), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3030), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3030), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3040), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3040), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3040), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3050), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3050), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3060), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3060), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3060), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3070), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3070), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3070), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3080), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2910), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2910), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2910), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2910) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2920), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2920), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2930), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2930), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2930), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2930), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2940), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3140), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3140), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3150), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3150), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3150), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3160), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3160), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2150), new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2160), new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2160), new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2170), new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2170), new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2180), new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2180), new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2180), new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2190), new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2190), new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2190), new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2190), new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2200), new DateTime(2022, 4, 14, 16, 9, 25, 78, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3110), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3120), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2860), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2870), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2870), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2880), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2880), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2650), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2610), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2660), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2670), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2670), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2670), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(2670) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3780), new DateTime(2022, 4, 14, 16, 9, 24, 362, DateTimeKind.Local).AddTicks(3780), "$2a$11$fSA/8VlNSJUjUJFEWzO2H.2NL.V4rS.bE3RtpJJVM3M7qjfvUMfs." });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 542, DateTimeKind.Local).AddTicks(3120), new DateTime(2022, 4, 14, 16, 9, 24, 542, DateTimeKind.Local).AddTicks(3100), "$2a$11$C1IcrQvZvMaavdwx4.hKeO9OZ/uTxXUGDJKcXMUYlbVNUhW4OtHS6" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 719, DateTimeKind.Local).AddTicks(7390), new DateTime(2022, 4, 14, 16, 9, 24, 719, DateTimeKind.Local).AddTicks(7380), "$2a$11$Xzp12Epn5TIOzPCBEV4oa.CccjDsJHjaMdQZBgng.uLEPj62S9G9q" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 14, 16, 9, 24, 898, DateTimeKind.Local).AddTicks(3370), new DateTime(2022, 4, 14, 16, 9, 24, 898, DateTimeKind.Local).AddTicks(3370), "$2a$11$L35O1SSN9tyrZcckGB2t7uTFg06L4xklRJyRHsdlZX0lpNAnEYK8e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogAtividade");

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5140), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5150), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5150), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5530), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5530), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5530) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5540), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5540), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5540), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5550), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5550), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5550), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5560), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5560), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5560), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5570), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5560) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5570), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5580), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5580), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5580), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5590), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5590), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5590), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5600), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5600), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5600), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5610), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5610), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5610), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5620), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5620), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5620), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5630), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5630), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5630), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5640), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5640), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5640), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5650), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5650), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5650), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5650), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5660), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5660), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5670), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5670), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5670), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5680), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5680), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5690), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5690), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5690), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5690), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5700), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5710), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5710), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5720), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5720), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5730), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5730), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5730), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5740), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5740), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5740), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5750), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5750), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5750), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5760), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5760), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5770), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5770), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5770), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5780), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5780), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5780), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5790), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5790), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5790), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5800), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5800), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5810), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5810), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5810), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5820), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5820), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5820), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5830), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5830), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5830), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5840), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5840), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5840), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5840) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5850), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5850), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5850), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5860), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5860), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5870), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5870), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5870), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5880), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5880), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5880), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5890), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5900), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5900), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5910), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5910), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5910), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5920), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5920), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5920), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5930), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5930), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5930), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5930), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5940), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5940), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5940), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5950), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5950), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5950), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5960), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5960), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5960), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5970), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5970), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5970), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5360), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5360), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5360), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5370), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5370), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5370), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5380), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5380), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5380), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5390), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5390), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5390), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5400), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5400), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5410), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5410), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5420), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5410) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5420), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5420) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5290), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5300), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5310), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5310), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5320), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5310) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5320), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5320), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5320), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5330), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5330), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5480), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5490), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5480) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5490), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5490), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5490), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5490) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5500), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5500), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5190), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5190), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5200), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5200), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5200), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5210), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5210), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5210), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5220), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5220), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5230), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5230), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5230), new DateTime(2022, 4, 14, 15, 31, 25, 5, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5460), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5450) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5460), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5240), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5250), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5250), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5250) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5260), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5260), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5010), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(4980), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5030), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5030), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5030), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5030), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(6030), new DateTime(2022, 4, 14, 15, 31, 24, 271, DateTimeKind.Local).AddTicks(6030), "$2a$11$pAgWZeIMfbRsr/2mb.N5g.XBG0DMOhtWbg7Joq1jH8iA75.cADhJq" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 458, DateTimeKind.Local).AddTicks(3890), new DateTime(2022, 4, 14, 15, 31, 24, 458, DateTimeKind.Local).AddTicks(3870), "$2a$11$oRJxOwoiUf3l0XhfbBSh6OE5J2M0YZzq0OTPieX9fewUtLMXkZSPy" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 641, DateTimeKind.Local).AddTicks(9090), new DateTime(2022, 4, 14, 15, 31, 24, 641, DateTimeKind.Local).AddTicks(9070), "$2a$11$VX1v4sTkAp5oPWviXt0kGu7FuymEdYtv0RYWXa.CVyXySQ21fqZW2" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 14, 15, 31, 24, 823, DateTimeKind.Local).AddTicks(6140), new DateTime(2022, 4, 14, 15, 31, 24, 823, DateTimeKind.Local).AddTicks(6130), "$2a$11$fs8Ixm2w688EbtKbrgL9M.1eFcBBis.L1Z9jduCjcPu9TlY9wKjJS" });
        }
    }
}
