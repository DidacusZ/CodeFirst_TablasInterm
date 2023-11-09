using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CodeFirst8.Migrations
{
    /// <inheritdoc />
    public partial class _15m : Migration
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
                name: "FK_Rel_Libros_Prestamos_Libro_id_libro",
                table: "Rel_Libros_Prestamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Libros_Prestamos_Prestamo_id_prestamo",
                table: "Rel_Libros_Prestamos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prestamo",
                table: "Prestamo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Libro",
                table: "Libro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autor",
                table: "Autor");

            migrationBuilder.RenameTable(
                name: "Prestamo",
                newName: "Prestamos");

            migrationBuilder.RenameTable(
                name: "Libro",
                newName: "Libros");

            migrationBuilder.RenameTable(
                name: "Autor",
                newName: "Autores");

            migrationBuilder.AddColumn<int>(
                name: "id_editorial",
                table: "Libros",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prestamos",
                table: "Prestamos",
                column: "id_prestamo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Libros",
                table: "Libros",
                column: "id_libro");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autores",
                table: "Autores",
                column: "id_autor");

            migrationBuilder.CreateTable(
                name: "Editoriales",
                columns: table => new
                {
                    id_editorial = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editoriales", x => x.id_editorial);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libros_id_editorial",
                table: "Libros",
                column: "id_editorial");

            migrationBuilder.AddForeignKey(
                name: "FK_Libros_Editoriales_id_editorial",
                table: "Libros",
                column: "id_editorial",
                principalTable: "Editoriales",
                principalColumn: "id_editorial",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Autores_Libros_Autores_id_autor",
                table: "Rel_Autores_Libros",
                column: "id_autor",
                principalTable: "Autores",
                principalColumn: "id_autor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Autores_Libros_Libros_id_libro",
                table: "Rel_Autores_Libros",
                column: "id_libro",
                principalTable: "Libros",
                principalColumn: "id_libro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Libros_Prestamos_Libros_id_libro",
                table: "Rel_Libros_Prestamos",
                column: "id_libro",
                principalTable: "Libros",
                principalColumn: "id_libro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rel_Libros_Prestamos_Prestamos_id_prestamo",
                table: "Rel_Libros_Prestamos",
                column: "id_prestamo",
                principalTable: "Prestamos",
                principalColumn: "id_prestamo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Libros_Editoriales_id_editorial",
                table: "Libros");

            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Autores_Libros_Autores_id_autor",
                table: "Rel_Autores_Libros");

            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Autores_Libros_Libros_id_libro",
                table: "Rel_Autores_Libros");

            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Libros_Prestamos_Libros_id_libro",
                table: "Rel_Libros_Prestamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Rel_Libros_Prestamos_Prestamos_id_prestamo",
                table: "Rel_Libros_Prestamos");

            migrationBuilder.DropTable(
                name: "Editoriales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prestamos",
                table: "Prestamos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Libros",
                table: "Libros");

            migrationBuilder.DropIndex(
                name: "IX_Libros_id_editorial",
                table: "Libros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autores",
                table: "Autores");

            migrationBuilder.DropColumn(
                name: "id_editorial",
                table: "Libros");

            migrationBuilder.RenameTable(
                name: "Prestamos",
                newName: "Prestamo");

            migrationBuilder.RenameTable(
                name: "Libros",
                newName: "Libro");

            migrationBuilder.RenameTable(
                name: "Autores",
                newName: "Autor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prestamo",
                table: "Prestamo",
                column: "id_prestamo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Libro",
                table: "Libro",
                column: "id_libro");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autor",
                table: "Autor",
                column: "id_autor");

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
    }
}
