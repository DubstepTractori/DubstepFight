using DubstepFight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFightClassLibrary
{
    public class Fight
    {
        int moves;
        public Fight() { moves = 0; } //пошаговое сражение и кол во ходов соответсвенно
        public void Battle()
        {
            while (moves != 30) // тут будет  сам хож битвы просто бкжем запрашивать способность и прокать пасивку и добавим условия для отражающих умений
            {                   // только нужно понимать что мы не знаем каких героев выберет игрок




                moves++;
            }
        }
    }
}
