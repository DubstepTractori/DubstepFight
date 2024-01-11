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

    public partial class BlackKnightInfoForm : Form
    {

        FightSceneMenu ReturnFight;
        public BlackKnightInfoForm(FightSceneMenu returnFight)
        {
            InitializeComponent();


            ReturnFight = returnFight;


        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ReturnFight.Show();
        }
    }
}
