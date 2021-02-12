namespace GameZork.DataAccessLayer.Extensions
{
    using GameZork.DataAccessLayer;
    using GameZork.DataAccessLayer.AccessLayer;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;

    public static class DataAccessLayerServiceExtensions
    {
        /// <summary>
        ///     Extension method use to initialize data access.
        /// </summary>
        /// <param name="services">Collection of the available services for the app.</param>
        /// <returns>Returns edited services collection.</returns>
        public static IServiceCollection AddDataAccessLayerService(this IServiceCollection services)
        {
            services.AddDbContext<GameZorkDbContext>(options =>
            {
                options.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=ZorkDb;Trusted_Connection=true;", opt => opt.MigrationsAssembly("StudentManager.DataAccessLayer"));
            });

            services.AddTransient<WeaponsAccessLayer>();

            return services;
        }
    }
}
