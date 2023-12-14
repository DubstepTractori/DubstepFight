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
            this.Player1Attack1MyButton = new DubstepFight.MyCustomAttackButton1();
            this.Player1HeroNameLabel = new System.Windows.Forms.Label();
            this.Player1HpLabel = new System.Windows.Forms.Label();
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
            // Player1Attack1MyButton
            // 
            this.Player1Attack1MyButton.BackColor = System.Drawing.Color.Gray;
            this.Player1Attack1MyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Player1Attack1MyButton.ForeColor = System.Drawing.Color.Gray;
            this.Player1Attack1MyButton.Location = new System.Drawing.Point(12, 300);
            this.Player1Attack1MyButton.Name = "Player1Attack1MyButton";
            this.Player1Attack1MyButton.Size = new System.Drawing.Size(118, 49);
            this.Player1Attack1MyButton.TabIndex = 2;
            this.Player1Attack1MyButton.Text = "Атака";
            this.Player1Attack1MyButton.UseVisualStyleBackColor = false;
            // 
            // Player1HeroNameLabel
            // 
            this.Player1HeroNameLabel.AutoSize = true;
            this.Player1HeroNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player1HeroNameLabel.Location = new System.Drawing.Point(12, 3);
            this.Player1HeroNameLabel.Name = "Player1HeroNameLabel";
            this.Player1HeroNameLabel.Size = new System.Drawing.Size(71, 20);
            this.Player1HeroNameLabel.TabIndex = 3;
            this.Player1HeroNameLabel.Text = "NoName";
            // 
            // Player1HpLabel
            // 
            this.Player1HpLabel.AutoSize = true;
            this.Player1HpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player1HpLabel.Location = new System.Drawing.Point(23, 33);
            this.Player1HpLabel.Name = "Player1HpLabel";
            this.Player1HpLabel.Size = new System.Drawing.Size(18, 20);
            this.Player1HpLabel.TabIndex = 4;
            this.Player1HpLabel.Text = "0";
            this.Player1HpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FightSceneMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Player1HpLabel);
            this.Controls.Add(this.Player1HeroNameLabel);
            this.Controls.Add(this.Player1Attack1MyButton);
            this.Controls.Add(this.Player2HpProgressBar);
            this.Controls.Add(this.Player1HpProgressBar);
            this.Name = "FightSceneMenu";
            this.Text = "Dubstep Fight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar Player1HpProgressBar;
        private System.Windows.Forms.ProgressBar Player2HpProgressBar;
        private MyCustomAttackButton1 Player1Attack1MyButton;
        private System.Windows.Forms.Label Player1HeroNameLabel;
        private System.Windows.Forms.Label Player1HpLabel;
    }
}