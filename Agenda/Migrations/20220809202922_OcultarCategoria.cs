using Microsoft.EntityFrameworkCore.Migrations;

namespace Farmacia.Migrations
{
    public partial class OcultarCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Categoria",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Categoria");
        }
    }
}
