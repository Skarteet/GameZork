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
                new Weapon{Name = "Spear",Damage=10,MissRate=5}
            };
        }
    }
}
