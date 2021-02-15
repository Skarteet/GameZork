using AutoMapper;
using GameZork.DataAccessLayer.Extensions;
using GameZork.DataAccessLayer.Models;
using GameZork.DataAccessLayer.Seeder;
using GameZork.Services.Dto;
using GameZork.Services.Service;
using Microsoft.Extensions.DependencyInjection;

namespace GameZork.Services.Extension
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddDataService(this IServiceCollection services)
        {
            services.AddDataAccessLayerService();
            services.AddScoped<WeaponsService>();
            services.AddScoped<MonsterService>();
            services.AddScoped<CellService>();
            services.AddScoped<ItemService>();
            services.AddScoped<ItemService>();
            services.AddScoped<PlayerService>();
            services.AddScoped<Seeder>();
            return services;
        }

        public static Mapper InstantiateMapper()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Weapon, WeaponDto>()
                .ReverseMap());
            var mapper = new Mapper(config);

            var weapondto = mapper.Map<WeaponDto>(new Weapon { Damage = 1, Id = 1, MissRate = 2, Name = "Spear" });
            var weapon = mapper.Map<Weapon>(new WeaponDto { Damage = 1, Id = 1, MissRate = 2, Name = "Spear" });
            return new Mapper(config);
        }
    }
}
