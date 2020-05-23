using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace TrendaTest.Web.Migrations
{
    public partial class FinalDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaApertura",
                table: "Productos");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaApertura",
                table: "Tiendas",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaApertura",
                table: "Tiendas");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaApertura",
                table: "Productos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
