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
        MainViewModel viewModel;
        Rectangle GitHubLinkRec;
        Rectangle BackToSettingsRec;
        Rectangle FormRec;
        Rectangle CreditsLabelRec;

        public DevelopersCreditMenu(SettingsMenu returnSettings, MainViewModel viewModel)
        {
            InitializeComponent();
            this.Settings = returnSettings;
            this.viewModel = viewModel;
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

        private void DevelopersCreditMenu_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            FormRec = new Rectangle(this.Location, this.Size);
            BackToSettingsRec = new Rectangle(BackToSettingsButton.Location, BackToSettingsButton.Size);
            GitHubLinkRec = new Rectangle(GitHubLinkButton.Location, GitHubLinkButton.Size);
            CreditsLabelRec = new Rectangle(CreditsLabel.Location, CreditsLabel.Size);

            viewModel.UseCustomFontBut(BackToSettingsButton);
            viewModel.UseCustomFontBut(GitHubLinkButton);
            viewModel.UseCustomFontLab(CreditsLabel);

            this.WindowState = FormWindowState.Maximized;
        }

        private void DevelopersCreditMenu_Resize(object sender, EventArgs e)
        {
            viewModel.ControlResize(BackToSettingsRec, FormRec, BackToSettingsButton, this);
            viewModel.ControlResize(GitHubLinkRec, FormRec, GitHubLinkButton, this);
            viewModel.ControlResize(CreditsLabelRec, FormRec, CreditsLabel, this);
        }
    }
}
