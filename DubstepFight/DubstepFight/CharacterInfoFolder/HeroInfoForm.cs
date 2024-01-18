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
        MainViewModel viewModel;
        Rectangle ReturnButtonRec;
        Rectangle FormRec;

        public HeroInfoForm(FightSceneMenu returnFight, BaseHero hero, MainViewModel viewModel)
        {
            InitializeComponent();
            ReturnFight = returnFight;
            Hero = hero;
            this.viewModel = viewModel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            ReturnFight.Show();
        }
        private void returnButton_MouseEnter(object sender, EventArgs e)
        {
            returnButton.ForeColor = Color.Magenta;
            returnButton.BackColor = Color.Magenta;


        }
        private void returnButton_MouseLeave(object sender, EventArgs e)
        {
            returnButton.ForeColor = Color.Cyan;
            returnButton.BackColor = Color.Transparent;
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
            ReturnButtonRec = new Rectangle(returnButton.Location, returnButton.Size);

            TextClear();
            HeroNameLabel.Text = Hero.Name;

            using (StreamReader fileReader = new StreamReader(Hero.CharInfoTxtPath))
            {
                string line = "";

                while ((line = fileReader.ReadLine()) != "=Border=")
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

        private void HeroInfoForm_Resize(object sender, EventArgs e)
        {
            viewModel.ControlResize(ReturnButtonRec, FormRec, returnButton, this);
        }
    }
}
