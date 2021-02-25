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
                new Monster{Name = "Troll", Defense=10, HP=100, MaxHP=100, MissRate=20, Power= 40, Rate=3 },
                new Monster{Name = "Sanglier", Defense=0, HP=50, MaxHP=50, MissRate=20, Power= 10, Rate=1 },
                new Monster{Name = "Géant", Defense=20, HP=200, MaxHP=200, MissRate=50, Power= 60, Rate=5 },
                new Monster{Name = "Fenhrir", Defense = 50, HP = 500, MaxHP = 500, MissRate= 40, Power= 100, Rate = 10}
            };
        }
    }
}
