using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DestinoCertoAPI.Models
{
    [Table("Clientes")]
    public class Cliente
    {
       // public Cliente() 
       // { 
       //     Reservas = new Collection<Reserva>();
       // }

        [Key]
        public int Id {  get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter no máximo 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter no mínimo 3 caracteres")]
        public string Nome { get; set; }

        [Required]
        [StringLength(20)]
        public string Senha { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string Cpf { get; set; }

        [Required]
        [StringLength(20)]
        public string Telefone { get; set; }

        public DateTime DataNascimento { get; set; }

        //public ICollection<Reserva> Reservas { get; set; }

        [JsonIgnore]
        public List<Reserva> reservas { get; set; }
    }
}
