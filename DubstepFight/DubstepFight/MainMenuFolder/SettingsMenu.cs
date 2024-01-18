using DubstepFight.MainMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DubstepFight
{
    public partial class SettingsMenu : Form
    {

        MainGameMenu menu;
        DevelopersCreditMenu Credits;
        MainViewModel viewModel;


        public SettingsMenu(MainGameMenu returnMenu, MainViewModel viewModel)
        {
            InitializeComponent();
            this.menu = returnMenu;
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }
        private void BackToMainMenuButton_MouseEnter(object sender, EventArgs e)
        {
            BackToMainMenuButton.ForeColor = Color.Magenta;
            BackToMainMenuButton.BackColor = Color.Magenta;
            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
            WMP.URL = Path.GetFullPath("../../Resources/Other/Kcick.mp3");
            WMP.settings.volume = 100; // меняя значение можно регулировать громкость
            WMP.controls.play();


        }
        private void BackToMainMenuButton_MouseLeave(object sender, EventArgs e)
        {
            BackToMainMenuButton.ForeColor = Color.Cyan;
            BackToMainMenuButton.BackColor = Color.Transparent;
        }

        private void DevelopersButton_Click(object sender, EventArgs e)
        {
            Credits = new DevelopersCreditMenu(this);
            Credits.Show();
            Credits.Location = this.Location;
            Credits.Size = this.Size;
            this.Hide();
        }
        private void DevelopersButton_MouseEnter(object sender, EventArgs e)
        {
            DevelopersButton.ForeColor = Color.Magenta;
            DevelopersButton.BackColor = Color.Magenta;
            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
            WMP.URL = Path.GetFullPath("../../Resources/Other/Kcick.mp3");
            WMP.settings.volume = 100; // меняя значение можно регулировать громкость
            WMP.controls.play();


        }
        private void DevelopersButton_MouseLeave(object sender, EventArgs e)
        {
            DevelopersButton.ForeColor = Color.Cyan;
            DevelopersButton.BackColor = Color.Transparent;
        }


        private void ChooseCharacterLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
