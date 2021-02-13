using GameZork.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.DataAccessLayer.Seeder
{
    public static class MonsterSeeder
    {
        public static List<Monster> Seed()
        {
            return new List<Monster>()
            {
                new Monster{Name = "Troll"}
            };
        }
    }
}
