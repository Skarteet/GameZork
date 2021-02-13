using GameZork.DataAccessLayer.Extensions;
using GameZork.DataAccessLayer.Seeder;
using GameZork.Services.Service;
using Microsoft.Extensions.DependencyInjection;

namespace GameZork.Services.Extension
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddDataService(this IServiceCollection services)
        {
            services.AddDataAccessLayerService();
            services.AddScoped<WeaponsService>();
            services.AddScoped<MonsterService>();
            services.AddScoped<Seeder>();
            return services;
        }
    }
}
