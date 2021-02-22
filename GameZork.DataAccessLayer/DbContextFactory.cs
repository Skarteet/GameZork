namespace GameZork.DataAccessLayer
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;

    public class DbContextFactory : IDesignTimeDbContextFactory<GameZorkDbContext>
    {
        public GameZorkDbContext CreateDbContext(string[] args)
        {
            var dbContextBuilder = new DbContextOptionsBuilder<GameZorkDbContext>();

            dbContextBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS; Database=ZorkDb; Trusted_Connection=true;",
                opt => opt.MigrationsAssembly("GameZork.DataAccessLayer")).EnableSensitiveDataLogging();

            return new GameZorkDbContext(dbContextBuilder.Options);
        }
    }
}
