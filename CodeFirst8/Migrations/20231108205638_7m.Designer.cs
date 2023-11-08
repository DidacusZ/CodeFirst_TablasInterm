﻿// <auto-generated />
using CodeFirst8.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CodeFirst8.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231108205638_7m")]
    partial class _7m
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CodeFirst8.Models.Autor", b =>
                {
                    b.Property<int>("id_autor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id_autor"));

                    b.Property<int>("id_libro")
                        .HasColumnType("integer");

                    b.HasKey("id_autor");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("CodeFirst8.Models.Libro", b =>
                {
                    b.Property<int>("id_libro")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id_libro"));

                    b.Property<int>("id_autor")
                        .HasColumnType("integer");

                    b.HasKey("id_libro");

                    b.ToTable("Libro");
                });

            modelBuilder.Entity("Rel_Autores_Libros", b =>
                {
                    b.Property<int>("id_libro")
                        .HasColumnType("integer");

                    b.Property<int>("id_autor")
                        .HasColumnType("integer");

                    b.HasKey("id_libro", "id_autor");

                    b.HasIndex("id_autor");

                    b.ToTable("Rel_Autores_Libros");
                });

            modelBuilder.Entity("Rel_Autores_Libros", b =>
                {
                    b.HasOne("CodeFirst8.Models.Autor", null)
                        .WithMany()
                        .HasForeignKey("id_autor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirst8.Models.Libro", null)
                        .WithMany()
                        .HasForeignKey("id_libro")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
