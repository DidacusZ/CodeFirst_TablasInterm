using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst8.Models
{
    public class Editorial
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int id_editorial { get; set; }
        public string nombre_editorial { get; set; }


        public ICollection<Libro> LibrosEditorial { get; set; }//una editorial puede tener muchos libros
    }
}
