using System.ComponentModel.DataAnnotations;

namespace AgenciaSemStress.Models
{
    public class AnunciosModel
    {
        [Key]
        public int AnuncioID { get; set; }
        [Display(Name ="Marque para Promocional")]
        public Boolean TipoAnuncio { get; set; }

        [Required(ErrorMessage = "Preencha o campo Preço")]
        [Display(Name ="Preço do Anuncio")]
        public float? ValorAnuncio { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome do Anuncio")]
        [MaxLength(50, ErrorMessage = "Limite de Caracteres Excedido")]
        [MinLength(2, ErrorMessage = "Digite um Nome com mais de duas Letras")]
        [Display(Name ="Nome do Anuncio")]
        public string? NomeAnuncio { get; set; }

        [Required(ErrorMessage = "Preencha o campo Data de Saida")]
        [Display(Name = "Data de Saida")]
        public DateTime DataSaida { get; set; }

        [Required(ErrorMessage = "Preencha o campo Data de Retorno")]
        [Display(Name = "Data de Retorno")]
        public DateTime DataRetorno { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastroAnuncio { get; set; }
    }
}
