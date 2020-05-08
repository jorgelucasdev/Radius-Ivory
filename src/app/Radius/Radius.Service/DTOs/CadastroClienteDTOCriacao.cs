using System;
using System.Collections.Generic;
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
        [RegularExpression("^[(][1-9]{2}[)](?:[2-8]|9[1-9])[0-9]{3}[-][0-9]{4}$", ErrorMessage = "O campo {0} foi preenchido em formato incorreto, preencha o campo no formato: (00)1234-5678 ou (00)12345-6789")]
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


        /* Relacionamento*/
        public IEnumerable<ProjetoDTOCriacao> Projetos { get; set; }
    }
}
