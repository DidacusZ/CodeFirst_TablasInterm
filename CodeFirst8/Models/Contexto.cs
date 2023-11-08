using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace CodeFirst8.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> opciones) : base(opciones)
        {

        }

        public Contexto()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            //Libros-Autores
            modelBuilder.Entity<Libro>()
            .HasMany(l => l.Autores_Libros)
            .WithMany(l => l.Libros_Autores)
            .UsingEntity(
            "Rel_Autores_Libros",
            l => l.HasOne(typeof(Autor)).WithMany().HasForeignKey("id_autor").HasPrincipalKey(nameof(Autor.id_autor)),//PK
            r => r.HasOne(typeof(Libro)).WithMany().HasForeignKey("id_libro").HasPrincipalKey(nameof(Libro.id_libro)),
            j => j.HasKey("id_libro", "id_autor"));


            //Libros-Prestamos
            modelBuilder.Entity<Libro>()
            .HasMany(e => e.Prestamos_Libros)
            .WithMany(e => e.Libros_Prestamos)
            .UsingEntity(
            "Rel_Libros_Prestamos",            
            r => r.HasOne(typeof(Prestamo)).WithMany().HasForeignKey("id_prestamo").HasPrincipalKey(nameof(Prestamo.id_prestamo)),//poner primero contrario a entidad inicial(Libros)
            l => l.HasOne(typeof(Libro)).WithMany().HasForeignKey("id_libro").HasPrincipalKey(nameof(Libro.id_libro)),
            j => j.HasKey("id_libro", "id_prestamo")
            );            
        }
    }

    public class Libro
    {
        [Key]public int id_libro { get; set; }
        //public int id_autor { get; set; }
        //public int id_prestamo { get; set; }

        public List<Autor> Autores_Libros { get; } =new();
        public List<Prestamo> Prestamos_Libros { get; } = new();
    }

    public class Autor
    {
        [Key] public int id_autor { get; set; }
        //public int id_libro { get; set; }

        public List<Libro> Libros_Autores { get; } = new();
    }

    
    public class Prestamo
    {
        [Key] public int id_prestamo { get; set; }
        //public int id_libro { get; set; }

        public List<Libro> Libros_Prestamos { get; } = new();
    }
}
