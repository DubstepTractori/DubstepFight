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
            PowerWeapon = 7;
        }
        public void Passive()
        {
            //отхил героя на 3 еденицы реализовать в будующем
        }

        

    }
}
