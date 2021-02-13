using GameZork.Services.Service;
using System;
using System.Linq;

namespace GameZork
{
    public class test
    {
        private readonly WeaponsService WeaponsService;
        private readonly MonsterService MonstersService;
        public test(WeaponsService weaponsService
            , MonsterService monsterService)
        {
            this.WeaponsService = weaponsService;
            this.MonstersService = monsterService;
        }

        public void Start()
        {
            var weapons = this.WeaponsService.GetAll().FirstOrDefault();
            var monster = this.MonstersService.GetAll().FirstOrDefault();
            Console.Clear();
            Console.WriteLine(weapons?.Name);
            Console.WriteLine(monster?.Name);
        }
    }
}
