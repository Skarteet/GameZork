using GameZork.DataAccessLayer.AccessLayer;
using GameZork.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameZork.Services.Service
{
    public  class WeaponsService
    {
        private readonly WeaponsAccessLayer weapons;
        public WeaponsService(WeaponsAccessLayer weaponsAccessLayer)
        {
            this.weapons = weaponsAccessLayer;
        }

        public List<WeaponDto> GetAll()
        {
            var res = this.weapons.GetCollection()?.ToList();
            return this.weapons.GetCollection().Select(w => new WeaponDto
            {
                Id = w.Id,
                Name = w.Name
            }).ToList();
        }
    }
}
