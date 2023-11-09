using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CodeFirst8.Migrations
{
    /// <inheritdoc />
    public partial class _17m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Libros_Coleccion_id_coleccion",
                table: "Libros");

            migrationBuilder.DropForeignKey(
                name: "FK_Libros_Genero_id_genero",
                table: "Libros");

            migrationBuilder.DropTable(
                name: "Rel_Libros_Prestamos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genero",
                table: "Genero");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Coleccion",
                table: "Coleccion");

            migrationBuilder.RenameTable(
                name: "Genero",
                newName: "Generos");

            migrationBuilder.RenameTable(
                name: "Coleccion",
                newName: "Colecciones");

            migrationBuilder.AddColumn<int>(
                name: "id_estdo_prestamo",
                table: "Prestamos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_usuario",
                table: "Prestamos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Generos",
                table: "Generos",
                column: "id_genero");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Colecciones",
                table: "Colecciones",
                column: "id_coleccion");

            migrationBuilder.CreateTable(
                name: "Estados_Prestamos",
                columns: table => new
                {
                    id_estado_prestamo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estados_Prestamos", x => x.id_estado_prestamo);
                });

            migrationBuilder.CreateTable(
                name: "Rel_Prestamos_Libros",
                columns: table => new
                {
                    id_libro = table.Column<int>(type: "integer", nullable: false),
                    id_prestamo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rel_Prestamos_Libros", x => new { x.id_libro, x.id_prestamo });
                    table.ForeignKey(
                        name: "FK_Rel_Prestamos_Libros_Libros_id_libro",
                        column: x => x.id_libro,
                        principalTable: "Libros",
                        principalColumn: "id_libro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rel_Prestamos_Libros_Prestamos_id_prestamo",
                        column: x => x.id_prestamo,
                        principalTable: "Prestamos",
                        principalColumn: "id_prestamo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    id_estado_prestamo = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.id_estado_prestamo);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_id_estdo_prestamo",
                table: "Prestamos",
                column: "id_estdo_prestamo");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamos_id_usuario",
                table: "Prestamos",
                column: "id_usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Rel_Prestamos_Libros_id_prestamo",
                table: "Rel_Prestamos_Libros",
                column: "id_prestamo");

            migrationBuilder.AddForeignKey(
                name: "FK_Libros_Colecciones_id_coleccion",
                table: "Libros",
                column: "id_coleccion",
                principalTable: "Colecciones",
                principalColumn: "id_coleccion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Libros_Generos_id_genero",
                table: "Libros",
                column: "id_genero",
                principalTable: "Generos",
                principalColumn: "id_genero",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Estados_Prestamos_id_estdo_prestamo",
                table: "Prestamos",
                column: "id_estdo_prestamo",
                principalTable: "Estados_Prestamos",
                principalColumn: "id_estado_prestamo",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Usuarios_id_usuario",
                table: "Prestamos",
                column: "id_usuario",
                principalTable: "Usuarios",
                principalColumn: "id_estado_prestamo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Libros_Colecciones_id_coleccion",
                table: "Libros");

            migrationBuilder.DropForeignKey(
                name: "FK_Libros_Generos_id_genero",
                table: "Libros");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Estados_Prestamos_id_estdo_prestamo",
                table: "Prestamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Usuarios_id_usuario",
                table: "Prestamos");

            migrationBuilder.DropTable(
                name: "Estados_Prestamos");

            migrationBuilder.DropTable(
                name: "Rel_Prestamos_Libros");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Prestamos_id_estdo_prestamo",
                table: "Prestamos");

            migrationBuilder.DropIndex(
                name: "IX_Prestamos_id_usuario",
                table: "Prestamos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Generos",
                table: "Generos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Colecciones",
                table: "Colecciones");

            migrationBuilder.DropColumn(
                name: "id_estdo_prestamo",
                table: "Prestamos");

            migrationBuilder.DropColumn(
                name: "id_usuario",
                table: "Prestamos");

            migrationBuilder.RenameTable(
                name: "Generos",
                newName: "Genero");

            migrationBuilder.RenameTable(
                name: "Colecciones",
                newName: "Coleccion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genero",
                table: "Genero",
                column: "id_genero");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Coleccion",
                table: "Coleccion",
                column: "id_coleccion");

            migrationBuilder.CreateTable(
                name: "Rel_Libros_Prestamos",
                columns: table => new
                {
                    id_libro = table.Column<int>(type: "integer", nullable: false),
                    id_prestamo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rel_Libros_Prestamos", x => new { x.id_libro, x.id_prestamo });
                    table.ForeignKey(
                        name: "FK_Rel_Libros_Prestamos_Libros_id_libro",
                        column: x => x.id_libro,
                        principalTable: "Libros",
                        principalColumn: "id_libro",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rel_Libros_Prestamos_Prestamos_id_prestamo",
                        column: x => x.id_prestamo,
                        principalTable: "Prestamos",
                        principalColumn: "id_prestamo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rel_Libros_Prestamos_id_prestamo",
                table: "Rel_Libros_Prestamos",
                column: "id_prestamo");

            migrationBuilder.AddForeignKey(
                name: "FK_Libros_Coleccion_id_coleccion",
                table: "Libros",
                column: "id_coleccion",
                principalTable: "Coleccion",
                principalColumn: "id_coleccion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Libros_Genero_id_genero",
                table: "Libros",
                column: "id_genero",
                principalTable: "Genero",
                principalColumn: "id_genero",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
