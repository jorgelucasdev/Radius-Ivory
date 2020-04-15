using Radius.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Radius.Application.Interfaces
{
    public interface IServicoCadastroCliente
    {

        Task<IEnumerable<CadastroClienteDTOCriacao>> ListarTodos();

        Task<IEnumerable<CadastroClienteDTOCriacao>> ListarTodosComCondicao();

        Task<CadastroClienteDTOCriacao> ListarEndereco(Guid id);

        Task<CadastroClienteDTOCriacao> ListarProjetoseEndereco(Guid id);

        Task<CadastroClienteDTOCriacao> Adicionar(CadastroClienteDTOCriacao vm);

        Task<CadastroClienteDTOCriacao> Atualizar (CadastroClienteDTOCriacao vm);

        Task<bool> Remover(Guid id);

        Task<EnderecoDTO> AtualizarEndereco(EnderecoDTO vs);


    }
}
