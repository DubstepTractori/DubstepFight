using DubstepFight;
using DubstepFight.Core.Model.Attack;
using DubstepFight.Core.Model.Fight;
using DubstepFight.Core.Model.Passive;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFightClassLibrary
{
    public class Assasin : BaseHero
    {


        /// <summary>
        /// класс асассина
        /// </summary>

        Random Rand = new Random();
        public Assasin() { Health = 75; Power = 20; Name = "Ассассин"; Passive = new Passive(0); Attack2CD = 3;
            Attack1ImgPath = @"..\..\Resources\Assassin\Assassin_Attack_1.jpg";
            Attack2ImgPath = @"..\..\Resources\Assassin\Assassin_Attack_2.jpg";
        }



        public override int Attack1()
        {
            Attack2CD -= 1;
            return Power;
        }

        public override int Attack2()
        {
            Attack2CD = 3;
            Passive.PassiveCounter1 += 2;
            return Convert.ToInt32(Power/2);
        }

        public override int TakeDamage(int takenDamage)
        {
            
            if (Rand.Next(0, 10) < 3)
            {
                return 0;
            }
            else
            {
                Health -= takenDamage;
                return takenDamage;
            }
        }

        public override int PassiveProc()
        {
            if (Passive.PassiveCounter1 > 0)
            {
                Passive.PassiveCounter1 -= 1;
                return Power / 2;
            }
            else
            {
                return 0;
            }
            
        }

        //public Assasin(List<AssasinAttack> attacks, List<AssasinPassive> passives) : this()
        //{
        //    Attacks = new List<BaseAttack>();
        //    Passives = new List<BasePassive>();
        //    foreach(AssasinAttack attack in attacks)
        //    {
        //        Attacks.Add(attack);
        //    }

        //    foreach(AssasinPassive passive in passives)
        //    { 
        //        Passives.Add(passive); 
        //    }

        //}
    }
}
