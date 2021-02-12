using GameZork.DataAccessLayer.Models;

namespace GameZork.DataAccessLayer.AccessLayer
{
    public class WeaponsAccessLayer : BaseAccessLayer<Weapon>
    {
        public WeaponsAccessLayer(GameZorkDbContext context): base(context)
        {

        }
    }
}
