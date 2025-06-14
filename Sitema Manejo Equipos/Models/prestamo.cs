using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sitema_Manejo_Equipos.Models
{
    public class prestamo
    {
        [Key]
        public int id_prestamo { get; set; }

        public string fecha_prestamo { get; set; }

        public string lugar { get; set; }

        public string fecha_devolucion { get; set; }

        [Required]
        public string tipo_prestamo { get; set; }

        public int? empleado_solicita { get; set; }

        public string matricula { get; set; }

        public int id_equipo { get; set; }

        public int empleado_autoriza { get; set; }

        [ForeignKey("empleado_solicita")]
        public empleado EmpleadoQueSolicita { get; set; }

        [ForeignKey("empleado_autoriza")]
        public empleado EmpleadoQueAutoriza { get; set; }

        [ForeignKey("matricula")]
        public alumno alumno { get; set; }

        [ForeignKey("id_equipo")]
        public equipo equipo { get; set; }
    }
}
