using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class atualizacaoDaTabelaSocioAdicionandoNumeroTelefone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NumeroDeTelefone",
                table: "Socio",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 29, 698, DateTimeKind.Local).AddTicks(32), new DateTime(2022, 3, 24, 14, 34, 29, 698, DateTimeKind.Local).AddTicks(16) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 29, 698, DateTimeKind.Local).AddTicks(41), new DateTime(2022, 3, 24, 14, 34, 29, 698, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 29, 698, DateTimeKind.Local).AddTicks(44), new DateTime(2022, 3, 24, 14, 34, 29, 698, DateTimeKind.Local).AddTicks(43) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6774), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6579), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6578) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6593), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6592) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6596), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6595) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6598), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6597) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6601), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6603), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6605), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6607), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6610), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6609) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6612), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6611) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6615), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6614) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6617), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6619), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6622), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6621) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6624), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6623) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6626), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6629), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6631), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6630) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6527), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6531), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6530) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6533), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6532) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6535), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6538), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6537) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6540), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6542), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6541) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6544), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6544) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6547), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6549), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6548) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6750), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 29, 698, DateTimeKind.Local).AddTicks(112), new DateTime(2022, 3, 24, 14, 34, 29, 698, DateTimeKind.Local).AddTicks(111) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 29, 698, DateTimeKind.Local).AddTicks(119), new DateTime(2022, 3, 24, 14, 34, 29, 698, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 29, 698, DateTimeKind.Local).AddTicks(124), new DateTime(2022, 3, 24, 14, 34, 29, 698, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 29, 698, DateTimeKind.Local).AddTicks(127), new DateTime(2022, 3, 24, 14, 34, 29, 698, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6674), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6679), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6436), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6434) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6447), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6441) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6472), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6467) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6475), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6482), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6481) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6194), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6175), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6208), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6209) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6212), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6211), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6213), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6816), new DateTime(2022, 3, 24, 14, 34, 28, 711, DateTimeKind.Local).AddTicks(6815), "$2a$11$aGRqZKllmFby0RmAIl9ruOADoqCirRUyNsadtvrfxx74/iqg6so1W" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 29, 43, DateTimeKind.Local).AddTicks(9440), new DateTime(2022, 3, 24, 14, 34, 29, 43, DateTimeKind.Local).AddTicks(9420), "$2a$11$bpagg8usOIrE5fXL2gtaWub0sz9ydz2.lmly730fbRUn8F4jMvEMi" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 24, 14, 34, 29, 358, DateTimeKind.Local).AddTicks(5679), new DateTime(2022, 3, 24, 14, 34, 29, 358, DateTimeKind.Local).AddTicks(5663), "$2a$11$84GWwGQjMBrNJU9xIWDa5O4ylx3qg9UzoRt.v7ppKsyMHfravZKH6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroDeTelefone",
                table: "Socio");

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3064), new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3071), new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3074), new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1595), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1455), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1460), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1459) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1462), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1462) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1465), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1464) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1467), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1466) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1469), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1468) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1472), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1471) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1474), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1473) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1477), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1479), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1482), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1481) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1484), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1486), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1489), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1491), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1493), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1495), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1498), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1398), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1397) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1404), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1406), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1409), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1408) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1411), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1410) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1414), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1416), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1418), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1417) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1421), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1423), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1572), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3122), new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3121) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3125), new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3125) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3128), new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3131), new DateTime(2022, 3, 24, 9, 56, 11, 385, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1540), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1545), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1544) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1273), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1289), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1278) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1348), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1347) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1351), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1361), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1045), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1026), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1059), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1063), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1062), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1065), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1666), new DateTime(2022, 3, 24, 9, 56, 10, 398, DateTimeKind.Local).AddTicks(1665), "$2a$11$C2aYvy2Hi7LaB4JTalyqzeW0pHxGeHSX/1pFJRPNW/AOfpac9UBm6" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 10, 790, DateTimeKind.Local).AddTicks(7061), new DateTime(2022, 3, 24, 9, 56, 10, 790, DateTimeKind.Local).AddTicks(7041), "$2a$11$7kucCii4hxS0UH4bzqXJqecWz6CweGyrlEUbhhMuK2yEESmajrDI." });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 3, 24, 9, 56, 11, 96, DateTimeKind.Local).AddTicks(2042), new DateTime(2022, 3, 24, 9, 56, 11, 96, DateTimeKind.Local).AddTicks(2023), "$2a$11$XMd6Bacqvn0wua0pEgLklOjuvi4m16NCqPFMPhFb1rGrCUnY63x3K" });
        }
    }
}
