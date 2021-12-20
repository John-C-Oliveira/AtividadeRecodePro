using System.ComponentModel.DataAnnotations;

namespace AgenciaSemStress.Models
{
    public class Contato
    {
        [Key]
        public int IDContato { get; set; }
        [Required(ErrorMessage ="Preencha o nome para poder enviar a mensagem")]
        [MinLength(2, ErrorMessage = "Mínimo de Caracteres não atingido")]
        [MaxLength(40,ErrorMessage ="Máximo de Caracteres excedido")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Preencha o Telefone para poder enviar a mensagem")]
        [MinLength(11, ErrorMessage = "Mínimo de Caracteres não atingido, insira o DDD e o número")]
        [MaxLength(14, ErrorMessage ="Máximo de números excedidos, utilize somente: pais,estado e numero")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Preencha o nome para poder enviar a mensagem")]
        [MinLength(5, ErrorMessage = "Mínimo de Caracteres não atingido")]
        [MaxLength(1000, ErrorMessage="Máximo de Caracteres excedidos")]
        public string Mensagem { get; set; }

    }     
}