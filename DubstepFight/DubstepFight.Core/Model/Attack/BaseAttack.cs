using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DubstepFight.Core.Model.Attack
{
    public abstract class BaseAttack
    {

        /// <summary>
        /// базовый класс для атак
        /// </summary>
        int damage;
        public int Damage
        {
            get
            { return damage; }
            set
            { damage = value; }
        }
        public BaseAttack() { damage = 0; }

        public abstract int Attack(int Power);
        
    }
}
