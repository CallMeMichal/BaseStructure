using BaseStructure.Application.Interface;
using BaseStructure.Application.Service.Home;
using Microsoft.Extensions.DependencyInjection;

namespace BaseStructure.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<HomeService>();
            return services;
        }
    }
}
