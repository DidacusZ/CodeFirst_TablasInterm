using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst8.Migrations
{
    /// <inheritdoc />
    public partial class _14m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Autores_Libros_Autor_id_libro",
                table: "Rel_Autores_Libros");

            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Autores_Libros_Libro_id_autor",
                table: "Rel_Autores_Libros");

            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Libros_Prestamos_Libro_id_prestamo",
                table: "Rel_Libros_Prestamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Libros_Prestamos_Prestamo_id_libro",
                table: "Rel_Libros_Prestamos");

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Autores_Libros_Autor_id_autor",
                table: "Rel_Autores_Libros",
                column: "id_autor",
                principalTable: "Autor",
                principalColumn: "id_autor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Autores_Libros_Libro_id_libro",
                table: "Rel_Autores_Libros",
                column: "id_libro",
                principalTable: "Libro",
                principalColumn: "id_libro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Libros_Prestamos_Libro_id_libro",
                table: "Rel_Libros_Prestamos",
                column: "id_libro",
                principalTable: "Libro",
                principalColumn: "id_libro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Libros_Prestamos_Prestamo_id_prestamo",
                table: "Rel_Libros_Prestamos",
                column: "id_prestamo",
                principalTable: "Prestamo",
                principalColumn: "id_prestamo",
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

            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Libros_Prestamos_Libro_id_libro",
                table: "Rel_Libros_Prestamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Libros_Prestamos_Prestamo_id_prestamo",
                table: "Rel_Libros_Prestamos");

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Autores_Libros_Autor_id_libro",
                table: "Rel_Autores_Libros",
                column: "id_libro",
                principalTable: "Autor",
                principalColumn: "id_autor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Autores_Libros_Libro_id_autor",
                table: "Rel_Autores_Libros",
                column: "id_autor",
                principalTable: "Libro",
                principalColumn: "id_libro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Libros_Prestamos_Libro_id_prestamo",
                table: "Rel_Libros_Prestamos",
                column: "id_prestamo",
                principalTable: "Libro",
                principalColumn: "id_libro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Libros_Prestamos_Prestamo_id_libro",
                table: "Rel_Libros_Prestamos",
                column: "id_libro",
                principalTable: "Prestamo",
                principalColumn: "id_prestamo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
