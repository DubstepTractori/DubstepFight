using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight.Core.Model.Attack
{
    public class ElfAttack : BaseAttack
    {
        /// <summary>
        /// Дефолтная тычка Эльфа
        /// </summary>


        
        public ElfAttack() { Damage = 0; }

        

        public override int Attack(int Power)
        {
            int Damage = Power / 3;
            return Damage;
        }

    }
}
