namespace DubstepFight
{
    partial class MainGameMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGameMenu));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.ChoosePlayer1Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("ascii", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.Cyan;
            this.WelcomeLabel.Location = new System.Drawing.Point(205, 53);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(407, 80);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Добро пожаловать\r\nв Dubstep Fight";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChoosePlayer1Button
            // 
            this.ChoosePlayer1Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChoosePlayer1Button.BackColor = System.Drawing.Color.Transparent;
            this.ChoosePlayer1Button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChoosePlayer1Button.BackgroundImage")));
            this.ChoosePlayer1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChoosePlayer1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChoosePlayer1Button.FlatAppearance.BorderSize = 0;
            this.ChoosePlayer1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoosePlayer1Button.Font = new System.Drawing.Font("ascii", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChoosePlayer1Button.ForeColor = System.Drawing.Color.Cyan;
            this.ChoosePlayer1Button.Location = new System.Drawing.Point(280, 169);
            this.ChoosePlayer1Button.Name = "ChoosePlayer1Button";
            this.ChoosePlayer1Button.Size = new System.Drawing.Size(244, 62);
            this.ChoosePlayer1Button.TabIndex = 1;
            this.ChoosePlayer1Button.Text = "Play";
            this.ChoosePlayer1Button.UseVisualStyleBackColor = false;
            this.ChoosePlayer1Button.Click += new System.EventHandler(this.ChoosePlayer1Button_Click);
            this.ChoosePlayer1Button.MouseEnter += new System.EventHandler(this.ChoosePlayer1Button_MouseEnter);
            this.ChoosePlayer1Button.MouseLeave += new System.EventHandler(this.ChoosePlayer1Button_MouseLeave);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("ascii", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(314, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsButton.BackgroundImage")));
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("ascii", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.Cyan;
            this.SettingsButton.Location = new System.Drawing.Point(314, 294);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(164, 39);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            this.SettingsButton.MouseEnter += new System.EventHandler(this.SettingsButton_MouseEnter);
            this.SettingsButton.MouseLeave += new System.EventHandler(this.SettingsButton_MouseLeave);
            // 
            // MainGameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChoosePlayer1Button);
            this.Controls.Add(this.WelcomeLabel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "MainGameMenu";
            this.Text = "Dubstep Fight";
            this.Load += new System.EventHandler(this.MainGameMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button ChoosePlayer1Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SettingsButton;
    }
}

