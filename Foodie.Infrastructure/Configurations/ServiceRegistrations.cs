using Foodie.Application.Common.Interfaces.Authentication;
using Foodie.Application.Common.Interfaces.Services;
using Foodie.Infrastructure.Authentication;
using Foodie.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Foodie.Infrastructure.Configurations
{
    public static class ServiceRegistrations
    {
        public static IServiceCollection RegisterInfrastructure(this IServiceCollection services,
        IConfiguration configuration){
            services.AddSingleton<IJwtProvider, JwtTokenProvider>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));
            return services;
        }
    }
}