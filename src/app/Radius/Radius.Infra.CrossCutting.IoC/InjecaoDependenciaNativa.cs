using Microsoft.Extensions.DependencyInjection;
using Radius.Application.Interfaces;
using Radius.Application.Services;
using Radius.Data.Context;
using Radius.Data.Repository;
using Radius.Data.UoW;
using Radius.Domain.Interfaces.Repositories;

namespace Radius.Infra.CrossCutting.IoC
{
    public static class InjecaoDependenciaNativa
    {
        public static void RegistrarDependencias(this IServiceCollection services)
        {
            //Data
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<RadiusContext>();

            //Repositorios
            services.AddScoped(typeof(IRepositorio<>), typeof(Repositorio<>));
            services.AddScoped<IRepositorioFaleConosco, RepositorioFaleConosco>();

            //Servicos
            services.AddScoped<IServicoFaleConosco, ServicoFaleConosco>();
        }
    }
}
