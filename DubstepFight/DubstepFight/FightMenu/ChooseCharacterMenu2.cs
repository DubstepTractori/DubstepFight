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

namespace DubstepFight.FightMenu
{
    public partial class ChooseCharacterMenu2 : Form
    {

        FightSceneMenu fightMenu;
        ChooseCharacterMenu returnMenu;
        MainGameMenu returnMenuMain;
        BaseHero chosenHeroPlayer1;
        BaseHero chosenHeroPlayer2;

        
        public ChooseCharacterMenu2(ChooseCharacterMenu ReturnMenu, BaseHero ChosenHeroPlayer1, MainGameMenu ReturnMenuMain)
        {
            InitializeComponent();
            returnMenu = ReturnMenu;
            chosenHeroPlayer1 = ChosenHeroPlayer1;
            returnMenuMain = ReturnMenuMain;

        }

        private void ChooseHeroAssasinButton_Click(object sender, EventArgs e)
        {
            chosenHeroPlayer2 = new Assasin();
            fightMenu = new FightSceneMenu(chosenHeroPlayer1, chosenHeroPlayer2, returnMenuMain);

            fightMenu.Show();
            fightMenu.Location = this.Location;
            fightMenu.Size = this.Size;
            returnMenu.Close();
            this.Close();
        }

        private void ChooseHeroElfButton_Click(object sender, EventArgs e)
        {
            chosenHeroPlayer2 = new Elf();
            fightMenu = new FightSceneMenu(chosenHeroPlayer1, chosenHeroPlayer2, returnMenuMain);

            fightMenu.Show();
            fightMenu.Location = this.Location;
            fightMenu.Size = this.Size;
            returnMenu.Close();
            this.Close();
        }

        private void ChooseHeroBlackKnightButton_Click(object sender, EventArgs e)
        {
            chosenHeroPlayer2 = new BlackKnight();
            fightMenu = new FightSceneMenu(chosenHeroPlayer1, chosenHeroPlayer2, returnMenuMain);

            fightMenu.Show();
            fightMenu.Location = this.Location;
            fightMenu.Size = this.Size;
            returnMenu.Close();
            this.Close();
        }

        private void ChooseHeroGiantButton_Click(object sender, EventArgs e)
        {
            chosenHeroPlayer2 = new Giant();
            fightMenu = new FightSceneMenu(chosenHeroPlayer1, chosenHeroPlayer2, returnMenuMain);

            fightMenu.Show();
            fightMenu.Location = this.Location;
            fightMenu.Size = this.Size;
            returnMenu.Close();
            this.Close();
        }

        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            returnMenu.Show();
            this.Close();
        }
    }
}
