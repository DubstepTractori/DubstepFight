using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight.Core.Model.Attack
{
    public class PoisonAttack : AssasinAttack
    {
        public PoisonAttack() { Damage = 0; }

        /// <summary>
        /// атака с ядом урон которой постепенно возрастает на протяжении 4 ходов
        /// </summary>
        public override int Attack(int Power)
        {
            int poison = 2;
            poison = poison * 2;
            return poison;
        }
    }
}