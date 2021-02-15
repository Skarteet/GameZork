using GameZork.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.Services.Dto
{
    public class MonsterDto : FighterDto
    {
        public string Name { get; set; }
        public int MissRate { get; set; }
        public int Rate { get; set; }

        public MonsterDto() { }
        public MonsterDto(Monster monster)
        {
            this.Id = monster.Id;
            Name = monster.Name;
            MissRate = monster.MissRate;
            Rate = monster.Rate;
            HP = monster.HP;
            MaxHP = monster.MaxHP;
            Power = monster.Power;
            Defense = monster.Defense;
        }

    }
}
