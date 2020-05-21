using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrendaTest.Web.Migrations
{
    public partial class CompleteDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tienda",
                table: "Tienda");

            migrationBuilder.RenameTable(
                name: "Tienda",
                newName: "Tiendas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tiendas",
                table: "Tiendas",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Sku = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(maxLength: 50, nullable: false),
                    FechaApertura = table.Column<DateTime>(nullable: false),
                    Descripcion = table.Column<string>(maxLength: 50, nullable: false),
                    Valor = table.Column<int>(maxLength: 15, nullable: false),
                    PicturePath = table.Column<string>(nullable: false),
                    TiendaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Sku);
                    table.ForeignKey(
                        name: "FK_Productos_Tiendas_TiendaId",
                        column: x => x.TiendaId,
                        principalTable: "Tiendas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_TiendaId",
                table: "Productos",
                column: "TiendaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tiendas",
                table: "Tiendas");

            migrationBuilder.RenameTable(
                name: "Tiendas",
                newName: "Tienda");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tienda",
                table: "Tienda",
                column: "Id");
        }
    }
}
