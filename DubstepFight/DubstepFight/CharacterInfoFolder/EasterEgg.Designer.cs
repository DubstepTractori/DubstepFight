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
            ((System.ComponentModel.ISupportInitialize)(this.SecretPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SecretPictureBox
            // 
            this.SecretPictureBox.Image = global::DubstepFight.Properties.Resources.SecretNigga;
            this.SecretPictureBox.Location = new System.Drawing.Point(-1, -2);
            this.SecretPictureBox.Name = "SecretPictureBox";
            this.SecretPictureBox.Size = new System.Drawing.Size(303, 223);
            this.SecretPictureBox.TabIndex = 0;
            this.SecretPictureBox.TabStop = false;
            // 
            // EasterEgg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SecretPictureBox);
            this.Name = "EasterEgg";
            this.Text = "EasterEgg";
            ((System.ComponentModel.ISupportInitialize)(this.SecretPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox SecretPictureBox;
    }
}