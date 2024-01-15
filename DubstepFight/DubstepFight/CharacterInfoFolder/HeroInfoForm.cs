using DubstepFight.FightMenu;
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

namespace DubstepFight.CharacterInfoFolder
{
    public partial class HeroInfoForm : Form
    {

        FightSceneMenu ReturnFight;
        BaseHero Hero;
        public HeroInfoForm(FightSceneMenu returnFight, BaseHero hero)
        {
            InitializeComponent();
            ReturnFight = returnFight;
            Hero = hero;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ReturnFight.Show();
        }

        private void HeroInfoForm_Load(object sender, EventArgs e)
        {
            HeroNameLabel.Text = Hero.Name;

            using (StreamReader fileReader = new StreamReader(Hero.CharInfoTxtPath))
            {
                string line = "";
                
                while(line != "=Border=")
                {
                    line = fileReader.ReadLine();
                    HeroBaseAttackInfoLabel.Text += line;
                }
            }

        }
    }
}
