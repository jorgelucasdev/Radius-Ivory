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
            var vmLista = _mapper.Map<CadastroClienteDTOCriacao>(await _repositorio.ObterEnderecoCliente(id));
            return vmLista;
        }

        public async Task<CadastroClienteDTOCriacao> ListarPorId(Guid id)
        {
            var vmLista = _mapper.Map<CadastroClienteDTOCriacao>(await _repositorio.ObterProjetoseEnderecoCliente(id));
            return vmLista;
        }

        public async Task<IEnumerable<CadastroClienteDTOCriacao>> Buscar(FiltroClienteDTO filtro)
        {
            var vmLista = _mapper.Map<IEnumerable<CadastroClienteDTOCriacao>>(await _repositorio.BuscarTodosComCondicao(x => x.EstaAtivo));

            if (filtro != null)
            {
                if (!string.IsNullOrEmpty(filtro.ClienteNome))
                {
                    vmLista = vmLista.Where(x => x.RazaoSocial.ToUpper() == filtro.ClienteNome.ToUpper());
                }

                if (filtro.PeriodoCadastro != null)
                {
                    vmLista = vmLista.Where(x => x.DataCadastro == filtro.PeriodoCadastro);
                }

                if (filtro.PeriodoEncerramento != null)
                {
                    vmLista = vmLista.Where(x => x.DataEncerramento == filtro.PeriodoEncerramento);
                }
            }

            return vmLista;
        }

        public async Task<CadastroClienteDTOCriacao> Adicionar(CadastroClienteDTOCriacao vm)
        {

            if (_repositorio.BuscarTodosComCondicao(f => f.CNPJ == vm.CNPJ).Result.Any())
            {
                throw new NotImplementedException("Já existe um cliente cadastrado com esse CNPJ.");
            }

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
            if (_repositorio.ObterProjetoseEnderecoCliente(Id).Result.Projetos.Any())
            {
                throw new NotImplementedException("O cliente possui projetos cadastrados!");
            }

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
