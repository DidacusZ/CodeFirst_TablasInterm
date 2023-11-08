using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst8.Migrations
{
    /// <inheritdoc />
    public partial class _9m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibroPrestamo");

            migrationBuilder.CreateTable(
                name: "Rel_Libros_Prestamos",
                columns: table => new
                {
                    Libros_Prestamosid_libro = table.Column<int>(type: "integer", nullable: false),
                    Prestamos_Librosid_prestamo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rel_Libros_Prestamos", x => new { x.Libros_Prestamosid_libro, x.Prestamos_Librosid_prestamo });
                    table.ForeignKey(
                        name: "FK_Rel_Libros_Prestamos_Libro_Libros_Prestamosid_libro",
                        column: x => x.Libros_Prestamosid_libro,
                        principalTable: "Libro",
                        principalColumn: "id_libro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rel_Libros_Prestamos_Prestamo_Prestamos_Librosid_prestamo",
                        column: x => x.Prestamos_Librosid_prestamo,
                        principalTable: "Prestamo",
                        principalColumn: "id_prestamo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rel_Libros_Prestamos_Prestamos_Librosid_prestamo",
                table: "Rel_Libros_Prestamos",
                column: "Prestamos_Librosid_prestamo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rel_Libros_Prestamos");

            migrationBuilder.CreateTable(
                name: "LibroPrestamo",
                columns: table => new
                {
                    Libros_Prestamosid_libro = table.Column<int>(type: "integer", nullable: false),
                    Prestamos_Librosid_prestamo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibroPrestamo", x => new { x.Libros_Prestamosid_libro, x.Prestamos_Librosid_prestamo });
                    table.ForeignKey(
                        name: "FK_LibroPrestamo_Libro_Libros_Prestamosid_libro",
                        column: x => x.Libros_Prestamosid_libro,
                        principalTable: "Libro",
                        principalColumn: "id_libro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LibroPrestamo_Prestamo_Prestamos_Librosid_prestamo",
                        column: x => x.Prestamos_Librosid_prestamo,
                        principalTable: "Prestamo",
                        principalColumn: "id_prestamo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LibroPrestamo_Prestamos_Librosid_prestamo",
                table: "LibroPrestamo",
                column: "Prestamos_Librosid_prestamo");
        }
    }
}
