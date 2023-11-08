using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst8.Migrations
{
    /// <inheritdoc />
    public partial class _10m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_libro",
                table: "Rel_Libros_Prestamos",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rel_Libros_Prestamos_id_libro",
                table: "Rel_Libros_Prestamos",
                column: "id_libro");

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Libros_Prestamos_Libro_id_libro",
                table: "Rel_Libros_Prestamos",
                column: "id_libro",
                principalTable: "Libro",
                principalColumn: "id_libro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Libros_Prestamos_Libro_id_libro",
                table: "Rel_Libros_Prestamos");

            migrationBuilder.DropIndex(
                name: "IX_Rel_Libros_Prestamos_id_libro",
                table: "Rel_Libros_Prestamos");

            migrationBuilder.DropColumn(
                name: "id_libro",
                table: "Rel_Libros_Prestamos");
        }
    }
}
