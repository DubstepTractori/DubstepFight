﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight
{
    public class BlackKnight : BaseHero
    {
        public BlackKnight() { Health = 150; Power = 25; Name = "Темный Рыцарь"; }

        public int Attack1()
        {
            int Attack = Power / 3;//значение атаки и его расчеты
            return Attack;
        }

        public int Attack2()  //темнота поглощая рыцаря наносит доп урон
        {
            Health -= 7;
            Power--;
            int Attack = Power / 3 + 10;//значение атаки и его расчеты
            return Attack;
        }
        public void Passive() // возрастание его мощи
        {
            Power++;

        }
    }
}
