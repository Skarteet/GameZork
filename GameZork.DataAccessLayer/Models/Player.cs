using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.DataAccessLayer.Models
{
    public class Player : Fighter
    {
        public string Name { get; set; }

        public int XP { get; set; }
        public int Level { get; set; }
        public int NextLevelXpRequired { get; set; }

        public virtual ICollection<Weapon> Weapons { get; set; }
        public virtual ICollection<Item> Items { get; set; }

        public virtual Cell Cell { get; set; }
        public virtual Map Map { get; set;}
    }
}
