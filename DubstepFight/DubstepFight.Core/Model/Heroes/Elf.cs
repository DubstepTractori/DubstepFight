using DubstepFight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFightClassLibrary
{
    public class Elf : BaseHero
    {

        public int ultimate; //Стата для накопление ультимейта во время ходов
        public int Ultimate
        {
            get
            { return ultimate; }
            set
            { ultimate = value; }
        }
        public Elf() 
        {

            Health = 100;
            Power = 15;
            Ultimate = 0;
            Name = "Эльф";
        }







        public void Passive()
        {
            Random rnd = new Random();
            int cube = rnd.Next(1, 10);

            if (cube > 5)
            {
                if (Health < 100)
                {
                    Health += 10;
                }
            }
        }


    }
}
