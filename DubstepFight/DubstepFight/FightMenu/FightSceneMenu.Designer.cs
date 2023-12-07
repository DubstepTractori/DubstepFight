namespace DubstepFight.FightMenu
{
    partial class FightSceneMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Player1HpProgressBar = new System.Windows.Forms.ProgressBar();
            this.Player2HpProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // Player1HpProgressBar
            // 
            this.Player1HpProgressBar.Location = new System.Drawing.Point(12, 26);
            this.Player1HpProgressBar.Name = "Player1HpProgressBar";
            this.Player1HpProgressBar.Size = new System.Drawing.Size(342, 35);
            this.Player1HpProgressBar.TabIndex = 0;
            this.Player1HpProgressBar.Value = 100;
            // 
            // Player2HpProgressBar
            // 
            this.Player2HpProgressBar.Location = new System.Drawing.Point(450, 26);
            this.Player2HpProgressBar.Name = "Player2HpProgressBar";
            this.Player2HpProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Player2HpProgressBar.RightToLeftLayout = true;
            this.Player2HpProgressBar.Size = new System.Drawing.Size(338, 35);
            this.Player2HpProgressBar.TabIndex = 1;
            this.Player2HpProgressBar.Value = 100;
            // 
            // FightSceneMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Player2HpProgressBar);
            this.Controls.Add(this.Player1HpProgressBar);
            this.Name = "FightSceneMenu";
            this.Text = "Dubstep Fight";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar Player1HpProgressBar;
        private System.Windows.Forms.ProgressBar Player2HpProgressBar;
    }
}