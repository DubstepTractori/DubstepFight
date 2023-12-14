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
        int dexterity;
        public int Dexterity
        {
            get
            { return dexterity; }
            set
            { dexterity = value; }
        }


        public Assasin() { Health = 75; Power = 20; Dexterity = 1; Name = "Асассин"; }

        public Assasin(List<AssasinAttack> attacks, List<AssasinPassive> passives) : this()
        {
            Attacks = new List<BaseAttack>();
            Passives = new List<BasePassive>();
            foreach(AssasinAttack attack in attacks)
            {
                Attacks.Add(attack);
            }

            foreach(AssasinPassive passive in passives)
            { 
                Passives.Add(passive); 
            }

        }
    }
}
