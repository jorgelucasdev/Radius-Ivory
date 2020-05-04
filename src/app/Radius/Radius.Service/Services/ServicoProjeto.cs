using AutoMapper;
using Radius.Application.Interfaces;
using Radius.Service.DTOs;
using Radius.Domain.Entities;
using Radius.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Radius.Application.Services
{
    public class ServicoProjeto : IServicoProjeto
    {

        private readonly IRepositorioProjeto _repositorio;

        private readonly IMapper _mapper;

        public ServicoProjeto(IRepositorioProjeto repositorio,
                                      IMapper mapper)
        {
            _repositorio = repositorio;
            _mapper = mapper;
        }

        public async Task<ProjetoDTOCriacao> Adicionar(ProjetoDTOCriacao vm)
        {

            var entidade = _mapper.Map<ProjetoEntidade>(vm);
            await _repositorio.Adicionar(entidade);

            var vmResult = _mapper.Map<ProjetoDTOCriacao>(entidade);
            return vmResult; throw new NotImplementedException();
        }

        public async Task<ProjetoDTOCriacao> Atualizar(ProjetoDTOCriacao vm)
        {

            var entidade = _mapper.Map<ProjetoEntidade>(vm);
            await _repositorio.Atualizar(entidade);

            var vmResult = _mapper.Map<ProjetoDTOCriacao>(entidade);
            return vmResult; throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProjetoDTOCriacao>> Buscar(FiltroProjetoDTO filtro)
        {
            var vmLista = _mapper.Map<IEnumerable<ProjetoDTOCriacao>>(await _repositorio.BuscarTodosComCondicao(x => x.EstaAtivo));

            if (filtro != null)
            {
                if (!string.IsNullOrEmpty(filtro.Empresa))
                {
                    vmLista = vmLista.Where(x => x.Empresa.ToUpper() == filtro.Empresa.ToUpper());
                }

                if (!string.IsNullOrEmpty(filtro.CNPJ))
                {
                    vmLista = vmLista.Where(x => x.CNPJ == filtro.CNPJ);
                }

                if (!string.IsNullOrEmpty(filtro.NomeProjeto))
                {
                    vmLista = vmLista.Where(x => x.NomeProjeto.ToUpper() == filtro.NomeProjeto.ToUpper());
                }

                if (filtro.PeriodoCadastro != null)
                {
                    vmLista = vmLista.Where(x => x.DataInicio == filtro.PeriodoCadastro);
                }

                if (filtro.PeriodoEncerramento != null)
                {
                    vmLista = vmLista.Where(x => x.DataTermino == filtro.PeriodoEncerramento);
                }
            }

            return vmLista;
        }


        public async Task<IEnumerable<ProjetoDTOCriacao>> ListarTodos()
        {
            var vmLista = _mapper.Map<IEnumerable<ProjetoDTOCriacao>>(await _repositorio.BuscarTodos());
            return vmLista;
        }

        public async Task<IEnumerable<ProjetoDTOCriacao>> ListarTodosComCondicao()
        {
            var vmLista = _mapper.Map<IEnumerable<ProjetoDTOCriacao>>(await _repositorio.BuscarTodosComCondicao(x => x.EstaAtivo));
            return vmLista;
        }

        public async Task<bool> Remover(Guid Id)
        {
            return await _repositorio.Deletar(Id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

    }
}
