using AutoMapper;
using GameZork.DataAccessLayer.Extensions;
using GameZork.DataAccessLayer.Models;
using GameZork.DataAccessLayer.Seeder;
using GameZork.Services.Dto;
using GameZork.Services.Service;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GameZork.Services.Extension
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddDataService(this IServiceCollection services, string dbPath)
        {
            services.AddDataAccessLayerService(dbPath);
            services.AddScoped<WeaponsService>();
            services.AddScoped<MonsterService>();
            services.AddScoped<CellService>();
            services.AddScoped<ItemService>();
            services.AddScoped<ItemService>();
            services.AddScoped<PlayerService>();
            services.AddScoped<Seeder>();
            return services;
        }
    }
}
