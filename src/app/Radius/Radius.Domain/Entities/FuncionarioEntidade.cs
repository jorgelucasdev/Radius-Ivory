using System;
using System.Collections.Generic;
using System.Text;

namespace Radius.Domain.Entities
{
    public class FuncionarioEntidade : BaseEntidade
    {

        public string Cargo { get; set; }
        public override bool Validar()
        {
            return true;
        }
    }
}
