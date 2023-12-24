using DubstepFight.Core.Model.Attack;
using DubstepFight.Core.Model.Fight;
using DubstepFight.Core.Model.Passive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
        Random random = new Random();
        public BlackKnight() { Health = 150; Power = 25; Name = "Тёмный Рыцарь"; Passive = new Passive(0); }

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

        public override int PassiveProc()
        {
            if(Health <= 75 && Health > 50)
            {
                if(random.Next(0,10) < 3)
                {
                    Health += 25;
                }
                return Convert.ToInt32(25 * 1.5);
            }
            else if (Health <= 50 && Health > 25)
            {
                if (random.Next(0, 10) < 5)
                {
                    Health += 25;
                }
                return Convert.ToInt32(25 * 1.5);
            }
            else if (Health <= 25)
            {
                if (random.Next(0, 10) < 7)
                {
                    Health += 25;
                }
                return Convert.ToInt32(25 * 1.5);
            }
            else
            {
                return 25;
            }
        }
    }
}
