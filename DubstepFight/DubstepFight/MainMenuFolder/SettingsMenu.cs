using DubstepFight.MainMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        Rectangle FormRec;


        public SettingsMenu(MainGameMenu returnMenu, MainViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
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


        }
        private void DevelopersButton_MouseLeave(object sender, EventArgs e)
        {
            DevelopersButton.ForeColor = Color.Cyan;
            DevelopersButton.BackColor = Color.Transparent;
        }


        private void ChooseCharacterLabel_Click(object sender, EventArgs e)
        {

        }

        private void SettingsMenu_Load(object sender, EventArgs e)
        {
            SettingsLabelRec = new Rectangle(SettingsLabel.Location, SettingsLabel.Size);
            DevelopersButtonRec = new Rectangle(DevelopersButton.Location, DevelopersButton.Size);
            ReturnMainMenuButtonRec = new Rectangle(BackToMainMenuButton.Location, BackToMainMenuButton.Size);
            FormRec = new Rectangle(this.Location, this.Size);

            viewModel.UseCustomFontLab(SettingsLabel);
            viewModel.UseCustomFontBut(BackToMainMenuButton);
            viewModel.UseCustomFontBut(DevelopersButton);
        }

        private void SettingsMenu_Resize(object sender, EventArgs e)
        {
            viewModel.ControlResize(SettingsLabelRec, FormRec, SettingsLabel, this);
            viewModel.ControlResize(DevelopersButtonRec, FormRec, DevelopersButton, this);
            viewModel.ControlResize(ReturnMainMenuButtonRec, FormRec, BackToMainMenuButton, this);
        }
    }
}
