
using GameZork.Services.Dto;
using Microsoft.Extensions.Configuration;
using System;

namespace GameZork
{
    public static class Globals
    {
        public static IServiceProvider Services { get; set; }

        public static PlayerDto Player { get; set; }

        public static EventHandler Exit { get; set; }
 
    }
}
