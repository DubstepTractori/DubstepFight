using DubstepFight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFightClassLibrary
{
    public class Knuckleduster : Weapon
    {

        public Knuckleduster(BaseHero baseHero)  //Кастет
        {
            double PowerOfHeroAndKnuckleduster = (baseHero.Health / 10);
            PowerWeapon = (int)(baseHero.Power * PowerOfHeroAndKnuckleduster);
        }

        

    }
}
