using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Flunt.Notifications;
using Flunt.Validations;

namespace Radius.Service.DTOs
{
    public class ProjetoDTOCriacao
    {
        [Key]
        public Guid Id { get; set; }

       
        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public Guid ClienteId { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string Empresa { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string Estado { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Responsavel { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string SetorR { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string TelefoneR { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} está com formato inválido")]
        public string EmailR { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string CoResponsavel { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string SetorC { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        public string TelefoneC { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "O campo {0} está com formato inválido")]
        public string EmailC { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string NomeProjeto { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string Segmento { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [DataType(DataType.Date)]
        public DateTime DataInicio { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [DataType(DataType.Date)]
        public DateTime DataTermino { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 10)]
        public string Apresentacao { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 10)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 10)]
        public string Justificativa { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 10)]
        public string ObjetivoGeral { get; set; }


        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 10)]
        public string ObjetivoEspecifico { get; set; }

    }
}

