using DubstepFight.Core.Model.Passive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight.Core.Model.Passive
{
    public class KnuckkledusterPassive : BasePassive
    {
        /// <summary>
        /// пассивка кастета с возрастанием мощи владельца
        /// </summary>
        private PassiveType _passiveType;
        public PassiveType PassiveType { get => _passiveType; set => _passiveType = value; }
        public override bool Passive(int Power, int PowerWeapon) // возрастание его мощи
        {
            Power++;
            return true;
        }
    }
}
