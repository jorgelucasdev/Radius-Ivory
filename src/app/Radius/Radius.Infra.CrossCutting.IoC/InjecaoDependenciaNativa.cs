using Microsoft.Extensions.DependencyInjection;
using Radius.Application.Interfaces;
using Radius.Application.Services;
using Radius.CrossCutting.Identity.Abastraction;
using Radius.CrossCutting.Identity.Repository;
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
            services.AddScoped<IRepositorioCadastroCliente, RepositorioCadastroCliente>();
            services.AddScoped<IRepositorioEndereco, RepositorioEndereco>();
            services.AddScoped<IRepositorioProjeto, RepositorioProjeto>();
            services.AddScoped<IRepositorioUsuario, RepositorioUsuario>();

            //Servicos
            services.AddScoped<IServicoFaleConosco, ServicoFaleConosco>();
            services.AddScoped<IServicoCadastroCliente, ServicoCadastroCliente>();
            services.AddScoped<IServicoProjeto, ServicoProjeto>();
            services.AddScoped<IservicoUsuario, ServicoUsuario>();

            // Identity
            services.AddScoped<IUserIdentity, RepositorioUserIdentity>();

        }
    }
}
