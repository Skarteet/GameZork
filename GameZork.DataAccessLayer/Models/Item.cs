﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.DataAccessLayer.Models
{
    public class Item : BaseDataObject
    {
        public string Name { get; set; }
        public int? HpRestoreValue { get; set; }
        public int? AttackBoost{ get; set; }
        public int? DefenseBoost{ get; set; }
        public virtual ICollection<Player> Players { get; set; }
    }
}
