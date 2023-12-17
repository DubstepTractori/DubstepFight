namespace DubstepFight.FightMenu
{
    partial class ChooseCharacterMenu2
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
            this.ReturnToMenuButton = new System.Windows.Forms.Button();
            this.ChooseHeroGiantButton = new System.Windows.Forms.Button();
            this.ChooseHeroElfButton = new System.Windows.Forms.Button();
            this.ChooseHeroBlackKnightButton = new System.Windows.Forms.Button();
            this.ChooseHeroAssasinButton = new System.Windows.Forms.Button();
            this.ChooseCharacterLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnToMenuButton
            // 
            this.ReturnToMenuButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ReturnToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnToMenuButton.Location = new System.Drawing.Point(319, 378);
            this.ReturnToMenuButton.Name = "ReturnToMenuButton";
            this.ReturnToMenuButton.Size = new System.Drawing.Size(167, 40);
            this.ReturnToMenuButton.TabIndex = 12;
            this.ReturnToMenuButton.Text = "Вернуться";
            this.ReturnToMenuButton.UseVisualStyleBackColor = true;
            // 
            // ChooseHeroGiantButton
            // 
            this.ChooseHeroGiantButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseHeroGiantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseHeroGiantButton.Location = new System.Drawing.Point(471, 242);
            this.ChooseHeroGiantButton.Name = "ChooseHeroGiantButton";
            this.ChooseHeroGiantButton.Size = new System.Drawing.Size(167, 100);
            this.ChooseHeroGiantButton.TabIndex = 11;
            this.ChooseHeroGiantButton.Text = "Гигант";
            this.ChooseHeroGiantButton.UseVisualStyleBackColor = true;
            this.ChooseHeroGiantButton.Click += new System.EventHandler(this.ChooseHeroGiantButton_Click);
            // 
            // ChooseHeroElfButton
            // 
            this.ChooseHeroElfButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseHeroElfButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseHeroElfButton.Location = new System.Drawing.Point(471, 99);
            this.ChooseHeroElfButton.Name = "ChooseHeroElfButton";
            this.ChooseHeroElfButton.Size = new System.Drawing.Size(167, 94);
            this.ChooseHeroElfButton.TabIndex = 10;
            this.ChooseHeroElfButton.Text = "Эльф";
            this.ChooseHeroElfButton.UseVisualStyleBackColor = true;
            this.ChooseHeroElfButton.Click += new System.EventHandler(this.ChooseHeroElfButton_Click);
            // 
            // ChooseHeroBlackKnightButton
            // 
            this.ChooseHeroBlackKnightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChooseHeroBlackKnightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseHeroBlackKnightButton.Location = new System.Drawing.Point(185, 242);
            this.ChooseHeroBlackKnightButton.Name = "ChooseHeroBlackKnightButton";
            this.ChooseHeroBlackKnightButton.Size = new System.Drawing.Size(157, 100);
            this.ChooseHeroBlackKnightButton.TabIndex = 9;
            this.ChooseHeroBlackKnightButton.Text = "Тёмный \r\nРыцарь";
            this.ChooseHeroBlackKnightButton.UseVisualStyleBackColor = true;
            this.ChooseHeroBlackKnightButton.Click += new System.EventHandler(this.ChooseHeroBlackKnightButton_Click);
            // 
            // ChooseHeroAssasinButton
            // 
            this.ChooseHeroAssasinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseHeroAssasinButton.Location = new System.Drawing.Point(185, 99);
            this.ChooseHeroAssasinButton.Name = "ChooseHeroAssasinButton";
            this.ChooseHeroAssasinButton.Size = new System.Drawing.Size(157, 94);
            this.ChooseHeroAssasinButton.TabIndex = 8;
            this.ChooseHeroAssasinButton.Text = "Ассасин";
            this.ChooseHeroAssasinButton.UseVisualStyleBackColor = true;
            this.ChooseHeroAssasinButton.Click += new System.EventHandler(this.ChooseHeroAssasinButton_Click);
            // 
            // ChooseCharacterLabel
            // 
            this.ChooseCharacterLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChooseCharacterLabel.AutoSize = true;
            this.ChooseCharacterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseCharacterLabel.Location = new System.Drawing.Point(297, 28);
            this.ChooseCharacterLabel.Name = "ChooseCharacterLabel";
            this.ChooseCharacterLabel.Size = new System.Drawing.Size(241, 48);
            this.ChooseCharacterLabel.TabIndex = 7;
            this.ChooseCharacterLabel.Text = "Выберите персонажа для\r\nИгрока 2";
            this.ChooseCharacterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooseCharacterMenu2
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
            this.Name = "ChooseCharacterMenu2";
            this.Text = "ChooseCharacterMenu2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnToMenuButton;
        private System.Windows.Forms.Button ChooseHeroGiantButton;
        private System.Windows.Forms.Button ChooseHeroElfButton;
        private System.Windows.Forms.Button ChooseHeroBlackKnightButton;
        private System.Windows.Forms.Button ChooseHeroAssasinButton;
        private System.Windows.Forms.Label ChooseCharacterLabel;
    }
}