using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst8.Migrations
{
    /// <inheritdoc />
    public partial class _12m : Migration
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

            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Libros_Prestamos_Libro_Libros_Prestamosid_libro",
                table: "Rel_Libros_Prestamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Libros_Prestamos_Libro_id_libro",
                table: "Rel_Libros_Prestamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Libros_Prestamos_Prestamo_Prestamos_Librosid_prestamo",
                table: "Rel_Libros_Prestamos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rel_Libros_Prestamos",
                table: "Rel_Libros_Prestamos");

            migrationBuilder.DropIndex(
                name: "IX_Rel_Libros_Prestamos_id_libro",
                table: "Rel_Libros_Prestamos");

            migrationBuilder.DropColumn(
                name: "Libros_Prestamosid_libro",
                table: "Rel_Libros_Prestamos");

            migrationBuilder.DropColumn(
                name: "id_libro",
                table: "Prestamo");

            migrationBuilder.DropColumn(
                name: "id_autor",
                table: "Libro");

            migrationBuilder.DropColumn(
                name: "id_prestamo",
                table: "Libro");

            migrationBuilder.DropColumn(
                name: "id_libro",
                table: "Autor");

            migrationBuilder.RenameColumn(
                name: "Prestamos_Librosid_prestamo",
                table: "Rel_Libros_Prestamos",
                newName: "id_prestamo");

            migrationBuilder.RenameIndex(
                name: "IX_Rel_Libros_Prestamos_Prestamos_Librosid_prestamo",
                table: "Rel_Libros_Prestamos",
                newName: "IX_Rel_Libros_Prestamos_id_prestamo");

            migrationBuilder.AlterColumn<int>(
                name: "id_libro",
                table: "Rel_Libros_Prestamos",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rel_Libros_Prestamos",
                table: "Rel_Libros_Prestamos",
                columns: new[] { "id_libro", "id_prestamo" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rel_Libros_Prestamos",
                table: "Rel_Libros_Prestamos");

            migrationBuilder.RenameColumn(
                name: "id_prestamo",
                table: "Rel_Libros_Prestamos",
                newName: "Prestamos_Librosid_prestamo");

            migrationBuilder.RenameIndex(
                name: "IX_Rel_Libros_Prestamos_id_prestamo",
                table: "Rel_Libros_Prestamos",
                newName: "IX_Rel_Libros_Prestamos_Prestamos_Librosid_prestamo");

            migrationBuilder.AlterColumn<int>(
                name: "id_libro",
                table: "Rel_Libros_Prestamos",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "Libros_Prestamosid_libro",
                table: "Rel_Libros_Prestamos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_libro",
                table: "Prestamo",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_autor",
                table: "Libro",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_prestamo",
                table: "Libro",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_libro",
                table: "Autor",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rel_Libros_Prestamos",
                table: "Rel_Libros_Prestamos",
                columns: new[] { "Libros_Prestamosid_libro", "Prestamos_Librosid_prestamo" });

            migrationBuilder.CreateIndex(
                name: "IX_Rel_Libros_Prestamos_id_libro",
                table: "Rel_Libros_Prestamos",
                column: "id_libro");

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
                name: "FK_Rel_Libros_Prestamos_Libro_Libros_Prestamosid_libro",
                table: "Rel_Libros_Prestamos",
                column: "Libros_Prestamosid_libro",
                principalTable: "Libro",
                principalColumn: "id_libro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Libros_Prestamos_Libro_id_libro",
                table: "Rel_Libros_Prestamos",
                column: "id_libro",
                principalTable: "Libro",
                principalColumn: "id_libro");

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Libros_Prestamos_Prestamo_Prestamos_Librosid_prestamo",
                table: "Rel_Libros_Prestamos",
                column: "Prestamos_Librosid_prestamo",
                principalTable: "Prestamo",
                principalColumn: "id_prestamo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
