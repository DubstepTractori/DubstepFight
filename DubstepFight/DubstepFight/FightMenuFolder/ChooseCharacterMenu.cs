﻿using DubstepFight.FightMenu;
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

        FightSceneMenu fightMenu;
        MainViewModel viewModel;
        
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
        }


        private void ChooseHeroElfButton_Click(object sender, EventArgs e)
        {
            CreateHeroAction("Elf");
        }

        private void ChooseHeroBlackKnightButton_Click(object sender, EventArgs e)
        {
            CreateHeroAction("BlackKnight");
        }

        private void ChooseHeroGiantButton_Click(object sender, EventArgs e)
        {
            CreateHeroAction("Giant");
        }
    }
}
