using Foodie.Application.Services.Auth;
using Microsoft.Extensions.DependencyInjection;

namespace Foodie.Application.Configurations
{
    public static class ServiceRegistrations
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services){
            return services.AddScoped<IAuthService, AuthService>();
        }
    }
}