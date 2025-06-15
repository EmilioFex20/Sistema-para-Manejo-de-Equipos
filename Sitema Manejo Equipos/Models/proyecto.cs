using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sitema_Manejo_Equipos.Models
{
    public class proyecto
    {
        [Key]
        public int id_proyecto { get; set; }

        [Required]
        [MaxLength(50)]
        public string? nombre { get; set; }

        public string? descripcion { get; set; }

        public int responsable_proyecto { get; set; }

        [ForeignKey("responsable_proyecto")]
        public empleado EmpleadoResponsable { get; set; }

        public ICollection<alumno> alumnos { get; set; }
    }
}
