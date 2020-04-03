using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Radius.Data.Context;
using System;

namespace Radius.Application.Extensions
{
    public static class DatabaseSetup
    {
        public static void AddDatabaseSetup(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            //services.AddDbContext<RadiusContext>(options =>
            //    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            
            services.AddDbContext<RadiusContext>(opt => opt.UseInMemoryDatabase(databaseName: "RadiusDb"));
        }
    }
}
