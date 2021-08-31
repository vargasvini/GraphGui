using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using RendaSolidaria.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using RendaSolidaria.Infra.Data.Repositories.Interfaces;
using RendaSolidaria.Infra.Data.Repositories.Implementations;

namespace RendaSolidaria.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureAPI(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddPooledDbContextFactory<MainContext>(opt =>
                opt.UseNpgsql(configuration.GetConnectionString("PostgresConnStrD"))
            );
            services.AddTransient<MainContext>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}