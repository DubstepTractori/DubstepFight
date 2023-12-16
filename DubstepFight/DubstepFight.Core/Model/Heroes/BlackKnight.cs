using DubstepFight.Core.Model.Attack;
using DubstepFight.Core.Model.Passive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight
{
    public class BlackKnight : BaseHero
    {
        /// <summary>
        /// класс темного рыцаря
        /// </summary>
        public BlackKnight() { Health = 150; Power = 25; Name = "Темный Рыцарь"; }

        public override int Attack1()
        {
            return Power;
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
