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

        public BlackKnight(List<BlackKnightAttack> attacks, List<BlackkingPassive> passives) : this()
        {
            Attacks = new List<BaseAttack>();
            Passives = new List<BasePassive>();
            foreach (BlackKnightAttack attack in attacks)
            {
                Attacks.Add(attack);
            }

            foreach (BlackkingPassive passive in passives)
            {
                Passives.Add(passive);
            }

        }
    }
}
