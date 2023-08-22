using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
     abstract class Ghost:GameObject
    {
        public Ghost(char G, GameCell start) : base(GameObjectType.Enemy, G)
        {
            this.CurrentCell = start;
        }
         public abstract GameCell Move();

    }
}
