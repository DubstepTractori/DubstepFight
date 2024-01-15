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


        public SettingsMenu(MainGameMenu returnMenu)
        {
            InitializeComponent();
            this.menu = returnMenu;
        }

        private void BackToMainMenuButton_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void DevelopersButton_Click(object sender, EventArgs e)
        {
            Credits = new DevelopersCreditMenu(this);
            Credits.Show();
            Credits.Location = this.Location;
            Credits.Size = this.Size;
            this.Hide();
        }
    }
}
