using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;

namespace GameZork.DataAccessLayer.Seeder
{
    public static class HostExtension
    {
        public static IHost SeedDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                SeedApplicationData(scope);
            }
            return host;
        }

        private static void SeedApplicationData(IServiceScope scope)
        {
            var seeder = scope.ServiceProvider.GetRequiredService<Seeder>();
            try
            {
                Task.WaitAll(seeder.EnsureSeedDataAsync());
            }
            catch (Exception e)
            {
                throw new Exception(string.Format("Seed application data Error:{0}", e.Message));
            }
        }
    }
}
