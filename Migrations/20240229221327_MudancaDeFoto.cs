using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class MudancaDeFoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Foto",
                table: "Socio",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2112), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2123), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2126), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2128), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4738), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4737) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4741), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4742), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4744), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4745), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4747), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4749), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4748) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4750), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4751), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4752), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4753), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4754), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4754) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4755), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4756), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4757), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4758), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4759), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4760), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4761), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4762), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4763), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4764), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4765), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4766), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4766) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4768), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4769), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4770), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4771), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4772), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4773), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4774), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4776), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4777), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4776) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4778), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4779), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4780), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4781), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4782), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4783), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4784), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4785), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4785) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4786), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4787), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4788), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4789), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4790), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4791), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4792), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4832), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4833), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4834), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4835), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4836), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4837), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4838), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4840), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4842), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4843), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4844), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4845), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4846), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4845) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4847), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4847) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4848), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4849), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4849) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4850), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4851), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4851) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4852), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4853), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4854), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4854) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4855), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4855) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4856), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4856) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4857), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4857) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4858), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4858) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4859), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4860), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4861), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4861) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4862), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4862) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4863), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4864), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4865), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4866), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4866) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4867), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4869), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4869) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4870), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4870) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4871), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4871) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4872), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4872) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4873), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4873) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4874), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4874) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4875), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4875) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4877), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4876) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4878), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4877) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4879), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4878) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4880), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4879) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4881), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4880) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4882), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4883), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4882) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4884), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4883) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4885), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4884) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4907), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4909), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4908) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4910), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4911), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4912), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4912) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4913), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4913) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4914), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4914) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4915), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4916), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4916) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4917), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4919), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4919) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4920), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4921), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4922), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4923), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4924), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4924) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4925), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4926), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4927), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4928), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4929), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4929) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4930), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4931), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4931) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4932), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4932) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4934), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4933) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4630), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4634), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4635), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4635) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4637), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4636) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4638), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4639), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4640), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4639) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4641), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4642), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4644), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4645), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4644) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4646), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4647), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4648), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4647) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4649), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4650), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4651), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4652), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4586), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4589), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4589) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4590), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4591), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4592), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4593), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4594), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4595), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4596), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4597), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4678), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4681), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4681) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4683), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4683) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4684), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4684) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4685), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4687), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4686) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4688), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4688) });

            migrationBuilder.UpdateData(
                table: "Joia",
                keyColumn: "IdJoia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataInicio" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2401), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2400), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2468), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2492), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2497), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2500), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2503), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2512), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2514), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2517), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2520), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2524), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2527), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2529), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2532), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2535), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2538), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2541), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2540) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2543), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2547), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2550), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2967), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3096), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3102), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3103), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3105), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3108), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3109), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3110), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3111), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3113), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3112) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3114), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3115), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3115) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3116), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3116) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3117), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3117) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3118), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3119), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3120), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3173), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3174), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4664), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4668), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4669), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3334), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3345), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3346), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3347), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3348), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3348) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3351), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3352), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3353), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3354), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3355), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3356), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3357), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3358), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3359), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3360), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3361), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3361), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3363), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3364), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4567), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4570), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4572), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4573), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4572) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4574), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4461), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4452), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4467), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4470), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4470), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4471), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4958), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4957), "$2a$11$EwJ9lu.DKKAhzsIzrTLziuDynaop/rcjHD3IkUyHURSzS/yTTQ8qy" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 501, DateTimeKind.Local).AddTicks(1013), new DateTime(2024, 2, 29, 21, 13, 26, 501, DateTimeKind.Local).AddTicks(997), "$2a$11$sszw5aHcYqNuyIWp2zmGkOznH1HSHashrYXL0TB.mXjLpCJubkmsi" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 620, DateTimeKind.Local).AddTicks(9004), new DateTime(2024, 2, 29, 21, 13, 26, 620, DateTimeKind.Local).AddTicks(9001), "$2a$11$G3CvJLodsXw5CEujE5R/TeP20VyTr40wlrxS4e2st3mBjnNk1Ant6" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 743, DateTimeKind.Local).AddTicks(2650), new DateTime(2024, 2, 29, 21, 13, 26, 743, DateTimeKind.Local).AddTicks(2647), "$2a$11$bkC2m/PCtFFUa2XZBA04HOP6dEvvDabkNiozYwMDDMrz1UhmAuH8u" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 867, DateTimeKind.Local).AddTicks(2582), new DateTime(2024, 2, 29, 21, 13, 26, 867, DateTimeKind.Local).AddTicks(2576), "$2a$11$yqHxivVuzIAStv2e6urtwedw.71moWX81E7Vj90TW/JbNAFYeksLa" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 984, DateTimeKind.Local).AddTicks(5098), new DateTime(2024, 2, 29, 21, 13, 26, 984, DateTimeKind.Local).AddTicks(5091), "$2a$11$UmWeNxsSufZRpZOEbhfdIugOb5VDQ0rT4BxATQpiy1kvW.GTIS3GO" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Foto",
                table: "Socio",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8317), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8312) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8323), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8325), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8324) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8327), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2096), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2100), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2101), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2103), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2104), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2105), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2107), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2108), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2110), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2111), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2112), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2114), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2115), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2116), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2117), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2117) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2119), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2120), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2121), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2146), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2147), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2149), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2150), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2151), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2153), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2155), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2156), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2157), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2159), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2160), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2161), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2161) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2162), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2164), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2165), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2166), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2167), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2169), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2170), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2171), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2172), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2174), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2175), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2176), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2177), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2179), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2180), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2181), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2183), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2184), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2185), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2186), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2189), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2190), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2191), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2192), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2194), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2195), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2194) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2196), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2198), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2199), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2198) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2200), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2201), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2203), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2204), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2205), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2206), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2208), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2209), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2210), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2211), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2234), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2235), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2236), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2238), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2239), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2240), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2241), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2244), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2245), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2245) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2246), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2248), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2247) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2249), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2250), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2251), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2253), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2254), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2255), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2256), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2258), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2259), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2258) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2260), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2261), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2263), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2264), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2265), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2266), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2266) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2268), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2269), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2270), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2271), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2273), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2274), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2274) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2275), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2277), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2279), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2280), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2279) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2281), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2282), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2284), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2285), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2286), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2287), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2289), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2290), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2292), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2293), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2294), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2295), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2295) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2297), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2298), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2299), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2325), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2323) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2326), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2326) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2327), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2329), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1997), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2001), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2003), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2004), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2005), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2007), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2008), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2010), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2009) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2011), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2012), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2012) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2013), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2015), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2016), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2017), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2018), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2043), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2044), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2046), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1975), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1977), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1978), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1980), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1981), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1981) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1982), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1983), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1983) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1985), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1984) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1986), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1987), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2075), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2078), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2080), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2081), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2082), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2082) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2084), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2085), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "Joia",
                keyColumn: "IdJoia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataInicio" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8407), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8406), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8429), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8438), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8438) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8440), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8442), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8443), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8443) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8445), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8445) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8447), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8450), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8451), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8451) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8453), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8453) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8454), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8456), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8457), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8458), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8458) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8460), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8459) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8461), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8461) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8529), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8528) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8531), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8531) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8532), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8532) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8579), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8584), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8584) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8585), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8587), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8588), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8590), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8589) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8591), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8592), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8592) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8593), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8593) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8595), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8594) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8596), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8595) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8597), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8597) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8598), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8599), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8599) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8600), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8602), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8603), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8604), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "MenuAcao",
                keyColumn: "IdMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8605), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2060), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2065), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2067), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8634), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8637), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8638), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8639), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8639) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8640), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8642), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8641) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8643), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8644), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8645), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8644) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8646), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8646) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8647), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8648), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8649), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8649) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8650), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8651), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8651) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8652), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8653), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8683), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "PerfilMenuAcao",
                keyColumn: "IdPerfilMenuAcao",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8684), new DateTime(2023, 10, 2, 0, 21, 43, 891, DateTimeKind.Local).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1955), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1955) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1958), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1960), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1962), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1963), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1848), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1835), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1854), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1855) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1856), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1856), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1857), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2354), new DateTime(2023, 10, 2, 0, 21, 42, 996, DateTimeKind.Local).AddTicks(2353), "$2a$11$b5uv9Tyma2tZieFUTvmohuRqaUP2r0tgC3hzeVtr.MhYjwSP4RpNC" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 138, DateTimeKind.Local).AddTicks(2962), new DateTime(2023, 10, 2, 0, 21, 43, 138, DateTimeKind.Local).AddTicks(2944), "$2a$11$8ogc1DI4RQiFigmEIAOQue91ecdf.FRrU1vLYpa0JWhj1MbjFh4g2" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 276, DateTimeKind.Local).AddTicks(8810), new DateTime(2023, 10, 2, 0, 21, 43, 276, DateTimeKind.Local).AddTicks(8807), "$2a$11$5zOo0Qn8F5Po81m5ZpfuQeepzIv0gTng6OfX8qTe/CbJPVZ/Y.uJa" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 422, DateTimeKind.Local).AddTicks(2918), new DateTime(2023, 10, 2, 0, 21, 43, 422, DateTimeKind.Local).AddTicks(2913), "$2a$11$fVOF0BrxfSIzNhVnesVGEeAR4l0LyQu/D.Y1nl8oRYweB0pp33r6a" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 575, DateTimeKind.Local).AddTicks(7376), new DateTime(2023, 10, 2, 0, 21, 43, 575, DateTimeKind.Local).AddTicks(7373), "$2a$11$f5VursqucJwsMnI7VbPZaO/tTGzyOSYKBSP/5kLjhl6aGW2pbRAHm" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2023, 10, 2, 0, 21, 43, 740, DateTimeKind.Local).AddTicks(3508), new DateTime(2023, 10, 2, 0, 21, 43, 740, DateTimeKind.Local).AddTicks(3502), "$2a$11$Kap6OZKQ53nBdCS1QZGFjedBp70Fj/4KurjVjZJHaKMC17m12dSnC" });
        }
    }
}
