using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sitema_Manejo_Equipos.Models
{
    public class empleado
    {
        [Key]
        public int num_empleado { get; set; }

        [Required]
        [MaxLength(50)]
        public string? nombre { get; set; }
        public string? apellido_paterno { get; set; }
        public string? apellido_materno { get; set; }

        public string? foto { get; set; }

        [Required]
        public string? tipo_empleado { get; set; }

        public int? coordinador { get; set; }

        [ForeignKey("coordinador")]
        public empleado EmpleadoCoordinador { get; set; }

        public ICollection<proyecto> ProyectosResponsables { get; set; }

        public ICollection<laboratorio> LaboratoriosResponsables { get; set; }

        public ICollection<prestamo> PrestamosSolicitados { get; set; }

        public ICollection<prestamo> PrestamosAutorizados { get; set; }
    }
}
