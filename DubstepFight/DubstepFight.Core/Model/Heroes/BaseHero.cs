using DubstepFight.Core.Model.Attack;
using DubstepFight.Core.Model.Fight;
using DubstepFight.Core.Model.Passive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight
{
    public abstract class BaseHero
    {
        private int health;
        private int power;
        private string name;
        private Passive passive;
        private int kdTwoAttack;


        /// <summary>
        /// базовый класс героя
        /// </summary>
        public BaseHero() { Health = 0; Power = 0; Name = "NoName"; Passive = new Passive(0); KDTwoAttack = 1; }

        public abstract int Attack1();
        public abstract int Attack2();

        public abstract int TakeDamage(int takenDamage);

        public abstract int PassiveProc();

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
        public int KDTwoAttack
        {
            get
            { return kdTwoAttack; }
            set
            { kdTwoAttack = value; }
        }

        public string Name
        {
            get
            { return name; }
            set
            { name = value; }
        }

        public Passive Passive
        {
            get
            { return passive; }
            set
            { passive = value; }
        }

         
    }


}
