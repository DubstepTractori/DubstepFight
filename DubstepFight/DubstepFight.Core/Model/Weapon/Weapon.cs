using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFightClassLibrary
{
    internal class Weapon
    {
        int powerWeapon;
        string nameOfWeapon;

        public Weapon()
        {
            powerWeapon = 0;
            nameOfWeapon = "NoName";
        }

        
        public int PowerWeapon
        {
            get
            { return powerWeapon; }
            set
            { powerWeapon = value; }
        }
        public string NameOfWeapon { get => nameOfWeapon; set => nameOfWeapon = value; }
    }
}
