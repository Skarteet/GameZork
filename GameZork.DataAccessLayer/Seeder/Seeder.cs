using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.DataAccessLayer.Seeder
{
    public class Seeder
    {
        private readonly GameZorkDbContext dbContext;

        public Seeder(GameZorkDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task EnsureSeedDataAsync()
        {
            if (!this.dbContext.Weapons.Any())
            {
                await this.dbContext.Weapons.AddRangeAsync(WeaponSeeder.Seed()).ConfigureAwait(false);
            }

            if (!this.dbContext.Monster.Any())
            {
                await this.dbContext.Monster.AddRangeAsync(MonsterSeeder.Seed()).ConfigureAwait(false);
            }

            if (!this.dbContext.Item.Any())
            {
                await this.dbContext.Item.AddRangeAsync(ItemSeeder.Seed()).ConfigureAwait(false);
            }

            await this.dbContext.SaveChangesAsync();
        }
    }
}
