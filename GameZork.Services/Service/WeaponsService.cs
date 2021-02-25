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
            return this.weapons.GetCollection().Select(w => new WeaponDto(w)).ToList();
        }

        public WeaponDto GetRandom()
        {
            var weapons = GetAll();
            return weapons.ElementAt(new Random().Next(0, weapons.Count));
        }
    }
}
