namespace LibraryProject.Presentation
{
    partial class PrivacyPolicyPage
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
            this.TrollLabel = new System.Windows.Forms.Label();
            this.backLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TrollLabel
            // 
            this.TrollLabel.AutoSize = true;
            this.TrollLabel.Font = new System.Drawing.Font("Segoe UI Black", 27.84906F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TrollLabel.Location = new System.Drawing.Point(-4, 60);
            this.TrollLabel.Name = "TrollLabel";
            this.TrollLabel.Size = new System.Drawing.Size(571, 110);
            this.TrollLabel.TabIndex = 0;
            this.TrollLabel.Text = "NO PRIVACY HERE\r\n[Insert IP Adress leak here]";
            this.TrollLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.backLabel.Location = new System.Drawing.Point(12, 227);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(115, 17);
            this.backLabel.TabIndex = 1;
            this.backLabel.Text = "Back To Main Page";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // PrivacyPolicyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(564, 267);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.TrollLabel);
            this.Name = "PrivacyPolicyPage";
            this.Text = "PrivacyPolicyPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TrollLabel;
        private Label backLabel;
    }
}