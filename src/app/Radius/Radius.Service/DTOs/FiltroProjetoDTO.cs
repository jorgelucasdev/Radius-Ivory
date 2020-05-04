using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radius.Service.DTOs
{
    public class FiltroProjetoDTO
    {
        public string Empresa { get; set; }

        [StringLength(14, ErrorMessage = "O campo {0} precisa ter {1} caracteres", MinimumLength = 14)]
        public string CNPJ { get; set; }

        public string NomeProjeto { get; set; }

        public DateTime? PeriodoCadastro { get; set; }

        public DateTime? PeriodoEncerramento { get; set; }

    }
}
