using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class GameObject
    { 
      public  char  displayCharacter;
        public GameCell currentCell;
        public GameObjectType gt;
        public GameObject(GameObjectType type,char DisplayCharacter)
        {
            this.gt = type;
            this.displayCharacter = DisplayCharacter;
        }
        public static GameObjectType GetGetGameObject(string DisplayCharacter)
        {
            if (DisplayCharacter == "|" || DisplayCharacter == "%" || DisplayCharacter == "#")
            {
                return GameObjectType.Wall;
            }
            else if(DisplayCharacter=="P")
            {
                return GameObjectType.Player;
            }
            else if(DisplayCharacter=="G")
            {
                return GameObjectType.Enemy;
            }
           else  if(DisplayCharacter==".")
            {
                return GameObjectType.Reward;
            }
           else 
           {
                return GameObjectType.None;
           }
        }
        public char DisplayCharacter { get => displayCharacter; set => displayCharacter = value; }
        public GameObjectType GameObjectType { get => gt; set => gt = value; }
        public  GameCell CurrentCell
        {
            get => currentCell;
            set
            {
                currentCell = value;
                currentCell.currentGameObject = this;
            }

        }
    }
}
