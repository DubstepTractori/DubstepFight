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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void CheckIfPlayer2Dead()
        {
            if (Player2HPBar.Value <= 0)
            {
                MessageBox.Show("Игрок 2 убит");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Player1Skil1Button_Click(object sender, EventArgs e)
        {
            try
            {
                Player2HPBar.Value -= 10;
            }
            catch
            {
                Player2HPBar.Value = 0;
            }
            CheckIfPlayer2Dead();
        }
    }
}
