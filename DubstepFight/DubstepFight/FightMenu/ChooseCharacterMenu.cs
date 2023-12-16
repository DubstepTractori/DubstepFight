using DubstepFight.FightMenu;
using DubstepFightClassLibrary;
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
    public partial class ChooseCharacterMenu : Form
    {
        MainGameMenu menu;
        FightSceneMenu fight;

        Assasin ChosenAssasin;
        Elf ChosenElf;
        BlackKnight ChosenBlackKnight;
        Giant ChosenGiant;
        
        public ChooseCharacterMenu(MainGameMenu returnMenu)
        {
            InitializeComponent();
            this.menu = returnMenu;
        }

        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void ChooseHeroAssasinButton_Click(object sender, EventArgs e)
        {
            ChosenAssasin = new Assasin();
            fight = new FightSceneMenu(ChosenAssasin);

            fight.Show();
            fight.Location = this.Location;
            fight.Size = this.Size;
            this.Close();
        }

        private void ChooseHeroElfButton_Click(object sender, EventArgs e)
        {
            ChosenElf = new Elf();
            fight = new FightSceneMenu(ChosenElf);

            fight.Show();
            fight.Location = this.Location;
            fight.Size = this.Size;
            this.Close();
        }

        private void ChooseHeroBlackKnightButton_Click(object sender, EventArgs e)
        {
            ChosenBlackKnight = new BlackKnight();
            fight = new FightSceneMenu(ChosenBlackKnight);

            fight.Show();
            fight.Location = this.Location;
            fight.Size = this.Size;
            this.Close();
        }

        private void ChooseHeroGiantButton_Click(object sender, EventArgs e)
        {
            ChosenGiant = new Giant();
            fight = new FightSceneMenu(ChosenGiant);

            fight.Show();
            fight.Location = this.Location;
            fight.Size = this.Size;
            this.Close();
        }
    }
}
