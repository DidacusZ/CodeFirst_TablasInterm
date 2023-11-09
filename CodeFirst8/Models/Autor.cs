using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst8.Models
{
    public class Autor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int id_autor { get; set; }
        public string codigo_acceso { get; set; }
        public string descripcion_acceso { get; set; }

        public List<Libro> LibrosAutores { get; } = new();
    }
}
