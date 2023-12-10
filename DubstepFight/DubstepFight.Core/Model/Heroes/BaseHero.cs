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
        private List<BaseAttack> _attacks;
        private List<BasePassive> _passives;

        /// <summary>
        /// базовый класс героя
        /// </summary>
        public BaseHero() { Health = 0; Power = 0; Name = "NoName"; }

        protected BaseHero(List<BaseAttack> attacks, List<BasePassive> passives) : this()
        {
            _attacks = attacks;
            _passives = passives;
        }

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

        public List<BaseAttack> Attacks { get => _attacks; set => _attacks = value; }
        public List<BasePassive> Passives { get => _passives; set => _passives = value; }
    }


}
