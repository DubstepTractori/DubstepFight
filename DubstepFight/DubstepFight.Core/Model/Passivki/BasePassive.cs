using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight.Core.Model.Passive
{
    public enum PassiveType
    {
        Counter,
        Vampiric
    }
    public abstract class BasePassive
    {
        /// <summary>
        /// базовый класс пасивки.
        /// </summary>
        public abstract void Passive();
    }
}
