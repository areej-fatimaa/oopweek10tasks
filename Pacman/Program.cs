using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using EZInput;
using System.Threading.Tasks;

namespace Pacman
{
    class Game
    { 
    static void Main(string[] args)
    {
            List<Ghost> GhostList = new List<Ghost>();
        GameGrid grid = new GameGrid(24, 70, "maze.txt");
        GameCell start = new GameCell(12, 22, grid);
        PacmanPlayer pacman = new PacmanPlayer('p', start);
            start.currentGameObject = pacman;
            pacman.CurrentCell = start;
        printMaze(grid);
        printGameObject(pacman);
            //////////////horizontal ghost///////////////////
            GameCell startHG = new GameCell(12, 22, grid);
            HorizontalGhost HG = new HorizontalGhost('G', startHG);
            startHG.currentGameObject = HG;
            HG.CurrentCell = startHG;
            GhostList.Add(HG);
            /////////////////////////////////////////vertical ghost////////////////////////
            GameCell startVG = new GameCell(3, 2, grid);
            VerticalGhost VG = new VerticalGhost('G', startVG);
            startVG.currentGameObject = VG;
            VG.CurrentCell = startVG;
            GhostList.Add(VG);
            /////////////////////random ghost///////////////////////
            GameCell startRG = new GameCell(22, 20, grid);
            RandomGhost RG = new RandomGhost('G', startRG);
            startVG.currentGameObject = RG;
            RG.CurrentCell = startRG;
            GhostList.Add(RG);
            ////////////////smart ghost/////////////////////
            GameCell startSG = new GameCell(22, 10, grid);
           SmartGhost SG = new SmartGhost('G', startSG,start);
            startSG.currentGameObject = SG;
            SG.CurrentCell = startSG;
            GhostList.Add(SG);
        bool gameRunning = true;
        while (gameRunning)
        {
                foreach(Ghost ghost in GhostList)
                {
                    ghost.Move();
                }
            Thread.Sleep(90);
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                moveGameObject(pacman, GameDirection.Up);
            }

            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                moveGameObject(pacman, GameDirection.Down);
            }

            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                moveGameObject(pacman, GameDirection.Right);
            }

            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                moveGameObject(pacman, GameDirection.Left);
            }
        }
    }
    static void clearGameCellContent(GameCell gameCell, GameObject newGameObject)
    {
        gameCell.currentGameObject = newGameObject;
        Console.SetCursorPosition(gameCell.y, gameCell.x);
        Console.Write(newGameObject.DisplayCharacter);

    }
    static void printGameObject(GameObject gameObject)
    {
        Console.SetCursorPosition(gameObject.CurrentCell.y, gameObject.CurrentCell.x);
        Console.Write(gameObject.DisplayCharacter);

    }

    static void moveGameObject(GameObject gameObject, GameDirection direction)
    {
        GameCell nextCell = gameObject.CurrentCell.NextCell(direction);
        if (nextCell != null)
        {
            GameObject newGO = new GameObject(GameObjectType.None, ' ');
            GameCell currentCell = gameObject.CurrentCell;
            clearGameCellContent(currentCell, newGO);
            gameObject.CurrentCell = nextCell;
            printGameObject(gameObject);
        }
    }

    static void printMaze(GameGrid grid)
    {
        for (int x = 0; x < grid.RowSize; x++)
        {
            for (int y = 0; y < grid.ColSize; y++)
            {
                GameCell cell = grid.GetCell(x, y);
                printCell(cell);
            }

        }
    }

    static void printCell(GameCell cell)
    {
        Console.SetCursorPosition(cell.y, cell.x);
        Console.Write(cell.currentGameObject.DisplayCharacter);
    }
}
}
