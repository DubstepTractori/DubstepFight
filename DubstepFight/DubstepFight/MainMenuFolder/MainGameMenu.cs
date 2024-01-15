using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DubstepFight
{
    public partial class MainGameMenu : Form
    {
        public MainGameMenu()
        {
            InitializeComponent();
        }

        ChooseCharacterMenu ChooseCharacter;
        SettingsMenu Settings;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChoosePlayer1Button_Click(object sender, EventArgs e)
        {
            ChooseCharacter = new ChooseCharacterMenu(this);
            ChooseCharacter.Show();
            ChooseCharacter.Size = this.Size;
            ChooseCharacter.Location = this.Location;
            this.Hide();
        }

        private void ChoosePlayer2Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная фунция пока недоступна");
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings = new SettingsMenu(this);
            Settings.Show();
            Settings.Size = this.Size;
            Settings.Location = this.Location;

            this.Hide();
        }

        private void MainGameMenu_Load(object sender, EventArgs e)
        {
        }
    }
}
