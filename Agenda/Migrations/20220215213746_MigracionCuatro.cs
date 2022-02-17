using Microsoft.EntityFrameworkCore.Migrations;

namespace Farmacia.Migrations
{
    public partial class MigracionCuatro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_venta_Categoria_CategoriaId",
                table: "venta");

            migrationBuilder.DropForeignKey(
                name: "FK_venta_Empleado_EmpleadoId",
                table: "venta");

            migrationBuilder.DropForeignKey(
                name: "FK_venta_Medicamento_MedicamentoId",
                table: "venta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_venta",
                table: "venta");

            migrationBuilder.RenameTable(
                name: "venta",
                newName: "Venta");

            migrationBuilder.RenameIndex(
                name: "IX_venta_MedicamentoId",
                table: "Venta",
                newName: "IX_Venta_MedicamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_venta_EmpleadoId",
                table: "Venta",
                newName: "IX_Venta_EmpleadoId");

            migrationBuilder.RenameIndex(
                name: "IX_venta_CategoriaId",
                table: "Venta",
                newName: "IX_Venta_CategoriaId");

            migrationBuilder.AlterColumn<string>(
                name: "Precio",
                table: "Venta",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Venta",
                table: "Venta",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Categoria_CategoriaId",
                table: "Venta",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Empleado_EmpleadoId",
                table: "Venta",
                column: "EmpleadoId",
                principalTable: "Empleado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Venta_Medicamento_MedicamentoId",
                table: "Venta",
                column: "MedicamentoId",
                principalTable: "Medicamento",
                principalColumn: "Id",
                onUpdate: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Categoria_CategoriaId",
                table: "Venta");

            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Empleado_EmpleadoId",
                table: "Venta");

            migrationBuilder.DropForeignKey(
                name: "FK_Venta_Medicamento_MedicamentoId",
                table: "Venta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Venta",
                table: "Venta");

            migrationBuilder.RenameTable(
                name: "Venta",
                newName: "venta");

            migrationBuilder.RenameIndex(
                name: "IX_Venta_MedicamentoId",
                table: "venta",
                newName: "IX_venta_MedicamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_Venta_EmpleadoId",
                table: "venta",
                newName: "IX_venta_EmpleadoId");

            migrationBuilder.RenameIndex(
                name: "IX_Venta_CategoriaId",
                table: "venta",
                newName: "IX_venta_CategoriaId");

            migrationBuilder.AlterColumn<double>(
                name: "Precio",
                table: "venta",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_venta",
                table: "venta",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_venta_Categoria_CategoriaId",
                table: "venta",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_venta_Empleado_EmpleadoId",
                table: "venta",
                column: "EmpleadoId",
                principalTable: "Empleado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_venta_Medicamento_MedicamentoId",
                table: "venta",
                column: "MedicamentoId",
                principalTable: "Medicamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
