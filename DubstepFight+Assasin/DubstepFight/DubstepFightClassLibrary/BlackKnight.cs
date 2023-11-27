using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight
{
    public class BlackKnight : BaseHero
    {
        public BlackKnight() { Health = 150; Power = 25; }

        public int Attack1()
        {
            return Power;
        }

        //public int Attack2() { }
        //public int Passive() { }
    }
}
