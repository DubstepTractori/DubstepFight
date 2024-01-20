using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DubstepFight.Core.Model.Fight
{
    public class Fight
    {
        private BaseHero player1Hero;
        private BaseHero player2Hero;
        private bool isPlayer1Turn;
        private int turnCounter;
        private bool gameOver;

        public Fight(BaseHero player1, BaseHero player2) {Player1Hero = player1; Player2Hero = player2; IsPlayer1Turn = true; TurnCounter = 30; }
        public BaseHero Player1Hero {
            get { return player1Hero; }
            set { player1Hero = value; }
        }
        public BaseHero Player2Hero {
            get { return player2Hero; }
            set { player2Hero = value; }
        }


        public int TurnCounter {
            get { return turnCounter; }
            set { turnCounter = value; }
        }

        public bool IsPlayer1Turn
        {
            get { return isPlayer1Turn; }
            set { isPlayer1Turn = value; }
        }

        public bool GameOver { get => gameOver; set => gameOver = value; }

        public void TurnSwitch()
        {
            IsPlayer1Turn = !IsPlayer1Turn;
            TurnCounter--;
            if(TurnCounter <= 0)
            {
                GameOver = true;
            }    
        }
    }
}
