using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst8.Models
{
    public class Usuario
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int id_usuario { get; set; }
        public string dni_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string apellidos_usuario { get; set; }
        public string tlf_usuario { get; set; }
        public string email_usuario { get; set; }
        public string clave_usuario { get; set; }

        public int id_acceso { get; set; }
        public Acceso acceso { get; set; }

        public bool estaBloqueado_usuario { get; set; }
        public DateTime fch_fin_bloqueo_usuario { get; set; }
        public DateTime fch_alta_usuario { get; set; }
        public DateTime fch_baja_usuario { get; set; }


        public ICollection<Prestamo> PrestamoUsuario { get; set; }//una usuario puede tener muchos prestamos
    }
}
