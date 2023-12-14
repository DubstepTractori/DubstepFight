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
    public partial class MyCustomAttackButton1 : Button
    {
        public MyCustomAttackButton1()
        {
            InitializeComponent();
            ButtonNormalState();
        }

        void ButtonNormalState()
        {
            this.Font = new Font("Microsoft Sans Serif", 14.25f);
            this.ForeColor = Color.Black;
            this.BackColor = Color.Gray;
        }

        void ButtonFocusedState()
        {
            this.Font = new Font("Microsoft Sans Serif", 19f);
            this.ForeColor = Color.Black;
            this.BackColor = Color.White;
        }


        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
            ButtonFocusedState();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            ButtonNormalState();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
