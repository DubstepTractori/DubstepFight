using DubstepFight.Core.Model.Fight;
using System;

namespace DubstepFight
{
    public class MainViewModel
    {
        public MainViewModel()
        {
        }

        public bool CreationCompleted { get; internal set; }
        public BaseHero FirstPlayerHero { get; internal set; }
        public BaseHero SecondPlayerHero { get; internal set; }
        public Fight GameFight { get; internal set; }

        private int playerCounter = 0;
        public void CreateHero(string HeroType)
        {
            if (playerCounter == 0)
            {
                FirstPlayerHero = new ();
                playerCounter++;
            }
            else if(playerCounter == 1) { }
            {
                SecondPlayerHero = new();
                CreationCompleted= true;
                GameFight = new Fight(FirstPlayerHero, SecondPlayerHero);
            }
        }
    }
}