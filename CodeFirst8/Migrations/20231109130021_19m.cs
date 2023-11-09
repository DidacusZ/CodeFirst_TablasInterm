using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst8.Migrations
{
    /// <inheritdoc />
    public partial class _19m : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "apellidos_usuario",
                table: "Usuarios",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "clave_usuario",
                table: "Usuarios",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "dni_usuario",
                table: "Usuarios",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "email_usuario",
                table: "Usuarios",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "estaBloqueado_usuario",
                table: "Usuarios",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "fch_alta_usuario",
                table: "Usuarios",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "fch_baja_usuario",
                table: "Usuarios",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "fch_fin_bloqueo_usuario",
                table: "Usuarios",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "nombre_usuario",
                table: "Usuarios",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tlf_usuario",
                table: "Usuarios",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "cantidad_libro",
                table: "Prestamos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "fch_entrega_prestamo",
                table: "Prestamos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "fch_fin_prestamo",
                table: "Prestamos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "fch_inicio_prestamo",
                table: "Prestamos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "edicion_libro",
                table: "Libros",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "isbn_libro",
                table: "Libros",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "titulo_libro",
                table: "Libros",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "descripcion_genero",
                table: "Generos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "nombre_genero",
                table: "Generos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "codigo_estado_prestamo",
                table: "Estados_Prestamos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "descripcion_estado_prestamo",
                table: "Estados_Prestamos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "nombre_editorial",
                table: "Editoriales",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "nombre_coleccion",
                table: "Colecciones",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "codigo_acceso",
                table: "Autores",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "descripcion_acceso",
                table: "Autores",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "codigo_acceso",
                table: "Accesos",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "descripcion_acceso",
                table: "Accesos",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "apellidos_usuario",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "clave_usuario",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "dni_usuario",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "email_usuario",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "estaBloqueado_usuario",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "fch_alta_usuario",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "fch_baja_usuario",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "fch_fin_bloqueo_usuario",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "nombre_usuario",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "tlf_usuario",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "cantidad_libro",
                table: "Prestamos");

            migrationBuilder.DropColumn(
                name: "fch_entrega_prestamo",
                table: "Prestamos");

            migrationBuilder.DropColumn(
                name: "fch_fin_prestamo",
                table: "Prestamos");

            migrationBuilder.DropColumn(
                name: "fch_inicio_prestamo",
                table: "Prestamos");

            migrationBuilder.DropColumn(
                name: "edicion_libro",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "isbn_libro",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "titulo_libro",
                table: "Libros");

            migrationBuilder.DropColumn(
                name: "descripcion_genero",
                table: "Generos");

            migrationBuilder.DropColumn(
                name: "nombre_genero",
                table: "Generos");

            migrationBuilder.DropColumn(
                name: "codigo_estado_prestamo",
                table: "Estados_Prestamos");

            migrationBuilder.DropColumn(
                name: "descripcion_estado_prestamo",
                table: "Estados_Prestamos");

            migrationBuilder.DropColumn(
                name: "nombre_editorial",
                table: "Editoriales");

            migrationBuilder.DropColumn(
                name: "nombre_coleccion",
                table: "Colecciones");

            migrationBuilder.DropColumn(
                name: "codigo_acceso",
                table: "Autores");

            migrationBuilder.DropColumn(
                name: "descripcion_acceso",
                table: "Autores");

            migrationBuilder.DropColumn(
                name: "codigo_acceso",
                table: "Accesos");

            migrationBuilder.DropColumn(
                name: "descripcion_acceso",
                table: "Accesos");
        }
    }
}
