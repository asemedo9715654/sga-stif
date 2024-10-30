using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class AdicaoDoCampoEmailEnviado : Migration
    {
        //protected override void Up(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.AlterColumn<string>(
        //        name: "Foto",
        //        table: "Socio",
        //        type: "nvarchar(max)",
        //        nullable: true,
        //        oldClrType: typeof(string),
        //        oldType: "nvarchar(max)");

        //    migrationBuilder.CreateTable(
        //        name: "EmailEnviado",
        //        columns: table => new
        //        {
        //            IdEmailEnviado = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            Apelido = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            NumeroSocio = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Obs = table.Column<string>(type: "nvarchar(max)", nullable: true),
        //            Corpo = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            Assunto = table.Column<string>(type: "nvarchar(max)", nullable: false),
        //            JaFoiEnviado = table.Column<bool>(type: "bit", nullable: false),
        //            DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            Eliminado = table.Column<bool>(type: "bit", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_EmailEnviado", x => x.IdEmailEnviado);
        //        });

        //    migrationBuilder.UpdateData(
        //        table: "Acao",
        //        keyColumn: "IdAcao",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4102), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4098) });

        //    migrationBuilder.UpdateData(
        //        table: "Acao",
        //        keyColumn: "IdAcao",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4108), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4108) });

        //    migrationBuilder.UpdateData(
        //        table: "Acao",
        //        keyColumn: "IdAcao",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4110), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4109) });

        //    migrationBuilder.UpdateData(
        //        table: "Acao",
        //        keyColumn: "IdAcao",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4111), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4111) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8295), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8294) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8308), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8308) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8310), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8309) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8312), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8311) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8313), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8313) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8315), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8314) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8316), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8316) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8318), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8317) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8320), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8320) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8322), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8322) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8324), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8323) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 12,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8354), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8350) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 13,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8356), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8355) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 14,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8357), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8357) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 15,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8359), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8359) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 16,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8361), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8360) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 17,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8362), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8362) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 18,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8364), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8363) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 19,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8365), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8365) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 20,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8367), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8366) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 21,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8368), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8368) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 22,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8370), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8369) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 23,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8371), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8371) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 24,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8373), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8372) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 25,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8374), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8374) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 26,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8376), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8375) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 27,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8377), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8377) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 28,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8379), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8378) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 29,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8380), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8380) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 30,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8382), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8381) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 31,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8383), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8383) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 32,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8385), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8384) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 33,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8386), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8386) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 34,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8388), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8387) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 35,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8390), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8390) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 36,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8392), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8391) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 37,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8393), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8393) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 38,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8395), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8394) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 39,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8396), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8396) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 40,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8398), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8397) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 41,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8400), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8399) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 42,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8401), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8400) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 43,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8402), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8402) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 44,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8404), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8403) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 45,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8406), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8405) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 46,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8407), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8407) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 47,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8409), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8408) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 48,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8410), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8410) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 49,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8412), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8411) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 50,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8413), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8413) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 51,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8415), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8414) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 52,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8416), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8416) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 53,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8418), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8417) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 54,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8419), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8419) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 55,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8421), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8420) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 56,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8422), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8422) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 57,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8424), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8423) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 58,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8425), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8425) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 59,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8427), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8426) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 60,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8428), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8428) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 61,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8431), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8430) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 62,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8459), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8458) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 63,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8495), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8492) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 64,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8497), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8496) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 65,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8498), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8498) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 66,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8500), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8499) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 67,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8502), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8501) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 68,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8503), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8502) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 69,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8505), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8504) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 70,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8506), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8506) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 71,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8508), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8507) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 72,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8509), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8508) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 73,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8510), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8510) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 74,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8512), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8511) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 75,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8513), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8513) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 76,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8535), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8534) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 77,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8537), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8537) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 78,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8540), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8539) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 79,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8542), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8541) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 80,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8544), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8543) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 81,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8545), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8545) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 82,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8547), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8547) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 83,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8549), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8548) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 84,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8551), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8550) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 85,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8553), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8552) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 86,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8554), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8554) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 87,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8557), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8557) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 88,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8559), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8559) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 89,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8561), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8560) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 90,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8563), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8562) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 91,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8565), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8564) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 92,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8567), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8566) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 93,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8568), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8568) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 94,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8570), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8570) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 95,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8572), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8572) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 96,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8574), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8574) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 97,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8576), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8575) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 98,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8578), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8577) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 99,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8580), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8579) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 100,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8581), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8581) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 101,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8583), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8583) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 102,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8585), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8584) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 103,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8587), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8586) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 104,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8589), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8588) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 105,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8590), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8590) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 106,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8592), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8592) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 107,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8594), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8594) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 108,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8596), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8595) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 109,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8598), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8597) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 110,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8599), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8599) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 111,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8602), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8601) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 112,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8604), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8603) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 113,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8606), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8606) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 114,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8608), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8608) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 115,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8646), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8645) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 116,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8648), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8647) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 117,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8650), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8649) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 118,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8652), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8651) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 119,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8653), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8653) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 120,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8655), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8654) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 121,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8657), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8656) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 122,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8659), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8658) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 123,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8661), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8660) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 124,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8664), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8663) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7976), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7975) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7980), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7979) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7981), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7981) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7983), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7982) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7984), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7984) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7986), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7985) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7987), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7987) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7989), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7988) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7990), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7990) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7992), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7991) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7993), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7993) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 12,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7996), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7995) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 13,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8209), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8155) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 14,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8211), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8210) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 15,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8212), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8212) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 16,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8214), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8213) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 17,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8215), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8215) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 18,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8217), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8216) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7947), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7946) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7950), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7950) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7952), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7951) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7953), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7953) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7955), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7954) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7956), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7955) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7957), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7957) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7959), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7958) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7960), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7960) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7961), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7961) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8263), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8262) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8268), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8267) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8271), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8270) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8273), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8272) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8275), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8274) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8277), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8276) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8279), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8278) });

        //    migrationBuilder.UpdateData(
        //        table: "Joia",
        //        keyColumn: "IdJoia",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "DataInicio" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4222), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4222), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4231) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4255), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4255) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4272), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4272) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4275), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4275) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4277), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4277) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4279), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4278) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4282), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4281) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4284), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4283) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4285), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4285) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4287), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4287) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4289), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4289) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4457), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4457) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 12,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4459), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4459) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 13,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4461), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4460) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 14,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4463), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4462) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 15,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4465), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4464) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 16,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4467), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4466) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 17,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4468), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4468) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 18,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4471), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4470) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 19,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4472), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4472) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4654), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4653) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4664), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4664) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4666), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4665) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4667), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4667) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4668), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4668) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4671), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4670) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4672), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4671) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4673), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4673) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4675), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4674) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4676), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4676) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4678), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4677) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 12,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4679), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4679) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 13,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4680), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4680) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 14,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4682), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4681) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 15,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4683), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4683) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 16,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4685), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4684) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 17,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4686), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4685) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 18,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4688), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4687) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 19,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4689), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4689) });

        //    migrationBuilder.UpdateData(
        //        table: "Perfil",
        //        keyColumn: "IdPerfil",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8241), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8240) });

        //    migrationBuilder.UpdateData(
        //        table: "Perfil",
        //        keyColumn: "IdPerfil",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8249), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8249) });

        //    migrationBuilder.UpdateData(
        //        table: "Perfil",
        //        keyColumn: "IdPerfil",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8252), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8251) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4726), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4725) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4732), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4732) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4734), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4733) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4735), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4734) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4736), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4736) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4738), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4737) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4739), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4738) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4740), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4740) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4741), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4741) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4775), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4774) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4776), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4775) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 12,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4777), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4777) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 13,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4779), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4778) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 14,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4780), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4779) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 15,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4781), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4781) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 16,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4782), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4782) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 17,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4784), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4783) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 18,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4786), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4785) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 19,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4787), new DateTime(2024, 3, 24, 10, 42, 21, 208, DateTimeKind.Local).AddTicks(4786) });

        //    migrationBuilder.UpdateData(
        //        table: "TipoQuota",
        //        keyColumn: "IdTipoQuota",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7919), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7918) });

        //    migrationBuilder.UpdateData(
        //        table: "TipoQuota",
        //        keyColumn: "IdTipoQuota",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7922), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7922) });

        //    migrationBuilder.UpdateData(
        //        table: "TipoQuota",
        //        keyColumn: "IdTipoQuota",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7924), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7924) });

        //    migrationBuilder.UpdateData(
        //        table: "TipoQuota",
        //        keyColumn: "IdTipoQuota",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7926), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7926) });

        //    migrationBuilder.UpdateData(
        //        table: "TipoQuota",
        //        keyColumn: "IdTipoQuota",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7928), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7928) });

        //    migrationBuilder.UpdateData(
        //        table: "TipologiaSocio",
        //        keyColumn: "IdTipologiaSocio",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7757), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7742), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7766), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7766) });

        //    migrationBuilder.UpdateData(
        //        table: "TipologiaSocio",
        //        keyColumn: "IdTipologiaSocio",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7768), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7768), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7770), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(7771) });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8737), new DateTime(2024, 3, 24, 10, 42, 19, 996, DateTimeKind.Local).AddTicks(8737), "$2a$11$Vg.QED2BCBdLsjs7V/bCqO2FiIyFVN9zVm14DjG/2vRkIhRMRItqu" });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 20, 188, DateTimeKind.Local).AddTicks(6115), new DateTime(2024, 3, 24, 10, 42, 20, 188, DateTimeKind.Local).AddTicks(6107), "$2a$11$Nj6k81HxuRQGLYYhY/8giO7Cdv4oIUQQAlK92IdMi3Ye9/e7RXej2" });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 20, 373, DateTimeKind.Local).AddTicks(1690), new DateTime(2024, 3, 24, 10, 42, 20, 373, DateTimeKind.Local).AddTicks(1684), "$2a$11$AvHzv7Z9NuXY8I2iv4ZlQOlj2cIVHVC.GTn90TZGagRiPr8sjRNHu" });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 20, 558, DateTimeKind.Local).AddTicks(397), new DateTime(2024, 3, 24, 10, 42, 20, 558, DateTimeKind.Local).AddTicks(392), "$2a$11$eVzAB/XbBIyuiJM0qv0YvuSF8HG9hLwxr4BW1xF9GTDxqQbpg3C7y" });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 20, 770, DateTimeKind.Local).AddTicks(654), new DateTime(2024, 3, 24, 10, 42, 20, 770, DateTimeKind.Local).AddTicks(645), "$2a$11$yOFvR1I3e1iGa4cYWUIsTeNp2vNa70W5NvyRzVQGR4SF7dhndzIdG" });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2024, 3, 24, 10, 42, 20, 996, DateTimeKind.Local).AddTicks(4492), new DateTime(2024, 3, 24, 10, 42, 20, 996, DateTimeKind.Local).AddTicks(4486), "$2a$11$vAHs0hpFEvLzJY7YOvDaduuSXFBgb46vOyiZOd4XQ6xcHlDuPbv5u" });
        //}

        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropTable(
        //        name: "EmailEnviado");

        //    migrationBuilder.AlterColumn<string>(
        //        name: "Foto",
        //        table: "Socio",
        //        type: "nvarchar(max)",
        //        nullable: false,
        //        defaultValue: "",
        //        oldClrType: typeof(string),
        //        oldType: "nvarchar(max)",
        //        oldNullable: true);

        //    migrationBuilder.UpdateData(
        //        table: "Acao",
        //        keyColumn: "IdAcao",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2112), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2106) });

        //    migrationBuilder.UpdateData(
        //        table: "Acao",
        //        keyColumn: "IdAcao",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2123), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2122) });

        //    migrationBuilder.UpdateData(
        //        table: "Acao",
        //        keyColumn: "IdAcao",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2126), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2125) });

        //    migrationBuilder.UpdateData(
        //        table: "Acao",
        //        keyColumn: "IdAcao",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2128), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2127) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4738), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4737) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4741), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4740) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4742), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4742) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4744), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4743) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4745), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4745) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4747), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4747) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4749), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4748) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4750), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4749) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4751), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4751) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4752), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4752) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4753), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4753) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 12,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4754), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4754) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 13,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4755), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4755) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 14,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4756), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4756) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 15,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4757), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4757) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 16,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4758), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4758) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 17,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4759), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4759) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 18,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4760), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4760) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 19,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4761), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4761) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 20,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4762), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4762) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 21,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4763), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4763) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 22,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4764), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4764) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 23,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4765), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4765) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 24,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4766), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4766) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 25,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4768), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4767) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 26,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4769), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4768) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 27,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4770), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4769) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 28,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4771), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4770) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 29,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4772), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4771) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 30,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4773), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4772) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 31,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4774), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4773) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 32,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4776), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4775) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 33,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4777), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4776) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 34,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4778), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4777) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 35,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4779), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4778) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 36,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4780), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4779) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 37,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4781), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4780) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 38,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4782), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4781) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 39,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4783), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4783) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 40,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4784), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4784) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 41,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4785), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4785) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 42,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4786), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4786) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 43,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4787), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4787) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 44,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4788), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4788) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 45,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4789), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4789) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 46,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4790), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4790) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 47,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4791), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4791) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 48,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4792), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4792) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 49,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4830) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 50,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4832), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4832) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 51,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4833), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4833) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 52,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4834), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4834) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 53,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4835), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4835) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 54,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4836), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4836) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 55,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4837), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4837) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 56,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4838), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4838) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 57,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4840), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4839) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 58,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4842), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4841) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 59,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4843), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4842) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 60,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4844), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4843) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 61,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4845), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4844) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 62,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4846), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4845) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 63,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4847), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4847) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 64,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4848), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4848) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 65,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4849), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4849) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 66,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4850), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4850) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 67,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4851), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4851) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 68,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4852), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4852) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 69,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4853), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4853) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 70,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4854), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4854) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 71,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4855), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4855) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 72,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4856), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4856) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 73,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4857), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4857) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 74,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4858), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4858) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 75,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4859), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4859) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 76,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4860), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4860) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 77,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4861), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4861) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 78,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4862), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4862) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 79,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4863), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4863) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 80,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4864), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4864) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 81,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4865), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4865) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 82,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4866), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4866) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 83,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4867), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4867) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 84,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4869), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4869) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 85,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4870), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4870) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 86,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4871), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4871) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 87,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4872), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4872) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 88,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4873), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4873) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 89,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4874), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4874) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 90,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4875), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4875) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 91,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4877), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4876) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 92,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4878), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4877) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 93,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4879), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4878) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 94,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4880), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4879) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 95,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4881), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4880) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 96,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4882), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4881) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 97,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4883), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4882) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 98,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4884), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4883) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 99,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4885), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4884) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 100,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4907), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4906) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 101,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4909), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4908) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 102,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4910), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4909) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 103,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4911), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4910) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 104,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4912), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4912) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 105,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4913), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4913) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 106,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4914), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4914) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 107,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4915), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4915) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 108,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4916), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4916) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 109,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4917), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4917) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 110,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4919), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4919) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 111,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4920), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4920) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 112,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4921), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4921) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 113,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4922), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4922) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 114,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4923), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4923) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 115,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4924), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4924) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 116,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4925), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4925) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 117,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4926), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4926) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 118,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4927), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4927) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 119,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4928), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4928) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 120,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4929), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4929) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 121,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4930), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4930) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 122,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4931), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4931) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 123,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4932), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4932) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 124,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4934), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4933) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4630), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4629) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4634), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4634) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4635), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4635) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4637), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4636) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4638), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4637) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4639), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4638) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4640), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4639) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4641), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4640) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4642), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4642) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4644), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4643) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4645), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4644) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 12,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4646), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4645) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 13,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4647), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4646) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 14,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4648), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4647) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 15,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4649), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4648) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 16,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4650), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4649) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 17,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4651), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4651) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 18,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4652), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4652) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4586), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4586) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4589), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4589) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4590), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4590) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4591), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4591) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4592), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4592) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4593), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4593) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4594), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4594) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4595), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4595) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4596), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4596) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4597), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4597) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4678), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4678) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4681), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4681) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4683), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4683) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4684), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4684) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4685), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4685) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4687), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4686) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4688), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4688) });

        //    migrationBuilder.UpdateData(
        //        table: "Joia",
        //        keyColumn: "IdJoia",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "DataInicio" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2401), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2400), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2415) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2468), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2467) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2492), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2491) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2497), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2496) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2500), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2499) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2503), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2502) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2512), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2511) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2514), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2514) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2517), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2516) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2520), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2519) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2524), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2523) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2527), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2526) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 12,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2529), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2529) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 13,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2532), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2531) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 14,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2535), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2534) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 15,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2538), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2537) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 16,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2541), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2540) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 17,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2543), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2543) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 18,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2547), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2547) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 19,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2550), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2549) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2967), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(2962) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3096), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3095) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3102), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3101) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3103), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3103) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3105), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3104) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3108), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3107) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3109), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3108) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3110), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3110) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3111), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3111) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3113), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3112) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3114), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3113) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 12,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3115), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3115) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 13,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3116), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3116) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 14,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3117), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3117) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 15,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3118), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3118) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 16,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3119), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3119) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 17,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3120), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3120) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 18,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3173), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3172) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 19,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3174), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3173) });

        //    migrationBuilder.UpdateData(
        //        table: "Perfil",
        //        keyColumn: "IdPerfil",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4664), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4664) });

        //    migrationBuilder.UpdateData(
        //        table: "Perfil",
        //        keyColumn: "IdPerfil",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4668), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4667) });

        //    migrationBuilder.UpdateData(
        //        table: "Perfil",
        //        keyColumn: "IdPerfil",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4669), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4669) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3334), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3333) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3345), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3345) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3346), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3346) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3347), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3347) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3348), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3348) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3351), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3351) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3352), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3352) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3353), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3353) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3354), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3354) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3355), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3355) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3356), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3356) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 12,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3357), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3357) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 13,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3358), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3358) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 14,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3359), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3358) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 15,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3360), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3359) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 16,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3361), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3360) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 17,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3361), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3361) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 18,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3363), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3362) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 19,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3364), new DateTime(2024, 2, 29, 21, 13, 27, 105, DateTimeKind.Local).AddTicks(3363) });

        //    migrationBuilder.UpdateData(
        //        table: "TipoQuota",
        //        keyColumn: "IdTipoQuota",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4567), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4567) });

        //    migrationBuilder.UpdateData(
        //        table: "TipoQuota",
        //        keyColumn: "IdTipoQuota",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4570), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4570) });

        //    migrationBuilder.UpdateData(
        //        table: "TipoQuota",
        //        keyColumn: "IdTipoQuota",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4572), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4571) });

        //    migrationBuilder.UpdateData(
        //        table: "TipoQuota",
        //        keyColumn: "IdTipoQuota",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4573), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4572) });

        //    migrationBuilder.UpdateData(
        //        table: "TipoQuota",
        //        keyColumn: "IdTipoQuota",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4574), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4574) });

        //    migrationBuilder.UpdateData(
        //        table: "TipologiaSocio",
        //        keyColumn: "IdTipologiaSocio",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4461), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4452), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4467), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4468) });

        //    migrationBuilder.UpdateData(
        //        table: "TipologiaSocio",
        //        keyColumn: "IdTipologiaSocio",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4470), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4470), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4471), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4471) });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4958), new DateTime(2024, 2, 29, 21, 13, 26, 382, DateTimeKind.Local).AddTicks(4957), "$2a$11$EwJ9lu.DKKAhzsIzrTLziuDynaop/rcjHD3IkUyHURSzS/yTTQ8qy" });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 501, DateTimeKind.Local).AddTicks(1013), new DateTime(2024, 2, 29, 21, 13, 26, 501, DateTimeKind.Local).AddTicks(997), "$2a$11$sszw5aHcYqNuyIWp2zmGkOznH1HSHashrYXL0TB.mXjLpCJubkmsi" });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 620, DateTimeKind.Local).AddTicks(9004), new DateTime(2024, 2, 29, 21, 13, 26, 620, DateTimeKind.Local).AddTicks(9001), "$2a$11$G3CvJLodsXw5CEujE5R/TeP20VyTr40wlrxS4e2st3mBjnNk1Ant6" });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 743, DateTimeKind.Local).AddTicks(2650), new DateTime(2024, 2, 29, 21, 13, 26, 743, DateTimeKind.Local).AddTicks(2647), "$2a$11$bkC2m/PCtFFUa2XZBA04HOP6dEvvDabkNiozYwMDDMrz1UhmAuH8u" });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 867, DateTimeKind.Local).AddTicks(2582), new DateTime(2024, 2, 29, 21, 13, 26, 867, DateTimeKind.Local).AddTicks(2576), "$2a$11$yqHxivVuzIAStv2e6urtwedw.71moWX81E7Vj90TW/JbNAFYeksLa" });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2024, 2, 29, 21, 13, 26, 984, DateTimeKind.Local).AddTicks(5098), new DateTime(2024, 2, 29, 21, 13, 26, 984, DateTimeKind.Local).AddTicks(5091), "$2a$11$UmWeNxsSufZRpZOEbhfdIugOb5VDQ0rT4BxATQpiy1kvW.GTIS3GO" });
        //}
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            base.Down(migrationBuilder);
        }

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //throw new NotImplementedException();
        }
    }
}
