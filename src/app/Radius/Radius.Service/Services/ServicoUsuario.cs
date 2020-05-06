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
    public class ServicoUsuario : IservicoUsuario
    {

        private readonly IRepositorioUsuario _repositorio;

        private readonly IMapper _mapper;

        public ServicoUsuario(IRepositorioUsuario repositorio,
                                      IMapper mapper)
        {
            _repositorio = repositorio;
            _mapper = mapper;
        }

        public async Task<UsuarioDTOCriacao> Adicionar(UsuarioDTOCriacao vm)
        {
            if(vm.Celular == "" && vm.Telefone == "")
            {
                throw new NotImplementedException("Entre os campos Celular e Telefone, pelo menos um tem que estar preenchido.");
            }

            var entidade = _mapper.Map<UsuarioEntidade>(vm);
            await _repositorio.Adicionar(entidade);

            var vmResult = _mapper.Map<UsuarioDTOCriacao>(entidade);
            return vmResult; throw new NotImplementedException();
        }

        public async Task<UsuarioDTOCriacao> Atualizar(UsuarioDTOCriacao vm)
        {

            var entidade = _mapper.Map<UsuarioEntidade>(vm);
            await _repositorio.Atualizar(entidade);

            var vmResult = _mapper.Map<UsuarioDTOCriacao>(entidade);
            return vmResult; throw new NotImplementedException();
        }


        public async Task<IEnumerable<UsuarioDTOCriacao>> ListarTodos()
        {
            var vmLista = _mapper.Map<IEnumerable<UsuarioDTOCriacao>>(await _repositorio.BuscarTodos());
            return vmLista;
        }

        public async Task<IEnumerable<UsuarioDTOCriacao>> ListarTodosComCondicao()
        {
            var vmLista = _mapper.Map<IEnumerable<UsuarioDTOCriacao>>(await _repositorio.BuscarTodosComCondicao(x => x.EstaAtivo));
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
