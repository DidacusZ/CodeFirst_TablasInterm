using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst8.Migrations
{
    /// <inheritdoc />
    public partial class _7m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Libro",
                newName: "id_libro");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Autor",
                newName: "id_autor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id_libro",
                table: "Libro",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "id_autor",
                table: "Autor",
                newName: "id");
        }
    }
}
