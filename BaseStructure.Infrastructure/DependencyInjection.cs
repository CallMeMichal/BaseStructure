using BaseStructure.Application.Interface;
using BaseStructure.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BaseStructure.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IHomeRepository, HomeRepository>();
            return services;
        }
    }
}
