using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Farmacia.Migrations
{
    public partial class Compras : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Compra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Precio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCompra = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    LaboratorioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compra_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compra_Empleado_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Compra_Laboratorio_LaboratorioId",
                        column: x => x.LaboratorioId,
                        principalTable: "Laboratorio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compra_CategoriaId",
                table: "Compra",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_EmpleadoId",
                table: "Compra",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Compra_LaboratorioId",
                table: "Compra",
                column: "LaboratorioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Compra");
        }
    }
}
