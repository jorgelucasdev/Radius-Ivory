using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Radius.CrossCutting.Identity.DbContext;
using Radius.Data.Context;
using System;

namespace Radius.Application.Configurations
{
    public static class DatabaseSetup
    {
        public static void AddDatabaseSetup(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseInMemoryDatabase(configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<RadiusContext>(options =>
                options.UseInMemoryDatabase(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
