using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CodeFirst8.Migrations
{
    /// <inheritdoc />
    public partial class _16m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id_coleccion",
                table: "Libros",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id_genero",
                table: "Libros",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Coleccion",
                columns: table => new
                {
                    id_coleccion = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coleccion", x => x.id_coleccion);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    id_genero = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.id_genero);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Libros_id_coleccion",
                table: "Libros",
                column: "id_coleccion");

            migrationBuilder.CreateIndex(
                name: "IX_Libros_id_genero",
                table: "Libros",
                column: "id_genero");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Libros_Coleccion_id_coleccion",
                table: "Libros");

            migrationBuilder.DropForeignKey(
                name: "FK_Libros_Genero_id_genero",
                table: "Libros");

            migrationBuilder.DropTable(
                name: "Coleccion");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropIndex(
                name: "IX_Libros_id_coleccion",
                table: "Libros");

            migrationBuilder.DropIndex(
                name: "IX_Libros_id_genero",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "id_coleccion",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "id_genero",
                table: "Libros");
        }
    }
}
