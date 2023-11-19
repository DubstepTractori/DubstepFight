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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        Form2 MainGame;


        private void button2_Click(object sender, EventArgs e)
        {
            MainGame = new Form2();
            MainGame.Show();  
        }

        private void Player1MenuButton_Click(object sender, EventArgs e)
        {
            MainGame = new Form2();
            MainGame.Show();
        }
    }
}
