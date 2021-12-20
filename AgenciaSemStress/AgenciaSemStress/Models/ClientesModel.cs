using System.ComponentModel.DataAnnotations;

namespace AgenciaSemStress.Models
{
    public class ClientesModel
    {
        [Key]
        public int ClienteID { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo de Caracteres excedido")]
        [MinLength(2, ErrorMessage = "Mínimo de Caracteres não atingido")]
        [Display(Name ="Nome")]
        public string NomeCliente { get; set; }

        [Required(ErrorMessage = "Preencha o campo Cpf")]
        [MaxLength(14, ErrorMessage = "Máximo de 14 Caracteres(Incluindo Sinais)")]
        [MinLength(11, ErrorMessage = "Mínimo de números para um Cpf não atingido")]
        [Display(Name ="CPF")]
        public string CpfCliente { get; set; }

        [Required(ErrorMessage = "Preencha o campo Telefone")]
        [MaxLength(50, ErrorMessage = "Limite de Caracteres para um número de telefone excedido")]
        [MinLength(11, ErrorMessage = "Adicione pelomenos o DDD e o número do seu Telefone")]
        [Display(Name="Telefone")]
        public string TelefoneCliente { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo de Caracteres excedido")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail Válido")]
        [Display(Name = "E-mail")]
        public string EmailCliente { get; set; }

       
        [Required(ErrorMessage = "Preencha o campo Logradouro")]
        [MaxLength(150, ErrorMessage = "Máximo de Caracteres excedido")]
        [MinLength(2, ErrorMessage = "Mínimo de Caracteres não atingido")]
        [Display(Name = "Endereço")]
        public string LogradouroCliente { get; set; }

        [Required(ErrorMessage = "Preencha o campo Cidade")]
        [MaxLength(20, ErrorMessage = "Máximo de Caracteres excedido, confira o nome informado")]
        [MinLength(2, ErrorMessage = "Mínimo de Caracteres não atingido")]
        [Display(Name = "Cidade")]
        public string CidadeCliente { get; set; }

        [Required(ErrorMessage = "Preencha o campo UF")]
        [MaxLength(3, ErrorMessage = "Máximo de 3  Caracteres, confira a Unidade Federativa")]
        [MinLength(2, ErrorMessage = "Mínimo de Caracteres não atingidos, confira a Unidade Federativa")]
        [Display(Name = "UF")]
        public string UFCliente { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Preencha o campo Data de Nascimento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTimeOffset NascimentoCliente { get; set; }

        [ScaffoldColumn(false)]

        public DateTime DataCadastroCliente { get; set; }
    }
}
