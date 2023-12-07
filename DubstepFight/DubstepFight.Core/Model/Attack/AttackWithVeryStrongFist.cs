using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight.Core.Model.Attack
{
    public class AttackWithVeryStrongFist : BaseAttack
    {

        /// <summary>
        /// Обилка гиганта
        /// </summary>
        /// <returns></returns>

        public int AttackWithVereStrongFist() //Обилка гиганта где с шансом
                                              //он может нанаести дефолтную тычку с прибавление 10 урона, тип с размаха Бьет
        {
            Random rnd = new Random();
            int cube = rnd.Next(1, 10);

            if (cube > 5)
            {

                return Attack(20) + 10;
            }

            return Attack(20);

        }

    }
}
