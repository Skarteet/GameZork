using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.DataAccessLayer.Models
{
    public class Map : BaseDataObject
    {
        public virtual ICollection<Cell> Cells { get; set; }
    }
}
