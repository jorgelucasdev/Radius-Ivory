using AutoMapper;
using Radius.Domain.Entities;
using Radius.Service.DTOs;

namespace Radius.Service.AutoMappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {

            CreateMap<FaleConoscoDTOCriacao, FaleConoscoEntidade>();

            CreateMap<CadastroClienteDTOCriacao, CadastroClienteEntidade>();

            CreateMap<EnderecoDTO, EnderecoEntidade>();

            CreateMap<ProjetoDTOCriacao, ProjetoEntidade>();

            CreateMap<UsuarioDTOCriacao, UsuarioEntidade>();
        }
    }
}
