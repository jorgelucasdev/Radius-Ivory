using Radius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Radius.Domain.Interfaces.Repositories
{
    public interface IRepositorio<T> where T : BaseEntidade
    {
        #region Leitura
        Task<List<T>> BuscarTodosComCondicao(Expression<Func<T, bool>> expression);
        Task<T> BuscarComCondicao(Expression<Func<T, bool>> expression);

        Task<List<T>> BuscarTodos();
        #endregion

        #region Escrita
        Task<T> Adicionar(T obj);
        Task<T> Atualizar(T obj);
        Task<bool> Deletar(Guid Id);
        Task<bool> Comitar();
        #endregion
    }
}
