using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class SmartGhost:Ghost
    {
        string Direction;
        GameCell player;
        public SmartGhost(char G, GameCell start,GameCell targetplayer) : base(G, start)
        {
            player = targetplayer;
        }
        public override GameCell Move()
        {
            int ghostX = currentCell.x;
            int ghostY = currentCell.y;
            int playerX = player.x;
            int playerY = player.y;

            int diffX = playerX - ghostX;
            int diffY = playerY - ghostY;
            if(Math.Abs(diffX)>Math.Abs(diffY))
            {
                GameCell nextCell = CurrentCell.NextCell(GameDirection.Left);
                if (nextCell != currentCell && Direction == "left")
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
                    if (nextCell != currentCell && Direction == "right")
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
            }
            return currentCell;
        }
    }
}
