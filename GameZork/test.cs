using GameZork.Services;
using System;
using System.Linq;

namespace GameZork
{
    public class test
    {
        private readonly WeaponsService WeaponsService;
        public test(WeaponsService weaponsService)
        {
            this.WeaponsService = weaponsService;
        }

        public void Start()
        {
            var weapons = this.WeaponsService.GetAll().FirstOrDefault();
            Console.WriteLine(weapons.Name);
        }
    }
}
