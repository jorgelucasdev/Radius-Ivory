using Radius.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Radius.Application.Interfaces
{
    public interface IServicoCadastroCliente
    {

        Task<CadastroClienteDTOCriacao> Adicionar(CadastroClienteDTOCriacao vm);

        Task<CadastroClienteDTOCriacao> Atualizar (CadastroClienteDTOCriacao vm);

        Task<IEnumerable<CadastroClienteDTOCriacao>> ListarTodos();

        Task<IEnumerable<CadastroClienteDTOCriacao>> ListarTodosComCondicao();

        Task<bool> Remover(Guid id);



    }
}
