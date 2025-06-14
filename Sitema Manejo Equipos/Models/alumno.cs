using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sitema_Manejo_Equipos.Models
{
    public class alumno
    {
        [Key]
        [MaxLength(10)]
        public string matricula { get; set; }

        [Required]
        [MaxLength(50)]
        public string nombre { get; set; }
        public string? apellido_paterno { get; set; }
        public string? apellido_materno { get; set; }

        public string foto { get; set; }

        public int id_proyecto { get; set; }

        [ForeignKey("id_proyecto")]
        public proyecto proyecto { get; set; }

        public ICollection<prestamo> prestamos { get; set; }
    }
}
