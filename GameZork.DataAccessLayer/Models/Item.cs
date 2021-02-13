using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.DataAccessLayer.Models
{
    public class Item : BaseDataObject
    {
        public virtual ObjectType ObjectType { get; set; }
    }
}
