
using Radius.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Radius.Application.Interfaces
{
    public interface IServicoFaleConosco
    {
        Task<FaleConoscoDTOCriacao> Adicionar(FaleConoscoDTOCriacao vm);
        Task<IEnumerable<FaleConoscoDTOCriacao>> ListarTodos();

        Task<IEnumerable<FaleConoscoDTOCriacao>> ListarTodosComCondicao();

        Task<bool> Remover(Guid id);


    }
}
