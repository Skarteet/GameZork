using Microsoft.Extensions.DependencyInjection;
using StudentManager.DataAccessLayer.Extensions;

namespace GameZork.Services.Extension
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddDataService(this IServiceCollection services)
        {
            services.AddDataAccessLayerService();
            services.AddScoped<WeaponsService>();
            return services;
        }
    }
}
