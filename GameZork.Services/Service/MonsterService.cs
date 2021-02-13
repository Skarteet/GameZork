﻿using GameZork.DataAccessLayer.AccessLayer;
using GameZork.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.Services.Service
{
    public class MonsterService
    {
        private readonly MonsterAccessLayer monsters;

        public MonsterService(MonsterAccessLayer monsterAccessLayer)
        {
            monsters = monsterAccessLayer;
        }

        public List<MonsterDto> GetAll()
        {
            return this.monsters.GetCollection().Select(m => new MonsterDto
            {
                Id = m.Id,
                Name = m.Name
            }).ToList();
        }
    }
}
