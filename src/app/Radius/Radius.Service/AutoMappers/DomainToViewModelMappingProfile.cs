using AutoMapper;
using Radius.Domain.Entities;
using Radius.Service.DTOs;

namespace Radius.Service.AutoMappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<FaleConoscoEntidade, FaleConoscoDTOCriacao>();

            CreateMap<CadastroClienteEntidade, CadastroClienteDTOCriacao>();

            CreateMap<EnderecoEntidade, EnderecoDTO>();
        }
    }
}
