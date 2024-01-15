using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
        }

        private void GitHubLinkButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/DubstepTractori");
        }
        private void GitHubLinkButton_MouseEnter(object sender, EventArgs e)
        {
            GitHubLinkButton.ForeColor = Color.Magenta;
            GitHubLinkButton.BackColor = Color.Magenta;


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
        }
        private void BackToSettingsButton_MouseEnter(object sender, EventArgs e)
        {
            BackToSettingsButton.ForeColor = Color.Magenta;
            BackToSettingsButton.BackColor = Color.Magenta;


        }
        private void BackToSettingsButton_MouseLeave(object sender, EventArgs e)
        {
            BackToSettingsButton.ForeColor = Color.Cyan;
            BackToSettingsButton.BackColor = Color.Transparent;
        }

        private void DimaCreditLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
