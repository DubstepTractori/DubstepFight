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

        public int Ultimate = 0; //Стата для накопление ультимейта во время ходов

        public Elf() 
        {

            Health = 100;
            Power = 20;
            Ultimate = 0;
            Name = "Эльф";
        }


        public double Attack() // Дефолтная атака эльфа
        {

            Ultimate++;
            return Power / 2;

        }

        public double AttackWithUltimate() // Атак с ультой
        {
            if (Ultimate > 5) //Если уже пять ходов было пройдено то Эльф бьёт Атакой 2х
            {
                return Attack() * 2;
            }

            return Attack();
        }


        public void Passive()
        {
            Random rnd = new Random();
            int cube = rnd.Next(1, 10);

            if (cube > 7)
            {
                if (Health < 100)
                {
                    Health += 10;
                }
            }
        }


    }
}
