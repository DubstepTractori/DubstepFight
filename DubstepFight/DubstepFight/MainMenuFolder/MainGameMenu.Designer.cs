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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.ChoosePlayer1Button = new System.Windows.Forms.Button();
            this.ChoosePlayer2Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeLabel.Location = new System.Drawing.Point(310, 42);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(182, 48);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Добро пожаловать\r\nв Dubstep Fight";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChoosePlayer1Button
            // 
            this.ChoosePlayer1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoosePlayer1Button.Location = new System.Drawing.Point(111, 174);
            this.ChoosePlayer1Button.Name = "ChoosePlayer1Button";
            this.ChoosePlayer1Button.Size = new System.Drawing.Size(164, 61);
            this.ChoosePlayer1Button.TabIndex = 1;
            this.ChoosePlayer1Button.Text = "Игрок 1";
            this.ChoosePlayer1Button.UseVisualStyleBackColor = true;
            this.ChoosePlayer1Button.Click += new System.EventHandler(this.ChoosePlayer1Button_Click);
            // 
            // ChoosePlayer2Button
            // 
            this.ChoosePlayer2Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoosePlayer2Button.Location = new System.Drawing.Point(508, 174);
            this.ChoosePlayer2Button.Name = "ChoosePlayer2Button";
            this.ChoosePlayer2Button.Size = new System.Drawing.Size(164, 61);
            this.ChoosePlayer2Button.TabIndex = 2;
            this.ChoosePlayer2Button.Text = "Игрок 2";
            this.ChoosePlayer2Button.UseVisualStyleBackColor = true;
            this.ChoosePlayer2Button.Click += new System.EventHandler(this.ChoosePlayer2Button_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(314, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton.Location = new System.Drawing.Point(314, 300);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(164, 33);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChoosePlayer2Button);
            this.Controls.Add(this.ChoosePlayer1Button);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "MainMenu";
            this.Text = "Dubstep Fight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button ChoosePlayer1Button;
        private System.Windows.Forms.Button ChoosePlayer2Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SettingsButton;
    }
}

