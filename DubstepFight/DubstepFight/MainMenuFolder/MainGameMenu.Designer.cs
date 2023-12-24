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
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.ChoosePlayer1Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChoosePlayer1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoosePlayer1Button.Location = new System.Drawing.Point(280, 169);
            this.ChoosePlayer1Button.Name = "ChoosePlayer1Button";
            this.ChoosePlayer1Button.Size = new System.Drawing.Size(244, 62);
            this.ChoosePlayer1Button.TabIndex = 1;
            this.ChoosePlayer1Button.Text = "Играть";
            this.ChoosePlayer1Button.UseVisualStyleBackColor = true;
            this.ChoosePlayer1Button.Click += new System.EventHandler(this.ChoosePlayer1Button_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.SettingsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SettingsButton.Location = new System.Drawing.Point(314, 294);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(164, 39);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(127, 42);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(568, 263);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // MainGameMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChoosePlayer1Button);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "MainGameMenu";
            this.Text = "Dubstep Fight";
            this.Load += new System.EventHandler(this.MainGameMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button ChoosePlayer1Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SettingsButton;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

