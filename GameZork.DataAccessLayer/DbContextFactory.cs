using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace GameZork.DataAccessLayer
{

    public class DbContextFactory : IDesignTimeDbContextFactory<GameZorkDbContext>
    {
        public GameZorkDbContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile($"{Directory.GetParent(Directory.GetCurrentDirectory())}\\appsettings.json", optional: false, reloadOnChange: true).Build();
            var dbContextBuilder = new DbContextOptionsBuilder<GameZorkDbContext>();
            dbContextBuilder.UseSqlServer(configuration.GetConnectionString("myDb1")/*"Server=localhost\\SQLEXPRESS;Database=ZorkDb;Trusted_Connection=True;"*/,
                opt => opt.MigrationsAssembly("GameZork.DataAccessLayer")).EnableSensitiveDataLogging();

            return new GameZorkDbContext(dbContextBuilder.Options);
        }
    }
}
