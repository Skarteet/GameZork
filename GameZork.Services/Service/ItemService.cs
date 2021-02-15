using GameZork.DataAccessLayer.AccessLayer;
using GameZork.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.Services.Service
{
    public class ItemService
    {
        private readonly ItemAccessLayer items;

        public ItemService(ItemAccessLayer itemAccessLayer)
        {
            this.items= itemAccessLayer;
        }

        public List<ItemDto> GetAll()
        {
            return this.items.GetCollection().Select(i => new ItemDto(i)).ToList();
        }
    }
}
