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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FightSceneMenu));
            this.Player1HpProgressBar = new System.Windows.Forms.ProgressBar();
            this.Player2HpProgressBar = new System.Windows.Forms.ProgressBar();
            this.Player1HeroNameLabel = new System.Windows.Forms.Label();
            this.Player1HpLabel = new System.Windows.Forms.Label();
            this.TurnCounterLabel = new System.Windows.Forms.Label();
            this.Player2HeroNameLabel = new System.Windows.Forms.Label();
            this.Player2HpLabel = new System.Windows.Forms.Label();
            this.Player1InfoButton = new System.Windows.Forms.Button();
            this.Player2InfoButton = new System.Windows.Forms.Button();
            this.Player1GetDamageLabel = new System.Windows.Forms.Label();
            this.Player2GetDamageLabel = new System.Windows.Forms.Label();
            this.PlayerWinLabel = new System.Windows.Forms.Label();
            this.Player1CharPicBox = new System.Windows.Forms.PictureBox();
            this.Player2CharPicBox = new System.Windows.Forms.PictureBox();
            this.ReturnMenuButton = new System.Windows.Forms.Button();
            this.Player2Attack2MyButton = new DubstepFight.MyCustomAttackButton1();
            this.Player2Attack1MyButton = new DubstepFight.MyCustomAttackButton1();
            this.Player1Attack2MyButton = new DubstepFight.MyCustomAttackButton1();
            this.Player1Attack1MyButton = new DubstepFight.MyCustomAttackButton1();
            ((System.ComponentModel.ISupportInitialize)(this.Player1CharPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2CharPicBox)).BeginInit();
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
            this.Player2HpProgressBar.ForeColor = System.Drawing.Color.Aqua;
            this.Player2HpProgressBar.Location = new System.Drawing.Point(450, 26);
            this.Player2HpProgressBar.Name = "Player2HpProgressBar";
            this.Player2HpProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Player2HpProgressBar.RightToLeftLayout = true;
            this.Player2HpProgressBar.Size = new System.Drawing.Size(338, 35);
            this.Player2HpProgressBar.TabIndex = 1;
            this.Player2HpProgressBar.Value = 100;
            this.Player2HpProgressBar.Click += new System.EventHandler(this.Player2HpProgressBar_Click);
            // 
            // Player1HeroNameLabel
            // 
            this.Player1HeroNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.Player1HeroNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1HeroNameLabel.ForeColor = System.Drawing.Color.Aqua;
            this.Player1HeroNameLabel.Location = new System.Drawing.Point(12, 3);
            this.Player1HeroNameLabel.Name = "Player1HeroNameLabel";
            this.Player1HeroNameLabel.Size = new System.Drawing.Size(342, 20);
            this.Player1HeroNameLabel.TabIndex = 3;
            this.Player1HeroNameLabel.Text = "NoName";
            // 
            // Player1HpLabel
            // 
            this.Player1HpLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Player1HpLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player1HpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1HpLabel.ForeColor = System.Drawing.Color.Aqua;
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
            this.TurnCounterLabel.BackColor = System.Drawing.Color.Transparent;
            this.TurnCounterLabel.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.TurnCounterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TurnCounterLabel.ForeColor = System.Drawing.Color.Aqua;
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
            this.Player2HeroNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.Player2HeroNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2HeroNameLabel.ForeColor = System.Drawing.Color.Aqua;
            this.Player2HeroNameLabel.Location = new System.Drawing.Point(450, 3);
            this.Player2HeroNameLabel.Name = "Player2HeroNameLabel";
            this.Player2HeroNameLabel.Size = new System.Drawing.Size(338, 20);
            this.Player2HeroNameLabel.TabIndex = 6;
            this.Player2HeroNameLabel.Text = "NoName";
            this.Player2HeroNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Player2HpLabel
            // 
            this.Player2HpLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Player2HpLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Player2HpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2HpLabel.ForeColor = System.Drawing.Color.Aqua;
            this.Player2HpLabel.Location = new System.Drawing.Point(733, 33);
            this.Player2HpLabel.Name = "Player2HpLabel";
            this.Player2HpLabel.Size = new System.Drawing.Size(46, 20);
            this.Player2HpLabel.TabIndex = 7;
            this.Player2HpLabel.Text = "0";
            this.Player2HpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player1InfoButton
            // 
            this.Player1InfoButton.BackColor = System.Drawing.Color.Transparent;
            this.Player1InfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Player1InfoButton.BackgroundImage")));
            this.Player1InfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player1InfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Player1InfoButton.FlatAppearance.BorderSize = 0;
            this.Player1InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player1InfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1InfoButton.ForeColor = System.Drawing.Color.Aqua;
            this.Player1InfoButton.Location = new System.Drawing.Point(12, 176);
            this.Player1InfoButton.Name = "Player1InfoButton";
            this.Player1InfoButton.Size = new System.Drawing.Size(39, 43);
            this.Player1InfoButton.TabIndex = 11;
            this.Player1InfoButton.Text = "i";
            this.Player1InfoButton.UseVisualStyleBackColor = false;
            this.Player1InfoButton.Click += new System.EventHandler(this.Player1InfoButton_Click);
            this.Player1InfoButton.MouseEnter += new System.EventHandler(this.Player1InfoButton_MouseEnter);
            this.Player1InfoButton.MouseLeave += new System.EventHandler(this.Player1InfoButton_MouseLeave);
            // 
            // Player2InfoButton
            // 
            this.Player2InfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Player2InfoButton.BackColor = System.Drawing.Color.Transparent;
            this.Player2InfoButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Player2InfoButton.BackgroundImage")));
            this.Player2InfoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player2InfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Player2InfoButton.FlatAppearance.BorderSize = 0;
            this.Player2InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player2InfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2InfoButton.ForeColor = System.Drawing.Color.Aqua;
            this.Player2InfoButton.Location = new System.Drawing.Point(749, 176);
            this.Player2InfoButton.Name = "Player2InfoButton";
            this.Player2InfoButton.Size = new System.Drawing.Size(39, 43);
            this.Player2InfoButton.TabIndex = 12;
            this.Player2InfoButton.Text = "i";
            this.Player2InfoButton.UseVisualStyleBackColor = false;
            this.Player2InfoButton.Click += new System.EventHandler(this.Player2InfoButton_Click);
            this.Player2InfoButton.MouseEnter += new System.EventHandler(this.Player2InfoButton_MouseEnter);
            this.Player2InfoButton.MouseLeave += new System.EventHandler(this.Player2InfoButton_MouseLeave);
            // 
            // Player1GetDamageLabel
            // 
            this.Player1GetDamageLabel.BackColor = System.Drawing.Color.Transparent;
            this.Player1GetDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1GetDamageLabel.ForeColor = System.Drawing.Color.Aqua;
            this.Player1GetDamageLabel.Location = new System.Drawing.Point(13, 104);
            this.Player1GetDamageLabel.Name = "Player1GetDamageLabel";
            this.Player1GetDamageLabel.Size = new System.Drawing.Size(341, 20);
            this.Player1GetDamageLabel.TabIndex = 13;
            this.Player1GetDamageLabel.Text = "NoDamageGet";
            // 
            // Player2GetDamageLabel
            // 
            this.Player2GetDamageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Player2GetDamageLabel.BackColor = System.Drawing.Color.Transparent;
            this.Player2GetDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2GetDamageLabel.ForeColor = System.Drawing.Color.Aqua;
            this.Player2GetDamageLabel.Location = new System.Drawing.Point(450, 104);
            this.Player2GetDamageLabel.Name = "Player2GetDamageLabel";
            this.Player2GetDamageLabel.Size = new System.Drawing.Size(338, 20);
            this.Player2GetDamageLabel.TabIndex = 14;
            this.Player2GetDamageLabel.Text = "NoDamageGet";
            this.Player2GetDamageLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PlayerWinLabel
            // 
            this.PlayerWinLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PlayerWinLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerWinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerWinLabel.ForeColor = System.Drawing.Color.Aqua;
            this.PlayerWinLabel.Location = new System.Drawing.Point(232, 75);
            this.PlayerWinLabel.Name = "PlayerWinLabel";
            this.PlayerWinLabel.Size = new System.Drawing.Size(341, 20);
            this.PlayerWinLabel.TabIndex = 15;
            this.PlayerWinLabel.Text = "NoWin";
            this.PlayerWinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player1CharPicBox
            // 
            this.Player1CharPicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player1CharPicBox.BackColor = System.Drawing.Color.Transparent;
            this.Player1CharPicBox.Location = new System.Drawing.Point(157, 179);
            this.Player1CharPicBox.Name = "Player1CharPicBox";
            this.Player1CharPicBox.Size = new System.Drawing.Size(165, 195);
            this.Player1CharPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1CharPicBox.TabIndex = 16;
            this.Player1CharPicBox.TabStop = false;
            // 
            // Player2CharPicBox
            // 
            this.Player2CharPicBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Player2CharPicBox.BackColor = System.Drawing.Color.Transparent;
            this.Player2CharPicBox.Location = new System.Drawing.Point(479, 179);
            this.Player2CharPicBox.Name = "Player2CharPicBox";
            this.Player2CharPicBox.Size = new System.Drawing.Size(165, 195);
            this.Player2CharPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2CharPicBox.TabIndex = 17;
            this.Player2CharPicBox.TabStop = false;
            this.Player2CharPicBox.Click += new System.EventHandler(this.Player2CharPicBox_Click);
            // 
            // ReturnMenuButton
            // 
            this.ReturnMenuButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ReturnMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.ReturnMenuButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReturnMenuButton.BackgroundImage")));
            this.ReturnMenuButton.FlatAppearance.BorderSize = 0;
            this.ReturnMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnMenuButton.ForeColor = System.Drawing.Color.Aqua;
            this.ReturnMenuButton.Location = new System.Drawing.Point(308, 104);
            this.ReturnMenuButton.Name = "ReturnMenuButton";
            this.ReturnMenuButton.Size = new System.Drawing.Size(197, 69);
            this.ReturnMenuButton.TabIndex = 18;
            this.ReturnMenuButton.Text = "Back to Menu\r\n";
            this.ReturnMenuButton.UseVisualStyleBackColor = false;
            this.ReturnMenuButton.Click += new System.EventHandler(this.ReturnMenuButton_Click);
            this.ReturnMenuButton.MouseEnter += new System.EventHandler(this.ReturnMenuButtonм_MouseEnter);
            this.ReturnMenuButton.MouseLeave += new System.EventHandler(this.ReturnMenuButton_MouseLeave);
            // 
            // Player2Attack2MyButton
            // 
            this.Player2Attack2MyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Player2Attack2MyButton.BackColor = System.Drawing.Color.Transparent;
            this.Player2Attack2MyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player2Attack2MyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Player2Attack2MyButton.FlatAppearance.BorderSize = 0;
            this.Player2Attack2MyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player2Attack2MyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Player2Attack2MyButton.ForeColor = System.Drawing.Color.Black;
            this.Player2Attack2MyButton.Location = new System.Drawing.Point(609, 380);
            this.Player2Attack2MyButton.Name = "Player2Attack2MyButton";
            this.Player2Attack2MyButton.Size = new System.Drawing.Size(120, 50);
            this.Player2Attack2MyButton.TabIndex = 10;
            this.Player2Attack2MyButton.UseVisualStyleBackColor = false;
            this.Player2Attack2MyButton.Click += new System.EventHandler(this.Player2Attack2MyButton_Click);
            // 
            // Player2Attack1MyButton
            // 
            this.Player2Attack1MyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Player2Attack1MyButton.BackColor = System.Drawing.Color.Transparent;
            this.Player2Attack1MyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player2Attack1MyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Player2Attack1MyButton.FlatAppearance.BorderSize = 0;
            this.Player2Attack1MyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player2Attack1MyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Player2Attack1MyButton.ForeColor = System.Drawing.Color.Black;
            this.Player2Attack1MyButton.Location = new System.Drawing.Point(670, 300);
            this.Player2Attack1MyButton.Name = "Player2Attack1MyButton";
            this.Player2Attack1MyButton.Size = new System.Drawing.Size(120, 50);
            this.Player2Attack1MyButton.TabIndex = 9;
            this.Player2Attack1MyButton.UseVisualStyleBackColor = false;
            this.Player2Attack1MyButton.Click += new System.EventHandler(this.Player2Attack1MyButton_Click);
            // 
            // Player1Attack2MyButton
            // 
            this.Player1Attack2MyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Player1Attack2MyButton.BackColor = System.Drawing.Color.Transparent;
            this.Player1Attack2MyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player1Attack2MyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Player1Attack2MyButton.FlatAppearance.BorderSize = 0;
            this.Player1Attack2MyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player1Attack2MyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Player1Attack2MyButton.ForeColor = System.Drawing.Color.Black;
            this.Player1Attack2MyButton.Location = new System.Drawing.Point(74, 380);
            this.Player1Attack2MyButton.Name = "Player1Attack2MyButton";
            this.Player1Attack2MyButton.Size = new System.Drawing.Size(120, 50);
            this.Player1Attack2MyButton.TabIndex = 8;
            this.Player1Attack2MyButton.UseVisualStyleBackColor = false;
            this.Player1Attack2MyButton.Click += new System.EventHandler(this.Player1Attack2MyButton_Click);
            // 
            // Player1Attack1MyButton
            // 
            this.Player1Attack1MyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Player1Attack1MyButton.BackColor = System.Drawing.Color.Transparent;
            this.Player1Attack1MyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Player1Attack1MyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Player1Attack1MyButton.FlatAppearance.BorderSize = 0;
            this.Player1Attack1MyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player1Attack1MyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Player1Attack1MyButton.ForeColor = System.Drawing.Color.Black;
            this.Player1Attack1MyButton.Location = new System.Drawing.Point(12, 300);
            this.Player1Attack1MyButton.Name = "Player1Attack1MyButton";
            this.Player1Attack1MyButton.Size = new System.Drawing.Size(120, 50);
            this.Player1Attack1MyButton.TabIndex = 2;
            this.Player1Attack1MyButton.UseVisualStyleBackColor = false;
            this.Player1Attack1MyButton.Click += new System.EventHandler(this.Player1Attack1MyButton_Click);
            // 
            // FightSceneMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnMenuButton);
            this.Controls.Add(this.Player2CharPicBox);
            this.Controls.Add(this.Player1CharPicBox);
            this.Controls.Add(this.PlayerWinLabel);
            this.Controls.Add(this.Player2GetDamageLabel);
            this.Controls.Add(this.Player1GetDamageLabel);
            this.Controls.Add(this.Player2InfoButton);
            this.Controls.Add(this.Player1InfoButton);
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
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FightSceneMenu";
            this.Text = "Dubstep Fight";
            this.Load += new System.EventHandler(this.FightSceneMenu_Load);
            this.Resize += new System.EventHandler(this.FightSceneMenu_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Player1CharPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2CharPicBox)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button Player1InfoButton;
        private System.Windows.Forms.Button Player2InfoButton;
        private System.Windows.Forms.Label Player1GetDamageLabel;
        private System.Windows.Forms.Label Player2GetDamageLabel;
        private System.Windows.Forms.Label PlayerWinLabel;
        private System.Windows.Forms.PictureBox Player1CharPicBox;
        private System.Windows.Forms.PictureBox Player2CharPicBox;
        private System.Windows.Forms.Button ReturnMenuButton;
    }
}