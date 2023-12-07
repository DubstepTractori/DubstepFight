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


        public int Attack() // Дефолтная атака эльфа
        {

            Ultimate++;
            return Power / 2;

        }

        public int AttackWithUltimate() // Атак с ультой
        {
            if (Ultimate > 5) //Если уже пять ходов было пройдено то Эльф бьёт Атакой 2х
            {
                int U = Ultimate;
                Ultimate = 0;
                return Attack() * U;
            }
            return 0;
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
