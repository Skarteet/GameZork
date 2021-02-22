using GameZork.DataAccessLayer.Models;
using GameZork.Services.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.Services.Dto
{
    public class PlayerDto : FighterDto
    {
        public string Name { get; set; }

        public int XP { get; set; }
        public int Level { get; set; }
        public int NextLevelXpRequired { get; set; }

        public List<WeaponDto> Weapons { get; set; }

        public List<ItemDto> Items { get; set; }

        public CellDto Cell { get; set; }
        public MapDto Map { get; set; }

        public PlayerDto() { }

        public PlayerDto(Player player)
        {
            this.Id = player.Id;
            Name = player.Name;
            XP = player.XP;
            Level = player.Level;
            NextLevelXpRequired = player.NextLevelXpRequired;
            HP = player.HP;
            MaxHP = player.MaxHP;
            Power = player.Power;
            Defense = player.Defense;

            Weapons = player.Weapons?.Select(w => new WeaponDto(w))?.ToList();
            Items = player.Items?.Select(i => new ItemDto(i))?.ToList();

            Cell = player.Cell !=null ? new CellDto(player.Cell) :  null;
            Map = player.Map != null ? new MapDto(player.Map) : null;
        }
    }
}
