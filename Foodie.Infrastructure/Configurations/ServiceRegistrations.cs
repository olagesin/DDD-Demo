using Microsoft.Extensions.DependencyInjection;

namespace Foodie.Infrastructure.Configurations
{
    public static class ServiceRegistrations
    {
        public static IServiceCollection RegisterInfrastructure(this IServiceCollection services){
            return services;
        }
    }
}