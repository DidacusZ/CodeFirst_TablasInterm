using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst8.Models
{
    public class Genero
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int id_genero { get; set; }
        public string nombre_genero { get; set; }
        public string descripcion_genero { get; set; }


        public ICollection<Libro> LibrosGenero { get; set; }//un genero puede tener muchos libros
    }
}
