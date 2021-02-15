using GameZork.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.DataAccessLayer.AccessLayer
{
    public class MapAccessLayer : BaseAccessLayer<Map>
    {
        public MapAccessLayer(GameZorkDbContext context) : base(context)
        {

        }

        public void Remove(Map map)
        {
            this.context.Remove(map);
        }

    }
}
