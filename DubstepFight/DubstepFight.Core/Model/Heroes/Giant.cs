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
            Power = 15; // гиганта
        }

        public double Attack() //Дефолтная атака
        {
            return Power / 2;
        }


        public double AttackWithVereStrongFist() //Обилка гиганта где с шансом
                                //он может нанаести дефолтную тычку с прибавление 10 урона, тип с размаха ебнет
        {
            Random rnd = new Random();
            int cube = rnd.Next(1, 10);

            if (cube > 7) 
            {

                return Attack() + 10;
            }

            return Attack();

        }


        public void Passive() //Когда у гиганта остаётся меньше 50 хп он ебашит с 2х уроном
        {
            if (Health < 50)
            {
                Power = Power * 2;
            }
        }


    }
}
