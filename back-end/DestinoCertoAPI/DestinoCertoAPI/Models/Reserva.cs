using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DestinoCertoAPI.Models
{
    //[Table("Reservas")]
    public class Reserva
    {
        [Key]
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public int ClienteId { get; set; }
        
        //[JsonIgnore]
        public Cliente Cliente { get; set; }

        public int DestinoId { get; set; }

        //[JsonIgnore]
        public Destino Destino { get; set; }
    }
}
