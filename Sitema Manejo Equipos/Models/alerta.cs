using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Sitema_Manejo_Equipos.Models
{
    public class alerta
    {
        [Key]
        public int id_alerta { get; set; }

        public int id_equipo { get; set; }

        [ForeignKey("id_equipo")]
        [JsonIgnore]
        public virtual equipo? equipo { get; set; }


        public string fecha { get; set; }

        public string hora { get; set; }
    }
}
