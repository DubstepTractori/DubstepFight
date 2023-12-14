using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight.Core.Model.Passive
{
    public class AssasinPassive : BasePassive
    {
        /// <summary>
        /// ловкость - если случайным обазом его значение кубика + ловкость превышают значение 
        /// то он наносит врагу урон без атаки типо во время атаки он может либо ударить в ответ либо ничего 
        /// </summary>
        private int _dexterity;
        private PassiveType _passiveType;
        public int Dexterity
        {
            get
            { return _dexterity; }
            set
            { _dexterity = value; }
        }

        public PassiveType PassiveType { get => _passiveType; set => _passiveType = value; }

        public AssasinPassive(int dexterity, PassiveType passiveType)
        {
            Dexterity = dexterity;
            _passiveType = passiveType;
        }
        public override bool Passive(int Power, int PowerWeapon) 
        {
            Dexterity++;
            Random rnd = new Random();
            int cube = rnd.Next(1, 10);
            if (_dexterity + cube > 10)
            {
                return true;
            }
            return  false;
        }
       
    }
}
