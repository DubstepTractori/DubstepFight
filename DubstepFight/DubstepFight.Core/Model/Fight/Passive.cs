using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO.Pipes;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight.Core.Model.Fight
{
    public class Passive
    {
        private int passiveCounter1;
        private int passiveCounter2;
        private int passiveCounter3;
        private int passiveCounter4;

        private bool isActive;

        public int PassiveCounter1
        { get { return passiveCounter1; } set {  passiveCounter1 = value; } }

        public int PassiveCounter2
        { get { return passiveCounter2; } set { passiveCounter2 = value; } }
        
        public int PassiveCounter3
        { get { return passiveCounter3; } set { passiveCounter3 = value; } }

        public int PassiveCounter4
        { get { return passiveCounter4; } set { passiveCounter4 = value; } }

        public bool IsActive
        { get { return isActive; } set { isActive = value; } }

        public Passive(int passiveCounter1p, int passiveCounter2p, int passiveCounter3p, int passiveCounter4p)
        {
            PassiveCounter1 = passiveCounter1p;
            PassiveCounter2 = passiveCounter2p;
            PassiveCounter3 = passiveCounter3p;
            PassiveCounter4 = passiveCounter4p;
        }

        public Passive(int passiveCounter1p, int passiveCounter2p, int passiveCounter3p)
        {
            PassiveCounter1 = passiveCounter1p;
            PassiveCounter2 = passiveCounter2p;
            PassiveCounter3 = passiveCounter3p;
        }
        public Passive(int passiveCounter1p, int passiveCounter2p)
        {
            PassiveCounter1 = passiveCounter1p;
            PassiveCounter2 = passiveCounter2p;
        }

        public Passive(int passiveCounter1p)
        {
            PassiveCounter1 = passiveCounter1p;
        }


        
    }
}
