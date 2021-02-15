using GameZork.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.Services.Dto
{
    public class CellDto : BaseDto
    {
        public int PosX { get; set; }
        public int PosY { get; set; }
        public bool CanMoveTo { get; set; }
        public string Description { get; set; }

        public CellDto() { }

        public CellDto(Cell cell)
        {
            this.Id = cell.Id;
            PosX = cell.PosX;
            PosY = cell.PosY;
            CanMoveTo = cell.canMoveTo;
            Description = cell.Description;
        }
        public CellDto(int id ,int posX, int posY, bool canMoveTo, string description)
        {
            this.Id = id;
            PosX = posX;
            PosY = posY;
            CanMoveTo = canMoveTo;
            Description = description;
        }
    }
}
