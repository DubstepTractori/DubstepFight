using DubstepFight.Core.Model.Fight;
using DubstepFightClassLibrary;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DubstepFight
{
    public class MainViewModel
    {
        public MainViewModel() {}
        public bool CreationCompleted { get; internal set; }
        public BaseHero FirstPlayerHero { get; internal set; }
        public BaseHero SecondPlayerHero { get; internal set; }
        public Fight GameFight { get; internal set; } //Класс Fight (счётчик ходов)
        public Random Random { get; internal set; }

        private int playerCounter = 0;
        public void CreateHero(string heroName)
        {
            if (playerCounter == 0) //Создание персонажа
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
        public void ControlResize(Rectangle ControlRec, Rectangle FormRec, Control Control, Form Form) //Изменение размера чего либо с изменением размера формы
        {
            float ratioX = (float)(Form.Width) / (float)(FormRec.Width);
            float ratioY = (float)(Form.Height) / (float)(FormRec.Height);

            int newX = (int)(ControlRec.Location.X * ratioX);
            int newY = (int)(ControlRec.Location.Y * ratioY);

            int newWidth = (int)(ControlRec.Width * ratioX);
            int newHeight = (int)(ControlRec.Height * ratioY);


            Control.Location = new Point(newX, newY);
            Control.Size = new Size(newWidth, newHeight);
        }
    }
}