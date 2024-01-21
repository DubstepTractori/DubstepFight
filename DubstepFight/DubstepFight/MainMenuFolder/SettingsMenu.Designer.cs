namespace DubstepFight
{
    partial class SettingsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsMenu));
            this.DevelopersButton = new System.Windows.Forms.Button();
            this.SettingsLabel = new System.Windows.Forms.Label();
            this.BackToMainMenuButton = new System.Windows.Forms.Button();
            this.SoundVolumeTrackBar = new System.Windows.Forms.TrackBar();
            this.SoundVolumeLabel = new System.Windows.Forms.Label();
            this.SoundVolumeNumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SoundVolumeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // DevelopersButton
            // 
            this.DevelopersButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DevelopersButton.BackColor = System.Drawing.Color.Transparent;
            this.DevelopersButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DevelopersButton.BackgroundImage")));
            this.DevelopersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DevelopersButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DevelopersButton.FlatAppearance.BorderSize = 0;
            this.DevelopersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DevelopersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevelopersButton.ForeColor = System.Drawing.Color.Cyan;
            this.DevelopersButton.Location = new System.Drawing.Point(291, 125);
            this.DevelopersButton.Name = "DevelopersButton";
            this.DevelopersButton.Size = new System.Drawing.Size(210, 53);
            this.DevelopersButton.TabIndex = 0;
            this.DevelopersButton.Text = "Authors";
            this.DevelopersButton.UseVisualStyleBackColor = false;
            this.DevelopersButton.Click += new System.EventHandler(this.DevelopersButton_Click);
            this.DevelopersButton.MouseEnter += new System.EventHandler(this.DevelopersButton_MouseEnter);
            this.DevelopersButton.MouseLeave += new System.EventHandler(this.DevelopersButton_MouseLeave);
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SettingsLabel.AutoSize = true;
            this.SettingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.SettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsLabel.ForeColor = System.Drawing.Color.Cyan;
            this.SettingsLabel.Location = new System.Drawing.Point(357, 60);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new System.Drawing.Size(84, 24);
            this.SettingsLabel.TabIndex = 2;
            this.SettingsLabel.Text = "Settings";
            this.SettingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SettingsLabel.Click += new System.EventHandler(this.ChooseCharacterLabel_Click);
            // 
            // BackToMainMenuButton
            // 
            this.BackToMainMenuButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BackToMainMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.BackToMainMenuButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackToMainMenuButton.BackgroundImage")));
            this.BackToMainMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackToMainMenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToMainMenuButton.FlatAppearance.BorderSize = 0;
            this.BackToMainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMainMenuButton.ForeColor = System.Drawing.Color.Cyan;
            this.BackToMainMenuButton.Location = new System.Drawing.Point(619, 375);
            this.BackToMainMenuButton.Name = "BackToMainMenuButton";
            this.BackToMainMenuButton.Size = new System.Drawing.Size(169, 63);
            this.BackToMainMenuButton.TabIndex = 4;
            this.BackToMainMenuButton.Text = "Back";
            this.BackToMainMenuButton.UseVisualStyleBackColor = false;
            this.BackToMainMenuButton.Click += new System.EventHandler(this.BackToMainMenuButton_Click);
            this.BackToMainMenuButton.MouseEnter += new System.EventHandler(this.BackToMainMenuButton_MouseEnter);
            this.BackToMainMenuButton.MouseLeave += new System.EventHandler(this.BackToMainMenuButton_MouseLeave);
            // 
            // SoundVolumeTrackBar
            // 
            this.SoundVolumeTrackBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SoundVolumeTrackBar.Location = new System.Drawing.Point(245, 268);
            this.SoundVolumeTrackBar.Maximum = 100;
            this.SoundVolumeTrackBar.Name = "SoundVolumeTrackBar";
            this.SoundVolumeTrackBar.Size = new System.Drawing.Size(304, 45);
            this.SoundVolumeTrackBar.TabIndex = 5;
            this.SoundVolumeTrackBar.TickFrequency = 10;
            this.SoundVolumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.SoundVolumeTrackBar.Scroll += new System.EventHandler(this.SoundVolumeTrackBar_Scroll);
            // 
            // SoundVolumeLabel
            // 
            this.SoundVolumeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SoundVolumeLabel.AutoSize = true;
            this.SoundVolumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.SoundVolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoundVolumeLabel.ForeColor = System.Drawing.Color.Cyan;
            this.SoundVolumeLabel.Location = new System.Drawing.Point(347, 256);
            this.SoundVolumeLabel.Name = "SoundVolumeLabel";
            this.SoundVolumeLabel.Size = new System.Drawing.Size(82, 24);
            this.SoundVolumeLabel.TabIndex = 6;
            this.SoundVolumeLabel.Text = "Volume";
            this.SoundVolumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SoundVolumeNumLabel
            // 
            this.SoundVolumeNumLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SoundVolumeNumLabel.AutoSize = true;
            this.SoundVolumeNumLabel.BackColor = System.Drawing.Color.Transparent;
            this.SoundVolumeNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoundVolumeNumLabel.ForeColor = System.Drawing.Color.Cyan;
            this.SoundVolumeNumLabel.Location = new System.Drawing.Point(241, 316);
            this.SoundVolumeNumLabel.Name = "SoundVolumeNumLabel";
            this.SoundVolumeNumLabel.Size = new System.Drawing.Size(59, 24);
            this.SoundVolumeNumLabel.TabIndex = 7;
            this.SoundVolumeNumLabel.Text = "100%";
            this.SoundVolumeNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SoundVolumeNumLabel);
            this.Controls.Add(this.SoundVolumeLabel);
            this.Controls.Add(this.SoundVolumeTrackBar);
            this.Controls.Add(this.BackToMainMenuButton);
            this.Controls.Add(this.SettingsLabel);
            this.Controls.Add(this.DevelopersButton);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "SettingsMenu";
            this.Text = "SettingsMenu";
            this.Load += new System.EventHandler(this.SettingsMenu_Load);
            this.Resize += new System.EventHandler(this.SettingsMenu_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.SoundVolumeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DevelopersButton;
        private System.Windows.Forms.Label SettingsLabel;
        private System.Windows.Forms.Button BackToMainMenuButton;
        private System.Windows.Forms.TrackBar SoundVolumeTrackBar;
        private System.Windows.Forms.Label SoundVolumeLabel;
        private System.Windows.Forms.Label SoundVolumeNumLabel;
    }
}