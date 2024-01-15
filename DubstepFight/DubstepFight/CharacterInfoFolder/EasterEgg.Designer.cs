namespace DubstepFight.CharacterInfoFolder
{
    partial class EasterEgg
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
            this.SecretPictureBox = new System.Windows.Forms.PictureBox();
            this.ReturnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SecretPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SecretPictureBox
            // 
            this.SecretPictureBox.Image = global::DubstepFight.Properties.Resources.SecretNigga;
            this.SecretPictureBox.Location = new System.Drawing.Point(2, -2);
            this.SecretPictureBox.Name = "SecretPictureBox";
            this.SecretPictureBox.Size = new System.Drawing.Size(796, 369);
            this.SecretPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SecretPictureBox.TabIndex = 0;
            this.SecretPictureBox.TabStop = false;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Location = new System.Drawing.Point(12, 373);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(776, 65);
            this.ReturnButton.TabIndex = 1;
            this.ReturnButton.Text = "Вернуться";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // EasterEgg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.SecretPictureBox);
            this.Name = "EasterEgg";
            this.Text = "EasterEgg";
            this.Load += new System.EventHandler(this.EasterEgg_Load);
            this.Resize += new System.EventHandler(this.EasterEgg_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.SecretPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SecretPictureBox;
        private System.Windows.Forms.Button ReturnButton;
    }
}