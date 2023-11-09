using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst8.Models
{
    public class Coleccion
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int id_coleccion { get; set; }
        public string nombre_coleccion { get; set; }


        public ICollection<Libro> LibrosColeccion { get; set; }//una coleccion puede tener muchos libros
    }
}
