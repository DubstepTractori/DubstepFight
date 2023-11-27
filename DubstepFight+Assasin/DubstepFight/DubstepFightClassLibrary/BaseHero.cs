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
    }


}
