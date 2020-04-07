using Microsoft.EntityFrameworkCore;
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
    public class RepositorioFaleConosco : Repositorio<FaleConoscoEntidade>, IRepositorioFaleConosco
    {
        private readonly RadiusContext _db;
        private readonly DbSet<FaleConoscoEntidade> _dbSet;
        public RepositorioFaleConosco(RadiusContext db) : base(db)
        {
            _db = db;

        }

        
    }
}
