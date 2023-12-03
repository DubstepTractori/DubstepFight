using DubstepFight;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFightClassLibrary
{
    public class Asssasin : BaseHero
    {
        int dexterity;
        public Asssasin() { Health = 75; Power = 20; dexterity = 1; Name = "Асассин"; }
        

        public int Attack1()            // <-- Дефолтная тычка героя(c особенностью класса )в данном классе у асассина есть нож
        {
            int knife = 2;//Нож ассассина
            int Attack = Power / 3 + knife;//значение атаки и его расчеты
            return Attack;
        }

        public int Attack2()// <-- суть второй атаки будет в том что ассасин проницает ядом свой клинок который
                            //дамажит уроном обычного клинка и в последующие 3 хода дополнительно наносит 4 урона за ход
                            // но ассасин теряет один ход ведь ему нужно сделать клинок ядовитым "нужно добавить более длительный кд"
        {
            return Attack1();
        }
        public int Attack2Passive()//урон яда по противнику в будущем мы просто будем вызывать его несколько раз с счетчиком до 3
                                                        
        {
            int poison = 4;
            return poison;
        }
        public int Passive() // ловкость - если случайным обазом его значение кубика + ловкость превышают значение то он наносит врагу урон без атаки типо во время атаки он может либо ударить в ответ либо ничего 
        { 
            dexterity++;
            Random rnd = new Random();
            int cube = rnd.Next(1, 10);
            if (dexterity + cube > 10)
            {
                return Attack1();
            }
            return 0;

        }

        
    }
}
