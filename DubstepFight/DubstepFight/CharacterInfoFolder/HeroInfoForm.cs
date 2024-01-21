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
        Rectangle ReturnMenuButtonRec;
        Rectangle FormRec;

        public HeroInfoForm(FightSceneMenu returnFight, BaseHero hero, MainViewModel viewModel)
        {
            InitializeComponent();
            ReturnFight = returnFight;
            Hero = hero;
            this.viewModel = viewModel;
        }

        private void ReturnMenuButton_Click(object sender, EventArgs e)
        {
            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Zvuc.mp3");
            viewModel.WMP.controls.play();
            ReturnFight.Show();
            this.Close();
        }
        private void ReturnMenuButton_MouseEnter(object sender, EventArgs e)
        {
            viewModel.WMP.URL = Path.GetFullPath("../../Resources/Other/Kcick.mp3");
            viewModel.WMP.controls.play();
            ReturnMenuButton.ForeColor = Color.Magenta;
            ReturnMenuButton.BackColor = Color.Magenta;
        }
        private void ReturnMenuButton_MouseLeave(object sender, EventArgs e)
        {
            ReturnMenuButton.ForeColor = Color.Cyan;
            ReturnMenuButton.BackColor = Color.Transparent;
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
            this.DoubleBuffered = true;

            ReturnMenuButtonRec = new Rectangle(ReturnMenuButton.Location, ReturnMenuButton.Size);
            FormRec = new Rectangle(this.Location, this.Size);

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
                fileReader.Close();
            }

            viewModel.UseCustomFontBut(ReturnMenuButton);
            viewModel.UseCustomFontLab(HeroBaseAttackInfoLabel);
            viewModel.UseCustomFontLab(HeroSkill1InfoLabel);
            viewModel.UseCustomFontLab(HeroPassiveInfoLabel);
            viewModel.UseCustomFontLab(HeroBaseAttackLabel);
            viewModel.UseCustomFontLab(HeroSkill1Label);
            viewModel.UseCustomFontLab(HaroPassiveLabel);

            HeroBaseAttackInfoLabel.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
            HeroSkill1InfoLabel.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
            HeroPassiveInfoLabel.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
            HeroBaseAttackLabel.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
            HeroSkill1Label.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
            HaroPassiveLabel.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
            this.WindowState = FormWindowState.Maximized;
        }

        private void HeroInfoForm_Resize_1(object sender, EventArgs e)
        {
            //viewModel.ControlResize(ReturnMenuButtonRec, FormRec, ReturnMenuButton, this);
        }

    }
}
