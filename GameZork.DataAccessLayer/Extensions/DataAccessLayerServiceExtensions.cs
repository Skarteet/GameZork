namespace GameZork.DataAccessLayer.Extensions
{
    using GameZork.DataAccessLayer;
    using GameZork.DataAccessLayer.AccessLayer;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using System.Configuration;
    using System.IO;

    public static class DataAccessLayerServiceExtensions
    {
        /// <summary>
        ///     Extension method use to initialize data access.
        /// </summary>
        /// <param name="services">Collection of the available services for the app.</param>
        /// <returns>Returns edited services collection.</returns>
        public static IServiceCollection AddDataAccessLayerService(this IServiceCollection services, string dbPath)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile($"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent}\\appsettings.json", optional: false, reloadOnChange: true).Build();
            services.AddDbContext<GameZorkDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("myDb1"), opt => opt.MigrationsAssembly("StudentManager.DataAccessLayer"));
            }); ;

            services.AddTransient<WeaponsAccessLayer>();
            services.AddTransient<CellAccessLayer>();
            services.AddTransient<ItemAccessLayer>();
            services.AddTransient<MonsterAccessLayer>();
            services.AddTransient<PlayerAccessLayer>();
            services.AddTransient<MapAccessLayer>();

            return services;
        }
    }
}
