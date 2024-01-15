using DubstepFight.Core.Model.Fight;
using DubstepFightClassLibrary;
using System;

namespace DubstepFight
{
    public class MainViewModel
    {
        public MainViewModel() {}
        public bool CreationCompleted { get; internal set; }
        public BaseHero FirstPlayerHero { get; internal set; }
        public BaseHero SecondPlayerHero { get; internal set; }
        public Fight GameFight { get; internal set; }
        public Random Random { get; internal set; }

        private int playerCounter = 0;
        public void CreateHero(string heroName)
        {
            if (playerCounter == 0)
            {
                switch (heroName)
                {
                    case "Assassin":
                        FirstPlayerHero = new Assasin();
                        break;
                    case "Elf":
                        FirstPlayerHero = new Elf();
                        break;
                    case "BlackKnight":
                        FirstPlayerHero = new BlackKnight();
                        break;
                    case "Giant":
                        FirstPlayerHero = new Giant();
                        break;
                    default:
                        break;
                }
                playerCounter++;
                //фывфыв
            }
            else if(playerCounter == 1)
            {
                switch (heroName)
                {
                    case "Assassin":
                        SecondPlayerHero = new Assasin();
                        break;
                    case "Elf":
                        SecondPlayerHero = new Elf();
                        break;
                    case "BlackKnight":
                        SecondPlayerHero = new BlackKnight();
                        break;
                    case "Giant":
                        SecondPlayerHero = new Giant();
                        break;
                    default:
                        break;
                }
                CreationCompleted = true;
                GameFight = new Fight(FirstPlayerHero, SecondPlayerHero);
            }
        }
    }
}