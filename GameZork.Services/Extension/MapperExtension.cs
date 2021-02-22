using AutoMapper;
using GameZork.DataAccessLayer.Models;
using GameZork.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.Services.Extension
{
    public static class MapperExtension
    {
        public static Mapper Mapper { get; set; }
        public static void InstantiateMapper()
        {
            var config = new MapperConfiguration(
                cfg => {
                    cfg.CreateMap<Weapon, WeaponDto>().ReverseMap();
                    cfg.CreateMap<Cell, CellDto>().ReverseMap();
                    cfg.CreateMap<Item, ItemDto>().ReverseMap();
                    cfg.CreateMap<Map, MapDto>()
                        .ForMember(dto => dto.Cells, act => act.MapFrom(src => src.Cells as List<CellDto>))
                        .ReverseMap();
                    cfg.CreateMap<Monster, MonsterDto>().ReverseMap();
                    cfg.CreateMap<Player, PlayerDto>()
                    .ForMember(dto => dto.Items, act => act.MapFrom(src => src.Items as List<ItemDto>))
                    .ForMember(dto => dto.Weapons, act => act.MapFrom(src => src.Weapons as List<WeaponDto>))
                    .ReverseMap().IgnoreNoMap();
                });
            Mapper = new Mapper(config);
        }
    }
}
