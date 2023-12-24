using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DubstepFight.Core.Model.Attack
{
    public class BlackKnightAttack : BaseAttack
    {

        /// <summary>
        /// класс дефолтной тычки героя
        /// </summary>
        public BlackKnightAttack() { Damage = 0; }
        public override int Attack(int Power)
        {
            int Damage = Power / 3;
            return Damage;
        }
    }
}
