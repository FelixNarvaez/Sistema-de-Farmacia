using Microsoft.EntityFrameworkCore.Migrations;

namespace Farmacia.Migrations
{
    public partial class AddCampoEstado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Medicamento",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Laboratorio",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Empleado",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Medicamento");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Laboratorio");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Empleado");
        }
    }
}
