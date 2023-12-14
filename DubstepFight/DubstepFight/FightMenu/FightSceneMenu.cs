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
    public partial class FightSceneMenu : Form
    {
        BaseHero ChosenHero;



        public FightSceneMenu(BaseHero chosenHero)
        {
            InitializeComponent();
            ChosenHero = chosenHero;
            Player1HeroNameLabel.Text = chosenHero.Name;
            Player1HpLabel.Text = chosenHero.Health.ToString();
        }
    }
}
