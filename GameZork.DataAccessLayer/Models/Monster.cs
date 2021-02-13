using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.DataAccessLayer.Models
{
    public class Monster : Fighter
    {
        public string Name { get; set; }
        public int MissRate { get; set; }
        public int Rate { get; set; }
    }
}
