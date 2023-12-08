using DubstepFight;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFightClassLibrary
{
    public class Asssasin : BaseHero
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
        public Asssasin() { Health = 75; Power = 20; Dexterity = 1; Name = "Асассин"; }
    }
}
