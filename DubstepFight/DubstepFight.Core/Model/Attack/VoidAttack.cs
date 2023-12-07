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
        public int Attack(int Power)  //темнота поглощая рыцаря наносит доп урон
        {
            Power -= 5;
            int Attack = Power / 2;//значение атаки и его расчеты
            return Attack;
        }
    }
}
