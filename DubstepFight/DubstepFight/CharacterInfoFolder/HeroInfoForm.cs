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
            this.HeroNameLabel.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
            this.HeroBaseAttackInfoLabel.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
            this.HeroPassiveInfoLabel.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
            this.HeroSkill1Label.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
            this.HeroBaseAttackLabel.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
            this.HeroSkill1InfoLabel.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
            this.HaroPassiveLabel.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
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
            WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
            WMP.URL = Path.GetFullPath("../../Resources/Other/Kcick.mp3");
            WMP.settings.volume = 100; // меняя значение можно регулировать громкость
            WMP.controls.play();


        }
        private void returnButton_MouseLeave(object sender, EventArgs e)
        {
            returnButton.ForeColor = Color.Cyan;
            returnButton.BackColor = Color.Transparent;
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

        private void HeroNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void HeroSkill1InfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void HeroBaseAttackInfoLabel_Click(object sender, EventArgs e)
        {

        }

        private void HaroPassiveLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
