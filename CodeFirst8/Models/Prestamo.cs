using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst8.Models
{
    public class Prestamo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int id_prestamo { get; set; }

        public int id_usuario { get; set; }
        public Usuario usuario { get; set; }
        public int id_estdo_prestamo { get; set; }
        public EstadoPrestamo estado { get; set; }

        public int cantidad_libro { get; set; }
        public DateTime fch_inicio_prestamo { get; set; }
        public DateTime fch_fin_prestamo { get; set; }
        public DateTime fch_entrega_prestamo { get; set; }


        public List<Libro> LibrosPrestamos { get; } = new();
    }
}
