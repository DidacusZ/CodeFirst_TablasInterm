using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst8.Migrations
{
    /// <inheritdoc />
    public partial class _6m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Autores_Libros_Autor_id_autor",
                table: "Rel_Autores_Libros");

            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Autores_Libros_Libro_id_libro",
                table: "Rel_Autores_Libros");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Libro_id_autor",
                table: "Libro");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Autor_id_libro",
                table: "Autor");

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Autores_Libros_Autor_id_autor",
                table: "Rel_Autores_Libros",
                column: "id_autor",
                principalTable: "Autor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Autores_Libros_Libro_id_libro",
                table: "Rel_Autores_Libros",
                column: "id_libro",
                principalTable: "Libro",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Autores_Libros_Autor_id_autor",
                table: "Rel_Autores_Libros");

            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Autores_Libros_Libro_id_libro",
                table: "Rel_Autores_Libros");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Libro_id_autor",
                table: "Libro",
                column: "id_autor");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Autor_id_libro",
                table: "Autor",
                column: "id_libro");

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Autores_Libros_Autor_id_autor",
                table: "Rel_Autores_Libros",
                column: "id_autor",
                principalTable: "Autor",
                principalColumn: "id_libro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Autores_Libros_Libro_id_libro",
                table: "Rel_Autores_Libros",
                column: "id_libro",
                principalTable: "Libro",
                principalColumn: "id_autor",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
