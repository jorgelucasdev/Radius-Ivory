using System;
using System.ComponentModel.DataAnnotations;

namespace Radius.Service.DTOs
{
    public class UsuarioDTOCriacao
    {
        [Key]
        public Guid Id { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(11, ErrorMessage = "O campo {0} precisa ter {1} caracteres", MinimumLength = 11)]
        public string CPF { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} está com formato inválido")]
        public string Email { get; set; }

        [RegularExpression("^[(][1-9]{2}[)](?:[2-8]|9[1-9])[0-9]{3}[-][0-9]{4}$", ErrorMessage = "Formato incorreto, preencha o campo no formato: (00)1234-5678 ou (00)12345-6789")] 
        public string Celular { get; set; }

        public string Whatsapp { get; set; }

           
        [RegularExpression("^[(][1-9]{2}[)] (?:[2-8]|9[1-9])[0-9]{3}[-][0-9]{4}$", ErrorMessage = "Formato incorreto, preencha o campo no formato: (00)1234-5678 ou (00)12345-6789")]
        public string Telefone { get; set; }

        public string Setor { get; set; }

        public string Cargo { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [DataType(DataType.Date)]
        public DateTime Aniversario { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [DataType(DataType.Date)]
        public DateTime DataFim { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string Status { get; set; }


        public string Observacoes { get; set; }



    }
}

