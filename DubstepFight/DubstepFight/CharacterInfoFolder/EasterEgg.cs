using DubstepFight.FightMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DubstepFight.CharacterInfoFolder
{
    public partial class EasterEgg : Form
    {
        FightSceneMenu returnGame;

        public EasterEgg(FightSceneMenu ReturnMenu)
        {
            returnGame = ReturnMenu;
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            returnGame.Show();
            this.Close();
        }
    }
}
