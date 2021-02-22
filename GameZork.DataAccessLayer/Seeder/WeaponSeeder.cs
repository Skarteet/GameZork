using GameZork.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.DataAccessLayer.Seeder
{
    public static class WeaponSeeder
    {
        public static List<Weapon> Seed()
        {
            return new List<Weapon>
            {
                new Weapon{Name = "Lance",Damage=40,MissRate=10},
                new Weapon{Name = "Poing",Damage=20,MissRate=5},
                new Weapon{Name = "Epée",Damage=30,MissRate=5},
                new Weapon{Name = "Marteau",Damage=60,MissRate=20},  
            };
        }
    }
}
