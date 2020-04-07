using Radius.Data.Context;
using Radius.Domain.Entities;
using Radius.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Radius.Data.Repository
{
    public class RepositorioFuncionario : Repositorio<FuncionarioEntidade> , IRepositorioFuncionario
    {
        public RepositorioFuncionario(RadiusContext db) : base(db)
        {

        }
    }
}
