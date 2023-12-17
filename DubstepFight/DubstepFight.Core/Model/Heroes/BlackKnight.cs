using DubstepFight.Core.Model.Attack;
using DubstepFight.Core.Model.Fight;
using DubstepFight.Core.Model.Passive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight
{
    public class BlackKnight : BaseHero
    {
        /// <summary>
        /// класс темного рыцаря
        /// </summary>
        /// 
        public BlackKnight() { Health = 150; Power = 25; Name = "Тёмный Рыцарь"; Passive = new Passive(0); }

        public override int Attack1()
        {
            if(Health>=Convert.ToInt32(Health/2))
            {
                return Power;
            }
            else
            {
                return Power + Convert.ToInt32(Power * 0.2);
            }
        }

        public override int Attack2()
        {
            return Convert.ToInt32(Power * 1.3);
        }

        public override int TakeDamage(int takenDamage)
        {
            Health -= takenDamage;
            return takenDamage;
        }
    }
}
