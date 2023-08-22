using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class GameCell
    {
        public int X;
        public int Y;
        public GameObject CurrentGameObject;
       public GameGrid gameGrid;
        public GameCell(int x,int y,GameGrid gameGrid)
        {
            this.X = x;
            this.Y = y;
            this.gameGrid = gameGrid;
        }
        public GameCell NextCell(GameDirection direction)
        {
            if(direction==GameDirection.Left)
            {
                if (this.Y > 0)
                {
                    GameCell nextCell = gameGrid.GetCell(this.X, this.Y - 1);
                    if (nextCell.CurrentGameObject.GameObjectType != GameObjectType.Wall)
                    {
                        return nextCell;
                    }
                }
            }
            if (direction == GameDirection.Right)
            {
                if (this.Y <gameGrid.ColSize-1)
                {
                    GameCell nextCell = gameGrid.GetCell(this.X, this.Y + 1);
                    if (nextCell.CurrentGameObject.GameObjectType != GameObjectType.Wall)
                    {
                        return nextCell;
                    }
                }
            }
            if (direction == GameDirection.Up)
            {
                if (this.X > 0)
                {
                    GameCell nextCell = gameGrid.GetCell(this.X-1, this.Y);
                    if (nextCell.CurrentGameObject.GameObjectType != GameObjectType.Wall)
                    {
                        return nextCell;
                    }
                }
            }
            if (direction == GameDirection.Down)
            {
                if (this.X < gameGrid.RowSize-1)
                {
                    GameCell nextCell = gameGrid.GetCell(this.X+1, this.Y);
                    if (nextCell.CurrentGameObject.GameObjectType != GameObjectType.Wall)
                    {
                        return nextCell;
                    }
                }
            }
            return this;
        }
        public int x { get => X; set => X = value; }
        public int y { get => Y; set => Y = value; }
        public GameObject currentGameObject { get => CurrentGameObject; set => CurrentGameObject = value; }

    }
}
