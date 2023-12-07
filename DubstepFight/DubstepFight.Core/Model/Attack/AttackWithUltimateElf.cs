using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight.Core.Model.Attack
{
    public class AttackWithUltimateElf : BaseAttack
    {

        /// <summary>
        /// Обилка Эльфа
        /// </summary>

        //Пока не уверен насчёт ультимейта, как с ним поступать

        public AttackWithUltimateElf() { Damage = 0; }
        public int ultimate;

        public int AttackWithUltimate() // Атак с ультой
        {
            if (ultimate > 5) //Если уже пять ходов было пройдено то Эльф бьёт Атакой 2х
            {
                int U = ultimate;
                ultimate = 0;
                return Attack(15) * U;
            }
            return 0;
        }

    }
}
