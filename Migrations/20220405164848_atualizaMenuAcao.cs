using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class atualizaMenuAcao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "MenuAcaoMaster",
                table: "MenuAcao",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7462), new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7474), new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7473) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7477), new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(991), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(997), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(997) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1002), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1001) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1006), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1004) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1009), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1012), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1078), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1077) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1082), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1086), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1085) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1089), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1089) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1092), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1096), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1098), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1098) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1102), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1105), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1107), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1111), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1110) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1114), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1117), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1120), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1123), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1128), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1130), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1133), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1132) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1137), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1140), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1144), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1146), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1149), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1153), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1156), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1159), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1158) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1162), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1162) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1166), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1169), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1168) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1172), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1171) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1175), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1174) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1178), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1181), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1180) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1185), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1184) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1188), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1191), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1190) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1194), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1197), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1196) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1200), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1203), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1202) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1207), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1206) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1210), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1212), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1212) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1216), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1219), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1218) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1222), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1221) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1225), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1224) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1228), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1227) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1231), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1234), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1233) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1237), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1360), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1365), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1369), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1372), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1375), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1374) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1378), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1382), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1385), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1384) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1389), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1388) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1391), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1394), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1397), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1400), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1403), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1402) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1406), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1405) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1410), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1409) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1413), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1412) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1418), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1417) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1420), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1419) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1423), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1426), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1425) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1429), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1431), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1430) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1434), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1437), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1440), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1443), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1446), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1449), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1448) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1452), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1451) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1455), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1454) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1458), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1457) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1461), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1460) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1464), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1467), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1466) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1470), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1469) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1473), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1477), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1480), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1483), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1482) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1487), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1490), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1489) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1493), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1496), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1499), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1498) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1503), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1506), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1510), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1513), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1512) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1516), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1515) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1519), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1581), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1585), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1589), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1592), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1595), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1595) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1599), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1602), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1605), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1609), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1612), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1615), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1618), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1621), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1624), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1627), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1630), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(719), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(726), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(725) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(730), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(729) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(733), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(736), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(738), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(738) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(741), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(744), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(747), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(746) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(751), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(750) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(754), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(753) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(757), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(756) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(760), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(763), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(762) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(767), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(774), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(777), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(776) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(779), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(558), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(566), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(565) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(569), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(568) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(572), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(575), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(574) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(578), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(582), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(581) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(585), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(584) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(588), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(590), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(929), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(928) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(935), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(938), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(937) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(941), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(945), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(944) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(948), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(951), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7583), new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7582) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7591), new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7595), new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7599), new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7598) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7602), new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7601) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7605), new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7604) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7608), new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7610), new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7610) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7613), new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7616), new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7615) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7619), new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7622), new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7624), new DateTime(2022, 4, 5, 15, 48, 46, 378, DateTimeKind.Local).AddTicks(7624) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(866), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(888), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(480), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(478) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(490), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(489) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(494), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(498), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(497) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(501), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(121), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(112), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(134), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(140), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(139), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(143), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(144) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1784), new DateTime(2022, 4, 5, 15, 48, 44, 811, DateTimeKind.Local).AddTicks(1783), "$2a$11$E05WiIx0lzrX5vo2C4.2qOcRI4qtB1UKZOX1IubdCJiivY7FMrkES" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 45, 205, DateTimeKind.Local).AddTicks(5504), new DateTime(2022, 4, 5, 15, 48, 45, 205, DateTimeKind.Local).AddTicks(5448), "$2a$11$is9041Ey.zIrsNXnX8/lCumHTy4.N3QuvakVkv4n5W.aFD0maf6D." });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 45, 614, DateTimeKind.Local).AddTicks(6273), new DateTime(2022, 4, 5, 15, 48, 45, 614, DateTimeKind.Local).AddTicks(6254), "$2a$11$ZfSDsE/69RuSbDJ/QuvCpuQ9/rZZwEWFypwht1nAX1sWwFKe7F4va" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 48, 46, 0, DateTimeKind.Local).AddTicks(2957), new DateTime(2022, 4, 5, 15, 48, 46, 0, DateTimeKind.Local).AddTicks(2944), "$2a$11$ythQYNJ0BAnIGPp6F9GAuew8/KuYOPJXLT7YtVQHYwy48rvClOrUq" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenuAcaoMaster",
                table: "MenuAcao");

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(1870), new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(1882), new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Acao",
                keyColumn: "IdAcao",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(1885), new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3447), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3454), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3458), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3462), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3461) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3465), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3468), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3471), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3474), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3478), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3481), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3484), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3483) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3487), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3549), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3553), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3556), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3556) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3560), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3563), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3562) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3566), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3565) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 19,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3570), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 20,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3575), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3574) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 21,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3582), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 22,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3585), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 23,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3588), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3587) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 24,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3591), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 25,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3594), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 26,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3597), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 27,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3600), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 28,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3603), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 29,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3608), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 30,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3611), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 31,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3614), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 32,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3617), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 33,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3620), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 34,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3623), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 35,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3627), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 36,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3630), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 37,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3632), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 38,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3635), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 39,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3639), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 40,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3642), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 41,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3645), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 42,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3648), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 43,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3651), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 44,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3654), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 45,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3657), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 46,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3660), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 47,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3663), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 48,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3667), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 49,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3670), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 50,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3674), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 51,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3677), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 52,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3680), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 53,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3683), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 54,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3687), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 55,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3690), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 56,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3694), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 57,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3697), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 58,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3700), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3699) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 59,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3703), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3702) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 60,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3706), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 61,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3709), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 62,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3712), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 63,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3715), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3714) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 64,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3772), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3771) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 65,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3775), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 66,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3779), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3778) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 67,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3782), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 68,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3786), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 69,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3789), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3788) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 70,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3793), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3791) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 71,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3796), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 72,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3801), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3800) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 73,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3804), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3803) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 74,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3807), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 75,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3811), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 76,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3814), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3813) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 77,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3817), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3817) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 78,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3821), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 79,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3824), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 80,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3827), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3826) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 81,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3830), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 82,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3834), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3833) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 83,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3837), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 84,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3840), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3839) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 85,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3843), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3843) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 86,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3846), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 87,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3849), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 88,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3852), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 89,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3855), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 90,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3858), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 91,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3861), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 92,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3864), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 93,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3867), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3866) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 94,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3871), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3869) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 95,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3873), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3873) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 96,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3876), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3875) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 97,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3879), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3878) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 98,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3883), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 99,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3886), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3885) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 100,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3889), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3888) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 101,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3892), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 102,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3895), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 103,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3898), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3897) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 104,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3901), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3900) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 105,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3904), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 106,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3907), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 107,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3910), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 108,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3913), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3912) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 109,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3916), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3915) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 110,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3919), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 111,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3922), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 112,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3925), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3924) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 113,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3928), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3927) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 114,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3931), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 115,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4026), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4025) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 116,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4030), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4029) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 117,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4042), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 118,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4045), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4044) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 119,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4048), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4047) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 120,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4051), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4050) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 121,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4059), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 122,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4062), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 123,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4067), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "Agencia",
                keyColumn: "IdAgencia",
                keyValue: 124,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4070), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4069) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3151), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3159), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3225), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3229), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3233), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3236), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3239), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3243), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3245), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3249), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3252), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3255), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3258), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 14,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3261), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 15,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3264), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 16,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3267), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 17,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3270), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Cidade",
                keyColumn: "IdCidade",
                keyValue: 18,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3273), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3078), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3083), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3087), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3090), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3089) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3093), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3097), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3100), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3103), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3106), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "Ilha",
                keyColumn: "IdIlha",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3110), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3386), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3391), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3395), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3394) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3398), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3402), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3406), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "InstituicaoFinanceira",
                keyColumn: "IdInstituicaoFinanceira",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3408), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(1989), new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(1998), new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2003), new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2002) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2007), new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2011), new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 6,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2015), new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 7,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2019), new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 8,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2023), new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 9,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2027), new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 10,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2030), new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2029) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 11,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2034), new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 12,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2037), new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "IdMenu",
                keyValue: 13,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2041), new DateTime(2022, 4, 5, 15, 24, 47, 450, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3340), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3338) });

            migrationBuilder.UpdateData(
                table: "Perfil",
                keyColumn: "IdPerfil",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3347), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3014), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3022), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3026), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3025) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3029), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3028) });

            migrationBuilder.UpdateData(
                table: "TipoQuota",
                keyColumn: "IdTipoQuota",
                keyValue: 5,
                columns: new[] { "DataAtualizacao", "DataCriacao" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3033), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(2641), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(2621), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(2653), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(2655) });

            migrationBuilder.UpdateData(
                table: "TipologiaSocio",
                keyColumn: "IdTipologiaSocio",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(2659), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(2658), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(2662), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(2663) });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 1,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4179), new DateTime(2022, 4, 5, 15, 24, 45, 798, DateTimeKind.Local).AddTicks(4178), "$2a$11$c64MhiOQghaA/x08uHe4QeIGywVmo0eLIUCD8EmBUxE6rHHa3R60C" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 2,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 46, 158, DateTimeKind.Local).AddTicks(5331), new DateTime(2022, 4, 5, 15, 24, 46, 158, DateTimeKind.Local).AddTicks(5315), "$2a$11$e4uAHyvJf4KrVmDBUb1dWehkC60exGrKPOXOMq9JURXz1GgJESlSC" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 3,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 46, 642, DateTimeKind.Local).AddTicks(6082), new DateTime(2022, 4, 5, 15, 24, 46, 642, DateTimeKind.Local).AddTicks(6042), "$2a$11$jVnsSJsrM5NQFJJQJnaiV.JkZW7USoMa7t3Zgl0prZZoz27pZqhMe" });

            migrationBuilder.UpdateData(
                table: "Utilizador",
                keyColumn: "IdUtilizador",
                keyValue: 4,
                columns: new[] { "DataAtualizacao", "DataCriacao", "PalavraPasse" },
                values: new object[] { new DateTime(2022, 4, 5, 15, 24, 47, 92, DateTimeKind.Local).AddTicks(9743), new DateTime(2022, 4, 5, 15, 24, 47, 92, DateTimeKind.Local).AddTicks(9732), "$2a$11$A.iN9LLDBe92xzXnTJcwB.40jDyOrMM1IjjjZLK3.bzuB6z5u1qjG" });
        }
    }
}
