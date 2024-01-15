namespace DubstepFight.CharacterInfoFolder
{
    partial class HeroInfoForm
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
            this.HeroNameLabel = new System.Windows.Forms.Label();
            this.HeroBaseAttackLabel = new System.Windows.Forms.Label();
            this.HeroBaseAttackInfoLabel = new System.Windows.Forms.Label();
            this.HeroSkill1Label = new System.Windows.Forms.Label();
            this.HeroSkill1InfoLabel = new System.Windows.Forms.Label();
            this.HeroPassiveLabel = new System.Windows.Forms.Label();
            this.HeroPassiveInfoLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeroNameLabel
            // 
            this.HeroNameLabel.AutoSize = true;
            this.HeroNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeroNameLabel.Location = new System.Drawing.Point(12, 9);
            this.HeroNameLabel.Name = "HeroNameLabel";
            this.HeroNameLabel.Size = new System.Drawing.Size(122, 25);
            this.HeroNameLabel.TabIndex = 0;
            this.HeroNameLabel.Text = "HeroName";
            // 
            // HeroBaseAttackLabel
            // 
            this.HeroBaseAttackLabel.AutoSize = true;
            this.HeroBaseAttackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeroBaseAttackLabel.Location = new System.Drawing.Point(35, 48);
            this.HeroBaseAttackLabel.Name = "HeroBaseAttackLabel";
            this.HeroBaseAttackLabel.Size = new System.Drawing.Size(139, 20);
            this.HeroBaseAttackLabel.TabIndex = 1;
            this.HeroBaseAttackLabel.Text = "Базовая атака:";
            // 
            // HeroBaseAttackInfoLabel
            // 
            this.HeroBaseAttackInfoLabel.AutoSize = true;
            this.HeroBaseAttackInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeroBaseAttackInfoLabel.Location = new System.Drawing.Point(68, 80);
            this.HeroBaseAttackInfoLabel.Name = "HeroBaseAttackInfoLabel";
            this.HeroBaseAttackInfoLabel.Size = new System.Drawing.Size(68, 20);
            this.HeroBaseAttackInfoLabel.TabIndex = 2;
            this.HeroBaseAttackInfoLabel.Text = "Attack 1";
            // 
            // HeroSkill1Label
            // 
            this.HeroSkill1Label.AutoSize = true;
            this.HeroSkill1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeroSkill1Label.Location = new System.Drawing.Point(35, 146);
            this.HeroSkill1Label.Name = "HeroSkill1Label";
            this.HeroSkill1Label.Size = new System.Drawing.Size(139, 20);
            this.HeroSkill1Label.TabIndex = 3;
            this.HeroSkill1Label.Text = "Способность 1:";
            // 
            // HeroSkill1InfoLabel
            // 
            this.HeroSkill1InfoLabel.AutoSize = true;
            this.HeroSkill1InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeroSkill1InfoLabel.Location = new System.Drawing.Point(68, 180);
            this.HeroSkill1InfoLabel.Name = "HeroSkill1InfoLabel";
            this.HeroSkill1InfoLabel.Size = new System.Drawing.Size(68, 20);
            this.HeroSkill1InfoLabel.TabIndex = 4;
            this.HeroSkill1InfoLabel.Text = "Attack 2";
            // 
            // HeroPassiveLabel
            // 
            this.HeroPassiveLabel.AutoSize = true;
            this.HeroPassiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeroPassiveLabel.Location = new System.Drawing.Point(35, 335);
            this.HeroPassiveLabel.Name = "HeroPassiveLabel";
            this.HeroPassiveLabel.Size = new System.Drawing.Size(163, 20);
            this.HeroPassiveLabel.TabIndex = 6;
            this.HeroPassiveLabel.Text = "Пассивный навык:";
            // 
            // HeroPassiveInfoLabel
            // 
            this.HeroPassiveInfoLabel.AutoSize = true;
            this.HeroPassiveInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeroPassiveInfoLabel.Location = new System.Drawing.Point(68, 365);
            this.HeroPassiveInfoLabel.Name = "HeroPassiveInfoLabel";
            this.HeroPassiveInfoLabel.Size = new System.Drawing.Size(63, 20);
            this.HeroPassiveInfoLabel.TabIndex = 7;
            this.HeroPassiveInfoLabel.Text = "Passive";
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.Location = new System.Drawing.Point(628, 383);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(160, 55);
            this.returnButton.TabIndex = 8;
            this.returnButton.Text = "Вернуться";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // HeroInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.HeroPassiveInfoLabel);
            this.Controls.Add(this.HeroPassiveLabel);
            this.Controls.Add(this.HeroSkill1InfoLabel);
            this.Controls.Add(this.HeroSkill1Label);
            this.Controls.Add(this.HeroBaseAttackInfoLabel);
            this.Controls.Add(this.HeroBaseAttackLabel);
            this.Controls.Add(this.HeroNameLabel);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "HeroInfoForm";
            this.Text = "AssassinInfoForm";
            this.Load += new System.EventHandler(this.HeroInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeroNameLabel;
        private System.Windows.Forms.Label HeroBaseAttackLabel;
        private System.Windows.Forms.Label HeroBaseAttackInfoLabel;
        private System.Windows.Forms.Label HeroSkill1Label;
        private System.Windows.Forms.Label HeroSkill1InfoLabel;
        private System.Windows.Forms.Label HeroPassiveLabel;
        private System.Windows.Forms.Label HeroPassiveInfoLabel;
        private System.Windows.Forms.Button returnButton;
    }
}