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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeroInfoForm));
            this.HeroNameLabel = new System.Windows.Forms.Label();
            this.HeroBaseAttackLabel = new System.Windows.Forms.Label();
            this.HeroBaseAttackInfoLabel = new System.Windows.Forms.Label();
            this.HeroSkill1Label = new System.Windows.Forms.Label();
            this.HeroSkill1InfoLabel = new System.Windows.Forms.Label();
            this.HaroPassiveLabel = new System.Windows.Forms.Label();
            this.HeroPassiveInfoLabel = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeroNameLabel
            // 
            this.HeroNameLabel.AutoSize = true;
            this.HeroNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeroNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeroNameLabel.ForeColor = System.Drawing.Color.Cyan;
            this.HeroNameLabel.Location = new System.Drawing.Point(12, 9);
            this.HeroNameLabel.Name = "HeroNameLabel";
            this.HeroNameLabel.Size = new System.Drawing.Size(114, 25);
            this.HeroNameLabel.TabIndex = 0;
            this.HeroNameLabel.Text = "Ассассин";
            // 
            // HeroBaseAttackLabel
            // 
            this.HeroBaseAttackLabel.AutoSize = true;
            this.HeroBaseAttackLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeroBaseAttackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeroBaseAttackLabel.ForeColor = System.Drawing.Color.Cyan;
            this.HeroBaseAttackLabel.Location = new System.Drawing.Point(35, 48);
            this.HeroBaseAttackLabel.Name = "HeroBaseAttackLabel";
            this.HeroBaseAttackLabel.Size = new System.Drawing.Size(139, 20);
            this.HeroBaseAttackLabel.TabIndex = 1;
            this.HeroBaseAttackLabel.Text = "Базовая атака:";
            // 
            // HeroBaseAttackInfoLabel
            // 
            this.HeroBaseAttackInfoLabel.AutoSize = true;
            this.HeroBaseAttackInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeroBaseAttackInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeroBaseAttackInfoLabel.ForeColor = System.Drawing.Color.Cyan;
            this.HeroBaseAttackInfoLabel.Location = new System.Drawing.Point(68, 80);
            this.HeroBaseAttackInfoLabel.Name = "HeroBaseAttackInfoLabel";
            this.HeroBaseAttackInfoLabel.Size = new System.Drawing.Size(420, 20);
            this.HeroBaseAttackInfoLabel.TabIndex = 2;
            this.HeroBaseAttackInfoLabel.Text = "Ассасин бьёт своим кинжалом, нанося 20 урона.";
            // 
            // HeroSkill1Label
            // 
            this.HeroSkill1Label.AutoSize = true;
            this.HeroSkill1Label.BackColor = System.Drawing.Color.Transparent;
            this.HeroSkill1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeroSkill1Label.ForeColor = System.Drawing.Color.Cyan;
            this.HeroSkill1Label.Location = new System.Drawing.Point(35, 146);
            this.HeroSkill1Label.Name = "HeroSkill1Label";
            this.HeroSkill1Label.Size = new System.Drawing.Size(139, 20);
            this.HeroSkill1Label.TabIndex = 3;
            this.HeroSkill1Label.Text = "Способность 1:";
            // 
            // HeroSkill1InfoLabel
            // 
            this.HeroSkill1InfoLabel.AutoSize = true;
            this.HeroSkill1InfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeroSkill1InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeroSkill1InfoLabel.ForeColor = System.Drawing.Color.Cyan;
            this.HeroSkill1InfoLabel.Location = new System.Drawing.Point(68, 180);
            this.HeroSkill1InfoLabel.Name = "HeroSkill1InfoLabel";
            this.HeroSkill1InfoLabel.Size = new System.Drawing.Size(610, 120);
            this.HeroSkill1InfoLabel.TabIndex = 4;
            this.HeroSkill1InfoLabel.Text = resources.GetString("HeroSkill1InfoLabel.Text");
            // 
            // HaroPassiveLabel
            // 
            this.HaroPassiveLabel.AutoSize = true;
            this.HaroPassiveLabel.BackColor = System.Drawing.Color.Transparent;
            this.HaroPassiveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HaroPassiveLabel.ForeColor = System.Drawing.Color.Cyan;
            this.HaroPassiveLabel.Location = new System.Drawing.Point(35, 335);
            this.HaroPassiveLabel.Name = "HaroPassiveLabel";
            this.HaroPassiveLabel.Size = new System.Drawing.Size(163, 20);
            this.HaroPassiveLabel.TabIndex = 6;
            this.HaroPassiveLabel.Text = "Пассивный навык:";
            // 
            // HeroPassiveInfoLabel
            // 
            this.HeroPassiveInfoLabel.AutoSize = true;
            this.HeroPassiveInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeroPassiveInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeroPassiveInfoLabel.ForeColor = System.Drawing.Color.Cyan;
            this.HeroPassiveInfoLabel.Location = new System.Drawing.Point(68, 365);
            this.HeroPassiveInfoLabel.Name = "HeroPassiveInfoLabel";
            this.HeroPassiveInfoLabel.Size = new System.Drawing.Size(522, 40);
            this.HeroPassiveInfoLabel.TabIndex = 7;
            this.HeroPassiveInfoLabel.Text = "При получении урона Ассассин имеет 30% шанс увернуться,\r\nигнорируя весь полученны" +
    "й урон";
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.Transparent;
            this.returnButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("returnButton.BackgroundImage")));
            this.returnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.returnButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnButton.FlatAppearance.BorderSize = 0;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.ForeColor = System.Drawing.Color.Cyan;
            this.returnButton.Location = new System.Drawing.Point(628, 383);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(160, 55);
            this.returnButton.TabIndex = 8;
            this.returnButton.Text = "Back";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.button1_Click);
            this.returnButton.MouseEnter += new System.EventHandler(this.returnButton_MouseEnter);
            this.returnButton.MouseLeave += new System.EventHandler(this.returnButton_MouseLeave);
            // 
            // HeroInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.HeroPassiveInfoLabel);
            this.Controls.Add(this.HaroPassiveLabel);
            this.Controls.Add(this.HeroSkill1InfoLabel);
            this.Controls.Add(this.HeroSkill1Label);
            this.Controls.Add(this.HeroBaseAttackInfoLabel);
            this.Controls.Add(this.HeroBaseAttackLabel);
            this.Controls.Add(this.HeroNameLabel);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "HeroInfoForm";
            this.Text = "AssassinInfoForm";
            this.Load += new System.EventHandler(this.HeroInfoForm_Load);
            this.Resize += new System.EventHandler(this.HeroInfoForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeroNameLabel;
        private System.Windows.Forms.Label HeroBaseAttackLabel;
        private System.Windows.Forms.Label HeroBaseAttackInfoLabel;
        private System.Windows.Forms.Label HeroSkill1Label;
        private System.Windows.Forms.Label HeroSkill1InfoLabel;
        private System.Windows.Forms.Label HaroPassiveLabel;
        private System.Windows.Forms.Label HeroPassiveInfoLabel;
        private System.Windows.Forms.Button returnButton;
    }
}