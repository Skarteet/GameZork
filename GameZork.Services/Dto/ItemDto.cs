using GameZork.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.Services.Dto
{
    public class ItemDto : BaseDto
    {
        public string Name { get; set; }
        public int? HpRestoreValue { get; set; }
        public int? AttackBoost { get; set; }
        public int? DefenseBoost { get; set; }

        public ItemDto() { }
        public ItemDto(Item item) 
        {
            this.Id = item.Id;
            Name = item.Name;
            HpRestoreValue = item.HpRestoreValue;
            AttackBoost = item.AttackBoost;
            DefenseBoost = item.DefenseBoost;
        }
    }
}
