using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class PacmanPlayer:GameObject
    {
        public PacmanPlayer(char p, GameCell start):base(GameObjectType.Player, p)
        {
            this.CurrentCell = start;
        }
        public GameCell Move(GameDirection direction)
        {
            return this.CurrentCell.NextCell(direction);
        }
    }
}
