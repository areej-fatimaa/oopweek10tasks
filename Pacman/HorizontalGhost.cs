using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class HorizontalGhost:Ghost
    {
        string Direction;
        public HorizontalGhost(char G, GameCell start) : base(G,start)
        {
            Direction = "left";
        }
        public override GameCell Move()
        {

            GameCell nextCell = CurrentCell.NextCell(GameDirection.Left);
            if (nextCell !=currentCell&&Direction=="left")
            {
                GameCell currentCell = CurrentCell;
                Console.SetCursorPosition(currentCell.y, currentCell.x);
                Console.Write(' ');
                CurrentCell = nextCell;
                Console.SetCursorPosition(CurrentCell.y, CurrentCell.x);
                Console.Write(DisplayCharacter);
            }
            else
            {
                Direction = "right";
                nextCell = CurrentCell.NextCell(GameDirection.Right);
                if (nextCell !=currentCell&&Direction=="right")
                {
                    currentCell = CurrentCell;
                    Console.SetCursorPosition(currentCell.y, currentCell.x);
                    Console.Write(' ');
                    CurrentCell = nextCell;
                    Console.SetCursorPosition(CurrentCell.y, CurrentCell.x);
                    Console.Write(DisplayCharacter);
                }
                else
                {
                    Direction = "left";
                }
            }

            return currentCell;
        }
    }
}
