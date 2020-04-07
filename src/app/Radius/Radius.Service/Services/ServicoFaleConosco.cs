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
    public class ServicoFaleConosco : IServicoFaleConosco
    {
        private readonly IRepositorioFaleConosco _repositorio;
        private readonly IMapper _mapper;
        public ServicoFaleConosco(IRepositorioFaleConosco repositorio, IMapper mapper)
        {
            _repositorio = repositorio;
            _mapper = mapper;
        }

        public async Task<FaleConoscoDTOCriacao> Adicionar(FaleConoscoDTOCriacao vm)
        {
            var entidade = _mapper.Map<FaleConoscoEntidade>(vm);
            await _repositorio.Adicionar(entidade);

            var vmResult = _mapper.Map<FaleConoscoDTOCriacao>(entidade);
            return vmResult;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task<IEnumerable<FaleConoscoDTOCriacao>> ListarTodosComCondicao()
        {
            var vmLista = _mapper.Map<IEnumerable<FaleConoscoDTOCriacao>>(await _repositorio.BuscarTodosComCondicao(x => x.EstaAtivo));
            return vmLista;
        }

        public async Task<IEnumerable<FaleConoscoDTOCriacao>> ListarTodos()
        {
            var vmLista = _mapper.Map<IEnumerable<FaleConoscoDTOCriacao>>(await _repositorio.BuscarTodos());
            return vmLista;
        }
     

        public async Task<bool> Remover(Guid Id)
        {
            return await _repositorio.Deletar(Id);
        }

     
    }
}
