using GameZork.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace GameZork.DataAccessLayer
{
    public class GameZorkDbContext : DbContext
    {
        public GameZorkDbContext(DbContextOptions<GameZorkDbContext> options)
               : base(options)
        {

        }

        public DbSet<Weapon> Weapons { get; set; }
    }
}
