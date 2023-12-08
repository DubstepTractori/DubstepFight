using DubstepFight.Core.Model.Passive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight.Core.Model.Passivki
{
    public class BlackkingPassive : BasePassive
    {
        /// <summary>
        /// пассивка темного рыцаря повышающая его мощь
        /// </summary>
        private PassiveType _passiveType;
        public PassiveType PassiveType { get => _passiveType; set => _passiveType = value; }
        public override bool Passive(int Power, int PowerWeapon)
        {
            Power+=5;
            return true;

        }
    }
}
