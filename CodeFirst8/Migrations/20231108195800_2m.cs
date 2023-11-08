using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst8.Migrations
{
    /// <inheritdoc />
    public partial class _2m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostTag");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Libro",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Autor",
                newName: "id");

            migrationBuilder.CreateTable(
                name: "Rel_Autores_Libros",
                columns: table => new
                {
                    id_libro = table.Column<int>(type: "integer", nullable: false),
                    id_autor = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rel_Autores_Libros", x => new { x.id_libro, x.id_autor });
                    table.ForeignKey(
                        name: "FK_Rel_Autores_Libros_Autor_id_autor",
                        column: x => x.id_autor,
                        principalTable: "Autor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rel_Autores_Libros_Libro_id_libro",
                        column: x => x.id_libro,
                        principalTable: "Libro",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rel_Autores_Libros_id_autor",
                table: "Rel_Autores_Libros",
                column: "id_autor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rel_Autores_Libros");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Libro",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Autor",
                newName: "Id");

            migrationBuilder.CreateTable(
                name: "PostTag",
                columns: table => new
                {
                    id_libro = table.Column<int>(type: "integer", nullable: false),
                    id_autor = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTag", x => new { x.id_libro, x.id_autor });
                    table.ForeignKey(
                        name: "FK_PostTag_Autor_id_autor",
                        column: x => x.id_autor,
                        principalTable: "Autor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTag_Libro_id_libro",
                        column: x => x.id_libro,
                        principalTable: "Libro",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostTag_id_autor",
                table: "PostTag",
                column: "id_autor");
        }
    }
}
