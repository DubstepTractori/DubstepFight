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
            this.StartGameButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.Cyan;
            this.WelcomeLabel.Location = new System.Drawing.Point(258, 53);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(303, 74);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Добро пожаловать\r\nв Dubstep Fight";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartGameButton
            // 
            this.StartGameButton.BackColor = System.Drawing.Color.Transparent;
            this.StartGameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartGameButton.BackgroundImage")));
            this.StartGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartGameButton.FlatAppearance.BorderSize = 0;
            this.StartGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameButton.ForeColor = System.Drawing.Color.Cyan;
            this.StartGameButton.Location = new System.Drawing.Point(280, 169);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(244, 62);
            this.StartGameButton.TabIndex = 1;
            this.StartGameButton.Text = "Play";
            this.StartGameButton.UseVisualStyleBackColor = false;
            this.StartGameButton.Click += new System.EventHandler(this.ChoosePlayer1Button_Click);
            this.StartGameButton.MouseEnter += new System.EventHandler(this.ChoosePlayer1Button_MouseEnter);
            this.StartGameButton.MouseLeave += new System.EventHandler(this.ChoosePlayer1Button_MouseLeave);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Cyan;
            this.ExitButton.Location = new System.Drawing.Point(314, 366);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(164, 33);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.button1_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsButton.BackgroundImage")));
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.WelcomeLabel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "MainGameMenu";
            this.Text = "Dubstep Fight";
            this.Load += new System.EventHandler(this.MainGameMenu_Load);
            this.Resize += new System.EventHandler(this.MainGameMenu_Resize_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SettingsButton;
    }
}

