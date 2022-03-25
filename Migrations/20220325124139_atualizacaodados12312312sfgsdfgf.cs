using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class atualizacaodados12312312sfgsdfgf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(44), new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(27) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(56), new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(60), new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(59) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3371), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3370), 1, 2, "Ag. Fazenda" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 2, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3375), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3374), false, 1, 2, "Ag. Mindelo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 3, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3377), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3376), false, 1, 2, "Ag. ASA" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 4, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3379), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3378), false, 1, 2, "Ag. Assomada" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 5, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3381), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3380), false, 1, 2, "Ag. Espargos" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 6, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3383), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3382), false, 1, 2, "Ag. Rª Grande" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 7, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3385), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3384), false, 1, 2, "Ag. St. Maria" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 8, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3387), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3386), false, 1, 2, "Ag. Plateau" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 9, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3388), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3388), false, 1, 2, "Ag. Monte Sossego" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 10, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3390), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3390), false, 1, 2, "Ag. Palmarejo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 11, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3392), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3392), false, 1, 2, "Ag. São Filipe" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 12, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3394), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3394), false, 1, 2, "Ag. Calheta S. Miguel" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 13, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3396), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3396), false, 1, 2, "Ag. Aeroporto da Praia" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 14, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3398), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3397), false, 1, 2, "Ag. Boavista" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 15, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3400), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3399), false, 1, 2, "Ag. Aeroporto do Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 16, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3403), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3402), false, 1, 2, "Ag. Sucupira" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 17, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3404), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3404), false, 1, 2, "Ag. CCV – São Domingos" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 18, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3406), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3406), false, 1, 2, "Ag. Tarrafal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 19, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3408), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3407), false, 1, 2, "Ag. Santa Cruz" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 20, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3410), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3409), false, 1, 2, "Ag. CCV – Porto Novo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 21, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3412), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3411), false, 1, 2, "Ag. CCV - Plateau" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 22, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3414), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3413), false, 1, 2, "Ag. A. São Filipe" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 23, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3416), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3415), false, 1, 2, "Ag. Mosteiros" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 24, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3418), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3417), false, 1, 2, "Ag. Caixa Empresas" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 25, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3419), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3419), false, 1, 2, "Ag. Coculi" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 26, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3421), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3421), false, 1, 2, "Ag. Paul" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 27, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3423), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3423), false, 1, 2, "Ag. Fonte Cónego" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 28, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3425), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3424), false, 1, 2, "Ag. Aeroporto Boavista" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 29, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3427), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3426), false, 1, 2, "Ag. Maio" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 30, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3429), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3428), false, 1, 2, "Ag. Porto Novo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 31, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3431), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3430), false, 1, 2, "Ag. Ribeira Brava" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 32, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3432), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3432), false, 1, 2, "Ag. Ribeira Brava" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 33, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3434), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3434), false, 1, 2, "Ag. Tarrafal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 34, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3436), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3436), false, 1, 3, "Ag. Praia" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 35, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3438), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3437), false, 1, 3, "Ag. S. Vicente " });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 36, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3440), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3439), false, 1, 3, "Ag. Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 37, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3442), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3441), false, 1, 3, "Ag. S. Filipe" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 38, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3444), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3443), false, 1, 3, "Ag. Tarrafal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 39, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3445), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3445), false, 1, 3, "Ag. S. Catarina" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 40, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3447), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3447), false, 1, 3, "Ag. Porto Novo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 41, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3449), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3449), false, 1, 3, "Ag. Rª Grande" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 42, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3452), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3451), false, 1, 3, "Ag. Brava" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 43, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3454), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3453), false, 1, 3, "Ag. Boavista" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 44, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3456), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3455), false, 1, 3, "Ag. S. Nicolau" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 45, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3487), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3486), false, 1, 3, "Ag. Maio" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 46, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3489), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3489), false, 1, 3, "Ag. Santa Cruz" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 47, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3491), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3490), false, 1, 3, "Ag. Praça Nova" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 48, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3493), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3492), false, 1, 3, "Ag. ASA" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 49, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3495), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3494), false, 1, 3, "Ag. Avenida" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 50, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3497), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3496), false, 1, 3, "Ag. Monte Sossego" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 51, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3499), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3498), false, 1, 3, "Ag. Fonte Filipe" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 52, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3500), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3500), false, 1, 3, "Ag. Santa Maria" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 53, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3502), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3502), false, 1, 3, "Ag. Mosteiros" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 54, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3504), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3503), false, 1, 3, "Ag. Tarrafal S. Nicolau" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 55, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3506), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3505), false, 1, 3, "Ag. ASA II" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 56, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3508), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3507), false, 1, 3, "Gabinete Empresas Sul" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 57, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3510), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3509), false, 1, 3, "Gabinete Empresas Norte" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 58, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3511), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3511), false, 1, 3, "Ag. S. Domingos" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 59, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3513), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3513), false, 1, 3, "Ag. Palmarejo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 60, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3515), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3515), false, 1, 3, "Gabinete Empresas Sul II" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 61, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3517), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3517), false, 1, 3, "Gabinete Empresas Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 62, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3519), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3519), false, 1, 3, "Prol. Ach. São Filipe" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 63, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3521), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3520), false, 1, 4, "Ag. Praia" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 64, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3523), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3522), false, 1, 4, "Ag. Mindelo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 65, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3525), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3524), false, 1, 4, "Ag. Assomada" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 66, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3527), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3526), false, 1, 4, "Ag. Aeroporto do Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 67, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3528), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3528), false, 1, 4, "Ag. Boavista" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 68, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3531), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3531), false, 1, 4, "Ag. Porto Novo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 69, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3533), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3533), false, 1, 4, "Ag. Terra Branca" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 70, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3535), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3534), false, 1, 4, "Ag. Palmarejo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 71, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3537), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3536), false, 1, 4, "Ag. Monte Sossego" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 72, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3539), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3538), false, 1, 4, "Ag. Santa Maria" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 73, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3541), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3540), false, 1, 4, "Ag. São Filipe" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 74, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3543), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3542), false, 1, 4, "Ag. Rª Grande" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 75, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3544), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3544), false, 1, 4, "ASA – Private Banking" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 76, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3546), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3546), false, 1, 4, "Ag. Fazenda" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 77, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3548), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3547), false, 1, 4, "Ag. Órgãos" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 78, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3550), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3549), false, 1, 4, "Ag. Santa Cruz" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 79, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3552), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3551), false, 1, 4, "Ag. Ponta do Sol" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 80, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3554), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3553), false, 1, 4, "Ag. Maio" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 81, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3556), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3555), false, 1, 4, "Centro de empresas" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 82, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3558), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3557), false, 1, 4, "Centro de empresas II" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 83, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3560), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3559), false, 1, 4, "Ag. Sede" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 84, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3562), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3561), false, 1, 4, "Núcleo N/ Residentes" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 85, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3564), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3563), false, 1, 5, "Ag. Sede" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 86, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3566), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3565), false, 1, 5, "Ag. ASA" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 87, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3567), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3567), false, 1, 5, "Ag. Mindelo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 88, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3569), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3569), false, 1, 5, "Ag. Plateau" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 89, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3571), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3570), false, 1, 5, "Ag. Espargos" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 90, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3573), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3572), false, 1, 5, "Ag. Santa Maria" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 91, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3575), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3574), false, 1, 5, "ag. Sal Rei – Boavista" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 92, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3578), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3577), false, 1, 5, "Ag. Assomada" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 93, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3579), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3579), false, 1, 5, "Ag. Achada Grande Trás" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 94, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3582), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3582), false, 1, 5, "Gab. Particulares (Praia)" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 95, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3584), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3583), false, 1, 5, "Gab. Empresas (Praia)" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 96, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3659), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3658), false, 1, 8, "Ag. Sede" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 97, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3661), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3661), false, 1, 8, "Ag. Plateau" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 98, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3663), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3663), false, 1, 8, "Ag ASA" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 99, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3665), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3665), false, 1, 8, "Ag. Mindelo" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 100, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3668), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3667), false, 1, 8, "Ag. Espargos" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 101, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3670), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3669), false, 1, 9, "Ag. Sede" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 102, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3672), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3671), false, 1, 9, "Serviços Centrais" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 103, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3675), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3674), false, 1, 9, "Emigrantes" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 104, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3677), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3676), false, 1, 9, "Particulares Classic" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 105, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3679), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3678), false, 1, 9, "Afluentes" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 106, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3681), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3680), false, 1, 9, "Private" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 107, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3683), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3682), false, 1, 9, "Institucionais" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 108, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3685), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3685), false, 1, 9, "PME Nacionais" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 109, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3687), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3687), false, 1, 9, "Grandes Empresas Nacionais" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 110, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3689), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3688), false, 1, 9, "Corporate Internacional" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 111, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3693), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3692), false, 1, 9, "Ag. Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 112, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3695), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3694), false, 1, 9, "Emigrantes Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 113, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3696), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3696), false, 1, 9, "Particulares Classic Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 114, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3698), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3698), false, 1, 9, "Afluentes Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 115, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3700), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3700), false, 1, 9, "Private Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 116, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3702), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3701), false, 1, 9, "Institucionais Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 117, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3704), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3703), false, 1, 9, "PME Nacionais Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 118, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3706), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3705), false, 1, 9, "Grandes Empresas Nacionais Sal" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 119, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3708), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3707), false, 1, 11, "Ag. Sede - Praia" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 120, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3710), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3710), false, 1, 8, "Ag. Assomada" });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 121, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3712), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3712), false, 1, 8, "Ag. Sta Maria " });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 122, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3714), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3713), false, 1, 8, "Agencia Sal-Rei " });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 123, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3716), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3715), false, 1, 8, "Agencia S.Filipe " });

            migrationBuilder.InsertData(
                table: "Agencia",
                columns: new[] { "IdAgencia", "DataAtualizacao", "DataCriacao", "Eliminado", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { 124, new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3718), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3717), false, 1, 8, "Ag. Montsu " });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3223), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3227), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3229), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3231), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3233), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3235), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3234) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3236), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3238), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3240), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3242), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3244), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3246), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3247), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3249), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3251), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3254), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3255), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3257), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3176), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3179), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3182), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3181) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3184), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3186), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3191), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3194), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3196), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3195) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3197), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3197) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3199), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3307), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3310), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3311), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3313), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3315), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3317), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3319), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(159), new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(166), new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(165) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(171), new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(174), new DateTime(2022, 3, 25, 11, 41, 38, 383, DateTimeKind.Local).AddTicks(173) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3287), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3290), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3086), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3081) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3103), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3105), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3111), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3149), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(2870), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(2850), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(2880), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(2880) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(2883), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(2882), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(2889), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(4142), new DateTime(2022, 3, 25, 11, 41, 36, 993, DateTimeKind.Local).AddTicks(4141), "$2a$11$6p8hOUGmBYzbGNQKWNPvyO2eT.5OK4bPUOw9gAMkoy.wmdOO08/f2" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 37, 327, DateTimeKind.Local).AddTicks(8607), new DateTime(2022, 3, 25, 11, 41, 37, 327, DateTimeKind.Local).AddTicks(8590), "$2a$11$ftbGhP35UI7.eTGFjSB4g.qBwbry/1IkPzH2QjGtZkzzYODd/1Rfi" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 37, 659, DateTimeKind.Local).AddTicks(5610), new DateTime(2022, 3, 25, 11, 41, 37, 659, DateTimeKind.Local).AddTicks(5590), "$2a$11$wvxfpnwD7uEKhAwa8es/ZuVmSC42bdglKN0Sf0QAFspRExqCPlqKO" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 41, 38, 9, DateTimeKind.Local).AddTicks(1412), new DateTime(2022, 3, 25, 11, 41, 38, 9, DateTimeKind.Local).AddTicks(1393), "$2a$11$D8gqd3VfALSM4nARwyvO2eTh9R31fYMX7xCmEUMXznt9zzaPTT9V2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124);

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 2, 916, DateTimeKind.Local).AddTicks(3308), new DateTime(2022, 3, 25, 11, 6, 2, 916, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 2, 916, DateTimeKind.Local).AddTicks(3317), new DateTime(2022, 3, 25, 11, 6, 2, 916, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 2, 916, DateTimeKind.Local).AddTicks(3319), new DateTime(2022, 3, 25, 11, 6, 2, 916, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "IdCidade", "IdInstituicaoFinanceira", "Nome" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8238), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8237), 8, 1, "BCA" });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7936), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7943), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7947), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7950), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7954), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7957), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7960), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7959) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7964), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7967), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7971), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7974), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7973) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7977), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7981), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7984), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8077), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8081), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8085), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8089), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8088) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7867), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7872), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7876), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7879), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7882), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7881) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7886), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7889), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7892), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7895), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7898), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8180), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8185), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8189), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8192), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8195), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8199), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8202), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 2, 916, DateTimeKind.Local).AddTicks(3378), new DateTime(2022, 3, 25, 11, 6, 2, 916, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 2, 916, DateTimeKind.Local).AddTicks(3383), new DateTime(2022, 3, 25, 11, 6, 2, 916, DateTimeKind.Local).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 2, 916, DateTimeKind.Local).AddTicks(3386), new DateTime(2022, 3, 25, 11, 6, 2, 916, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 2, 916, DateTimeKind.Local).AddTicks(3389), new DateTime(2022, 3, 25, 11, 6, 2, 916, DateTimeKind.Local).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8142), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8148), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7785), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7812), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7816), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7825), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7829), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7827) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7461), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7440), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7471), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7476), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7475), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7484), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(7486) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8275), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8274), "$2a$11$7iUTMa8lY62GaiJ8rP8l.ediPwEV0jY8hL/VoPRwF1Zkch1T1Dg2K" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 2, 17, DateTimeKind.Local).AddTicks(8322), new DateTime(2022, 3, 25, 11, 6, 2, 17, DateTimeKind.Local).AddTicks(8301), "$2a$11$x07EDy26DyIjJKbpFGNMK.TlSXygNIITe/z5STsJXiitKQ/nGGM5S" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 2, 351, DateTimeKind.Local).AddTicks(1748), new DateTime(2022, 3, 25, 11, 6, 2, 351, DateTimeKind.Local).AddTicks(1729), "$2a$11$Ms6NU2yPp9NCOMPTxWAuieMRaqbl.PmlKqaYOHVO8.dxjExGv0d0K" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 2, 641, DateTimeKind.Local).AddTicks(6713), new DateTime(2022, 3, 25, 11, 6, 2, 641, DateTimeKind.Local).AddTicks(6703), "$2a$11$WTgWJ/UhpD/EiCDZ1WF5veuFy9FXI7hz4rvHLtga1YLio3KhRHgV." });
        }
    }
}
