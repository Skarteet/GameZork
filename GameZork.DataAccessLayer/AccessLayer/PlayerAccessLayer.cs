using GameZork.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.DataAccessLayer.AccessLayer
{
    public class PlayerAccessLayer : BaseAccessLayer<Player>
    {
        public PlayerAccessLayer (GameZorkDbContext context): base(context)
        {

        }
    }
}
