using GameZork.DataAccessLayer.Models;
using GameZork.Services.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.Services.Dto
{
    public class MapDto : BaseDto
    {
        public List<CellDto> Cells { get; set; }

        public MapDto(Map map)
        {
            Cells = map.Cells.Select(c => new CellDto(c)).ToList();
        }
    }
}
