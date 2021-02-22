using GameZork.DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZork.DataAccessLayer.AccessLayer
{
    public class CellAccessLayer : BaseAccessLayer<Cell>
    {
        public CellAccessLayer(GameZorkDbContext context) : base(context)
        {

        }

        public Cell AddCell(Cell cell)
        {
            return this.context.Cell.Add(cell)?.Entity;
        }

        public void Save(Cell cell)
        {
            var cellBase = this.context.Cell.Find(cell.Id);

            cellBase.canMoveTo = cell.canMoveTo;
            cellBase.Description = cell.Description;
            cellBase.PosX = cell.PosX;
            cellBase.PosY = cell.PosY;

            this.context.Cell.Update(cellBase);
            this.context.SaveChanges();
        }
    }
}
