using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Pacman
{
    class GameGrid
    {
        public GameCell[,] maze;
        public int RowSize;
        public int ColSize;
        public GameGrid(int rowSize, int colSize, string path)
        {
            this.RowSize = rowSize;
            this.ColSize = colSize;
            maze = new GameCell[rowSize, colSize];
            LoadFile(path);
        }
        public  GameCell[,] GetMaze()
        {
            return maze;
        }
        private void  LoadFile(string path)
        {
            StreamReader fp = new StreamReader(path);
            string record;
            for (int i = 0; i < RowSize; i++)
            {
                record = fp.ReadLine();
                for (int x = 0; x < ColSize; x++)
                {
                    GameCell gameCell = new GameCell(i, x, this);
                    Char value = record[x];
                    GameObjectType type = GameObject.GetGetGameObject(value.ToString());
                    gameCell.currentGameObject = new GameObject(type, value);
                    gameCell.currentGameObject.CurrentCell = gameCell;
                    maze[i,x] = gameCell;

                }
            }
            fp.Close();
        }
        public GameCell GetCell(int x, int y)
        {
            return maze[x,y];
        }
    }
}
