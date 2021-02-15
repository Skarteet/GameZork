using GameZork.DataAccessLayer.AccessLayer;
using GameZork.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.Services.Service
{
    public class CellService
    {
        private readonly CellAccessLayer cells;

        public CellService(CellAccessLayer cellAccessLayer)
        {
            this.cells = cellAccessLayer;
        }

        public List<CellDto> GetAll()
        {
            return this.cells.GetCollection().Select(c => new CellDto(c)).ToList();
        }
    }
}
