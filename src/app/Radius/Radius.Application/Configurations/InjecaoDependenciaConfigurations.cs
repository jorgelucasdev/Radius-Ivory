using Microsoft.Extensions.DependencyInjection;
using Radius.Infra.CrossCutting.IoC;
using System;

namespace Radius.Application.Configurations
{
    public static class DependencyInjectionSetup
    {
        public static void AddDependencyInjectionSetup(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            InjecaoDependenciaNativa.RegistrarDependencias(services);
        }
    }
}
