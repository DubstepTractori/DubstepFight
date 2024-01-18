using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DubstepFight.MainMenu
{
    public partial class DevelopersCreditMenu : Form
    {
        SettingsMenu Settings;

        public DevelopersCreditMenu(SettingsMenu returnSettings)
        {
            InitializeComponent();
            this.Settings = returnSettings;
            this.GarikCreditLabel.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
            this.VadimCreditLabel.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
            this.AntonCreditLabel.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
            this.DimaCreditLabel.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
        }

        private void GitHubLinkButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/DubstepTractori");
            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
            WMP.URL = Path.GetFullPath("../../Resources/Other/Zvuc.mp3");
            WMP.settings.volume = 100; // меняя значение можно регулировать громкость
            WMP.controls.play();
        }
        private void GitHubLinkButton_MouseEnter(object sender, EventArgs e)
        {
            GitHubLinkButton.ForeColor = Color.Magenta;
            GitHubLinkButton.BackColor = Color.Magenta;
            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
            WMP.URL = Path.GetFullPath("../../Resources/Other/Kcick.mp3");
            WMP.settings.volume = 100; // меняя значение можно регулировать громкость
            WMP.controls.play();


        }
        private void GitHubLinkButton_MouseLeave(object sender, EventArgs e)
        {
            GitHubLinkButton.ForeColor = Color.Cyan;
            GitHubLinkButton.BackColor = Color.Transparent;
        }

        private void BackToSettingsButton_Click(object sender, EventArgs e)
        {
            Settings.Show();
            this.Close();
            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
            WMP.URL = Path.GetFullPath("../../Resources/Other/Zvuc.mp3");
            WMP.settings.volume = 100; // меняя значение можно регулировать громкость
            WMP.controls.play();
        }
        private void BackToSettingsButton_MouseEnter(object sender, EventArgs e)
        {
            BackToSettingsButton.ForeColor = Color.Magenta;
            BackToSettingsButton.BackColor = Color.Magenta;
            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
            WMP.URL = Path.GetFullPath("../../Resources/Other/Kcick.mp3");
            WMP.settings.volume = 100; // меняя значение можно регулировать громкость
            WMP.controls.play();


        }
        private void BackToSettingsButton_MouseLeave(object sender, EventArgs e)
        {
            BackToSettingsButton.ForeColor = Color.Cyan;
            BackToSettingsButton.BackColor = Color.Transparent;
        }

        private void DimaCreditLabel_Click(object sender, EventArgs e)
        {
            

        }

        private void GarikCreditLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
