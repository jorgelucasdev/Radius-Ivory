using Flunt.Notifications;
using Flunt.Validations;
using System.ComponentModel.DataAnnotations;

namespace Radius.Service.DTOs
{
    public class FaleConoscoDTOCriacao
    {
        [Required]
        public string Corpo { get; set; }

        [Required]
        public string Assunto { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Nome { get; set; }
      
    }
}
