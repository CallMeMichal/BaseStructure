using BaseStructure.Application.Interface.Home;
using BaseStructure.Application.Service.Home;
using Microsoft.Extensions.DependencyInjection;

namespace BaseStructure.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IHomeService,HomeService>();
            return services;
        }
    }
}
