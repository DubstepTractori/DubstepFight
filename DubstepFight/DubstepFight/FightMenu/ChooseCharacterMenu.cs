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
    public partial class ChooseCharacterMenu : Form
    {
        MainGameMenu menu;

        public ChooseCharacterMenu(MainGameMenu returnMenu)
        {
            InitializeComponent();
            this.menu = returnMenu;
        }

        private void ReturnToMenuButton_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }
    }
}
