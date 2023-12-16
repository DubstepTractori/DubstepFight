using DubstepFight;
using DubstepFight.Core.Model.Attack;
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


        public Assasin() { Health = 75; Power = 20; Name = "Ассассин"; }

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
