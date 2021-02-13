using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.DataAccessLayer.Models
{
    public class Cell : BaseDataObject
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public bool canMoveTo { get; set; }
        public string Description { get; set; }
    }
}
