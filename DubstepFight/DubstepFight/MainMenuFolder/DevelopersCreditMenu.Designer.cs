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
            this.AntonCreditLabel = new System.Windows.Forms.Label();
            this.VadimCreditLabel = new System.Windows.Forms.Label();
            this.DimaCreditLabel = new System.Windows.Forms.Label();
            this.GarikCreditLabel = new System.Windows.Forms.Label();
            this.BackToSettingsButton = new System.Windows.Forms.Button();
            this.GitHubLinkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AntonCreditLabel
            // 
            this.AntonCreditLabel.AutoSize = true;
            this.AntonCreditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AntonCreditLabel.Location = new System.Drawing.Point(12, 110);
            this.AntonCreditLabel.Name = "AntonCreditLabel";
            this.AntonCreditLabel.Size = new System.Drawing.Size(687, 24);
            this.AntonCreditLabel.TabIndex = 1;
            this.AntonCreditLabel.Text = "Антон - Дизайнер отвечающий за текстуры героев и дизайн игры в целом.\r\n";
            // 
            // VadimCreditLabel
            // 
            this.VadimCreditLabel.AutoSize = true;
            this.VadimCreditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VadimCreditLabel.Location = new System.Drawing.Point(12, 167);
            this.VadimCreditLabel.Name = "VadimCreditLabel";
            this.VadimCreditLabel.Size = new System.Drawing.Size(659, 48);
            this.VadimCreditLabel.TabIndex = 2;
            this.VadimCreditLabel.Text = "Вадим - Отвечает за внутренний движок игры баланс героев, умений и\r\nпрочих механи" +
    "к в игре.";
            // 
            // DimaCreditLabel
            // 
            this.DimaCreditLabel.AutoSize = true;
            this.DimaCreditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DimaCreditLabel.Location = new System.Drawing.Point(12, 247);
            this.DimaCreditLabel.Name = "DimaCreditLabel";
            this.DimaCreditLabel.Size = new System.Drawing.Size(617, 24);
            this.DimaCreditLabel.TabIndex = 3;
            this.DimaCreditLabel.Text = "Дима - Дорабатывает и предлагает идеи для внутреннего движка.";
            // 
            // GarikCreditLabel
            // 
            this.GarikCreditLabel.AutoSize = true;
            this.GarikCreditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GarikCreditLabel.Location = new System.Drawing.Point(12, 29);
            this.GarikCreditLabel.Name = "GarikCreditLabel";
            this.GarikCreditLabel.Size = new System.Drawing.Size(720, 48);
            this.GarikCreditLabel.TabIndex = 4;
            this.GarikCreditLabel.Text = "Гарик - Занимается итерфейсом, для достижения более понятной и приятной\r\nработы п" +
    "ользователя с нашей игрой.";
            // 
            // BackToSettingsButton
            // 
            this.BackToSettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackToSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToSettingsButton.Location = new System.Drawing.Point(616, 382);
            this.BackToSettingsButton.Name = "BackToSettingsButton";
            this.BackToSettingsButton.Size = new System.Drawing.Size(172, 56);
            this.BackToSettingsButton.TabIndex = 6;
            this.BackToSettingsButton.Text = "Вернуться";
            this.BackToSettingsButton.UseVisualStyleBackColor = true;
            this.BackToSettingsButton.Click += new System.EventHandler(this.BackToSettingsButton_Click);
            // 
            // GitHubLinkButton
            // 
            this.GitHubLinkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GitHubLinkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GitHubLinkButton.Location = new System.Drawing.Point(12, 313);
            this.GitHubLinkButton.Name = "GitHubLinkButton";
            this.GitHubLinkButton.Size = new System.Drawing.Size(214, 93);
            this.GitHubLinkButton.TabIndex = 5;
            this.GitHubLinkButton.Text = "GitHub";
            this.GitHubLinkButton.UseVisualStyleBackColor = true;
            this.GitHubLinkButton.Click += new System.EventHandler(this.GitHubLinkButton_Click);
            // 
            // DevelopersCreditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackToSettingsButton);
            this.Controls.Add(this.GitHubLinkButton);
            this.Controls.Add(this.GarikCreditLabel);
            this.Controls.Add(this.DimaCreditLabel);
            this.Controls.Add(this.VadimCreditLabel);
            this.Controls.Add(this.AntonCreditLabel);
            this.Name = "DevelopersCreditMenu";
            this.Text = "Dubstep Fight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AntonCreditLabel;
        private System.Windows.Forms.Label VadimCreditLabel;
        private System.Windows.Forms.Label DimaCreditLabel;
        private System.Windows.Forms.Label GarikCreditLabel;
        private System.Windows.Forms.Button BackToSettingsButton;
        private System.Windows.Forms.Button GitHubLinkButton;
    }
}