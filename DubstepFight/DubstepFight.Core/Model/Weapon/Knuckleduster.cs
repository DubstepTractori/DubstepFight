using DubstepFight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFightClassLibrary
{
    internal class Knuckleduster : Weapon
    {

        public Knuckleduster(BaseHero baseHero)  //Кастет
        {
            NameOfWeapon = "Кастет";

            double PowerOfHeroAndKnuckleduster = (baseHero.Health / 10);
            PowerWeapon = (int)(baseHero.Power * PowerOfHeroAndKnuckleduster);
        }

        

    }
}
