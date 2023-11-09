using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CodeFirst8.Migrations
{
    /// <inheritdoc />
    public partial class _18m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Usuarios_id_usuario",
                table: "Prestamos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "id_estado_prestamo",
                table: "Usuarios",
                newName: "id_acceso");

            migrationBuilder.AlterColumn<int>(
                name: "id_acceso",
                table: "Usuarios",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "id_usuario",
                table: "Usuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "id_usuario");

            migrationBuilder.CreateTable(
                name: "Accesos",
                columns: table => new
                {
                    id_acceso = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accesos", x => x.id_acceso);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_id_acceso",
                table: "Usuarios",
                column: "id_acceso");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Usuarios_id_usuario",
                table: "Prestamos",
                column: "id_usuario",
                principalTable: "Usuarios",
                principalColumn: "id_usuario",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Accesos_id_acceso",
                table: "Usuarios",
                column: "id_acceso",
                principalTable: "Accesos",
                principalColumn: "id_acceso",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Usuarios_id_usuario",
                table: "Prestamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Accesos_id_acceso",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "Accesos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_id_acceso",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "id_usuario",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "id_acceso",
                table: "Usuarios",
                newName: "id_estado_prestamo");

            migrationBuilder.AlterColumn<int>(
                name: "id_estado_prestamo",
                table: "Usuarios",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "id_estado_prestamo");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Usuarios_id_usuario",
                table: "Prestamos",
                column: "id_usuario",
                principalTable: "Usuarios",
                principalColumn: "id_estado_prestamo",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
