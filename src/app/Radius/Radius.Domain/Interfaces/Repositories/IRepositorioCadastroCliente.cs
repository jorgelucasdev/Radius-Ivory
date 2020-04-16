using System;
using Radius.Domain.Entities;
using System.Threading.Tasks;


namespace Radius.Domain.Interfaces.Repositories
{
    public interface IRepositorioCadastroCliente : IRepositorio<CadastroClienteEntidade>
    {
        Task<CadastroClienteEntidade> ObterEnderecoCliente(Guid Id);

        Task<CadastroClienteEntidade> ObterProjetoseEnderecoCliente(Guid Id);
    }
}