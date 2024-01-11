namespace DubstepFight
{
    partial class ChooseCharacterMenu
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
            this.ChooseCharacterLabel = new System.Windows.Forms.Label();
            this.ReturnToMenuButton = new System.Windows.Forms.Button();
            this.ChooseHeroGiantButton = new System.Windows.Forms.Button();
            this.ChooseHeroElfButton = new System.Windows.Forms.Button();
            this.ChooseHeroBlackKnightButton = new System.Windows.Forms.Button();
            this.ChooseHeroAssasinButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseCharacterLabel
            // 
            this.ChooseCharacterLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChooseCharacterLabel.AutoSize = true;
            this.ChooseCharacterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseCharacterLabel.Location = new System.Drawing.Point(294, 30);
            this.ChooseCharacterLabel.Name = "ChooseCharacterLabel";
            this.ChooseCharacterLabel.Size = new System.Drawing.Size(241, 48);
            this.ChooseCharacterLabel.TabIndex = 1;
            this.ChooseCharacterLabel.Text = "Выберите персонажа для\r\nИгрока 1";
            this.ChooseCharacterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReturnToMenuButton
            // 
            this.ReturnToMenuButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ReturnToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnToMenuButton.Location = new System.Drawing.Point(313, 377);
            this.ReturnToMenuButton.Name = "ReturnToMenuButton";
            this.ReturnToMenuButton.Size = new System.Drawing.Size(167, 40);
            this.ReturnToMenuButton.TabIndex = 6;
            this.ReturnToMenuButton.Text = "Вернуться";
            this.ReturnToMenuButton.UseVisualStyleBackColor = true;
            this.ReturnToMenuButton.Click += new System.EventHandler(this.ReturnToMenuButton_Click);
            // 
            // ChooseHeroGiantButton
            // 
            this.ChooseHeroGiantButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseHeroGiantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseHeroGiantButton.Image = global::DubstepFight.Properties.Resources.Gigant_Pose;
            this.ChooseHeroGiantButton.Location = new System.Drawing.Point(465, 241);
            this.ChooseHeroGiantButton.Name = "ChooseHeroGiantButton";
            this.ChooseHeroGiantButton.Size = new System.Drawing.Size(167, 100);
            this.ChooseHeroGiantButton.TabIndex = 5;
            this.ChooseHeroGiantButton.UseVisualStyleBackColor = true;
            this.ChooseHeroGiantButton.Click += new System.EventHandler(this.ChooseHeroGiantButton_Click);
            // 
            // ChooseHeroElfButton
            // 
            this.ChooseHeroElfButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseHeroElfButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseHeroElfButton.Image = global::DubstepFight.Properties.Resources.Elf_Pose;
            this.ChooseHeroElfButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ChooseHeroElfButton.Location = new System.Drawing.Point(465, 98);
            this.ChooseHeroElfButton.Name = "ChooseHeroElfButton";
            this.ChooseHeroElfButton.Size = new System.Drawing.Size(167, 94);
            this.ChooseHeroElfButton.TabIndex = 4;
            this.ChooseHeroElfButton.UseVisualStyleBackColor = true;
            this.ChooseHeroElfButton.Click += new System.EventHandler(this.ChooseHeroElfButton_Click);
            // 
            // ChooseHeroBlackKnightButton
            // 
            this.ChooseHeroBlackKnightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChooseHeroBlackKnightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseHeroBlackKnightButton.Image = global::DubstepFight.Properties.Resources.BlackKnight_Pose;
            this.ChooseHeroBlackKnightButton.Location = new System.Drawing.Point(179, 241);
            this.ChooseHeroBlackKnightButton.Name = "ChooseHeroBlackKnightButton";
            this.ChooseHeroBlackKnightButton.Size = new System.Drawing.Size(157, 100);
            this.ChooseHeroBlackKnightButton.TabIndex = 3;
            this.ChooseHeroBlackKnightButton.UseVisualStyleBackColor = true;
            this.ChooseHeroBlackKnightButton.Click += new System.EventHandler(this.ChooseHeroBlackKnightButton_Click);
            // 
            // ChooseHeroAssasinButton
            // 
            this.ChooseHeroAssasinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseHeroAssasinButton.Image = global::DubstepFight.Properties.Resources.Assassin_Pose;
            this.ChooseHeroAssasinButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ChooseHeroAssasinButton.Location = new System.Drawing.Point(179, 98);
            this.ChooseHeroAssasinButton.Name = "ChooseHeroAssasinButton";
            this.ChooseHeroAssasinButton.Size = new System.Drawing.Size(157, 94);
            this.ChooseHeroAssasinButton.TabIndex = 2;
            this.ChooseHeroAssasinButton.UseVisualStyleBackColor = true;
            this.ChooseHeroAssasinButton.Click += new System.EventHandler(this.ChooseHeroAssasinButton_Click);
            // 
            // ChooseCharacterMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnToMenuButton);
            this.Controls.Add(this.ChooseHeroGiantButton);
            this.Controls.Add(this.ChooseHeroElfButton);
            this.Controls.Add(this.ChooseHeroBlackKnightButton);
            this.Controls.Add(this.ChooseHeroAssasinButton);
            this.Controls.Add(this.ChooseCharacterLabel);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "ChooseCharacterMenu";
            this.Text = "Dubstep Fight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ChooseCharacterLabel;
        private System.Windows.Forms.Button ChooseHeroAssasinButton;
        private System.Windows.Forms.Button ChooseHeroBlackKnightButton;
        private System.Windows.Forms.Button ChooseHeroElfButton;
        private System.Windows.Forms.Button ChooseHeroGiantButton;
        private System.Windows.Forms.Button ReturnToMenuButton;
    }
}