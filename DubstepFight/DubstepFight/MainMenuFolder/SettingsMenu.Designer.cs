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
            this.ChooseCharacterLabel = new System.Windows.Forms.Label();
            this.BackToMainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DevelopersButton
            // 
            this.DevelopersButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DevelopersButton.BackColor = System.Drawing.Color.Transparent;
            this.DevelopersButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DevelopersButton.BackgroundImage")));
            this.DevelopersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DevelopersButton.FlatAppearance.BorderSize = 0;
            this.DevelopersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DevelopersButton.Font = new System.Drawing.Font("ascii", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // ChooseCharacterLabel
            // 
            this.ChooseCharacterLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChooseCharacterLabel.AutoSize = true;
            this.ChooseCharacterLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChooseCharacterLabel.Font = new System.Drawing.Font("ascii", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseCharacterLabel.ForeColor = System.Drawing.Color.Cyan;
            this.ChooseCharacterLabel.Location = new System.Drawing.Point(341, 53);
            this.ChooseCharacterLabel.Name = "ChooseCharacterLabel";
            this.ChooseCharacterLabel.Size = new System.Drawing.Size(110, 24);
            this.ChooseCharacterLabel.TabIndex = 2;
            this.ChooseCharacterLabel.Text = "Settings";
            this.ChooseCharacterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChooseCharacterLabel.Click += new System.EventHandler(this.ChooseCharacterLabel_Click);
            // 
            // BackToMainMenuButton
            // 
            this.BackToMainMenuButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BackToMainMenuButton.BackColor = System.Drawing.Color.Transparent;
            this.BackToMainMenuButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackToMainMenuButton.BackgroundImage")));
            this.BackToMainMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackToMainMenuButton.FlatAppearance.BorderSize = 0;
            this.BackToMainMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToMainMenuButton.Font = new System.Drawing.Font("ascii", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackToMainMenuButton);
            this.Controls.Add(this.ChooseCharacterLabel);
            this.Controls.Add(this.DevelopersButton);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "SettingsMenu";
            this.Text = "SettingsMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DevelopersButton;
        private System.Windows.Forms.Label ChooseCharacterLabel;
        private System.Windows.Forms.Button BackToMainMenuButton;
    }
}