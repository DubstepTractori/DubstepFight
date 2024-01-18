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
using System.IO;
using WMPLib;

namespace DubstepFight.FightMenu
{
    public partial class FightSceneMenu : Form
    {

        MainGameMenu returnMenuMain;
        MainViewModel viewModel;
        HeroInfoForm heroInfo;

        public WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();



        private void FormRezizeToThisShowAndHide(Form fromForm)
        {
            fromForm.Size = this.Size;
            fromForm.Location = this.Location;
            fromForm.Show();
            this.Hide();
        }

        public FightSceneMenu(MainGameMenu MainMenu, MainViewModel viewModel)
        {
            InitializeComponent();

            returnMenuMain = MainMenu;
            this.viewModel = viewModel;

            TurnCounterLabel.Text = this.viewModel.GameFight.TurnCounter.ToString();

            InitializePlayers();

            TurnCheck();
        }

        private void InitializePlayers()
        {

            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
            WMP.URL = Path.GetFullPath("../../Resources/Other/DabstepTraktori.mp3");
            WMP.settings.volume = 100; // меняя значение можно регулировать громкость
            WMP.controls.play(); // Старт




            ReturnMenuButton.Enabled = false;
            ReturnMenuButton.Visible = false;

            Player1HeroNameLabel.Text = viewModel.FirstPlayerHero.Name;
            Player1HpLabel.Text = viewModel.FirstPlayerHero.Health.ToString();
            Player1HpProgressBar.Maximum = viewModel.FirstPlayerHero.Health;
            Player1HpProgressBar.Value = viewModel.FirstPlayerHero.Health;
            Player1Attack1MyButton.Image = Image.FromFile(viewModel.FirstPlayerHero.Attack1ImgPath);
            Player1Attack2MyButton.Image = Image.FromFile(viewModel.FirstPlayerHero.Attack2ImgPath);
            Player1CharPicBox.Image = Image.FromFile(viewModel.FirstPlayerHero.CharPoseIdleImgPath);


            Player2HeroNameLabel.Text = viewModel.SecondPlayerHero.Name;
            Player2HpLabel.Text = viewModel.SecondPlayerHero.Health.ToString();
            Player2HpProgressBar.Maximum = viewModel.SecondPlayerHero.Health;
            Player2HpProgressBar.Value = viewModel.SecondPlayerHero.Health;
            Player2Attack1MyButton.Image = Image.FromFile(viewModel.SecondPlayerHero.Attack1ImgPath);
            Player2Attack2MyButton.Image = Image.FromFile(viewModel.SecondPlayerHero.Attack2ImgPath);
            Image Player2CharPoseIdle = Image.FromFile((viewModel.SecondPlayerHero.CharPoseIdleImgPath));
            Player2CharPoseIdle.RotateFlip(RotateFlipType.Rotate180FlipY);
            Player2CharPicBox.Image = Player2CharPoseIdle;

            Player1GetDamageLabel.Text = "";
            Player2GetDamageLabel.Text = "";
            PlayerWinLabel.Text = "";
        }

        private void FrameUpdate()
        { 
            

            TurnCheck();

            TurnCounterLabel.Text = viewModel.GameFight.TurnCounter.ToString();

            Player1HpLabel.Text = viewModel.FirstPlayerHero.Health.ToString();
            Player1HpProgressBar.Value = viewModel.FirstPlayerHero.Health;

            Player2HpLabel.Text = viewModel.SecondPlayerHero.Health.ToString();
            Player2HpProgressBar.Value = viewModel.SecondPlayerHero.Health;

            



        }
        private void TurnCheck()
        {
            if (!viewModel.GameFight.IsPlayer1Turn)
            {
                PassiveCheck(viewModel.FirstPlayerHero, viewModel.SecondPlayerHero, Player2Attack1MyButton, Player2Attack2MyButton, 
                    Player1Attack1MyButton, Player1Attack2MyButton);
                

                Player1Attack1MyButton.ButtonDisable();
                Player1Attack2MyButton.ButtonDisable();


                Player2Attack1MyButton.ButtonEnable();
                Player2Attack2MyButton.ButtonEnable();

                if (viewModel.SecondPlayerHero.Attack2CD > 0)
                { Player2Attack2MyButton.ButtonDisable(); }
            }

            if (viewModel.GameFight.IsPlayer1Turn)
            {
                PassiveCheck(viewModel.SecondPlayerHero, viewModel.FirstPlayerHero, Player1Attack1MyButton, Player1Attack2MyButton, 
                    Player2Attack1MyButton, Player2Attack2MyButton);

                Player1Attack1MyButton.ButtonEnable();
                Player1Attack2MyButton.ButtonEnable();

                if (viewModel.FirstPlayerHero.Attack2CD > 0)
                { Player1Attack2MyButton.ButtonDisable(); }

                Player2Attack1MyButton.ButtonDisable();
                Player2Attack2MyButton.ButtonDisable();
            }
        }

        private void Player1Win()
        {
            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
            viewModel.SecondPlayerHero.Health = 0;
            Player2HpLabel.Text = viewModel.SecondPlayerHero.Health.ToString();
            Player2HpProgressBar.Value = 0;
            PlayerWinLabel.Text = "Победил Игрок 1";
            ReturnMenuButton.Visible = true;
            ReturnMenuButton.Enabled = true;
            WMP.controls.stop();

        }

        private void Player2Win()
        {
            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
            viewModel.FirstPlayerHero.Health = 0;
            Player1HpLabel.Text = viewModel.FirstPlayerHero.Health.ToString();
            Player1HpProgressBar.Value = 0;
            PlayerWinLabel.Text = "Победил Игрок 2";
            ReturnMenuButton.Visible = true;
            ReturnMenuButton.Enabled = true;
            WMP.controls.stop();
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
                if(PlayerWaiting.Passive.PassiveCounter1 > 0)
                {
                    PlayerDoing.Health -= Convert.ToInt32(PlayerDoing.Health * 0.15);
                }
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
                int damageDealt = viewModel.SecondPlayerHero.TakeDamage(viewModel.FirstPlayerHero.Attack1());
                Player2GetDamageLabel.Text = "Полученный урон: " + damageDealt;
                viewModel.GameFight.TurnSwitch();
                FrameUpdate();
                if (viewModel.SecondPlayerHero.Health <= 0)
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
                int damageDealt = viewModel.SecondPlayerHero.TakeDamage(viewModel.FirstPlayerHero.Attack2());
                Player2GetDamageLabel.Text = "Полученный урон: " + damageDealt;
                viewModel.GameFight.TurnSwitch();
                FrameUpdate();
                if (viewModel.SecondPlayerHero.Health <= 0)
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
                int damageDealt = viewModel.FirstPlayerHero.TakeDamage(viewModel.SecondPlayerHero.Attack1());
                Player1GetDamageLabel.Text = "Полученный урон: " + damageDealt;
                viewModel.GameFight.TurnSwitch();
                FrameUpdate();
                if (viewModel.FirstPlayerHero.Health <= 0)
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
                int damageDealt = viewModel.FirstPlayerHero.TakeDamage(viewModel.SecondPlayerHero.Attack2());
                Player1GetDamageLabel.Text = "Полученный урон: " + damageDealt;
                viewModel.GameFight.TurnSwitch();
                FrameUpdate();
                if(viewModel.FirstPlayerHero.Health <= 0)
                { Player2Win(); }
            }
            catch
            {              
                Player2Win();
            }
        }

 



        private void Player1InfoButton_Click(object sender, EventArgs e)
        {
            heroInfo = new HeroInfoForm(this, viewModel.FirstPlayerHero);
            FormRezizeToThisShowAndHide(heroInfo);
        }
        private void Player1InfoButton_MouseEnter(object sender, EventArgs e)
        {
            Player1InfoButton.ForeColor = Color.Magenta;
            Player1InfoButton.BackColor = Color.Magenta;


        }
        private void Player1InfoButton_MouseLeave(object sender, EventArgs e)
        {
            Player1InfoButton.ForeColor = Color.Cyan;
            Player1InfoButton.BackColor = Color.Transparent;
        }

        private void Player2InfoButton_Click(object sender, EventArgs e)
        {
            heroInfo = new HeroInfoForm(this, viewModel.SecondPlayerHero);
            FormRezizeToThisShowAndHide(heroInfo);
        }
        private void Player2InfoButton_MouseEnter(object sender, EventArgs e)
        {
            Player2InfoButton.ForeColor = Color.Magenta;
            Player2InfoButton.BackColor = Color.Magenta;


        }
        private void Player2InfoButton_MouseLeave(object sender, EventArgs e)
        {
            Player2InfoButton.ForeColor = Color.Cyan;
            Player2InfoButton.BackColor = Color.Transparent;
        }

        private void ReturnMenuButton_Click(object sender, EventArgs e)
        {

            FormRezizeToThisShowAndHide(returnMenuMain);
            this.Close();

        }
        private void ReturnMenuButtonм_MouseEnter(object sender, EventArgs e)
        {
            ReturnMenuButton.ForeColor = Color.Magenta;
            ReturnMenuButton.BackColor = Color.Magenta;


        }
        private void ReturnMenuButton_MouseLeave(object sender, EventArgs e)
        {
            ReturnMenuButton.ForeColor = Color.Cyan;
            ReturnMenuButton.BackColor = Color.Transparent;
        }

        private void Player2HpProgressBar_Click(object sender, EventArgs e)
        {

        }

        private void Player2CharPicBox_Click(object sender, EventArgs e)
        {

        }
    }
}
