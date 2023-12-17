﻿using DubstepFight;
using DubstepFight.Core.Model.Attack;
using DubstepFight.Core.Model.Fight;
using DubstepFight.Core.Model.Passive;
using DubstepFight.Core.Model.Passivki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFightClassLibrary
{
    public class Elf : BaseHero
    {
        /// <summary>
        /// класс эльфа
        /// </summary>
        public Elf() { Health = 100; Power = 15; Name = "Эльф"; Passive = new Passive(0); }
        public override int Attack1()
        {
            return Power;
            Passive.PassiveCounter1 += 1;
        }

        public override int Attack2()
        {
            return Convert.ToInt32(20 + (6*Passive.PassiveCounter1));
            Passive.PassiveCounter1 = 0;
        }

        public override int PassiveProc()
        {
            return 0; // пассивка прописана выше
        }

        public override int TakeDamage(int takenDamage)
        {
            Health -= takenDamage;
            return takenDamage;
        }

    }
}
