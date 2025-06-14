using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sitema_Manejo_Equipos.Models
{
    public class alerta
    {
        [Key]
        public int id_alerta { get; set; }

        public int id_equipo { get; set; }

        [ForeignKey("IdEquipo")]
        public equipo equipo { get; set; }

        public string fecha { get; set; }

        public string hora { get; set; }
    }
}
