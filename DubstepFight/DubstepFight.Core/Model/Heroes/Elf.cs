using DubstepFight;
using DubstepFight.Core.Model.Attack;
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
        public Elf() 
        {

            Health = 100;
            Power = 15;
            Name = "Эльф";
        }
        public Elf(List<ElfAttack> attacks, List<ElfPassive> passives) : this()
        {
            Attacks = new List<BaseAttack>();
            Passives = new List<BasePassive>();
            foreach (ElfAttack attack in attacks)
            {
                Attacks.Add(attack);
            }

            foreach (ElfPassive passive in passives)
            {
                Passives.Add(passive);
            }

        }
    }
}
