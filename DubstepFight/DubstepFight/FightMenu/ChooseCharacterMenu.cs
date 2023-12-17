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
        ChooseCharacterMenu2 chooseCharacter2;

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
            chooseCharacter2 = new ChooseCharacterMenu2(this, ChosenAssasin);

            chooseCharacter2.Show();
            chooseCharacter2.Location = this.Location;
            chooseCharacter2.Size = this.Size;
            this.Close();
        }

        private void ChooseHeroElfButton_Click(object sender, EventArgs e)
        {
            ChosenElf = new Elf();
            chooseCharacter2 = new ChooseCharacterMenu2(this, ChosenElf);

            chooseCharacter2.Show();
            chooseCharacter2.Location = this.Location;
            chooseCharacter2.Size = this.Size;
            this.Close();
        }

        private void ChooseHeroBlackKnightButton_Click(object sender, EventArgs e)
        {
            ChosenBlackKnight = new BlackKnight();
            chooseCharacter2 = new ChooseCharacterMenu2(this, ChosenBlackKnight);

            chooseCharacter2.Show();
            chooseCharacter2.Location = this.Location;
            chooseCharacter2.Size = this.Size;
            this.Close();
        }

        private void ChooseHeroGiantButton_Click(object sender, EventArgs e)
        {
            ChosenGiant = new Giant();
            chooseCharacter2 = new ChooseCharacterMenu2(this, ChosenGiant);

            chooseCharacter2.Show();
            chooseCharacter2.Location = this.Location;
            chooseCharacter2.Size = this.Size;
            this.Close();
        }
    }
}
