using DubstepFight.Core.Model.Passive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight.Core.Model.Passivki
{
    public class ElfPassive : BasePassive
    {
        /// <summary>
        /// пассивка эльфа с эфектом рандома
        /// </summary>
        private PassiveType _passiveType;
        public PassiveType PassiveType { get => _passiveType; set => _passiveType = value; }
        public override bool Passive(int Power, int PowerWeapon)
        {
            Random rnd = new Random();
            int cube = rnd.Next(1, 10);

            if (cube > 5)
            {
                if (Power < 100)
                {
                    return true;
                }
                else return false;
            }
            return false;

        }

    }
}
