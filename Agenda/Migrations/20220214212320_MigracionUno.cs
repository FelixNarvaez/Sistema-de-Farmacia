using Microsoft.EntityFrameworkCore.Migrations;

namespace Farmacia.Migrations
{
    public partial class MigracionUno : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FechaCreacion",
                table: "Medicamento",
                newName: "FechaVencimiento");

            migrationBuilder.AddColumn<string>(
                name: "Laboratorio",
                table: "Categoria",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Laboratorio",
                table: "Categoria");

            migrationBuilder.RenameColumn(
                name: "FechaVencimiento",
                table: "Medicamento",
                newName: "FechaCreacion");
        }
    }
}
