using GameZork.Services.Service;
using System;
using System.Linq;

namespace GameZork
{
    public class test
    {
        private readonly WeaponsService WeaponsService;
        private readonly MonsterService MonstersService;
        private readonly CellService CellsService;
        private readonly ItemService ItemService;
        private readonly PlayerService PlayerService;
        public test(WeaponsService weaponsService
            , MonsterService monsterService
            , CellService cellService
            , ItemService itemService
            , PlayerService playerService
            )
        {
            this.WeaponsService = weaponsService;
            this.MonstersService = monsterService;
            this.CellsService = cellService;
            this.ItemService = itemService;
            this.PlayerService = playerService;
        }

        public void Start()
        {
            //var player = this.PlayerService.Get(1);
            //var weapon = this.WeaponsService.GetAll().First();
            //var item = this.ItemService.GetAll().First();
            //this.PlayerService.AddWeapon(player.Id, weapon.Id);
            //this.PlayerService.AddItem(player.Id, item.Id);
            //player = this.PlayerService.Get(1);
            //Console.WriteLine(player?.Name);
            //var weapons = this.WeaponsService.GetAll().FirstOrDefault();
            //var monster = this.MonstersService.GetAll().FirstOrDefault();
            //var cell = this.CellsService.GetAll().FirstOrDefault();
            ////var item = this.ItemService.GetAll().FirstOrDefault();
            //var objecType = this.ObjectTypeService.GetAll().FirstOrDefault();
            //var player = this.PlayerService.GetAll().FirstOrDefault();
            //Console.Clear();
            //Console.WriteLine(weapons?.Name);
            //Console.WriteLine(monster?.Name);
            //Console.WriteLine(cell?.PosX);
            ////Console.WriteLine(item?.Id);
            //Console.WriteLine(objecType?.Name);
            //Console.WriteLine(player?.Name);
        }
    }
}
