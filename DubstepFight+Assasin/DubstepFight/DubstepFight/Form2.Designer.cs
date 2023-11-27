namespace DubstepFight
{
    partial class Form2
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
            this.Player1HPBar = new System.Windows.Forms.ProgressBar();
            this.Player2HPBar = new System.Windows.Forms.ProgressBar();
            this.Player1Skil1Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Player1HPBar
            // 
            this.Player1HPBar.Location = new System.Drawing.Point(12, 12);
            this.Player1HPBar.Name = "Player1HPBar";
            this.Player1HPBar.Size = new System.Drawing.Size(354, 41);
            this.Player1HPBar.TabIndex = 0;
            this.Player1HPBar.Value = 100;
            // 
            // Player2HPBar
            // 
            this.Player2HPBar.Location = new System.Drawing.Point(624, 12);
            this.Player2HPBar.Name = "Player2HPBar";
            this.Player2HPBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Player2HPBar.RightToLeftLayout = true;
            this.Player2HPBar.Size = new System.Drawing.Size(354, 41);
            this.Player2HPBar.TabIndex = 1;
            this.Player2HPBar.Value = 100;
            // 
            // Player1Skil1Button
            // 
            this.Player1Skil1Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Player1Skil1Button.Location = new System.Drawing.Point(12, 248);
            this.Player1Skil1Button.Name = "Player1Skil1Button";
            this.Player1Skil1Button.Size = new System.Drawing.Size(112, 59);
            this.Player1Skil1Button.TabIndex = 2;
            this.Player1Skil1Button.Text = "Удар";
            this.Player1Skil1Button.UseVisualStyleBackColor = true;
            this.Player1Skil1Button.Click += new System.EventHandler(this.Player1Skil1Button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 450);
            this.Controls.Add(this.Player1Skil1Button);
            this.Controls.Add(this.Player2HPBar);
            this.Controls.Add(this.Player1HPBar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar Player1HPBar;
        private System.Windows.Forms.ProgressBar Player2HPBar;
        private System.Windows.Forms.Button Player1Skil1Button;
    }
}