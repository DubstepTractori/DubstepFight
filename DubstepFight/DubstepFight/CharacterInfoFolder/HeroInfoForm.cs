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

        private void TextClear()
        {
            HeroNameLabel.Text = "";
            HeroBaseAttackInfoLabel.Text = "";
            HeroSkill1InfoLabel.Text = "";
            HeroPassiveInfoLabel.Text = "";
        }
        private void HeroInfoForm_Load(object sender, EventArgs e)
        {
            TextClear();
            HeroNameLabel.Text = Hero.Name;

            using (StreamReader fileReader = new StreamReader(Hero.CharInfoTxtPath))
            {
                string line = "";
                
                while((line = fileReader.ReadLine()) != "=Border=")
                {
                    HeroBaseAttackInfoLabel.Text += line += "\r\n";
                }
                while ((line = fileReader.ReadLine()) != "=Border=")
                {
                    HeroSkill1InfoLabel.Text += line += "\r\n";
                }
                while ((line = fileReader.ReadLine()) != "=Border=")
                {
                    HeroPassiveInfoLabel.Text += line += "\r\n";
                }
            }

        }
    }
}
