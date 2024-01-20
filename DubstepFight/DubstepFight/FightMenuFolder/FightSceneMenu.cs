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

namespace DubstepFight.FightMenu
{
    public partial class FightSceneMenu : Form
    {

        MainGameMenu returnMenuMain;
        MainViewModel viewModel;
        HeroInfoForm heroInfo;
        Rectangle FormRec;
        Rectangle Player1HeroNameLabelRec;
        Rectangle Player2HeroNameLabelRec;
        Rectangle Player1HpProgressBarRec;
        Rectangle Player2HpProgressBarRec;
        Rectangle Player1HpLabelRec;
        Rectangle Player2HpLabelRec;
        Rectangle TurnCounterLabelRec;
        Rectangle PlayerWinLabelRec;
        Rectangle Player1GetDamageLabelRec;
        Rectangle Player2GetDamageLabelRec;
        Rectangle ReturnMenuButtonRec;
        Rectangle Player1CharPicBoxRec;
        Rectangle Player2CharPicBoxRec;

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

            if(viewModel.GameFight.GameOver == true)
            {
                if (viewModel.FirstPlayerHero.Health > viewModel.SecondPlayerHero.Health)
                {
                    Player1Win(true);
                }
                else if (viewModel.FirstPlayerHero.Health < viewModel.SecondPlayerHero.Health)
                {
                    Player2Win(true);
                }
                else
                {
                    DrawWin(true);
                }
            }
        }

        private void Player1Win(bool noTurns)
        {
            viewModel.SecondPlayerHero.Health = 0;
            Player2HpLabel.Text = viewModel.SecondPlayerHero.Health.ToString();
            Player2HpProgressBar.Value = 0;
            if (noTurns)
            {
                PlayerWinLabel.Text = "Ходы закончились.\r\nПобедил Игрок 1";
            }
            else
            {
                PlayerWinLabel.Text = "Победил Игрок 1";
            }
            ReturnMenuButton.Visible = true;
            ReturnMenuButton.Enabled = true;

        }

        private void Player2Win(bool noTurns)
        {
            viewModel.FirstPlayerHero.Health = 0;
            Player1HpLabel.Text = viewModel.FirstPlayerHero.Health.ToString();
            Player1HpProgressBar.Value = 0;
            if(noTurns)
            {
                PlayerWinLabel.Text = "Ходы закончились.\r\nПобедил Игрок 2";
            }
            else
            {
                PlayerWinLabel.Text = "Победил Игрок 2";
            }
            ReturnMenuButton.Visible = true;
            ReturnMenuButton.Enabled = true;
        }

        private void DrawWin(bool noTurns)
        {
            if (noTurns)
            {
                PlayerWinLabel.Text = "Ходы закончились.\r\nНичья";
            }
            else
            {
                PlayerWinLabel.Text = "Ничья";
            }
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
                viewModel.HeroPlayAttackAnim(Player1CharPicBox, Player2CharPicBox, true);
                Player2GetDamageLabel.Text = "Полученный урон: " + damageDealt;
                viewModel.GameFight.TurnSwitch();
                FrameUpdate();
                if (viewModel.SecondPlayerHero.Health <= 0)
                { Player1Win(false); }

            }
            catch
            {
                Player1Win(false);
            }
            
        }

        private void Player1Attack2MyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int damageDealt = viewModel.SecondPlayerHero.TakeDamage(viewModel.FirstPlayerHero.Attack2());
                viewModel.HeroPlayAttackAnim(Player1CharPicBox, Player2CharPicBox, true);
                Player2GetDamageLabel.Text = "Полученный урон: " + damageDealt;
                viewModel.GameFight.TurnSwitch();
                FrameUpdate();
                if (viewModel.SecondPlayerHero.Health <= 0)
                { Player1Win(false); }
            }
            catch
            {
                Player1Win(false);
            }
        }

        private void Player2Attack1MyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int damageDealt = viewModel.FirstPlayerHero.TakeDamage(viewModel.SecondPlayerHero.Attack1());
                viewModel.HeroPlayAttackAnim(Player2CharPicBox, Player1CharPicBox, false);
                Player1GetDamageLabel.Text = "Полученный урон: " + damageDealt;
                viewModel.GameFight.TurnSwitch();
                FrameUpdate();
                if (viewModel.FirstPlayerHero.Health <= 0)
                { Player2Win(false); }
            }
            catch
            {
                Player2Win(false);
            }
        }

        private void Player2Attack2MyButton_Click(object sender, EventArgs e)
        {
            try
            {
                int damageDealt = viewModel.FirstPlayerHero.TakeDamage(viewModel.SecondPlayerHero.Attack2());
                viewModel.HeroPlayAttackAnim(Player2CharPicBox, Player1CharPicBox, false);
                Player1GetDamageLabel.Text = "Полученный урон: " + damageDealt;
                viewModel.GameFight.TurnSwitch();
                FrameUpdate();
                if(viewModel.FirstPlayerHero.Health <= 0)
                { Player2Win(false); }
            }
            catch
            {              
                Player2Win(false);
            }
        }

        private void Player1InfoButton_Click(object sender, EventArgs e)
        {
            heroInfo = new HeroInfoForm(this, viewModel.FirstPlayerHero, viewModel);
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
            heroInfo = new HeroInfoForm(this, viewModel.SecondPlayerHero, viewModel);
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
            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Zvuc.mp3");
            viewModel.WMP.controls.play();
            viewModel.WMPMusic.controls.stop();
            FormRezizeToThisShowAndHide(returnMenuMain);
            viewModel.DeleteCharacters();
            this.Close();
        }
        private void ReturnMenuButtonм_MouseEnter(object sender, EventArgs e)
        {
            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Kcick.mp3");
            viewModel.WMP.controls.play();
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

        private void FightSceneMenu_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            FormRec = new Rectangle(this.Location, this.Size);
            Player1HeroNameLabelRec = new Rectangle(Player1HeroNameLabel.Location, Player1HeroNameLabel.Size);
            Player2HeroNameLabelRec = new Rectangle(Player2HeroNameLabel.Location, Player2HeroNameLabel.Size);
            Player1HpProgressBarRec = new Rectangle(Player1HpProgressBar.Location, Player1HpProgressBar.Size);
            Player2HpProgressBarRec = new Rectangle(Player2HpProgressBar.Location, Player2HpProgressBar.Size);
            Player1HpLabelRec = new Rectangle(Player1HpLabel.Location, Player1HpLabel.Size);
            Player2HpLabelRec = new Rectangle(Player2HpLabel.Location, Player2HpLabel.Size);
            TurnCounterLabelRec = new Rectangle(TurnCounterLabel.Location, TurnCounterLabel.Size);
            PlayerWinLabelRec = new Rectangle(PlayerWinLabel.Location, PlayerWinLabel.Size);
            Player1GetDamageLabelRec = new Rectangle(Player1GetDamageLabel.Location, Player1GetDamageLabel.Size);
            Player2GetDamageLabelRec = new Rectangle(Player2GetDamageLabel.Location, Player2GetDamageLabel.Size);
            ReturnMenuButtonRec = new Rectangle(ReturnMenuButton.Location, ReturnMenuButton.Size);
            Player1CharPicBoxRec = new Rectangle(Player1CharPicBox.Location, Player1CharPicBox.Size);
            Player2CharPicBoxRec = new Rectangle(Player2CharPicBox.Location, Player2CharPicBox.Size);

            viewModel.UseCustomFontLab(TurnCounterLabel);
            viewModel.UseCustomFontLab(PlayerWinLabel);
            viewModel.UseCustomFontLab(Player1HeroNameLabel);
            viewModel.UseCustomFontLab(Player2HeroNameLabel);
            viewModel.UseCustomFontLab(Player1HpLabel);
            viewModel.UseCustomFontLab(Player2HpLabel);
            viewModel.UseCustomFontLab(Player1GetDamageLabel);
            viewModel.UseCustomFontLab(Player2GetDamageLabel);
            viewModel.UseCustomFontBut(Player1InfoButton);
            viewModel.UseCustomFontBut(Player2InfoButton);

            this.WindowState = FormWindowState.Maximized;

            viewModel.WMPMusic.URL = Path.GetFullPath("../../Resources/Other/DabstepTraktori.mp3");
            viewModel.WMPMusic.controls.play();
        }

        private void FightSceneMenu_Resize(object sender, EventArgs e)
        {
            viewModel.ControlResize(Player1HeroNameLabelRec, FormRec, Player1HeroNameLabel, this);
            viewModel.ControlResize(Player2HeroNameLabelRec, FormRec, Player2HeroNameLabel, this);
            viewModel.ControlResize(Player1HpProgressBarRec, FormRec, Player1HpProgressBar, this);
            viewModel.ControlResize(Player2HpProgressBarRec, FormRec, Player2HpProgressBar, this);
            viewModel.ControlResize(Player1HpLabelRec, FormRec, Player1HpLabel, this);
            viewModel.ControlResize(Player2HpLabelRec, FormRec, Player2HpLabel, this);
            viewModel.ControlResize(TurnCounterLabelRec, FormRec, TurnCounterLabel, this);
            viewModel.ControlResize(PlayerWinLabelRec, FormRec, PlayerWinLabel, this);
            viewModel.ControlResize(Player1GetDamageLabelRec, FormRec, Player1GetDamageLabel, this);
            viewModel.ControlResize(Player2GetDamageLabelRec, FormRec, Player2GetDamageLabel, this);
            viewModel.ControlResize(ReturnMenuButtonRec, FormRec, ReturnMenuButton, this);
            viewModel.ControlResize(Player1CharPicBoxRec, FormRec, Player1CharPicBox, this);
            viewModel.ControlResize(Player2CharPicBoxRec, FormRec, Player2CharPicBox, this);
        }
    }
}
