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
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Magenta;
            button1.BackColor = Color.Magenta;

        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Cyan;
            button1.BackColor = Color.Transparent;
        }
        

        private void ChoosePlayer1Button_MouseEnter(object sender, EventArgs e)
        {
            ChoosePlayer1Button.ForeColor = Color.Magenta;
            ChoosePlayer1Button.BackColor = Color.Magenta;


        }
        private void ChoosePlayer1Button_MouseLeave(object sender, EventArgs e)
        {
            ChoosePlayer1Button.ForeColor = Color.Cyan;
            ChoosePlayer1Button.BackColor = Color.Transparent;
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
        private void SettingsButton_MouseEnter(object sender, EventArgs e)
        {
            SettingsButton.ForeColor = Color.Magenta;
            SettingsButton.BackColor = Color.Magenta;

        }
        private void SettingsButton_MouseLeave(object sender, EventArgs e)
        {
            SettingsButton.ForeColor = Color.Cyan;
            SettingsButton.BackColor = Color.Transparent;
        }

        private void MainGameMenu_Load(object sender, EventArgs e)
        {
        }
    }
}
