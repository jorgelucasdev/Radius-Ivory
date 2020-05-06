using Radius.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Radius.Application.Interfaces
{
    public interface IservicoUsuario
    {

        Task<UsuarioDTOCriacao> Adicionar(UsuarioDTOCriacao vm);

        Task<UsuarioDTOCriacao> Atualizar(UsuarioDTOCriacao vm);

        Task<IEnumerable<UsuarioDTOCriacao>> ListarTodos();

        Task<IEnumerable<UsuarioDTOCriacao>> ListarTodosComCondicao();

        Task<bool> Remover(Guid id);

    }
}