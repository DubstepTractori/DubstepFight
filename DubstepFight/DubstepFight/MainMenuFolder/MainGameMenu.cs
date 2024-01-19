using DubstepFight.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace DubstepFight
{
    public partial class MainGameMenu : Form
    {
        MainViewModel viewModel;
        Rectangle FormRec;
        Rectangle ExitButtonRec;
        Rectangle StartGameButtonRec;
        Rectangle SettingsButtonRec;
        Rectangle WelcomeLabelRec;

        public MainGameMenu()
        {
            InitializeComponent();
            viewModel = new MainViewModel();
            viewModel.MinecraftFont.AddFontFile(@"..\..\Resources\Other\MinecraftRusNEW.otf");
            
        }

        ChooseCharacterMenu ChooseCharacter;
        SettingsMenu Settings;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {

            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Kcick.mp3");
            viewModel.WMP.controls.play();
            ExitButton.ForeColor = Color.Magenta;
            ExitButton.BackColor = Color.Magenta;

        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {

            ExitButton.ForeColor = Color.Cyan;
            ExitButton.BackColor = Color.Transparent;
        }


        private void ChoosePlayer1Button_MouseEnter(object sender, EventArgs e)
        {
            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Kcick.mp3");
            viewModel.WMP.controls.play();
            StartGameButton.ForeColor = Color.Magenta;
            StartGameButton.BackColor = Color.Magenta;


        }
        private void ChoosePlayer1Button_MouseLeave(object sender, EventArgs e)
        {
            StartGameButton.ForeColor = Color.Cyan;
            StartGameButton.BackColor = Color.Transparent;
        }
        private void ChoosePlayer1Button_Click(object sender, EventArgs e)
        {
            ChooseCharacter = new ChooseCharacterMenu(this, viewModel);
            ChooseCharacter.Show();
            ChooseCharacter.Size = this.Size;
            ChooseCharacter.Location = this.Location;
            this.Hide();
            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Zvuc.mp3");
            viewModel.WMP.controls.play();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings = new SettingsMenu(this, viewModel);
            Settings.Show();
            Settings.Size = this.Size;
            Settings.Location = this.Location;
            this.Hide();
            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Zvuc.mp3");
            viewModel.WMP.controls.play();
        }
        private void SettingsButton_MouseEnter(object sender, EventArgs e)
        {
            SettingsButton.ForeColor = Color.Magenta;
            SettingsButton.BackColor = Color.Magenta;
            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Kcick.mp3");
            viewModel.WMP.controls.play();

        }
        private void SettingsButton_MouseLeave(object sender, EventArgs e)
        {
            SettingsButton.ForeColor = Color.Cyan;
            SettingsButton.BackColor = Color.Transparent;
        }

        private void MainGameMenu_Load(object sender, EventArgs e)
        {
            FormRec = new Rectangle(this.Location, this.Size);
            ExitButtonRec = new Rectangle(ExitButton.Location, ExitButton.Size);
            StartGameButtonRec = new Rectangle(StartGameButton.Location, StartGameButton.Size);
            SettingsButtonRec = new Rectangle(SettingsButton.Location, SettingsButton.Size);
            WelcomeLabelRec = new Rectangle(WelcomeLabel.Location, WelcomeLabel.Size);

            viewModel.UseCustomFontLab(WelcomeLabel);
            viewModel.UseCustomFontBut(StartGameButton);
            viewModel.UseCustomFontBut(SettingsButton);
            viewModel.UseCustomFontBut(ExitButton);

            viewModel.WMP.settings.volume = viewModel.WMPVolume;

            this.WindowState = FormWindowState.Maximized;

            viewModel.WMPMusic.URL = Path.GetFullPath("../../Resources/Other/DR_GABBA_Sunday_2PM.mp3");
            viewModel.WMPMusic.controls.play();
        }

        private void MainGameMenu_Resize_1(object sender, EventArgs e)
        {
            viewModel.ControlResize(ExitButtonRec, FormRec, ExitButton, this);
            viewModel.ControlResize(StartGameButtonRec, FormRec, StartGameButton, this);
            viewModel.ControlResize(SettingsButtonRec, FormRec, SettingsButton, this);
            viewModel.ControlResize(WelcomeLabelRec, FormRec, WelcomeLabel, this);
        }
    }
}
