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
            this.ChooseHeroAssasinButton = new System.Windows.Forms.Button();
            this.ChooseHeroBlackKnightButton = new System.Windows.Forms.Button();
            this.ChooseHeroElfButton = new System.Windows.Forms.Button();
            this.ChooseHeroGiantButton = new System.Windows.Forms.Button();
            this.ReturnToMenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseCharacterLabel
            // 
            this.ChooseCharacterLabel.AutoSize = true;
            this.ChooseCharacterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseCharacterLabel.Location = new System.Drawing.Point(303, 30);
            this.ChooseCharacterLabel.Name = "ChooseCharacterLabel";
            this.ChooseCharacterLabel.Size = new System.Drawing.Size(204, 24);
            this.ChooseCharacterLabel.TabIndex = 1;
            this.ChooseCharacterLabel.Text = "Выберите персонажа";
            this.ChooseCharacterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChooseHeroAssasinButton
            // 
            this.ChooseHeroAssasinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseHeroAssasinButton.Location = new System.Drawing.Point(183, 98);
            this.ChooseHeroAssasinButton.Name = "ChooseHeroAssasinButton";
            this.ChooseHeroAssasinButton.Size = new System.Drawing.Size(157, 94);
            this.ChooseHeroAssasinButton.TabIndex = 2;
            this.ChooseHeroAssasinButton.Text = "Ассасин";
            this.ChooseHeroAssasinButton.UseVisualStyleBackColor = true;
            this.ChooseHeroAssasinButton.Click += new System.EventHandler(this.ChooseHeroAssasinButton_Click);
            // 
            // ChooseHeroBlackKnightButton
            // 
            this.ChooseHeroBlackKnightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseHeroBlackKnightButton.Location = new System.Drawing.Point(183, 241);
            this.ChooseHeroBlackKnightButton.Name = "ChooseHeroBlackKnightButton";
            this.ChooseHeroBlackKnightButton.Size = new System.Drawing.Size(157, 100);
            this.ChooseHeroBlackKnightButton.TabIndex = 3;
            this.ChooseHeroBlackKnightButton.Text = "Чёрный\r\nРыцарь";
            this.ChooseHeroBlackKnightButton.UseVisualStyleBackColor = true;
            // 
            // ChooseHeroElfButton
            // 
            this.ChooseHeroElfButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseHeroElfButton.Location = new System.Drawing.Point(469, 98);
            this.ChooseHeroElfButton.Name = "ChooseHeroElfButton";
            this.ChooseHeroElfButton.Size = new System.Drawing.Size(167, 94);
            this.ChooseHeroElfButton.TabIndex = 4;
            this.ChooseHeroElfButton.Text = "Эльф";
            this.ChooseHeroElfButton.UseVisualStyleBackColor = true;
            this.ChooseHeroElfButton.Click += new System.EventHandler(this.ChooseHeroElfButton_Click);
            // 
            // ChooseHeroGiantButton
            // 
            this.ChooseHeroGiantButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseHeroGiantButton.Location = new System.Drawing.Point(469, 241);
            this.ChooseHeroGiantButton.Name = "ChooseHeroGiantButton";
            this.ChooseHeroGiantButton.Size = new System.Drawing.Size(167, 100);
            this.ChooseHeroGiantButton.TabIndex = 5;
            this.ChooseHeroGiantButton.Text = "Гигант";
            this.ChooseHeroGiantButton.UseVisualStyleBackColor = true;
            // 
            // ReturnToMenuButton
            // 
            this.ReturnToMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReturnToMenuButton.Location = new System.Drawing.Point(317, 377);
            this.ReturnToMenuButton.Name = "ReturnToMenuButton";
            this.ReturnToMenuButton.Size = new System.Drawing.Size(167, 40);
            this.ReturnToMenuButton.TabIndex = 6;
            this.ReturnToMenuButton.Text = "Вернуться";
            this.ReturnToMenuButton.UseVisualStyleBackColor = true;
            this.ReturnToMenuButton.Click += new System.EventHandler(this.ReturnToMenuButton_Click);
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