using DubstepFight;
using DubstepFight.Core.Model.Attack;
using DubstepFight.Core.Model.Fight;
using DubstepFight.Core.Model.Passive;
using DubstepFight.Core.Model.Passivki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFightClassLibrary
{
    public  class Giant : BaseHero
    {
        /// <summary>
        /// класс гиганта
        /// </summary>
        public Giant() { Health = 200; Power = 20; Name = "Гигант"; Attack2CD = 2;
            Attack1ImgPath = @"..\..\Resources\Other\NoIcon.png";
            Attack2ImgPath = @"..\..\Resources\Other\NoIcon.png";
        }
        public override int Attack1()
        {
            return Power;
        }

        public override int PassiveProc()
        {
            Attack2CD -= 1;
            return 0; //нет особой пассивки
        }
        public override int Attack2()
        {
            Attack2CD = 2;
            return Convert.ToInt32(Power * 1.3);
        }

        public override int TakeDamage(int takenDamage)
        {
            Health -= Convert.ToInt32(takenDamage * 0.8);
            return Convert.ToInt32(takenDamage*0.8);   
        }
    }
}
