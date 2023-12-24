using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight.Core.Model.Attack
{
    public class VoidAttack : BlackKnightAttack
    {
        public VoidAttack() { Damage = 0; }
        /// <summary>
        /// //темнота поглощая рыцаря наносит доп урон
        /// </summary>

        public int Attack(int Power)
        {
            int Attack = Power;
            Power -= 5;
            return Attack;
        }
    }
}
