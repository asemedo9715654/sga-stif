﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class AdicaoDaTabelaPerfilInstituicaoFinanceira : Migration
    {
        //protected override void Up(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.RenameColumn(
        //        name: "IdSocio",
        //        table: "RakingSocioResultado",
        //        newName: "TopR");

        //    migrationBuilder.AlterColumn<double>(
        //        name: "TotalMontantePago",
        //        table: "RakingSocioResultado",
        //        type: "float",
        //        nullable: false,
        //        oldClrType: typeof(decimal),
        //        oldType: "decimal(18,2)");

        //    migrationBuilder.AddColumn<string>(
        //        name: "Posicao",
        //        table: "RakingSocioResultado",
        //        type: "nvarchar(max)",
        //        nullable: false,
        //        defaultValue: "");

        //    migrationBuilder.CreateTable(
        //        name: "PerfilInstituicaoFinanceira",
        //        columns: table => new
        //        {
        //            IdPerfilInstituicaoFinanceira = table.Column<int>(type: "int", nullable: false)
        //                .Annotation("SqlServer:Identity", "1, 1"),
        //            IdPPerfil = table.Column<int>(type: "int", nullable: false),
        //            IdInstituicaoFinanceira = table.Column<int>(type: "int", nullable: false),
        //            Permitido = table.Column<bool>(type: "bit", nullable: false),
        //            PerfilIdPerfil = table.Column<int>(type: "int", nullable: true),
        //            DataCriacao = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            DataAtualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
        //            Eliminado = table.Column<bool>(type: "bit", nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_PerfilInstituicaoFinanceira", x => x.IdPerfilInstituicaoFinanceira);
        //            table.ForeignKey(
        //                name: "FK_PerfilInstituicaoFinanceira_Perfil_PerfilIdPerfil",
        //                column: x => x.PerfilIdPerfil,
        //                principalTable: "Perfil",
        //                principalColumn: "IdPerfil");
        //        });

        //    migrationBuilder.UpdateData(
        //        table: "Acao",
        //        keyColumn: "IdAcao",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8348), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8340) });

        //    migrationBuilder.UpdateData(
        //        table: "Acao",
        //        keyColumn: "IdAcao",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8355), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8354) });

        //    migrationBuilder.UpdateData(
        //        table: "Acao",
        //        keyColumn: "IdAcao",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8356), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8356) });

        //    migrationBuilder.UpdateData(
        //        table: "Acao",
        //        keyColumn: "IdAcao",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8357), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8357) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(169), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(169) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(173), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(172) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(174), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(174) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(176), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(175) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(177), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(176) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(178), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(178) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(179), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(179) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(181), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(180) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(182), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(182) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(183), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(183) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(185), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(184) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 12,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(186), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(185) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 13,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(187), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(187) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 14,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(188), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(188) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 15,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(190), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(189) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 16,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(191), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(190) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 17,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(192), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(192) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 18,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(193), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(193) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 19,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(195), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(194) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 20,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(221), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(220) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 21,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(223), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(222) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 22,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(224), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(223) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 23,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(225), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(225) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 24,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(226), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(226) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 25,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(228), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(227) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 26,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(229), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(228) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 27,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(230), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(229) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 28,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(231), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(231) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 29,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(232), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(232) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 30,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(233), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(233) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 31,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(235), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(234) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 32,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(236), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(235) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 33,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(237), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(237) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 34,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(238), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(238) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 35,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(239), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(239) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 36,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(241), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(240) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 37,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(242), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(241) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 38,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(243), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(243) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 39,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(244), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(244) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 40,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(245), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(245) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 41,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(246), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(246) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 42,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(248), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(247) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 43,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(249), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(248) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 44,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(250), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(250) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 45,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(251), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(251) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 46,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(252), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(252) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 47,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(254), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(253) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 48,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(255), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(254) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 49,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(256), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(256) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 50,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(257), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(257) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 51,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(258), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(258) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 52,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(260), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(259) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 53,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(261), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(260) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 54,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(262), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(261) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 55,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(263), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(263) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 56,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(264), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(264) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 57,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(265), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(265) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 58,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(267), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(266) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 59,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(268), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(268) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 60,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(269), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(269) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 61,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(270), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(270) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 62,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(271), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(271) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 63,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(273), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(272) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 64,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(274), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(273) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 65,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(275), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(275) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 66,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(276), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(276) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 67,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(277), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(277) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 68,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(279), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(278) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 69,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(280), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(280) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 70,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(281), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(281) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 71,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(304), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(303) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 72,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(306), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(305) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 73,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(307), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(306) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 74,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(308), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(308) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 75,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(309), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(309) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 76,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(310), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(310) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 77,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(312), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(311) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 78,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(313), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(312) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 79,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(314), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(314) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 80,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(318), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(317) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 81,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(319), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(318) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 82,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(320), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(319) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 83,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(321), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(321) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 84,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(322), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(322) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 85,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(324), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(323) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 86,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(325), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(324) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 87,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(326), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(326) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 88,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(327), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(327) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 89,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(328), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(328) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 90,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(330), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(329) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 91,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(331), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(330) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 92,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(332), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(331) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 93,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(333), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(333) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 94,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(334), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(334) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 95,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(335), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(335) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 96,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(337), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(336) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 97,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(338), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(337) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 98,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(339), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(339) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 99,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(340), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(340) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 100,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(341), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(341) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 101,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(343), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(342) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 102,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(344), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(343) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 103,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(345), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(345) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 104,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(346), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(346) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 105,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(347), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(347) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 106,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(349), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(348) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 107,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(351), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(351) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 108,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(353), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(352) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 109,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(354), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(353) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 110,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(355), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(355) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 111,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(356), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(356) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 112,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(357), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(357) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 113,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(359), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(358) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 114,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(360), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(359) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 115,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(361), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(361) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 116,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(362), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(362) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 117,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(363), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(363) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 118,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(365), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(364) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 119,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(366), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(365) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 120,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(367), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(366) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 121,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(368), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(368) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 122,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(392), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(391) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 123,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(393), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(393) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 124,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(394), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(394) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(71), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(70) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(74), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(73) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(75), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(75) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(76), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(76) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(78), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(77) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(79), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(78) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(80), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(80) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(81), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(81) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(82), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(82) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(83), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(83) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(85), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(84) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 12,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(86), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(85) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 13,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(87), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(86) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 14,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(88), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(88) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 15,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(89), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(89) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 16,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(90), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(90) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 17,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(125), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(123) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 18,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(126), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(126) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(47), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(47) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(50), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(50) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(52), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(51) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(53), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(52) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(54), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(54) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(55), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(55) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(57), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(56) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(58), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(57) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(59), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(58) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(60), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(60) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(150), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(150) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(153), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(153) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(155), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(155) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(157), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(156) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(158), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(157) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(159), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(159) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(160), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(160) });

        //    migrationBuilder.UpdateData(
        //        table: "Joia",
        //        keyColumn: "IdJoia",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "DataInicio" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8465), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8464), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8473) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8484), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8483) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8494), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8494) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8496), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8496) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8498), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8497) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8499), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8499) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8502), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8501) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8503), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8503) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8504), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8504) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8506), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8506) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8508), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8507) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8509), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8509) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 12,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8510), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8510) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 13,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8512), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8511) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 14,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8513), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8513) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 15,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8515), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8514) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 16,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8516), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8516) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 17,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8636), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8636) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 18,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8639), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8638) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 19,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8640), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8640) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8686), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8685) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8691), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8690) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8692), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8692) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8693), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8693) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8695), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8694) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8696), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8696) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8698), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8697) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8699), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8698) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8700), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8699) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8702), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8701) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8703), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8702) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 12,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8704), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8704) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 13,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8705), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8705) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 14,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8706), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8706) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 15,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8707), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8707) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 16,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8709), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8708) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 17,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8710), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8709) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 18,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8712), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8711) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 19,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8713), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8712) });

        //    migrationBuilder.UpdateData(
        //        table: "Perfil",
        //        keyColumn: "IdPerfil",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(137), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(136) });

        //    migrationBuilder.UpdateData(
        //        table: "Perfil",
        //        keyColumn: "IdPerfil",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(141), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(140) });

        //    migrationBuilder.UpdateData(
        //        table: "Perfil",
        //        keyColumn: "IdPerfil",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(143), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(142) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8744), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8743) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8747), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8747) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8749), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8748) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8750), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8750) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8751), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8751) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8752), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8752) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8753), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8753) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8755), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8754) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8756), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8755) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8757), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8757) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8758), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8758) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 12,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8760), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8759) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 13,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8761), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8760) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 14,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8762), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8762) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 15,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8763), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8763) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 16,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8764), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8764) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 17,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8765), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8765) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 18,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8767), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8767) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 19,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8800), new DateTime(2023, 10, 2, 0, 12, 45, 915, DateTimeKind.Local).AddTicks(8799) });

        //    migrationBuilder.UpdateData(
        //        table: "TipoQuota",
        //        keyColumn: "IdTipoQuota",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(28), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(27) });

        //    migrationBuilder.UpdateData(
        //        table: "TipoQuota",
        //        keyColumn: "IdTipoQuota",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(31), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(30) });

        //    migrationBuilder.UpdateData(
        //        table: "TipoQuota",
        //        keyColumn: "IdTipoQuota",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(33), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(32) });

        //    migrationBuilder.UpdateData(
        //        table: "TipoQuota",
        //        keyColumn: "IdTipoQuota",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(35), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(34) });

        //    migrationBuilder.UpdateData(
        //        table: "TipoQuota",
        //        keyColumn: "IdTipoQuota",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(36), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(36) });

        //    migrationBuilder.UpdateData(
        //        table: "TipologiaSocio",
        //        keyColumn: "IdTipologiaSocio",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 48, DateTimeKind.Local).AddTicks(9912), new DateTime(2023, 10, 2, 0, 12, 45, 48, DateTimeKind.Local).AddTicks(9898), new DateTime(2023, 10, 2, 0, 12, 45, 48, DateTimeKind.Local).AddTicks(9917), new DateTime(2023, 10, 2, 0, 12, 45, 48, DateTimeKind.Local).AddTicks(9917) });

        //    migrationBuilder.UpdateData(
        //        table: "TipologiaSocio",
        //        keyColumn: "IdTipologiaSocio",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 48, DateTimeKind.Local).AddTicks(9919), new DateTime(2023, 10, 2, 0, 12, 45, 48, DateTimeKind.Local).AddTicks(9918), new DateTime(2023, 10, 2, 0, 12, 45, 48, DateTimeKind.Local).AddTicks(9920), new DateTime(2023, 10, 2, 0, 12, 45, 48, DateTimeKind.Local).AddTicks(9920) });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(418), new DateTime(2023, 10, 2, 0, 12, 45, 49, DateTimeKind.Local).AddTicks(418), "$2a$11$BcfGdIjpjnHH6jJkyRyF6eHchvEsC.T8LshB.jAohP5lZehNjHnbG" });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 191, DateTimeKind.Local).AddTicks(1031), new DateTime(2023, 10, 2, 0, 12, 45, 191, DateTimeKind.Local).AddTicks(1025), "$2a$11$NbuZ7ixyb0lyQ9CUOa30V.LVq2QS56SQYcezwQkwe1M20gKv5NsW2" });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 335, DateTimeKind.Local).AddTicks(7928), new DateTime(2023, 10, 2, 0, 12, 45, 335, DateTimeKind.Local).AddTicks(7925), "$2a$11$ct8iAB4FUEEx2k7H7/cNp.USQdVnNuzX2FYZ4.jPIaSYbpSVSkq8." });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 484, DateTimeKind.Local).AddTicks(6550), new DateTime(2023, 10, 2, 0, 12, 45, 484, DateTimeKind.Local).AddTicks(6546), "$2a$11$QFfV1SXBDlZFqc/FPxKatueCydWyuBfAZ7ezdbdLC//3qqTkdghqi" });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 631, DateTimeKind.Local).AddTicks(3622), new DateTime(2023, 10, 2, 0, 12, 45, 631, DateTimeKind.Local).AddTicks(3615), "$2a$11$TxIBEk1HmksB4OfCwUq0beALDLWRaPJpAXD5aovP458xnu9lNOAjm" });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2023, 10, 2, 0, 12, 45, 778, DateTimeKind.Local).AddTicks(3304), new DateTime(2023, 10, 2, 0, 12, 45, 778, DateTimeKind.Local).AddTicks(3300), "$2a$11$SQUcMoJA1KHLumVQi2OLkOI.UypQFsMfVlI5Qw2ic5Er62QKK3DAy" });

        //    migrationBuilder.CreateIndex(
        //        name: "IX_PerfilInstituicaoFinanceira_PerfilIdPerfil",
        //        table: "PerfilInstituicaoFinanceira",
        //        column: "PerfilIdPerfil");
        //}

        //protected override void Down(MigrationBuilder migrationBuilder)
        //{
        //    migrationBuilder.DropTable(
        //        name: "PerfilInstituicaoFinanceira");

        //    migrationBuilder.DropColumn(
        //        name: "Posicao",
        //        table: "RakingSocioResultado");

        //    migrationBuilder.RenameColumn(
        //        name: "TopR",
        //        table: "RakingSocioResultado",
        //        newName: "IdSocio");

        //    migrationBuilder.AlterColumn<decimal>(
        //        name: "TotalMontantePago",
        //        table: "RakingSocioResultado",
        //        type: "decimal(18,2)",
        //        nullable: false,
        //        oldClrType: typeof(double),
        //        oldType: "float");

        //    migrationBuilder.UpdateData(
        //        table: "Acao",
        //        keyColumn: "IdAcao",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6090), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6080) });

        //    migrationBuilder.UpdateData(
        //        table: "Acao",
        //        keyColumn: "IdAcao",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6100), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6100) });

        //    migrationBuilder.UpdateData(
        //        table: "Acao",
        //        keyColumn: "IdAcao",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6100), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6100) });

        //    migrationBuilder.UpdateData(
        //        table: "Acao",
        //        keyColumn: "IdAcao",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6100), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6100) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8610) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8610) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8620) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8620) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8620) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8630) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8630) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8630) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8640) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8640) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8640) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 12,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8650), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8650) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 13,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8650), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8650) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 14,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8650), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8650) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 15,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8660), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8660) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 16,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8660), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8660) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 17,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8660), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8660) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 18,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8670), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8660) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 19,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8670), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8670) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 20,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8670), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8670) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 21,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8670), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8670) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 22,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8680), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8680) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 23,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8690), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8690) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 24,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8690), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8690) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 25,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8690) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 26,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8700) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 27,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8700) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 28,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8700) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 29,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8710), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8710) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 30,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8710), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8710) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 31,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8710), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8710) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 32,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8720) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 33,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8720) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 34,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8730) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 35,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8730) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 36,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8730) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 37,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8740) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 38,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8740) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 39,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8740) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 40,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8750) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 41,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8750) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 42,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8750) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 43,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8750) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 44,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8760) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 45,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8760) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 46,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8760) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 47,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8770), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8770) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 48,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8770), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8770) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 49,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8770), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8770) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 50,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8780), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8780) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 51,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8780), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8780) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 52,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8780), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8780) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 53,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8790), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8780) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 54,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8790), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8790) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 55,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8790), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8790) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 56,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8790), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8790) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 57,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8800), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8800) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 58,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8800), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8800) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 59,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8810), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8810) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 60,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8810), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8810) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 61,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8810), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8810) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 62,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8820), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8820) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 63,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8820), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8820) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 64,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8820), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8820) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 65,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8820) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 66,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8830) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 67,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8830) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 68,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8830) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 69,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8840), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8840) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 70,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8840), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8840) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 71,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8840), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8840) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 72,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8850), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8840) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 73,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8850), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8850) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 74,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8860), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8860) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 75,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8860), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8860) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 76,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8860), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8860) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 77,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8870), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8870) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 78,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8870), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8870) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 79,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8870), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8870) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 80,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8870) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 81,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8880) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 82,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8880) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 83,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8880) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 84,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8890), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8890) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 85,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8890), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8890) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 86,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8900), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8900) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 87,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8900), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8900) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 88,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8900), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8900) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 89,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8910), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8900) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 90,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8910), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8910) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 91,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8910), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8910) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 92,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8920), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8910) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 93,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8920), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8920) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 94,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8920), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8920) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 95,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8920), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8920) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 96,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8930), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8930) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 97,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8930), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8930) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 98,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8930), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8930) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 99,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8940), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8940) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 100,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8940), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8940) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 101,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8940), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8940) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 102,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8940) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 103,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8950) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 104,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8950) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 105,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8950) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 106,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8960), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8960) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 107,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8960), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8960) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 108,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8960), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8960) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 109,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8970), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8970) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 110,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8970), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8970) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 111,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8970), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8970) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 112,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8970) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 113,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8980) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 114,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8980) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 115,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8980), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8980) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 116,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8990), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8990) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 117,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8990), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8990) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 118,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8990), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8990) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 119,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9000), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9000) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 120,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9000), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9000) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 121,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9000), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9000) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 122,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9000) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 123,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9010) });

        //    migrationBuilder.UpdateData(
        //        table: "Agencia",
        //        keyColumn: "IdAgencia",
        //        keyValue: 124,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9010) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8440), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8440) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8450), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8440) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8450), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8450) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8450), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8450) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8450), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8450) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8460), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8460) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8460), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8460) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8460), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8460) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8470), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8470) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8470), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8470) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8470) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 12,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8480) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 13,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8480) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 14,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8480) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 15,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8490) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 16,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8490) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 17,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8500), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8500) });

        //    migrationBuilder.UpdateData(
        //        table: "Cidade",
        //        keyColumn: "IdCidade",
        //        keyValue: 18,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8500), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8500) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8380), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8380) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8390), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8390) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8390), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8390) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8400), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8400) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8400), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8400) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8400), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8400) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8410), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8400) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8410), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8410) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8410), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8410) });

        //    migrationBuilder.UpdateData(
        //        table: "Ilha",
        //        keyColumn: "IdIlha",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8410), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8410) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8560), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8560) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8570), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8570) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8570), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8570) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8580), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8570) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8580), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8580) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8580), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8580) });

        //    migrationBuilder.UpdateData(
        //        table: "InstituicaoFinanceira",
        //        keyColumn: "IdInstituicaoFinanceira",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8580), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8580) });

        //    migrationBuilder.UpdateData(
        //        table: "Joia",
        //        keyColumn: "IdJoia",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "DataInicio" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6230), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6230), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6230) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6270), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6260) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6290), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6290) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6290), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6290) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6300), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6300) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6300), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6300) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6310), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6300) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6310), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6310) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6310), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6310) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6320), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6310) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6320), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6320) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6320), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6320) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 12,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6330), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6330) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 13,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6330), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6330) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 14,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6330), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6330) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 15,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6340), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6340) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 16,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6340), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6340) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 17,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6340), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6340) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 18,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6350), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6350) });

        //    migrationBuilder.UpdateData(
        //        table: "Menu",
        //        keyColumn: "IdMenu",
        //        keyValue: 19,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6390), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6390) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6540), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6540) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6550), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6550) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6560), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6560) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6560), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6560) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6560), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6560) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6570), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6570) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6570), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6570) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6570), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6570) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6580), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6570) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6580), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6580) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6580), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6580) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 12,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6590), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6580) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 13,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6590), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6590) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 14,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6590), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6590) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 15,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6590), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6590) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 16,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6600), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6600) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 17,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6600), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6600) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 18,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6600), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6600) });

        //    migrationBuilder.UpdateData(
        //        table: "MenuAcao",
        //        keyColumn: "IdMenuAcao",
        //        keyValue: 19,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6610), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6610) });

        //    migrationBuilder.UpdateData(
        //        table: "Perfil",
        //        keyColumn: "IdPerfil",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8540), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8530) });

        //    migrationBuilder.UpdateData(
        //        table: "Perfil",
        //        keyColumn: "IdPerfil",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8540), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8540) });

        //    migrationBuilder.UpdateData(
        //        table: "Perfil",
        //        keyColumn: "IdPerfil",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8540), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8540) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6660), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6660) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6670), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6670) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6670), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6670) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6670), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6670) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6680), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6670) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6680), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6680) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 7,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6680), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6680) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 8,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6690), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6680) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 9,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6690), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6690) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 10,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6690), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6690) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 11,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6690), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6690) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 12,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6700), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6700) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 13,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6700), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6700) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 14,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6700), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6700) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 15,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6710), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6700) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 16,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6710), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6710) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 17,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6710), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6710) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 18,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6710), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6710) });

        //    migrationBuilder.UpdateData(
        //        table: "PerfilMenuAcao",
        //        keyColumn: "IdPerfilMenuAcao",
        //        keyValue: 19,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6720), new DateTime(2022, 7, 25, 23, 29, 51, 361, DateTimeKind.Local).AddTicks(6720) });

        //    migrationBuilder.UpdateData(
        //        table: "TipoQuota",
        //        keyColumn: "IdTipoQuota",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8340), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8330) });

        //    migrationBuilder.UpdateData(
        //        table: "TipoQuota",
        //        keyColumn: "IdTipoQuota",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8340), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8340) });

        //    migrationBuilder.UpdateData(
        //        table: "TipoQuota",
        //        keyColumn: "IdTipoQuota",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8350), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8340) });

        //    migrationBuilder.UpdateData(
        //        table: "TipoQuota",
        //        keyColumn: "IdTipoQuota",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8350), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8350) });

        //    migrationBuilder.UpdateData(
        //        table: "TipoQuota",
        //        keyColumn: "IdTipoQuota",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8350), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8350) });

        //    migrationBuilder.UpdateData(
        //        table: "TipologiaSocio",
        //        keyColumn: "IdTipologiaSocio",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8110), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8080), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8120), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8120) });

        //    migrationBuilder.UpdateData(
        //        table: "TipologiaSocio",
        //        keyColumn: "IdTipologiaSocio",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8130), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8130), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8130), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(8130) });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 1,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9070), new DateTime(2022, 7, 25, 23, 29, 50, 241, DateTimeKind.Local).AddTicks(9070), "$2a$11$0LFPOKsE8YD2zNZInVBvGOKMhaVOKJuoqde4rPxgF3Pwor5Gve1vC" });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 2,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 428, DateTimeKind.Local).AddTicks(2680), new DateTime(2022, 7, 25, 23, 29, 50, 428, DateTimeKind.Local).AddTicks(2660), "$2a$11$OH3StGw0PZBrw6tIPjH5DefMSnGXPOFwYkNmkGQtEDxe3qkvgNSsm" });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 3,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 615, DateTimeKind.Local).AddTicks(3730), new DateTime(2022, 7, 25, 23, 29, 50, 615, DateTimeKind.Local).AddTicks(3710), "$2a$11$3Rd/lVrXY8cMu76N5aBueebHWUTclPmBznivwk4wyjDuVn1dWyOtu" });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 4,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 803, DateTimeKind.Local).AddTicks(2840), new DateTime(2022, 7, 25, 23, 29, 50, 803, DateTimeKind.Local).AddTicks(2820), "$2a$11$n.IObooIf1XjK8X5RkRRSuxFdtPMfmO9RkqSYEhvmQX3PTzaR2mB2" });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 5,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 50, 990, DateTimeKind.Local).AddTicks(3660), new DateTime(2022, 7, 25, 23, 29, 50, 990, DateTimeKind.Local).AddTicks(3650), "$2a$11$WmjqQsWvQYEdzAdJRzKmX.F.0ioq/wrRrrNnwf9kpUp6Z3./TrGE6" });

        //    migrationBuilder.UpdateData(
        //        table: "Utilizador",
        //        keyColumn: "IdUtilizador",
        //        keyValue: 6,
        //        columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
        //        values: new object[] { new DateTime(2022, 7, 25, 23, 29, 51, 175, DateTimeKind.Local).AddTicks(5720), new DateTime(2022, 7, 25, 23, 29, 51, 175, DateTimeKind.Local).AddTicks(5710), "$2a$11$zL9iJkj5XGe.qXNM/HtHueReSWgwSnGmeYI432tD7aTmYPW2hb5lq" });
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
