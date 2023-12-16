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
            this.Player1HeroNameLabel = new System.Windows.Forms.Label();
            this.Player1HpLabel = new System.Windows.Forms.Label();
            this.TurnCounterLabel = new System.Windows.Forms.Label();
            this.Player2HeroNameLabel = new System.Windows.Forms.Label();
            this.Player2HpLabel = new System.Windows.Forms.Label();
            this.Player2Attack2MyButton = new DubstepFight.MyCustomAttackButton1();
            this.Player2Attack1MyButton = new DubstepFight.MyCustomAttackButton1();
            this.Player1Attack2MyButton = new DubstepFight.MyCustomAttackButton1();
            this.Player1Attack1MyButton = new DubstepFight.MyCustomAttackButton1();
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
            this.Player2HpProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Player2HpProgressBar.Location = new System.Drawing.Point(450, 26);
            this.Player2HpProgressBar.Name = "Player2HpProgressBar";
            this.Player2HpProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Player2HpProgressBar.RightToLeftLayout = true;
            this.Player2HpProgressBar.Size = new System.Drawing.Size(338, 35);
            this.Player2HpProgressBar.TabIndex = 1;
            this.Player2HpProgressBar.Value = 100;
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
            this.Player1HpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player1HpLabel.Location = new System.Drawing.Point(23, 33);
            this.Player1HpLabel.Name = "Player1HpLabel";
            this.Player1HpLabel.Size = new System.Drawing.Size(52, 20);
            this.Player1HpLabel.TabIndex = 4;
            this.Player1HpLabel.Text = "0";
            this.Player1HpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TurnCounterLabel
            // 
            this.TurnCounterLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TurnCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TurnCounterLabel.Location = new System.Drawing.Point(360, 32);
            this.TurnCounterLabel.Name = "TurnCounterLabel";
            this.TurnCounterLabel.Size = new System.Drawing.Size(84, 29);
            this.TurnCounterLabel.TabIndex = 5;
            this.TurnCounterLabel.Text = "0";
            this.TurnCounterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TurnCounterLabel.UseWaitCursor = true;
            // 
            // Player2HeroNameLabel
            // 
            this.Player2HeroNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Player2HeroNameLabel.AutoSize = true;
            this.Player2HeroNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player2HeroNameLabel.Location = new System.Drawing.Point(708, 3);
            this.Player2HeroNameLabel.Name = "Player2HeroNameLabel";
            this.Player2HeroNameLabel.Size = new System.Drawing.Size(71, 20);
            this.Player2HeroNameLabel.TabIndex = 6;
            this.Player2HeroNameLabel.Text = "NoName";
            // 
            // Player2HpLabel
            // 
            this.Player2HpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Player2HpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player2HpLabel.Location = new System.Drawing.Point(733, 33);
            this.Player2HpLabel.Name = "Player2HpLabel";
            this.Player2HpLabel.Size = new System.Drawing.Size(46, 20);
            this.Player2HpLabel.TabIndex = 7;
            this.Player2HpLabel.Text = "0";
            this.Player2HpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player2Attack2MyButton
            // 
            this.Player2Attack2MyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Player2Attack2MyButton.BackColor = System.Drawing.Color.White;
            this.Player2Attack2MyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Player2Attack2MyButton.ForeColor = System.Drawing.Color.Black;
            this.Player2Attack2MyButton.Location = new System.Drawing.Point(585, 380);
            this.Player2Attack2MyButton.Name = "Player2Attack2MyButton";
            this.Player2Attack2MyButton.Size = new System.Drawing.Size(118, 49);
            this.Player2Attack2MyButton.TabIndex = 10;
            this.Player2Attack2MyButton.Text = "Атака 2";
            this.Player2Attack2MyButton.UseVisualStyleBackColor = false;
            this.Player2Attack2MyButton.Click += new System.EventHandler(this.Player2Attack2MyButton_Click);
            // 
            // Player2Attack1MyButton
            // 
            this.Player2Attack1MyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Player2Attack1MyButton.BackColor = System.Drawing.Color.White;
            this.Player2Attack1MyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Player2Attack1MyButton.ForeColor = System.Drawing.Color.Black;
            this.Player2Attack1MyButton.Location = new System.Drawing.Point(670, 300);
            this.Player2Attack1MyButton.Name = "Player2Attack1MyButton";
            this.Player2Attack1MyButton.Size = new System.Drawing.Size(118, 49);
            this.Player2Attack1MyButton.TabIndex = 9;
            this.Player2Attack1MyButton.Text = "Атака 1";
            this.Player2Attack1MyButton.UseVisualStyleBackColor = false;
            this.Player2Attack1MyButton.Click += new System.EventHandler(this.Player2Attack1MyButton_Click);
            // 
            // Player1Attack2MyButton
            // 
            this.Player1Attack2MyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Player1Attack2MyButton.BackColor = System.Drawing.Color.White;
            this.Player1Attack2MyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Player1Attack2MyButton.ForeColor = System.Drawing.Color.Black;
            this.Player1Attack2MyButton.Location = new System.Drawing.Point(74, 380);
            this.Player1Attack2MyButton.Name = "Player1Attack2MyButton";
            this.Player1Attack2MyButton.Size = new System.Drawing.Size(118, 49);
            this.Player1Attack2MyButton.TabIndex = 8;
            this.Player1Attack2MyButton.Text = "Атака 2";
            this.Player1Attack2MyButton.UseVisualStyleBackColor = false;
            this.Player1Attack2MyButton.Click += new System.EventHandler(this.Player1Attack2MyButton_Click);
            // 
            // Player1Attack1MyButton
            // 
            this.Player1Attack1MyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Player1Attack1MyButton.BackColor = System.Drawing.Color.White;
            this.Player1Attack1MyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Player1Attack1MyButton.ForeColor = System.Drawing.Color.Black;
            this.Player1Attack1MyButton.Location = new System.Drawing.Point(12, 300);
            this.Player1Attack1MyButton.Name = "Player1Attack1MyButton";
            this.Player1Attack1MyButton.Size = new System.Drawing.Size(118, 49);
            this.Player1Attack1MyButton.TabIndex = 2;
            this.Player1Attack1MyButton.Text = "Атака 1";
            this.Player1Attack1MyButton.UseVisualStyleBackColor = false;
            this.Player1Attack1MyButton.Click += new System.EventHandler(this.Player1Attack1MyButton_Click);
            // 
            // FightSceneMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Player2Attack2MyButton);
            this.Controls.Add(this.Player2Attack1MyButton);
            this.Controls.Add(this.Player1Attack2MyButton);
            this.Controls.Add(this.Player2HpLabel);
            this.Controls.Add(this.Player2HeroNameLabel);
            this.Controls.Add(this.TurnCounterLabel);
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
        private System.Windows.Forms.Label TurnCounterLabel;
        private System.Windows.Forms.Label Player2HeroNameLabel;
        private System.Windows.Forms.Label Player2HpLabel;
        private MyCustomAttackButton1 Player1Attack2MyButton;
        private MyCustomAttackButton1 Player2Attack1MyButton;
        private MyCustomAttackButton1 Player2Attack2MyButton;
    }
}