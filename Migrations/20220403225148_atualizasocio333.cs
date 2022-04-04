using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class atualizasocio333 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NumeroDeTelefone",
                table: "Socio",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "NumeroDeTelemovel",
                table: "Socio",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidadeCinBi",
                table: "Socio",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ValidadePassaporte",
                table: "Socio",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6160), new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6140) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6170), new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6180), new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6530), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6540), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6540), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6550), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6590), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6600), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6600), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6600), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6610), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6610), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6610) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6620), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6620), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6620), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6630), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6630), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6640), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6640), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6640), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6650), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6650), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6650), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6660), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6660), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6660), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6670), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6670), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6670), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6680), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6680), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6680), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6690), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6690), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6690), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6700), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6700), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6710), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6710), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6710), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6720), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6720), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6720), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6730), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6730), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6730), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6740), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6740), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6740), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6750), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6750), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6750), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6760), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6760), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6760), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6770), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6770), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6900), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6900), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6900), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6910), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6910), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6920), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6920), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6920), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6930), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6930), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6940), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6940), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6940), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6940), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6950), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6950), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6960), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6960), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6960), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6960), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6970), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6970), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6970), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6980), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6980), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6980), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6990), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6990), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6990), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7000), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7000), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7000), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7010), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7010), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7020), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7020), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7020), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7030), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7030), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7030), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7040), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7040), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7040), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7050), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7050), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7060), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7060), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7060), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7070), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7070), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7070), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7070) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7110), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7120), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7110) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7120), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7120), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7130), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7130), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7130), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7140), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7140), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7140), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7150), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7150), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7150), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7160), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7160), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7160), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7170), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7170), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6360), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6360), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6370), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6370), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6370), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6370) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6380), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6380), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6380), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6390), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6390), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6400), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6400), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6410), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6410), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6410), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6420), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6410) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6420), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6420), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6420) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6220), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6230), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6230), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6230), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6240), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6240), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6240), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6250), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6250), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6330), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6490), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6490), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6500), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6490) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6500), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6500), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6500), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6510), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6220), new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6230), new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6230), new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6230), new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6240), new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6240), new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6240), new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6240) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6250), new DateTime(2022, 4, 3, 21, 51, 47, 823, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6460), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6470), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6170), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6180), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6180), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6190), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6180) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6190), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(6190) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(5840), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(5810), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(5860), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(5900), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(5900), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(5910), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7240), new DateTime(2022, 4, 3, 21, 51, 47, 105, DateTimeKind.Local).AddTicks(7240), "$2a$11$cr05d296v61ZW/7vtlMqTeZQRiWcK57JTLO6G8rfrG2EAFJtjCoEO" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 286, DateTimeKind.Local).AddTicks(3250), new DateTime(2022, 4, 3, 21, 51, 47, 286, DateTimeKind.Local).AddTicks(3220), "$2a$11$K/BICuUPyCrC5nVXYYK53OiRqlYxz7InVDFBzRG.maIhEKnVlTQ82" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 466, DateTimeKind.Local).AddTicks(6290), new DateTime(2022, 4, 3, 21, 51, 47, 466, DateTimeKind.Local).AddTicks(6260), "$2a$11$LhIOM.m4zyABEDu2JaRC/.lzNEAXPaJG57Ce0LJn0BQwMFJ6gTi4a" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 3, 21, 51, 47, 644, DateTimeKind.Local).AddTicks(9580), new DateTime(2022, 4, 3, 21, 51, 47, 644, DateTimeKind.Local).AddTicks(9550), "$2a$11$5Za2vjfF8zswzRa0XvKweuFuILRdaJm5lneXoYPRc.jsvESmzh.Ou" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroDeTelemovel",
                table: "Socio");

            migrationBuilder.DropColumn(
                name: "ValidadeCinBi",
                table: "Socio");

            migrationBuilder.DropColumn(
                name: "ValidadePassaporte",
                table: "Socio");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroDeTelefone",
                table: "Socio",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(2910), new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(2920), new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(2930), new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3550), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3550) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3560), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3560) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3560), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3560) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3570), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3560) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3620), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3630), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3630), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3640), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3640), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3640), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3650), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3650), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3650), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3660), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3660), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3660), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3660), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3670), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3670), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3670), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3680), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3680), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3680), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3690), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3690), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3690), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3700), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3700), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3700), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3700), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3710), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3710), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3720), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3720), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3720), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3730), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3730), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3730), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3740), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3740), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3740), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3740), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3750), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3750), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3750), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3760), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3760), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3760), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3770), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3770), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3770), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3780), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3780), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3780), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3780), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3830), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3830), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3830), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3840), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3840), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3840), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3840) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3850), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3850), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3850), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3860), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3860), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3860), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3870), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3870), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3870), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3870), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3880), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3880), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3880), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3890), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3890), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3890), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3900), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3900), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3900), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3910), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3910), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3910), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3920), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3920), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3920), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3930), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3930), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3930), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3940), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3940), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3940), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3950), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3950), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3950), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3960), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3960), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3960), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3960), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3960) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3970), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3970), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3970), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3970) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3980), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3980), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3980), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3980) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3990), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4020), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4020) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4030), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4030), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4030), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4030) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4040), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4040), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4040), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4050), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4050), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4050), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4060), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4060), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4060), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4070), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4070), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4070), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4070), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4070) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4080), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3380), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3390), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3390), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3400), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3400), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3410), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3410), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3410), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3420), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3420), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3420), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3430), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3430), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3430), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3440), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3440), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3440), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3450), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3050), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3060), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3050) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3060), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3060), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3070), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3070), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3070), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3080), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3340), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3350), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3510), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3510), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3510) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3520), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3520), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3520), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3530), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3520) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3530), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(3770), new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(3780), new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(3790), new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(3780) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(3790), new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(3790), new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(3790), new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(3790) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(3800), new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(3800), new DateTime(2022, 3, 31, 21, 58, 22, 453, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3480), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3490), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3000), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3000) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3010), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3010), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3020), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3010) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3020), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(3020) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(2710), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(2670), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(2770), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(2770), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(2770), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(2780), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(2780) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4140), new DateTime(2022, 3, 31, 21, 58, 21, 726, DateTimeKind.Local).AddTicks(4140), "$2a$11$jfLsQJT4etj10PgbY8UZEOFhA65/Hp3YV7FcZBXwT4K832r3ceA5C" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 21, 908, DateTimeKind.Local).AddTicks(4780), new DateTime(2022, 3, 31, 21, 58, 21, 908, DateTimeKind.Local).AddTicks(4750), "$2a$11$iJK7uoWKaVF6qVE8x1keG.0FhUkwNuXsbPMuZwpNbyin9JZGncNBi" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 22, 89, DateTimeKind.Local).AddTicks(9160), new DateTime(2022, 3, 31, 21, 58, 22, 89, DateTimeKind.Local).AddTicks(9130), "$2a$11$318cYiprZ5hNXt6GW1kqge7KDeTyPKaZ41OPVStJXRq2xPj/sQNQK" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 31, 21, 58, 22, 274, DateTimeKind.Local).AddTicks(790), new DateTime(2022, 3, 31, 21, 58, 22, 274, DateTimeKind.Local).AddTicks(760), "$2a$11$USGt.3Kft9uvF39wxbyOwumknsZTnz2g8.EAYBkYXp1p0yHTnD3bi" });
        }
    }
}
