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
            
        }

        ChooseCharacterMenu ChooseCharacter;
        SettingsMenu Settings;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
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
        }

        private void ChoosePlayer2Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данная фунция пока недоступна");
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Settings = new SettingsMenu(this, viewModel);
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
            FormRec = new Rectangle(this.Location, this.Size);
            ExitButtonRec = new Rectangle(ExitButton.Location, ExitButton.Size);
            StartGameButtonRec = new Rectangle(StartGameButton.Location, StartGameButton.Size);
            SettingsButtonRec = new Rectangle(SettingsButton.Location, SettingsButton.Size);
            WelcomeLabelRec = new Rectangle(WelcomeLabel.Location, WelcomeLabel.Size);
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
