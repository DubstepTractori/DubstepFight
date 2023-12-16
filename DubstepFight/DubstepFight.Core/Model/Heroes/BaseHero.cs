using DubstepFight.Core.Model.Attack;
using DubstepFight.Core.Model.Passive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight
{
    public abstract class BaseHero
    {
        private int health;
        private int power;
        private string name;


        /// <summary>
        /// базовый класс героя
        /// </summary>
        public BaseHero() { Health = 0; Power = 0; Name = "NoName"; }

        public abstract int Attack1();
        public abstract int Attack2();

        public abstract int TakeDamage(int takenDamage);

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
