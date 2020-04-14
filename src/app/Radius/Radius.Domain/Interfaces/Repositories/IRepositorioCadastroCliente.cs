using System;
using Radius.Domain.Entities;
using System.Threading.Tasks;


namespace Radius.Domain.Interfaces.Repositories
{
    public interface IRepositorioCadastroCliente : IRepositorio<CadastroClienteEntidade>
    {
        //Task<CadastroClienteEntidade> ObterEndereco(Guid Id);
    }
}