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
            this.DevelopersButton = new System.Windows.Forms.Button();
            this.ChooseCharacterLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BackToMainMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DevelopersButton
            // 
            this.DevelopersButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DevelopersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DevelopersButton.Location = new System.Drawing.Point(283, 143);
            this.DevelopersButton.Name = "DevelopersButton";
            this.DevelopersButton.Size = new System.Drawing.Size(210, 53);
            this.DevelopersButton.TabIndex = 0;
            this.DevelopersButton.Text = "Авторы";
            this.DevelopersButton.UseVisualStyleBackColor = true;
            this.DevelopersButton.Click += new System.EventHandler(this.DevelopersButton_Click);
            // 
            // ChooseCharacterLabel
            // 
            this.ChooseCharacterLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChooseCharacterLabel.AutoSize = true;
            this.ChooseCharacterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseCharacterLabel.Location = new System.Drawing.Point(335, 51);
            this.ChooseCharacterLabel.Name = "ChooseCharacterLabel";
            this.ChooseCharacterLabel.Size = new System.Drawing.Size(106, 24);
            this.ChooseCharacterLabel.TabIndex = 2;
            this.ChooseCharacterLabel.Text = "Настройки";
            this.ChooseCharacterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(283, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Кнопка";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BackToMainMenuButton
            // 
            this.BackToMainMenuButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BackToMainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToMainMenuButton.Location = new System.Drawing.Point(254, 305);
            this.BackToMainMenuButton.Name = "BackToMainMenuButton";
            this.BackToMainMenuButton.Size = new System.Drawing.Size(267, 53);
            this.BackToMainMenuButton.TabIndex = 4;
            this.BackToMainMenuButton.Text = "Вернуться";
            this.BackToMainMenuButton.UseVisualStyleBackColor = true;
            this.BackToMainMenuButton.Click += new System.EventHandler(this.BackToMainMenuButton_Click);
            // 
            // SettingsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackToMainMenuButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChooseCharacterLabel);
            this.Controls.Add(this.DevelopersButton);
            this.Name = "SettingsMenu";
            this.Text = "SettingsMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DevelopersButton;
        private System.Windows.Forms.Label ChooseCharacterLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BackToMainMenuButton;
    }
}