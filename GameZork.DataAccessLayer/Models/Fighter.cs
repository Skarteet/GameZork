using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.DataAccessLayer.Models
{
    public abstract class Fighter : BaseDataObject
    {
        public int HP { get; set; }
        public int MaxHP { get; set; }
        public int Power { get; set; }
        public int Defense { get; set; }
    }
}
