using AutoMapper;
using Radius.Application.Interfaces;
using Radius.Service.DTOs;
using Radius.Domain.Entities;
using Radius.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
