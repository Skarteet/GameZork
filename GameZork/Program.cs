using GameZork.DataAccessLayer.Seeder;
using GameZork.Services.Extension;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace GameZork
{
    class Program
    {
        static Task Main(string[] args)
        {
            using IHost host = CreatHostBuilder(args).Build().SeedDatabase();
            var run = host.RunAsync();

            var test = host.Services.GetService<test>();
            //test.exit += (o, e) => host.StopAsync();
            test.Start();

            return run;

        }

        static IHostBuilder CreatHostBuilder(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                //.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();


            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) =>
                    services.AddTransient<test>().AddDataService());
        }
    }
}
