using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sitema_Manejo_Equipos.Models
{
    public class laboratorio
    {
        [Key]
        public int id_lab { get; set; }

        [Required]
        [MaxLength(50)]
        public string nombre { get; set; }

        public string descripcion { get; set; }

        public int responsable_lab { get; set; }

        [ForeignKey("responsable_lab")]
        public empleado EmpleadoResponsable { get; set; }

        public ICollection<equipo> equipos { get; set; }
    }
}
