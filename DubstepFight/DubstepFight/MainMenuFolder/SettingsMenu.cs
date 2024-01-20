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
        Rectangle SettingsLabelRec;
        Rectangle ReturnMainMenuButtonRec;
        Rectangle DevelopersButtonRec;
        Rectangle SoundVolumeTrackBarRec;
        Rectangle SoundVolumeLabelRec;
        Rectangle SoundVolumeNumLabelRec;
        Rectangle FormRec;

        public SettingsMenu(MainGameMenu returnMenu, MainViewModel viewModel)
        {
            InitializeComponent();
            this.menu = returnMenu;
            this.viewModel = viewModel;
            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
            viewModel.WMP.settings.volume = viewModel.WMPVolume;
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

            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Kcick.mp3");
            viewModel.WMP.controls.play();


        }
        private void BackToMainMenuButton_MouseLeave(object sender, EventArgs e)
        {
            BackToMainMenuButton.ForeColor = Color.Cyan;
            BackToMainMenuButton.BackColor = Color.Transparent;
        }

        private void DevelopersButton_Click(object sender, EventArgs e)
        {
            Credits = new DevelopersCreditMenu(this, viewModel);
            Credits.Show();
            Credits.Location = this.Location;
            Credits.Size = this.Size;
            this.Hide();
        }
        private void DevelopersButton_MouseEnter(object sender, EventArgs e)
        {
            DevelopersButton.ForeColor = Color.Magenta;
            DevelopersButton.BackColor = Color.Magenta;
            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Kcick.mp3");
            viewModel.WMP.controls.play();


        }
        private void DevelopersButton_MouseLeave(object sender, EventArgs e)
        {
            DevelopersButton.ForeColor = Color.Cyan;
            DevelopersButton.BackColor = Color.Transparent;
        }


        private void ChooseCharacterLabel_Click(object sender, EventArgs e)
        {

        }

        private void SoundVolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            viewModel.WMPVolume = SoundVolumeTrackBar.Value;
            viewModel.WMP.settings.volume = SoundVolumeTrackBar.Value;
            viewModel.WMPMusic.settings.volume = SoundVolumeTrackBar.Value;
            SoundVolumeNumLabel.Text = SoundVolumeTrackBar.Value.ToString() + "%";
        }
        private void SettingsMenu_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            SettingsLabelRec = new Rectangle(SettingsLabel.Location, SettingsLabel.Size);
            DevelopersButtonRec = new Rectangle(DevelopersButton.Location, DevelopersButton.Size);
            ReturnMainMenuButtonRec = new Rectangle(BackToMainMenuButton.Location, BackToMainMenuButton.Size);
            SoundVolumeTrackBarRec = new Rectangle(SoundVolumeTrackBar.Location, SoundVolumeTrackBar.Size);
            SoundVolumeLabelRec = new Rectangle(SoundVolumeLabel.Location, SoundVolumeLabel.Size);
            SoundVolumeNumLabelRec = new Rectangle(SoundVolumeNumLabel.Location, SoundVolumeNumLabel.Size);
            FormRec = new Rectangle(this.Location, this.Size);

            viewModel.UseCustomFontLab(SettingsLabel);
            viewModel.UseCustomFontBut(BackToMainMenuButton);
            viewModel.UseCustomFontBut(DevelopersButton);
            viewModel.UseCustomFontLab(SoundVolumeLabel);
            viewModel.UseCustomFontLab(SoundVolumeNumLabel);

            SoundVolumeTrackBar.Value = viewModel.WMPVolume;
            SoundVolumeNumLabel.Text = viewModel.WMPVolume.ToString() + "%"; 

            this.WindowState = FormWindowState.Maximized;
        }

        private void SettingsMenu_Resize(object sender, EventArgs e)
        {
            viewModel.ControlResize(SettingsLabelRec, FormRec, SettingsLabel, this);
            viewModel.ControlResize(DevelopersButtonRec, FormRec, DevelopersButton, this);
            viewModel.ControlResize(ReturnMainMenuButtonRec, FormRec, BackToMainMenuButton, this);
            viewModel.ControlResize(SoundVolumeTrackBarRec, FormRec, SoundVolumeTrackBar, this);
            viewModel.ControlResize(SoundVolumeLabelRec, FormRec, SoundVolumeLabel, this);
            viewModel.ControlResize(SoundVolumeNumLabelRec, FormRec, SoundVolumeNumLabel, this);
        }
    }
}
