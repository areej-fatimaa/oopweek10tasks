using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class RandomGhost:Ghost
    {
        public RandomGhost(char G, GameCell start) : base(G, start)
        {
        }
        static int ghostDirection()
        {
            Random r = new Random();
            int value = r.Next(4);
            return value;
        }
        public override GameCell Move()
        {
            int value = ghostDirection();
            if(value==0)
            {
                GameCell nextCell = CurrentCell.NextCell(GameDirection.Left);
                if (nextCell != currentCell)
                {
                    GameCell currentCell = CurrentCell;
                    Console.SetCursorPosition(currentCell.y, currentCell.x);
                    Console.Write(' ');
                    CurrentCell = nextCell;
                    Console.SetCursorPosition(CurrentCell.y, CurrentCell.x);
                    Console.Write(DisplayCharacter);
                }
            }
            else if(value==1)
            {
                 GameCell  nextCell = CurrentCell.NextCell(GameDirection.Right);
                if (nextCell != currentCell)
                {
                    currentCell = CurrentCell;
                    Console.SetCursorPosition(currentCell.y, currentCell.x);
                    Console.Write(' ');
                    CurrentCell = nextCell;
                    Console.SetCursorPosition(CurrentCell.y, CurrentCell.x);
                    Console.Write(DisplayCharacter);
                }
            }
            else if(value==2)
            {
                GameCell nextCell = CurrentCell.NextCell(GameDirection.Up);
                if (nextCell != currentCell)
                {
                    GameCell currentCell = CurrentCell;
                    Console.SetCursorPosition(currentCell.y, currentCell.x);
                    Console.Write(' ');
                    CurrentCell = nextCell;
                    Console.SetCursorPosition(CurrentCell.y, CurrentCell.x);
                    Console.Write(DisplayCharacter);
                }
            }
            else if(value==3)
            {
               GameCell nextCell = CurrentCell.NextCell(GameDirection.Down);
                if (nextCell != currentCell)
                {
                    currentCell = CurrentCell;
                    Console.SetCursorPosition(currentCell.y, currentCell.x);
                    Console.Write(' ');
                    CurrentCell = nextCell;
                    Console.SetCursorPosition(CurrentCell.y, CurrentCell.x);
                    Console.Write(DisplayCharacter);
                }
            }
            return currentCell;
        }

    }
}
