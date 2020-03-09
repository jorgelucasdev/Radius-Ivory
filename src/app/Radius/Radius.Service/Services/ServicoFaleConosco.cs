using AutoMapper;
using Radius.Application.Interfaces;
using Radius.Application.ViewModels;
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

        public async Task<FaleConoscoDTO> Adicionar(FaleConoscoDTO vm)
        {
            var entidade = _mapper.Map<FaleConoscoEntidade>(vm);
            await _repositorio.Adicionar(entidade);

            var vmResult = _mapper.Map<FaleConoscoDTO>(entidade);
            return vmResult;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task<IEnumerable<FaleConoscoDTO>> ListarTodos()
        {
            var vmLista = _mapper.Map<IEnumerable<FaleConoscoDTO>>(await _repositorio.BuscarTodosComCondicao(x => x.EstaAtivo));
            return vmLista;
        }
    }
}
