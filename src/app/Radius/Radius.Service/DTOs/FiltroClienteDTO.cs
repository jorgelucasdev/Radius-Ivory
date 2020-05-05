using System;
using System.Collections.Generic;
using System.Text;

namespace Radius.Service.DTOs
{
    public class FiltroClienteDTO
    {
        public string ClienteNome { get; set; }

        public DateTime? PeriodoCadastro { get; set; }

        public DateTime? PeriodoEncerramento { get; set; }

    }
}
