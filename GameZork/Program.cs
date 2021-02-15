using GameZork.DataAccessLayer.Seeder;
using GameZork.Services.Extension;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading.Tasks;
using GameZork.MenuParts;


namespace GameZork
{
    class Program 
    {
        private static Menu Menu { get; set; }
        static Task Main(string[] args)
        {
            var mapper = ServicesExtension.InstantiateMapper();

            using IHost host = CreatHostBuilder(args).Build().SeedDatabase();
            var run = host.RunAsync();

            Globals.Services = host.Services;

            Menu = host.Services.GetService<Menu>();
            Menu.Exit += (o, e) => host.StopAsync();

            Menu.Start();




            //var test = host.Services.GetService<test>();
            //test.exit += (o, e) => host.StopAsync();
            //test.Start();

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
                    services.AddTransient<test>()
                    .AddTransient<Menu>()
                    .AddTransient<NewGame>()
                    .AddDataService());
        }
    }
}
