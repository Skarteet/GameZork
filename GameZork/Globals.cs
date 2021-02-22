using GameZork.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork
{
    public static class Globals
    {
        public static IServiceProvider Services { get; set; }

        public static PlayerDto Player { get; set; }

        public static EventHandler Exit { get; set; }
    }
}
