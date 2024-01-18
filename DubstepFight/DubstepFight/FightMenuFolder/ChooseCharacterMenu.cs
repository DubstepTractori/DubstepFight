using DubstepFight.FightMenu;
using DubstepFightClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DubstepFight
{
    public partial class ChooseCharacterMenu : Form
    {
        MainGameMenu menu;

        FightSceneMenu fightMenu;
        MainViewModel viewModel;
        
        public ChooseCharacterMenu(MainGameMenu returnMenu, MainViewModel viewModel)
        {
            InitializeComponent();
            this.menu = returnMenu;
            this.viewModel = viewModel;
            this.label1.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
            this.label2.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
            this.label3.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
            this.label4.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);

        }

        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
            WMP.URL = Path.GetFullPath("../../Resources/Other/Zvuc.mp3");
            WMP.settings.volume = 100; // меняя значение можно регулировать громкость
            WMP.controls.play();
        }
        private void ReturnToMenuButton_MouseEnter(object sender, EventArgs e)
        {
            ReturnToMenuButton.ForeColor = Color.Magenta;
            ReturnToMenuButton.BackColor = Color.Magenta;
            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
            WMP.URL = Path.GetFullPath("../../Resources/Other/Kcick.mp3");
            WMP.settings.volume = 100; // меняя значение можно регулировать громкость
            WMP.controls.play();


        }
        private void ReturnToMenuButton_MouseLeave(object sender, EventArgs e)
        {
            ReturnToMenuButton.ForeColor = Color.Cyan;
            ReturnToMenuButton.BackColor = Color.Transparent;
        }

        private void CreateHeroAction(string heroName)
        {
            viewModel.CreateHero(heroName);

            ChooseCharacterLabel.Text = "Выберите персонажа для\r\nИгрока 2";

            if (viewModel.CreationCompleted)
            {
                fightMenu = new FightSceneMenu(menu, viewModel);

                fightMenu.Show();
                fightMenu.Location = this.Location;
                fightMenu.Size = this.Size;
                this.Close();
            }
        }

        private void ChooseHeroAssasinButton_Click(object sender, EventArgs e)
        {
            CreateHeroAction("Assassin");
            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
            WMP.URL = Path.GetFullPath("../../Resources/Other/Zvuc.mp3");
            WMP.settings.volume = 100; // меняя значение можно регулировать громкость
            WMP.controls.play();
        }


        private void ChooseHeroElfButton_Click(object sender, EventArgs e)
        {
            CreateHeroAction("Elf");
            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
            WMP.URL = Path.GetFullPath("../../Resources/Other/Zvuc.mp3");
            WMP.settings.volume = 100; // меняя значение можно регулировать громкость
            WMP.controls.play();
        }

        private void ChooseHeroBlackKnightButton_Click(object sender, EventArgs e)
        {
            CreateHeroAction("BlackKnight");
            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
            WMP.URL = Path.GetFullPath("../../Resources/Other/Zvuc.mp3");
            WMP.settings.volume = 100; // меняя значение можно регулировать громкость
            WMP.controls.play();
        }

        private void ChooseHeroGiantButton_Click(object sender, EventArgs e)
        {
            CreateHeroAction("Giant");
            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
            WMP.URL = Path.GetFullPath("../../Resources/Other/Zvuc.mp3");
            WMP.settings.volume = 100; // меняя значение можно регулировать громкость
            WMP.controls.play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ChooseCharacterMenu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
