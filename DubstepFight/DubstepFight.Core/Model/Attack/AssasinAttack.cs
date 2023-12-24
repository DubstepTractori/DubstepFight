using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DubstepFight.Core.Model.Attack
{
    public class AssasinAttack : BaseAttack
    {
        public AssasinAttack() { Damage = 0; }

        /// <summary>
        /// класс Дефолтной тычки героя
        /// </summary>
        
        public override int Attack(int Power)
        {
            Damage = Power / 3 ;
            return Damage;
        }
    }
}
