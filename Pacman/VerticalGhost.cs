using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class VerticalGhost:Ghost
    {
        string Direction;
        public VerticalGhost(char G, GameCell start) : base(G, start)
        {
            Direction = "up";
        }
        public override GameCell Move()
        {
            GameCell nextCell = CurrentCell.NextCell(GameDirection.Up);
            if (nextCell != currentCell && Direction == "up")
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
                Direction = "down";
                nextCell = CurrentCell.NextCell(GameDirection.Down);
                if (nextCell != currentCell && Direction == "down")
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
                    Direction = "up";
                }
            }

            return currentCell;
            return currentCell;
        }
    }
}
