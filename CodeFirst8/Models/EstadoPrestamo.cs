using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst8.Models
{
    public class EstadoPrestamo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int id_estado_prestamo { get; set; }
        public string codigo_estado_prestamo { get; set; }
        public string descripcion_estado_prestamo { get; set; }


        public ICollection<Prestamo> PrestamoEstado { get; set; }//una estado puede tener muchos prestamos
    }
}
