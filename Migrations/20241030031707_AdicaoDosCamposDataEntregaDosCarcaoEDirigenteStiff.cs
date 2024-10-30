using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sga_stif.Migrations
{
    public partial class AdicaoDosCamposDataEntregaDosCarcaoEDirigenteStiff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataEntregaCartao",
                table: "Socio",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DerigenteStiff",
                table: "Socio",
                type: "int",
                nullable: true);

         
      
        }
    }
}
