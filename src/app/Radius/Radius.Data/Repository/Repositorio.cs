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
    public class Repositorio<T> : IDisposable, IRepositorio<T> where T : BaseEntidade
    {
        private readonly RadiusContext _db;
        private readonly DbSet<T> _dbSet;
        public Repositorio(RadiusContext ctx)
        {
            _db = ctx;
            _dbSet = _db.Set<T>();
        }

        #region Leitura
        public virtual async Task<T> BuscarComCondicao(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AsQueryable().AsNoTracking().FirstOrDefaultAsync(expression);
        }
        public virtual async Task<List<T>> BuscarTodosComCondicao(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AsNoTracking().Where(expression).ToListAsync();
        }
        #endregion

        #region Escrita
        public async Task<T> Adicionar(T obj)
        {
            obj.PrepararParaInserir();
            if (obj.Validar())
            {
                var result = await _dbSet.AddAsync(obj);
                await Comitar();

                return result.Entity;
            }
            else
            {
                return obj;
            }
        }
        public async Task<T> Atualizar(T obj)
        {
            obj.PrepararParaAtualizar();
            if (obj.Validar())
            {
                var result = _dbSet.Update(obj);
                await Comitar();

                return result.Entity;
            }
            else
            {
                return obj;
            }
        }
        public async Task<bool> Deletar(Guid Id)
        {
            var obj = await BuscarComCondicao(x => x.Id.Equals(Id));
            obj.Deletar();
            return await Comitar();
        }
        #endregion

        #region Importantes
        public async Task<bool> Comitar()
        {
            int result = 0;
            try
            {
                result = await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                //TODO Logger;
                Console.WriteLine(ex);
            }
            return result > 0 ? true : false;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
