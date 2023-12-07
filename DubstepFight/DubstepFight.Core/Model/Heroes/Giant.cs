using DubstepFight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFightClassLibrary
{
    internal class Giant : BaseHero
    {

        public Giant()
        {
            Health = 200; //Статы
            Power = 20; // гиганта
            Name = "Гигант";
        }

 


        public int Passive() //Когда у гиганта остаётся меньше 50 хп он Бьет с 2х уроном
        {
            if (Health < 50)
            {
                int Attack1 = Attack() * 2;
                return Attack1;
            }
            return 0;
        }


    }
}
