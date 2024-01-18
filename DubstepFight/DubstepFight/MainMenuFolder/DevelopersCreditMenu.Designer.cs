namespace DubstepFight.MainMenu
{
    partial class DevelopersCreditMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevelopersCreditMenu));
            this.CreditsLabel = new System.Windows.Forms.Label();
            this.BackToSettingsButton = new System.Windows.Forms.Button();
            this.GitHubLinkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreditsLabel
            // 
            this.CreditsLabel.BackColor = System.Drawing.Color.Transparent;
            this.CreditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreditsLabel.ForeColor = System.Drawing.Color.Azure;
            this.CreditsLabel.Location = new System.Drawing.Point(12, 36);
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(776, 284);
            this.CreditsLabel.TabIndex = 4;
            this.CreditsLabel.Text = resources.GetString("CreditsLabel.Text");
            // 
            // BackToSettingsButton
            // 
            this.BackToSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackToSettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.BackToSettingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackToSettingsButton.BackgroundImage")));
            this.BackToSettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackToSettingsButton.FlatAppearance.BorderSize = 0;
            this.BackToSettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToSettingsButton.ForeColor = System.Drawing.Color.Cyan;
            this.BackToSettingsButton.Location = new System.Drawing.Point(616, 378);
            this.BackToSettingsButton.Name = "BackToSettingsButton";
            this.BackToSettingsButton.Size = new System.Drawing.Size(172, 60);
            this.BackToSettingsButton.TabIndex = 6;
            this.BackToSettingsButton.Text = "Back";
            this.BackToSettingsButton.UseVisualStyleBackColor = false;
            this.BackToSettingsButton.Click += new System.EventHandler(this.BackToSettingsButton_Click);
            this.BackToSettingsButton.MouseEnter += new System.EventHandler(this.BackToSettingsButton_MouseEnter);
            this.BackToSettingsButton.MouseLeave += new System.EventHandler(this.BackToSettingsButton_MouseLeave);
            // 
            // GitHubLinkButton
            // 
            this.GitHubLinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GitHubLinkButton.BackColor = System.Drawing.Color.Transparent;
            this.GitHubLinkButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GitHubLinkButton.BackgroundImage")));
            this.GitHubLinkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GitHubLinkButton.FlatAppearance.BorderSize = 0;
            this.GitHubLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GitHubLinkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GitHubLinkButton.ForeColor = System.Drawing.Color.Cyan;
            this.GitHubLinkButton.Location = new System.Drawing.Point(12, 366);
            this.GitHubLinkButton.Name = "GitHubLinkButton";
            this.GitHubLinkButton.Size = new System.Drawing.Size(214, 72);
            this.GitHubLinkButton.TabIndex = 5;
            this.GitHubLinkButton.Text = "GitHub";
            this.GitHubLinkButton.UseVisualStyleBackColor = false;
            this.GitHubLinkButton.Click += new System.EventHandler(this.GitHubLinkButton_Click);
            this.GitHubLinkButton.MouseEnter += new System.EventHandler(this.GitHubLinkButton_MouseEnter);
            this.GitHubLinkButton.MouseLeave += new System.EventHandler(this.GitHubLinkButton_MouseLeave);
            // 
            // DevelopersCreditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackToSettingsButton);
            this.Controls.Add(this.GitHubLinkButton);
            this.Controls.Add(this.CreditsLabel);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "DevelopersCreditMenu";
            this.Text = "Dubstep Fight";
            this.Load += new System.EventHandler(this.DevelopersCreditMenu_Load);
            this.Resize += new System.EventHandler(this.DevelopersCreditMenu_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label CreditsLabel;
        private System.Windows.Forms.Button BackToSettingsButton;
        private System.Windows.Forms.Button GitHubLinkButton;
    }
}