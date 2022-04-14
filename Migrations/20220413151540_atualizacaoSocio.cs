using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class atualizacaoSocio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataAtivacao",
                table: "Socio",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInicio",
                table: "Socio",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumeroColaborador",
                table: "Socio",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CodigoPeriodo",
                table: "PeriodoQuota",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7018), new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7026), new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7180), new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7179) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7430), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7444), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7443) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7446), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7445) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7448), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7447) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7450), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7452), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7454), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7456), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7458), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7460), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7462), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7461) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7463), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7465), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7467), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7466) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7469), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7468) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7470), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7472), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7474), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7476), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7477), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7479), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7481), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7483), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7484), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7486), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7488), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7487) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7490), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7491), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7491) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7493), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7495), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7496), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7499), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7501), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7502), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7504), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7504) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7561), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7560) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7563), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7563) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7565), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7567), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7566) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7568), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7570), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7572), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7571) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7574), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7575), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7575) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7577), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7576) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7579), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7578) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7581), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7583), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7585), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7584) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7586), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7588), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7588) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7590), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7592), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7591) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7593), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7595), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7597), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7596) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7598), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7601), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7603), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7605), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7606), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7606) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7608), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7610), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7612), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7613), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7613) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7615), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7617), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7618), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7620), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7622), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7624), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7623) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7625), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7628), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7627) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7629), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7631), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7633), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7632) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7636), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7637), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7639), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7638) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7641), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7642), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7644), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7644) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7646), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7645) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7649), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7648) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7650), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7652), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7685), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7687), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7689), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7690), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7690) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7692), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7692) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7694), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7693) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7696), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7695) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7698), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7700), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7699) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7701), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7701) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7703), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7702) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7705), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7704) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7706), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7706) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7708), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7708) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7710), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7710) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7712), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7711) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7714), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7715), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7715) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7717), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7719), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7720), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7722), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7724), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7726), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7726) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7728), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7728) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7730), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7729) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7732), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7731) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7734), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7735), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7735) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7737), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7736) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7739), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7740), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7742), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7744), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7743) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7746), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7747), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7749), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7775), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7750) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7251), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7254), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7256), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7258), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7261), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7262), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7264), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7266), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7265) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7267), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7269), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7271), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7272), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7274), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7276), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7277), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7277) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7279), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7281), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7282), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7282) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7210), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7213), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7215), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7215) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7217), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7219), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7220), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7222), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7221) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7224), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7225), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7227), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7393), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7393) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7396), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7398), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7398) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7400), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7401), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7403), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7405), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7272), new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7279), new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7278) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7285), new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7288), new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7291), new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7295), new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7298), new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7301), new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7304), new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7307), new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7310), new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7313), new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7317), new DateTime(2022, 4, 13, 14, 15, 39, 330, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7315), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7320), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "Tipo" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7174), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7173), 1 });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "Tipo" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7178), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7178), 1 });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "Tipo" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7180), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7180), 1 });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7183), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7182) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao", "Tipo" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7184), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7184), 0 });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7000), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(6986), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7015), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7018), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7017), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7019), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7866), new DateTime(2022, 4, 13, 14, 15, 38, 305, DateTimeKind.Local).AddTicks(7865), "$2a$11$RZdNmth4bXgP3VNJVxTHi.cUhKpF0cLuW/fV//iK0uFa3KuuyOl1." });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 530, DateTimeKind.Local).AddTicks(6479), new DateTime(2022, 4, 13, 14, 15, 38, 530, DateTimeKind.Local).AddTicks(6468), "$2a$11$iSWFUZ5RjVgjJCAbe/Oqy..5UkStBN/DG4ONi86xrxk.E2jkxVgBy" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 38, 787, DateTimeKind.Local).AddTicks(3478), new DateTime(2022, 4, 13, 14, 15, 38, 787, DateTimeKind.Local).AddTicks(3471), "$2a$11$vosTrA5JZ6tYzimj2DelGu/jWNupOnQ4rzj864oGvVeT1ollqxbri" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 13, 14, 15, 39, 55, DateTimeKind.Local).AddTicks(3854), new DateTime(2022, 4, 13, 14, 15, 39, 55, DateTimeKind.Local).AddTicks(3846), "$2a$11$xWVSRJgWcq5hu0Btxqz.yuvd0ViKNc.nnxe8Rs/TT8FJB2tj/LMZ2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataAtivacao",
                table: "Socio");

            migrationBuilder.DropColumn(
                name: "DataInicio",
                table: "Socio");

            migrationBuilder.DropColumn(
                name: "NumeroColaborador",
                table: "Socio");

            migrationBuilder.DropColumn(
                name: "CodigoPeriodo",
                table: "PeriodoQuota");

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2690), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2681) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2695), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2699), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7132), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7136), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7137), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7139), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7141), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7142), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7143), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7145), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7146), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7146) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7148), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7149), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7150), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7152), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7154), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7156), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7157), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7159), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7160), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7161), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7163), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7164), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7189), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7189) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7191), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7190) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7192), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7192) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7194), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7195), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7196), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7198), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7199), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7200), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7202), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7203), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7205), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7204) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7206), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7206) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7207), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7207) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7209), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7208) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7210), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7210) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7212), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7211) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7213), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7213) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7214), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7214) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7217), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7218), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7219), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7221), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7222), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7223), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7225), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7226), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7226) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7228), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7227) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7229), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7229) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7231), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7232), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7233), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7235), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7236), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7237), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7237) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7239), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7238) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7240), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7242), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7241) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7243), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7242) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7244), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7246), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7247), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7247) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7249), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7250), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7251), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7251) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7254), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7255), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7255) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7257), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7256) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7258), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7257) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7259), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7261), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7262), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7286), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7288), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7289), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7290), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7292), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7293), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7293) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7295), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7294) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7296), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7295) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7297), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7297) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7299), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7300), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7302), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7303), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7305), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7304) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7306), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7306) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7308), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7309), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7310), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7310) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7312), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7314), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7315), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7315) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7317), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7318), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7320), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7321), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7322), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7324), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7325), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7326), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7328), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7329), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7329) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7331), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7332), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7332) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7333), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7335), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7336), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7338), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7339), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7338) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7340), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7342), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7343), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7345), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7346), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7346) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7347), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7349), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7348) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7351), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7352), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7354), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7353) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7355), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7356), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7356) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7358), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6986), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6989), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6991), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6992), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6992) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6994), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6995), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6996), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6998), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6999), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7000), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7002), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7003), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7004), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7049), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7051), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7053), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7054), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7056), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6954), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6953) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6957), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6958), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6958) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6960), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6961), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6963), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6962) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6964), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6965), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6965) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6967), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6968), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7106), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7109), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7110), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7111), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7113), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7114), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7115), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2739), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2739) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2749), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2751), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2751) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2753), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2753) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2755), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2757), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2759), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2758) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2761), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2763), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2762) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2764), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2764) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2766), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2766) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2768), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2769), new DateTime(2022, 4, 12, 9, 32, 58, 180, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7086), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7090), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7090) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "Tipo" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6927), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6926), 0 });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "Tipo" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6930), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6929), 0 });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "Tipo" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6932), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6931), 0 });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6933), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao", "Tipo" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6935), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6934), 1 });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6771), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6759), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6781), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6783), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6782), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6784), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7428), new DateTime(2022, 4, 12, 9, 32, 57, 472, DateTimeKind.Local).AddTicks(7427), "$2a$11$kh38DbAL/BeTuuy6XNve/.uSTNsDPJn5cAXMU4kT.8KRI5MVCmoJW" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 637, DateTimeKind.Local).AddTicks(3003), new DateTime(2022, 4, 12, 9, 32, 57, 637, DateTimeKind.Local).AddTicks(2995), "$2a$11$hRM9JdiIR6zF3l2Hkg2btuMVsOriJvBXWZvc2r4Wj01yLvyg0a6Qu" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 810, DateTimeKind.Local).AddTicks(1404), new DateTime(2022, 4, 12, 9, 32, 57, 810, DateTimeKind.Local).AddTicks(1396), "$2a$11$FuzdfAv3Aijf1Boi5RflYeZoDtcAvoNn8Pn2NVjlQmUcfGAuwbaFa" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 12, 9, 32, 57, 990, DateTimeKind.Local).AddTicks(3081), new DateTime(2022, 4, 12, 9, 32, 57, 990, DateTimeKind.Local).AddTicks(3073), "$2a$11$IBhd9/.1QN.ejkQlFu0BEuQTu/zBcUv6uCZVpOoGuoxsE9Q6.McKK" });
        }
    }
}
