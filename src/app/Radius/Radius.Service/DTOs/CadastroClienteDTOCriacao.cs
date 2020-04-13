using System;
using System.ComponentModel.DataAnnotations;
using Flunt.Notifications;
using Flunt.Validations;

namespace Radius.Service.DTOs
{
    public class CadastroClienteDTOCriacao
    {
        [Key]
        public Guid Id { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string RazaoSocial { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string NomeFantasia { get; set; }


        [Required(ErrorMessage ="O Campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter {1} caracteres", MinimumLength = 14)]
        public string CNPJ { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string Telefone { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} está com formato inválido")]
        public string Email { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [DataType(DataType.Date)]
        public DateTime DataCadastro { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [DataType(DataType.Date)]
        public DateTime? DataEncerramento { get; set; }


        public EnderecoDTO Endereco { get; set; }
    }
}
