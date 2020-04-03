﻿using Microsoft.EntityFrameworkCore;
using Radius.Data.Context;
using Radius.Domain.Entities;
using Radius.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Radius.Data.Repository
{
    public class RepositorioCadastroCliente : Repositorio<CadastroClienteEntidade>, IRepositorioCadastroCliente
    {
        private readonly RadiusContext _db;
        private readonly DbSet<CadastroClienteEntidade> _dbSet;
        public RepositorioCadastroCliente(RadiusContext db) : base(db)
        {
            _db = db;

        }

        
    }
}
