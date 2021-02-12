using GameZork.Services.Extension;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace GameZork
{
    class Program
    {
        static Task Main(string[] args)
        {
            using IHost host = CreatHostBuilder(args).Build();
            var run = host.RunAsync();

            var test = host.Services.GetService<test>();
            test.Start();

            return run;

        }

        static IHostBuilder CreatHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((_, services) => 
                    services.AddTransient<test>().AddDataService());
    }
}
