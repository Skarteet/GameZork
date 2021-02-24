using System;
using System.Configuration;
using System.Threading.Tasks;
using GameZork.DataAccessLayer.Seeder;
using GameZork.GameParts;
using GameZork.MenuParts;
using GameZork.Services.Extension;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GameZork
{
    class Program
    {
        private static Menu Menu { get; set; }
        static Task Main(string[] args)
        {
            MapperExtension.InstantiateMapper();

            using IHost host = CreatHostBuilder(args).Build().SeedDatabase();
            var run = host.RunAsync();

            Globals.Services = host.Services;

            Menu = host.Services.GetService<Menu>();
            Globals.Exit += (o, e) => { host.StopAsync(); Environment.Exit(0); };
            Menu.Start();

            return run;

        }

        static IHostBuilder CreatHostBuilder(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                 .AddEnvironmentVariables()
                 .AddCommandLine(args)
                 .Build();

            var set = ConfigurationManager.AppSettings["bddPath"];

            return Host.CreateDefaultBuilder(args)
                .ConfigureLogging((logging) =>
                {
                    logging.AddFilter("Microsoft.EntityFrameworkCore.Database.Command", LogLevel.Warning);
                })
                .ConfigureServices((_, services) =>
                    services
                    .AddTransient<Menu>()
                    .AddTransient<NewGame>()
                    .AddTransient<TurnAction>()
                    .AddTransient<Fight>()
                    .AddDataService(set));
        }
    }
}
