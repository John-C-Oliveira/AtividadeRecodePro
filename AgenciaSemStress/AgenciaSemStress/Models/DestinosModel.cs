using System.ComponentModel.DataAnnotations;

namespace AgenciaSemStress.Models
{
    public class DestinosModel
    {
        [Key]
        public int DestinoID { get; set; }
        [Required(ErrorMessage = "Preencha o Nome do Destino")]
        [MaxLength(100, ErrorMessage = "Limite de Caracteres excedido")]
        [Display(Name = "Nome do Destino")]
        public string NomeDestino { get; set; }

        [Required(ErrorMessage="Informe a quantidade máxima de Pessoas para esse Destino")]
        [Display(Name ="Quantidade Máxima de Pessoas Permitidas")]
        public int QtdadePessoa { get; set; }

        [Display(Name ="Fotos do Destino")]
        [Required(ErrorMessage = "Não é possível cadastrar um Destino sem carregar imagens")]
        public string IMGDestino { get; set; }

        [Required(ErrorMessage = "Preencha o Endereço do Destino")]
        [MaxLength(100, ErrorMessage = "Limite de Caracteres excedido")]
        [Display(Name = "Endereço do Destino")]
        public string EnderecoDestino { get; set; }

        [Required(ErrorMessage = "Preencha o Pais do Destino")]
        [MaxLength(30, ErrorMessage = "Limite de Caracteres excedido")]
        [Display(Name = "Pais Destino")]
        public string PaisDestino { get; set; }
        [Required(ErrorMessage = "Preencha a Unidade Federativa")]
        [Display(Name = "UF ( Unidade Federativa )")]
        public string UFDestino { get; set; }

        [ScaffoldColumn(false)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DataCadastroDestino { get; set; }
    }
}
