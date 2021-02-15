using GameZork.DataAccessLayer.Models;

namespace GameZork.Services.Dto
{
    public class WeaponDto : BaseDto
    {
        public string Name { get; set; }
        public int MissRate { get; set; }
        public int Damage { get; set; }

        public WeaponDto() { }

        public WeaponDto(Weapon weapon)
        {
            this.Id = weapon.Id;
            Name = weapon.Name;
            MissRate = weapon.MissRate;
            Damage = weapon.Damage;
        }
        public WeaponDto(int id ,string name, int missRate, int damage)
        {
            this.Id = id;
            Name = name;
            MissRate = missRate;
            Damage = damage;
        }
    }
}
