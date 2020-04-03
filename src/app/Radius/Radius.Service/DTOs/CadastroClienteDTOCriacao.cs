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

        [Required(ErrorMessage ="O Campo {0} é obrigatório")]
        public string CNPJ { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string NomeFantasia { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string Endereco { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [DataType(DataType.PostalCode)]
        public string CEP { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [DataType(DataType.PhoneNumber)]
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

    }
}
