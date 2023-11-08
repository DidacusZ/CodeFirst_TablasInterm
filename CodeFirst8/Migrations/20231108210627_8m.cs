using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CodeFirst8.Migrations
{
    /// <inheritdoc />
    public partial class _8m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_prestamo",
                table: "Libro",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Prestamo",
                columns: table => new
                {
                    id_prestamo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    id_libro = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamo", x => x.id_prestamo);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibroPrestamo");

            migrationBuilder.DropTable(
                name: "Prestamo");

            migrationBuilder.DropColumn(
                name: "id_prestamo",
                table: "Libro");
        }
    }
}
