using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFightClassLibrary
{
    internal class Katana : Weapon
    {
        public Katana() { PowerWeapon = 1; NameOfWeapon = "Катана"; }
        public void Passive()// игра будет через лейт идти либо через сильный старт поэтому малые статы и возможность стать сильнее
        {
            PowerWeapon++;
        }
    }
}
