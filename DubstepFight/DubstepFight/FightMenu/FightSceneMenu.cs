using DubstepFight.Core.Model.Fight;
using DubstepFightClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DubstepFight.FightMenu
{
    public partial class FightSceneMenu : Form
    {
        BaseHero Player1;
        BaseHero Player2;
        Fight MyFight;



        public FightSceneMenu(BaseHero chosenHero)
        {
            InitializeComponent();

            Player1 = chosenHero;
            Player2 = new Assasin();

            MyFight = new Fight(Player1, Player2);

            TurnCounterLabel.Text = MyFight.TurnCounter.ToString();

            Player1HeroNameLabel.Text = Player1.Name;
            Player1HpLabel.Text = Player1.Health.ToString();
            Player1HpProgressBar.Maximum = Player1.Health;
            Player1HpProgressBar.Value = Player1.Health;

            Player2HeroNameLabel.Text = Player2.Name;
            Player2HpLabel.Text = Player2.Health.ToString();
            Player2HpProgressBar.Maximum = Player2.Health;
            Player2HpProgressBar.Value = Player2.Health;

            TurnCheck();
        }

        private void FrameUpdate()
        {
            TurnCheck();

            TurnCounterLabel.Text = MyFight.TurnCounter.ToString();

            Player1HpLabel.Text = Player1.Health.ToString();
            Player1HpProgressBar.Value = Player1.Health;

            Player2HpLabel.Text = Player2.Health.ToString();
            Player2HpProgressBar.Value = Player2.Health;
        }
        private void TurnCheck()
        {
            if (!MyFight.IsPlayer1Turn)
            {
                Player1Attack1MyButton.ButtonDisable();
                Player1Attack2MyButton.ButtonDisable();

                Player2Attack1MyButton.ButtonEnable();
                Player2Attack2MyButton.ButtonEnable();
            }

            if (MyFight.IsPlayer1Turn)
            {
                Player1Attack1MyButton.ButtonEnable();
                Player1Attack2MyButton.ButtonEnable();

                Player2Attack1MyButton.ButtonDisable();
                Player2Attack2MyButton.ButtonDisable();
            }
        }


        private void Player1Attack1MyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Player2.TakeDamage(Player1.Attack1());
                MyFight.TurnSwitch();
                FrameUpdate();
            }
            catch
            {
                Player2.Health = 0;
                Player2HpLabel.Text = Player2.Health.ToString();
                Player2HpProgressBar.Value = 0;
                MessageBox.Show("Победил Игрок 1");
            }
            
        }

        private void Player1Attack2MyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Player2.TakeDamage(Player1.Attack2());
                MyFight.TurnSwitch();
                FrameUpdate();
            }
            catch
            {
                Player2.Health = 0;
                Player2HpLabel.Text = Player2.Health.ToString();
                Player2HpProgressBar.Value = 0;
                MessageBox.Show("Победил Игрок 1");
            }
        }

        private void Player2Attack1MyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Player1.TakeDamage(Player2.Attack1());
                MyFight.TurnSwitch();
                FrameUpdate();
            }
            catch
            {
                Player1.Health = 0;
                Player1HpLabel.Text = Player1.Health.ToString();
                Player1HpProgressBar.Value = 0;
                MessageBox.Show("Победил Игрок 2");
            }
        }

        private void Player2Attack2MyButton_Click(object sender, EventArgs e)
        {
            try
            {
                Player1.TakeDamage(Player2.Attack2());
                MyFight.TurnSwitch();
                FrameUpdate();
            }
            catch
            {
                Player1.Health = 0;
                Player1HpLabel.Text = Player1.Health.ToString();
                Player1HpProgressBar.Value = 0;
                MessageBox.Show("Победил Игрок 2");
            }
        }
    }
}
