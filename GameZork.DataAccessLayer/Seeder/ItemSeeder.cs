using GameZork.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.DataAccessLayer.Seeder
{
    public static class ItemSeeder
    {
        public static List<Item> Seed()
        {
            return new List<Item>()
            {
                new Item{Name = "Life potion", HpRestoreValue=50},
                new Item{Name = "Attack potion", AttackBoost=15},
                new Item{Name = "Defense potion", DefenseBoost=20}
            };
        }
    }
}
