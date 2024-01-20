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
        Rectangle FormRec;
        Rectangle AssassinPicBoxRec;
        Rectangle AssassinLabelRec;
        Rectangle ElfPicBoxRec;
        Rectangle ElfLabelRec;
        Rectangle BlackKnightPicBoxRec;
        Rectangle BlackKnightLabelRec;
        Rectangle GiantPicBoxRec;
        Rectangle GiantLabelRec;
        Rectangle ChooseCharacterLabelRec;
        Rectangle ReturnToMenuButtonRec;



        public ChooseCharacterMenu(MainGameMenu returnMenu, MainViewModel viewModel)
        {
            InitializeComponent();
            this.menu = returnMenu;
            this.viewModel = viewModel;
        }

        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Zvuc.mp3");
            viewModel.WMP.controls.play();
        }
        private void ReturnToMenuButton_MouseEnter(object sender, EventArgs e)
        {
            ReturnToMenuButton.ForeColor = Color.Magenta;
            ReturnToMenuButton.BackColor = Color.Magenta;
            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Kcick.mp3");
            viewModel.WMP.controls.play();


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

        private void ChooseCharacterMenu_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            FormRec = new Rectangle(this.Location, this.Size);
            AssassinPicBoxRec = new Rectangle(AssassinPicBox.Location, AssassinPicBox.Size);
            AssassinLabelRec = new Rectangle(AssassinLabel.Location, AssassinLabel.Size);
            ElfPicBoxRec = new Rectangle(ElfPicBox.Location, ElfPicBox.Size);
            ElfLabelRec = new Rectangle(ElfLabel.Location, ElfLabel.Size);
            BlackKnightPicBoxRec = new Rectangle(BlackKnightPicBox.Location, BlackKnightPicBox.Size);
            BlackKnightLabelRec = new Rectangle(BlackKnightLabel.Location, BlackKnightLabel.Size);
            GiantPicBoxRec = new Rectangle(GiantPicBox.Location, GiantPicBox.Size);
            GiantLabelRec = new Rectangle(GiantLabel.Location, GiantLabel.Size);
            ChooseCharacterLabelRec = new Rectangle(ChooseCharacterLabel.Location, ChooseCharacterLabel.Size);
            ReturnToMenuButtonRec = new Rectangle(ReturnToMenuButton.Location, ReturnToMenuButton.Size);

            viewModel.UseCustomFontLab(ChooseCharacterLabel);
            viewModel.UseCustomFontLab(AssassinLabel);
            viewModel.UseCustomFontLab(ElfLabel);
            viewModel.UseCustomFontLab(BlackKnightLabel);
            viewModel.UseCustomFontLab(GiantLabel);
            viewModel.UseCustomFontBut(ReturnToMenuButton);

            this.WindowState = FormWindowState.Maximized;
        }

        private void ChooseCharacterMenu_Resize(object sender, EventArgs e)
        {
            viewModel.ControlResize(AssassinPicBoxRec, FormRec, AssassinPicBox, this);
            viewModel.ControlResize(AssassinLabelRec, FormRec, AssassinLabel, this);
            viewModel.ControlResize(ElfPicBoxRec, FormRec, ElfPicBox, this);
            viewModel.ControlResize(ElfLabelRec, FormRec, ElfLabel, this);
            viewModel.ControlResize(BlackKnightPicBoxRec, FormRec, BlackKnightPicBox, this);
            viewModel.ControlResize(BlackKnightLabelRec, FormRec, BlackKnightLabel, this);
            viewModel.ControlResize(GiantPicBoxRec, FormRec, GiantPicBox, this);
            viewModel.ControlResize(GiantLabelRec, FormRec, GiantLabel, this);
            viewModel.ControlResize(ChooseCharacterLabelRec, FormRec, ChooseCharacterLabel, this);
            viewModel.ControlResize(ReturnToMenuButtonRec, FormRec, ReturnToMenuButton, this);
        }

        private void AssassinPicBox_Click(object sender, EventArgs e)
        {
            CreateHeroAction("Assassin");
            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Zvuc.mp3");
            viewModel.WMP.controls.play();
        }

        private void ElfPicBox_Click(object sender, EventArgs e)
        {
            CreateHeroAction("Elf");
            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Zvuc.mp3");
            viewModel.WMP.controls.play();
        }

        private void BlackKnightPicBox_Click(object sender, EventArgs e)
        {
            CreateHeroAction("BlackKnight");
            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Zvuc.mp3");
            viewModel.WMP.controls.play();
        }

        private void GiantPicBox_Click(object sender, EventArgs e)
        {
            CreateHeroAction("Giant");
            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Zvuc.mp3");
            viewModel.WMP.controls.play();
        }

        private void AssassinPicBox_MouseEnter(object sender, EventArgs e)
        {
            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Kcick.mp3");
            viewModel.WMP.controls.play();
        }

        private void ElfPicBox_MouseEnter(object sender, EventArgs e)
        {
            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Kcick.mp3");
            viewModel.WMP.controls.play();
        }

        private void BlackKnightPicBox_MouseEnter(object sender, EventArgs e)
        {
            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Kcick.mp3");
            viewModel.WMP.controls.play();
        }

        private void GiantPicBox_MouseEnter(object sender, EventArgs e)
        {
            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Kcick.mp3");
            viewModel.WMP.controls.play();
        }
    }
}
