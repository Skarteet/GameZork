using GameZork.DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
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
        public Player CreatePlayer(Player player)
        {
            var entry = context.Player.Add(player);
            context.SaveChanges();

            return entry.Entity;
        }

        public void Remove(int id)
        {
            var p = GetPlayer(id);
            context.Player.Remove(p);
            context.SaveChanges();
        }
        public Player GetPlayer(int id)
        {
            var player = context.Player.Single(p => p.Id == id);

            context.Entry(player).Collection(p => p.Weapons).Load();
            context.Entry(player).Collection(p => p.Items).Load();
            context.Entry(player).Reference(p => p.Map).Load();
            context.Entry(player.Map).Collection(m => m.Cells).Load();
            return player;
        }

        public void AddWeapon(int idPlayer, int idWeapon)
        {
            var player = context.Player.Single(p => p.Id == idPlayer);
            var weapon = context.Weapons.Single(w => w.Id == idWeapon);

            player.Weapons.Add(weapon);
            context.SaveChanges();
        }

        public void AddItem(int idPlayer,int idItem)
        {
            var player = context.Player.Single(p => p.Id == idPlayer);
            var item = context.Item.Single(i => i.Id == idItem);

            player.Items.Add(item);
            context.SaveChanges();
        }

        public void Save(Player player)
        {
            context.Player.Update(player);
            context.SaveChanges();
        }
    }
}
