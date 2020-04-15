using AutoMapper;
using Radius.Application.Interfaces;
using Radius.Service.DTOs;
using Radius.Domain.Entities;
using Radius.Domain.Interfaces.Repositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Radius.Application.Services
{
    public class ServicoCadastroCliente : IServicoCadastroCliente
    {

        private readonly IRepositorioCadastroCliente _repositorio;
        private readonly IRepositorioEndereco _repositorioEndereco;

        private readonly IMapper _mapper;

        public ServicoCadastroCliente(IRepositorioCadastroCliente repositorio,
                                      IRepositorioEndereco repositorioEndereco,
                                      IMapper mapper)
        {
            _repositorio = repositorio;
            _repositorioEndereco = repositorioEndereco;
            _mapper = mapper;
        }


        public async Task<IEnumerable<CadastroClienteDTOCriacao>> ListarTodos()
        {
            var vmLista = _mapper.Map<IEnumerable<CadastroClienteDTOCriacao>>(await _repositorio.BuscarTodos());
            return vmLista;
        }


        public async Task<IEnumerable<CadastroClienteDTOCriacao>> ListarTodosComCondicao()
        {
            var vmLista = _mapper.Map<IEnumerable<CadastroClienteDTOCriacao>>(await _repositorio.BuscarTodosComCondicao(x => x.EstaAtivo));
            return vmLista;
        }


        public async Task<CadastroClienteDTOCriacao> ListarEndereco(Guid id)
        {
            var vmLista = _mapper.Map<CadastroClienteDTOCriacao>(await _repositorio.ObterEndereco(id));
            return vmLista;
        }

        public async Task<CadastroClienteDTOCriacao> ListarProjetoseEndereco(Guid id)
        {
            var vmLista = _mapper.Map<CadastroClienteDTOCriacao>(await _repositorio.ObterProjetoseEndereco(id));
            return vmLista;
        }


        public async Task<CadastroClienteDTOCriacao> Adicionar(CadastroClienteDTOCriacao vm)
        {
            var entidade = _mapper.Map<CadastroClienteEntidade>(vm);
            await _repositorio.Adicionar(entidade);

            var vmResult = _mapper.Map<CadastroClienteDTOCriacao>(entidade);
            return vmResult; throw new NotImplementedException();
        }

        public async Task<CadastroClienteDTOCriacao> Atualizar(CadastroClienteDTOCriacao vm)
        {

            var entidade = _mapper.Map<CadastroClienteEntidade>(vm);
            await _repositorio.Atualizar(entidade);

            var vmResult = _mapper.Map<CadastroClienteDTOCriacao>(entidade);
            return vmResult; throw new NotImplementedException();
        }


        public async Task<bool> Remover(Guid Id)
        {
            return await _repositorio.Deletar(Id);
        }

        public async Task<EnderecoDTO> AtualizarEndereco(EnderecoDTO vs)
        {

            var entidade = _mapper.Map<EnderecoEntidade>(vs);
            await _repositorioEndereco.Atualizar(entidade);

            var vmResult = _mapper.Map<EnderecoDTO>(entidade);
            return vmResult; throw new NotImplementedException();
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
            GC.SuppressFinalize(_repositorioEndereco);
        }

    }
}
