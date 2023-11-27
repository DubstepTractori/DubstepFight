namespace DubstepFight
{
    partial class Form1
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
            this.WelcomeMenuText = new System.Windows.Forms.Label();
            this.Player1MenuButton = new System.Windows.Forms.Button();
            this.ExitGameButton = new System.Windows.Forms.Button();
            this.Player2MenuButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeMenuText
            // 
            this.WelcomeMenuText.AutoSize = true;
            this.WelcomeMenuText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WelcomeMenuText.Location = new System.Drawing.Point(414, 50);
            this.WelcomeMenuText.Name = "WelcomeMenuText";
            this.WelcomeMenuText.Size = new System.Drawing.Size(236, 50);
            this.WelcomeMenuText.TabIndex = 11;
            this.WelcomeMenuText.Text = "Добро пожаловать в\r\nDubstep Fight";
            this.WelcomeMenuText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player1MenuButton
            // 
            this.Player1MenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player1MenuButton.Location = new System.Drawing.Point(173, 174);
            this.Player1MenuButton.Name = "Player1MenuButton";
            this.Player1MenuButton.Size = new System.Drawing.Size(253, 74);
            this.Player1MenuButton.TabIndex = 8;
            this.Player1MenuButton.Text = "1 Игрок";
            this.Player1MenuButton.UseVisualStyleBackColor = true;
            this.Player1MenuButton.Click += new System.EventHandler(this.Player1MenuButton_Click);
            // 
            // ExitGameButton
            // 
            this.ExitGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitGameButton.Location = new System.Drawing.Point(419, 407);
            this.ExitGameButton.Name = "ExitGameButton";
            this.ExitGameButton.Size = new System.Drawing.Size(209, 42);
            this.ExitGameButton.TabIndex = 10;
            this.ExitGameButton.Text = "Выход";
            this.ExitGameButton.UseVisualStyleBackColor = true;
            // 
            // Player2MenuButton
            // 
            this.Player2MenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player2MenuButton.Location = new System.Drawing.Point(612, 174);
            this.Player2MenuButton.Name = "Player2MenuButton";
            this.Player2MenuButton.Size = new System.Drawing.Size(234, 74);
            this.Player2MenuButton.TabIndex = 9;
            this.Player2MenuButton.Text = "2 Игрока";
            this.Player2MenuButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 511);
            this.Controls.Add(this.WelcomeMenuText);
            this.Controls.Add(this.Player1MenuButton);
            this.Controls.Add(this.ExitGameButton);
            this.Controls.Add(this.Player2MenuButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeMenuText;
        private System.Windows.Forms.Button Player1MenuButton;
        private System.Windows.Forms.Button ExitGameButton;
        private System.Windows.Forms.Button Player2MenuButton;
    }
}

