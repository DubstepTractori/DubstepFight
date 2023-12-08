using DubstepFight.Core.Model.Passive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight.Core.Model.Passivki
{
    public class MagicStaffPassive : BasePassive
    {
        /// <summary>
        /// пассивка магического посоха с рандомныи возрастанием мощи оружия
        /// </summary>
        private PassiveType _passiveType;
        public PassiveType PassiveType { get => _passiveType; set => _passiveType = value; }
        public override bool Passive(int Power, int PowerWeapon) // возрастание его мощи
        {
            Random rnd = new Random();
            int cube = rnd.Next(1, 20);
            int changes = 19;
            if (cube > changes)
            {
                PowerWeapon += 5;
                changes--;
                return true;
            }
            return false;
        }
    }
    }
}
