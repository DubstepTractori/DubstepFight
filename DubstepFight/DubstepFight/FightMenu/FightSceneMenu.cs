using DubstepFight.CharacterInfoFolder;
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
using System.Threading;
using System.Windows.Forms;

namespace DubstepFight.FightMenu
{
    public partial class FightSceneMenu : Form
    {
        BaseHero Player1;
        BaseHero Player2;
        Fight MyFight;

        Random random;

        AssassinInfoForm assassinInfo;
        GiantInfoForm giantInfo;
        ElfInfoForm elfInfo;
        BlackKnightInfoForm blackKnightInfo;
        EasterEgg secretInfo;

        MainGameMenu returnMenuMain;

        private void FormRezizeToThisShowAndHide(Form fromForm)
        {
            fromForm.Size = this.Size;
            fromForm.Location = this.Location;
            fromForm.Show();
            this.Hide();
        }

        public FightSceneMenu(BaseHero chosenHero, BaseHero chosenHeroPlayer2, MainGameMenu MainMenu)
        {
            InitializeComponent();

            Player1 = chosenHero;
            Player2 = chosenHeroPlayer2;
            returnMenuMain = MainMenu;
            random = new Random();

            MyFight = new Fight(Player1, Player2);

            TurnCounterLabel.Text = MyFight.TurnCounter.ToString();

            ReturnMenuButton.Enabled = false;
            ReturnMenuButton.Visible = false;

            Player1HeroNameLabel.Text = Player1.Name;
            Player1HpLabel.Text = Player1.Health.ToString();
            Player1HpProgressBar.Maximum = Player1.Health;
            Player1HpProgressBar.Value = Player1.Health;
            Player1Attack1MyButton.Image = Image.FromFile(Player1.Attack1ImgPath);
            Player1Attack2MyButton.Image = Image.FromFile(Player1.Attack2ImgPath);
            Player1CharPicBox.Image = Image.FromFile(Player1.CharPoseIdleImgPath);


            Player2HeroNameLabel.Text = Player2.Name;
            Player2HpLabel.Text = Player2.Health.ToString();
            Player2HpProgressBar.Maximum = Player2.Health;
            Player2HpProgressBar.Value = Player2.Health;
            Player2Attack1MyButton.Image = Image.FromFile(Player2.Attack1ImgPath);
            Player2Attack2MyButton.Image = Image.FromFile(Player2.Attack2ImgPath);
            Image Player2CharPoseIdle = Image.FromFile((Player2.CharPoseIdleImgPath));
            Player2CharPoseIdle.RotateFlip(RotateFlipType.Rotate180FlipY);
            Player2CharPicBox.Image = Player2CharPoseIdle;

            Player1GetDamageLabel.Text = "";
            Player2GetDamageLabel.Text = "";
            PlayerWinLabel.Text = "";

            

            

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
                PassiveCheck(Player1, Player2, Player2Attack1MyButton, Player2Attack2MyButton, 
                    Player1Attack1MyButton, Player1Attack2MyButton);
                

                Player1Attack1MyButton.ButtonDisable();
                Player1Attack2MyButton.ButtonDisable();


                Player2Attack1MyButton.ButtonEnable();
                Player2Attack2MyButton.ButtonEnable();

                if (Player2.Attack2CD > 0)
                { Player2Attack2MyButton.ButtonDisable(); }
            }

            if (MyFight.IsPlayer1Turn)
            {
                PassiveCheck(Player2, Player1, Player1Attack1MyButton, Player1Attack2MyButton, 
                    Player2Attack1MyButton, Player2Attack2MyButton);

                Player1Attack1MyButton.ButtonEnable();
                Player1Attack2MyButton.ButtonEnable();

                if (Player1.Attack2CD > 0)
                { Player1Attack2MyButton.ButtonDisable(); }

                Player2Attack1MyButton.ButtonDisable();
                Player2Attack2MyButton.ButtonDisable();
            }
        }

        private void Player1Win()
        {
            Player2.Health = 0;
            Player2HpLabel.Text = Player2.Health.ToString();
            Player2HpProgressBar.Value = 0;
            PlayerWinLabel.Text = "Победил Игрок 1";
            ReturnMenuButton.Visible = true;
            ReturnMenuButton.Enabled = true;

        }

        private void Player2Win()
        {
            Player1.Health = 0;
            Player1HpLabel.Text = Player1.Health.ToString();
            Player1HpProgressBar.Value = 0;
            PlayerWinLabel.Text = "Победил Игрок 2";
            ReturnMenuButton.Visible = true;
            ReturnMenuButton.Enabled = true;
        }

        private void PassiveCheck(BaseHero PlayerDoing, BaseHero PlayerWaiting, Button PlayerWaitingAttackButton1, Button PlayerWaitingAttackButton2, 
            Button PlayerDoingAttackButton1, Button PlayerDoingAttackButton2)
        {
            AssassinPassiveProc(PlayerDoing, PlayerWaiting);
            BlackKnightPassiveProc(PlayerWaiting, PlayerWaitingAttackButton1);
            ElfPassiveProc(PlayerWaiting, PlayerWaitingAttackButton2);
        }

        private void AssassinPassiveProc(BaseHero PlayerDoing, BaseHero PlayerWaiting)
        {
            if(PlayerWaiting.Name == "Ассассин")
            {
                PlayerDoing.Health -= Convert.ToInt32(PlayerDoing.Health * 0.09);
                PlayerWaiting.PassiveProc();
            }
        }

        private void BlackKnightPassiveProc(BaseHero PlayerWaiting, Button PlayerWaitingAttackButton1)
        {
            if (PlayerWaiting.Name == "Тёмный Рыцарь")
            {
                PlayerWaiting.Power = PlayerWaiting.PassiveProc();
                PlayerWaitingAttackButton1.Image = Image.FromFile(PlayerWaiting.Attack1ImgPath);
            }
        }

        private void ElfPassiveProc(BaseHero PlayerWaiting, Button PlayerWaitingAttackButton2)
        {
            if (PlayerWaiting.Name == "Эльф")
            {
                PlayerWaitingAttackButton2.Image = Image.FromFile(PlayerWaiting.Attack2ImgPath);
            }
        }


        private void Player1Attack1MyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int damageDealt = Player2.TakeDamage(Player1.Attack1());
                Player2GetDamageLabel.Text = "Полученный урон: " + damageDealt;
                MyFight.TurnSwitch();
                FrameUpdate();
                if (Player2.Health <= 0)
                { Player1Win(); }

            }
            catch
            {
                Player1Win();
            }
            
        }

        private void Player1Attack2MyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int damageDealt = Player2.TakeDamage(Player1.Attack2());
                Player2GetDamageLabel.Text = "Полученный урон: " + damageDealt;
                MyFight.TurnSwitch();
                FrameUpdate();
                if (Player2.Health <= 0)
                { Player1Win(); }
            }
            catch
            {
                Player1Win();
            }
        }

        private void Player2Attack1MyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int damageDealt = Player1.TakeDamage(Player2.Attack1());
                Player1GetDamageLabel.Text = "Полученный урон: " + damageDealt;
                MyFight.TurnSwitch();
                FrameUpdate();
                if (Player1.Health <= 0)
                { Player2Win(); }
            }
            catch
            {
                Player2Win();
            }
        }

        private void Player2Attack2MyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int damageDealt = Player1.TakeDamage(Player2.Attack2());
                Player1GetDamageLabel.Text = "Полученный урон: " + damageDealt;
                MyFight.TurnSwitch();
                FrameUpdate();
                if(Player1.Health <= 0)
                { Player2Win(); }
            }
            catch
            {              
                Player2Win();
            }
        }

        private void Player1InfoButton_Click(object sender, EventArgs e)
        {
            if (Player1.Name == "Ассассин")
            {
                assassinInfo = new AssassinInfoForm(this);
                FormRezizeToThisShowAndHide(assassinInfo);
            }
            if (Player1.Name == "Гигант")
            {
                giantInfo = new GiantInfoForm(this);
                FormRezizeToThisShowAndHide(giantInfo);
            }
            if (Player1.Name == "Эльф")
            {
                elfInfo = new ElfInfoForm(this);
                FormRezizeToThisShowAndHide(elfInfo);
            }
            if (Player1.Name == "Тёмный Рыцарь")
            {
                if(random.Next(0,100) == 1)
                {
                    secretInfo = new EasterEgg();
                    FormRezizeToThisShowAndHide(secretInfo);
                }
                else
                {
                    blackKnightInfo = new BlackKnightInfoForm(this);
                    FormRezizeToThisShowAndHide(blackKnightInfo);
                }
                
                
            }

        }

        private void Player2InfoButton_Click(object sender, EventArgs e)
        {
            if (Player2.Name == "Ассассин")
            {
                assassinInfo = new AssassinInfoForm(this);
                FormRezizeToThisShowAndHide(assassinInfo);
            }
            if (Player2.Name == "Гигант")
            {
                giantInfo = new GiantInfoForm(this);
                FormRezizeToThisShowAndHide(giantInfo);
            }
            if (Player2.Name == "Эльф")
            {
                elfInfo = new ElfInfoForm(this);
                FormRezizeToThisShowAndHide(elfInfo);
            }
            if (Player2.Name == "Тёмный Рыцарь")
            {
                blackKnightInfo = new BlackKnightInfoForm(this);
                FormRezizeToThisShowAndHide(blackKnightInfo);
            }
        }

        private void ReturnMenuButton_Click(object sender, EventArgs e)
        {
            FormRezizeToThisShowAndHide(returnMenuMain);
            this.Close();
        }
    }
}
