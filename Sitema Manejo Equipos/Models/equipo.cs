using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Sitema_Manejo_Equipos.Models
{
    public class equipo
    {
        [Key]
        public int id_equipo { get; set; }

        public string nombre { get; set; }

        public string? foto { get; set; }

        public int? costo { get; set; }

        public string descripcion { get; set; }

        public string? proveedor { get; set; }
        public string? cpf { get; set; }

        [Required]
        public string origen { get; set; }

        public string f_adquisicion { get; set; }


        public int id_laboratorio { get; set; }

        [ForeignKey("id_laboratorio")]
        public laboratorio laboratorio { get; set; }

        public ICollection<prestamo> prestamos { get; set; }
        [JsonIgnore]
        public ICollection<alerta> alertas { get; set; }
    }
}
