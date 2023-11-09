using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst8.Models
{
    public class Libro
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int id_libro { get; set; }
        public string isbn_libro { get; set; }
        public string titulo_libro { get; set; }
        public string edicion_libro { get; set; }


        public int id_editorial { get; set; }//FK-Editoriales
        public Editorial editorial { get; set; }
        public int id_genero { get; set; }//FK-generos
        public Genero genero { get; set; }
        public int id_coleccion { get; set; }//FK-coleccion
        public Coleccion coleccion { get; set; }


        public List<Autor> AutoresLibros { get; } = new();
        public List<Prestamo> PrestamosLibros { get; } = new();
    }
}
