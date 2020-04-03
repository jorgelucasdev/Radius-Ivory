using AutoMapper;
using Radius.Application.ViewModels;
using Radius.Domain.Entities;

namespace Radius.Service.AutoMappers
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<FaleConoscoDTO, FaleConoscoEntidade>();
        }
    }
}
