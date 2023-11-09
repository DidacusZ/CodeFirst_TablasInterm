using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace CodeFirst8.Models
{
    public class Contexto : DbContext
    {
        //para que no de error en m-m poner distinto nombre entidad que en BD
        // <nombre entidad>     nombre en BD
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Coleccion> Colecciones { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<EstadoPrestamo> Estados_Prestamos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Acceso> Accesos { get; set; }

        public Contexto(DbContextOptions<Contexto> opciones) : base(opciones)
        {

        }

        public Contexto()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Libros-Editorial
            modelBuilder.Entity<Libro>()
            .HasOne(uno => uno.editorial)
            .WithMany(muchos => muchos.LibrosEditorial)
            .HasForeignKey(uno => uno.id_editorial);

            //Libros-Genero
            modelBuilder.Entity<Libro>()
            .HasOne(uno => uno.genero)
            .WithMany(muchos => muchos.LibrosGenero)
            .HasForeignKey(uno => uno.id_genero);

            //Libros-Coleccion
            modelBuilder.Entity<Libro>()
            .HasOne(uno => uno.coleccion)
            .WithMany(muchos => muchos.LibrosColeccion)
            .HasForeignKey(uno => uno.id_coleccion);

            //Prestamos-Estado
            modelBuilder.Entity<Prestamo>()
            .HasOne(uno => uno.estado)
            .WithMany(muchos => muchos.PrestamoEstado)
            .HasForeignKey(uno => uno.id_estdo_prestamo);


            //Prestamos-Usuario
            modelBuilder.Entity<Prestamo>()
            .HasOne(uno => uno.usuario)
            .WithMany(muchos => muchos.PrestamoUsuario)
            .HasForeignKey(uno => uno.id_usuario);

            //Usuarios-Acceso
            modelBuilder.Entity<Usuario>()
            .HasOne(uno => uno.acceso)
            .WithMany(muchos => muchos.UsuarioAcceso)
            .HasForeignKey(uno => uno.id_acceso);




            //Libros-Autores
            modelBuilder.Entity<Libro>()
            .HasMany(l => l.AutoresLibros)
            .WithMany(l => l.LibrosAutores)
            .UsingEntity(
            "Rel_Autores_Libros",
            l => l.HasOne(typeof(Autor)).WithMany().HasForeignKey("id_autor").HasPrincipalKey(nameof(Autor.id_autor)),//PK
            r => r.HasOne(typeof(Libro)).WithMany().HasForeignKey("id_libro").HasPrincipalKey(nameof(Libro.id_libro)),
            j => j.HasKey("id_libro", "id_autor"));


            //Libros-Prestamos
            modelBuilder.Entity<Libro>()
            .HasMany(e => e.PrestamosLibros)
            .WithMany(e => e.LibrosPrestamos)
            .UsingEntity(
            "Rel_Prestamos_Libros",
            r => r.HasOne(typeof(Prestamo)).WithMany().HasForeignKey("id_prestamo").HasPrincipalKey(nameof(Prestamo.id_prestamo)),//poner primero contrario a entidad inicial(Libros)
            l => l.HasOne(typeof(Libro)).WithMany().HasForeignKey("id_libro").HasPrincipalKey(nameof(Libro.id_libro)),
            j => j.HasKey("id_libro", "id_prestamo")
            );











            /*RELACION UNO A MUCHOS
            modelBuilder.Entity<muchos>()
           .HasOne(c2 => c2.uno)
           .WithMany(c1 => c1.muchosItems) //relacion está en uno(item)
           .HasForeignKey(c2 => c2.unoId); //campo está en muchos
            */

            /* RELACION UNO A UNO
            modelBuilder.Entity<uno2>()
            .HasOne(c2 => c2.uno1)
            .WithOne(c1 => c1.uno2)
            .HasForeignKey<uno2>(c2 => c2.uno1Id);
            */
        }
    }



}
