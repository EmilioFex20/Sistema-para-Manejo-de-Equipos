using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sitema_Manejo_Equipos.Models
{
    public class equipo
    {
        [Key]
        public int id_equipo { get; set; }

        public string nombre { get; set; }

        public string foto { get; set; }

        public int? costo { get; set; }

        public string descripcion { get; set; }

        public string proveedor { get; set; }

        [Required]
        public string origen { get; set; }

        public string f_adquisicion { get; set; }

        public string cpf { get; set; }

        public int id_laboratorio { get; set; }

        [ForeignKey("id_laboratorio")]
        public laboratorio laboratorio { get; set; }

        public ICollection<prestamo> prestamos { get; set; }

        public ICollection<alerta> alertas { get; set; }
    }
}
