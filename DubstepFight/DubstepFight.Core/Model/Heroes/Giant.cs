using DubstepFight;
using DubstepFight.Core.Model.Attack;
using DubstepFight.Core.Model.Passive;
using DubstepFight.Core.Model.Passivki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFightClassLibrary
{
    internal class Giant : BaseHero
    {
        /// <summary>
        /// класс гиганта
        /// </summary>
        public Giant()
        {
            Health = 200; //Статы
            Power = 20; // гиганта
            Name = "Гигант";
        }
        public Giant(List<GiantAttack> attacks, List<GiantPassive> passives) : this()
        {
            Attacks = new List<BaseAttack>();
            Passives = new List<BasePassive>();
            foreach (GiantAttack attack in attacks)
            {
                Attacks.Add(attack);
            }

            foreach (GiantPassive passive in passives)
            {
                Passives.Add(passive);
            }

        }
    }
}
