using AutoMapper;
using Radius.Application.ViewModels;
using Radius.Domain.Entities;

namespace Radius.Service.AutoMappers
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<FaleConoscoEntidade, FaleConoscoDTO>();
        }
    }
}
