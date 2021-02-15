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
        public DbSet<Cell> Cell { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Monster> Monster { get; set; }
        public DbSet<Map> Map { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
