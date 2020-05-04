using Radius.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Radius.Application.Interfaces
{
    public interface IServicoProjeto
    {

        Task<ProjetoDTOCriacao> Adicionar(ProjetoDTOCriacao vm);

        Task<ProjetoDTOCriacao> Atualizar(ProjetoDTOCriacao vm);

        Task<IEnumerable<ProjetoDTOCriacao>> Buscar(FiltroProjetoDTO filtro);

        Task<IEnumerable<ProjetoDTOCriacao>> ListarTodos();

        Task<IEnumerable<ProjetoDTOCriacao>> ListarTodosComCondicao();

        Task<bool> Remover(Guid id);

    }
}
