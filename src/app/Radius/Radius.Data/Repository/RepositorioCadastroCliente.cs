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
    public class RepositorioCadastroCliente : Repositorio<CadastroClienteEntidade>, IRepositorioCadastroCliente
    {
        private readonly RadiusContext _db;
        private readonly DbSet<CadastroClienteEntidade> _dbSet;
        public RepositorioCadastroCliente(RadiusContext db) : base(db)
        {
            _db = db;
            _dbSet = db.Set<CadastroClienteEntidade>();

        }

        public async Task<CadastroClienteEntidade> ObterEndereco(Guid Id)
        {
            return await _dbSet.AsNoTracking()
                .Include(c => c.Endereco)
                .FirstOrDefaultAsync(c => c.Id == Id);
        }

        public async Task<CadastroClienteEntidade> ObterProjetoseEndereco(Guid Id)
        {
            return await _dbSet.AsNoTracking()
                .Include(c => c.Endereco)
                .Include(c=> c.Projetos)
                .FirstOrDefaultAsync(c => c.Id == Id);
        }
    }
}
