using IRO.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace IRO.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IRODbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("InstantRODatabase")));

            services.AddScoped<IIRODbContext>(provider => provider.GetService<IRODbContext>());

            return services;
        }
    }
}
