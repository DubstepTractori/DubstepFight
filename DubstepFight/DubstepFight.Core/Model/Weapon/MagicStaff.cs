using DubstepFight;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFightClassLibrary
{
    internal class MagicStaff : Weapon
    {

        
        public MagicStaff() 
        {
            NameOfWeapon = "Магический посох";
            PowerWeapon = 10;

        }

        public void MagicOfRandom() // Магия рандома с малым шансом посох может апнуть себе статы и стать сильнее
        {
            Random rnd = new Random();
            int cube = rnd.Next(1, 10);

            if (cube > 8)
            {
                PowerWeapon += 5;
            }
        }
    }
}
