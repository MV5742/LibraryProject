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
            this.TrollLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TrollLabel.Location = new System.Drawing.Point(29, 39);
            this.TrollLabel.Name = "TrollLabel";
            this.TrollLabel.Size = new System.Drawing.Size(454, 100);
            this.TrollLabel.TabIndex = 0;
            this.TrollLabel.Text = "     NO PRIVACY HERE\r\n[Insert IP Adress leak here]";
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Location = new System.Drawing.Point(29, 202);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(106, 15);
            this.backLabel.TabIndex = 1;
            this.backLabel.Text = "Back To Main Page";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // PrivacyPolicyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 236);
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