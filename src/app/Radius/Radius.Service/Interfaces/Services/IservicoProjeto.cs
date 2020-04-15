using Radius.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Radius.Application.Interfaces
{
    public interface IServicoProjeto
    {

        Task<ProjetoDTOCriacao> Adicionar(ProjetoDTOCriacao vm);

        Task<ProjetoDTOCriacao> Atualizar(ProjetoDTOCriacao vm);

        Task<IEnumerable<ProjetoDTOCriacao>> ListarTodos();

        Task<IEnumerable<ProjetoDTOCriacao>> ListarTodosComCondicao();

        Task<bool> Remover(Guid id);



    }
}
