using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class atualizacaodados123123123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 1);

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
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8238), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8237) });

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

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 2, new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8180), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8179), false, "Caixa Económica de Cabo Verde" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 3, new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8185), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8184), false, "Banco Comercial do Atlântico" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 4, new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8189), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8188), false, "Banco Caboverdiano de Negócios" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 5, new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8192), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8191), false, "Banco Interatlântico" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 8, new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8195), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8194), false, "Banco Angolano de Investimentos" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 9, new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8199), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8198), false, "International Investment Bank" });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 11, new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8202), new DateTime(2022, 3, 25, 11, 6, 1, 695, DateTimeKind.Local).AddTicks(8201), false, "Ecobank Cabo Verde SA" });

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

            migrationBuilder.InsertData(
                table: "Utilizador",
                columns: new[] { "IdUtilizador", "Apelido", "DataAtualizacao", "DataCriacao", "Eliminado", "Email", "Foto", "IdPerfil", "Nome", "NomeUtilizador", "PalavraPasse" },
                values: new object[] { 4, "Tavares", new DateTime(2022, 3, 25, 11, 6, 2, 641, DateTimeKind.Local).AddTicks(6713), new DateTime(2022, 3, 25, 11, 6, 2, 641, DateTimeKind.Local).AddTicks(6703), false, "jair@sgastif.cv", null, 1, "Jair", "jair", "$2a$11$WTgWJ/UhpD/EiCDZ1WF5veuFy9FXI7hz4rvHLtga1YLio3KhRHgV." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1880), new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1890), new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1890), new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8740), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8580), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8580), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8590), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8590), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8590) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8600), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8600), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8600), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8600) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8610), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8610) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8620), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8620) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8630), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8630) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8640), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8520), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8520), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8520) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8530), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8530), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8530), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8530) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8540), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8540), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8540), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8540) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8550), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8550), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8550) });

            migrationBuilder.InsertData(
                table: "InstituicaoFinanceira",
                columns: new[] { "IdInstituicaoFinanceira", "DataAtualizacao", "DataCriacao", "Eliminado", "Nome" },
                values: new object[] { 1, new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8700), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8700), false, "BCA" });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1940), new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1940), new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1950), new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1950), new DateTime(2022, 3, 24, 19, 24, 46, 558, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8680), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8680), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8430), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8440), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8480), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8220), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8180), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8230), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8240), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8240), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8240), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8760), new DateTime(2022, 3, 24, 19, 24, 45, 983, DateTimeKind.Local).AddTicks(8760), "$2a$11$br5lE2IOlP/P9RyIO0PYkev/jpa2xzJoW.KZLHVvJPXskzqnHHu62" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 46, 170, DateTimeKind.Local).AddTicks(30), new DateTime(2022, 3, 24, 19, 24, 46, 170, DateTimeKind.Local), "$2a$11$dQilmQZfGvY3PMGN4hIhsOZs1C9OLi167JpAtu1n0uFSONchSUlgC" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 24, 19, 24, 46, 353, DateTimeKind.Local).AddTicks(3880), new DateTime(2022, 3, 24, 19, 24, 46, 353, DateTimeKind.Local).AddTicks(3850), "$2a$11$jY3uk1RoLV0cLMVMbPT9Uut69dBjFqAKdPRiloPPsdXa2V6yNDiOq" });
        }
    }
}
