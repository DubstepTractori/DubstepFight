using DubstepFight.FightMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DubstepFight.CharacterInfoFolder
{
    public partial class EasterEgg : Form
    {
        private Rectangle formRec;
        private Rectangle retunButtonRec;
        private FightSceneMenu returnGame;

        public EasterEgg(FightSceneMenu ReturnMenu)
        {
            InitializeComponent();
            returnGame = ReturnMenu;
            
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            returnGame.Show();
            this.Close();
        }

        private void EasterEgg_Load(object sender, EventArgs e)
        {
            retunButtonRec = new Rectangle(ReturnButton.Location, ReturnButton.Size);
            formRec = new Rectangle(this.Location, this.Size);
        }

        private void ControlResize(Rectangle r, Control c)
        {
            float ratioX = (float)(this.Width) / (float)(formRec.Width);
            float ratioY = (float)(this.Height) / (float)(formRec.Height);

            int newX = (int)(r.Location.X * ratioX);
            int newY = (int)(r.Location.Y * ratioY);

            int newWidth = (int)(r.Width * ratioX);
            int newHeight = (int)(r.Height * ratioY);


            c.Location = new Point(newX, newY);
            c.Size = new Size(newWidth, newHeight);
        }

        private void EasterEgg_Resize(object sender, EventArgs e)
        {
            ControlResize(retunButtonRec, ReturnButton);
        }
    }
}
