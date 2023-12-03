using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight
{
    public class BaseHero
    {
        private int health;
        private int power;
        private string name;
        public BaseHero() { Health = 0; Power = 0; Name = "NoName"; }
        public int Health
        {
            get
            { return health;}
            set
            { health = value;}
        }

        public int Power
        {
            get
            { return power;}
            set
            { power = value; }
        }

        public string Name
        {
            get
            { return name; }
            set
            { name = value; }
        }
    }


}
