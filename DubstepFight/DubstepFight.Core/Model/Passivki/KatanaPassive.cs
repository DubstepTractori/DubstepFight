using DubstepFight.Core.Model.Passive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight.Core.Model.Passivki
{
    internal class KatanaPassive : BasePassive
    {
        /// <summary>
        /// пассивка катаны с возрастанием ее мощи
        /// </summary>
        private PassiveType _passiveType;
        public PassiveType PassiveType { get => _passiveType; set => _passiveType = value; }
        public override bool Passive(int Power, int PowerWeapon) // возрастание его мощи
        {
            PowerWeapon++;
            return true;
        }
    }
}