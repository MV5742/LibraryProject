namespace LibraryProject.Presentation
{
    partial class MainPage
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
            this.LogInButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.TrendingButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.privacyPolicy = new System.Windows.Forms.Label();
            this.ContributorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.LogInButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.LogInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LogInButton.Location = new System.Drawing.Point(170, 147);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(131, 41);
            this.LogInButton.TabIndex = 9;
            this.LogInButton.Text = "LOG IN";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SearchButton.Location = new System.Drawing.Point(170, 216);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(131, 41);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TrendingButton
            // 
            this.TrendingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TrendingButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TrendingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrendingButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TrendingButton.ForeColor = System.Drawing.Color.Black;
            this.TrendingButton.Location = new System.Drawing.Point(170, 284);
            this.TrendingButton.Name = "TrendingButton";
            this.TrendingButton.Size = new System.Drawing.Size(131, 41);
            this.TrendingButton.TabIndex = 11;
            this.TrendingButton.Text = "TRENDING";
            this.TrendingButton.UseVisualStyleBackColor = false;
            this.TrendingButton.Click += new System.EventHandler(this.TrendingButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(9, 57);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(481, 66);
            this.Title.TabIndex = 12;
            this.Title.Text = "Bookish catalogue";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // privacyPolicy
            // 
            this.privacyPolicy.AutoSize = true;
            this.privacyPolicy.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.privacyPolicy.Location = new System.Drawing.Point(394, 399);
            this.privacyPolicy.Name = "privacyPolicy";
            this.privacyPolicy.Size = new System.Drawing.Size(84, 17);
            this.privacyPolicy.TabIndex = 13;
            this.privacyPolicy.Text = "Privacy Policy";
            // 
            // ContributorLabel
            // 
            this.ContributorLabel.AutoSize = true;
            this.ContributorLabel.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ContributorLabel.Location = new System.Drawing.Point(21, 399);
            this.ContributorLabel.Name = "ContributorLabel";
            this.ContributorLabel.Size = new System.Drawing.Size(107, 17);
            this.ContributorLabel.TabIndex = 14;
            this.ContributorLabel.Text = "Contributor Mode";
            this.ContributorLabel.Click += new System.EventHandler(this.ContributorLabel_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(502, 439);
            this.Controls.Add(this.ContributorLabel);
            this.Controls.Add(this.privacyPolicy);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.TrendingButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LogInButton);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button LogInButton;
        private Button SearchButton;
        private Button TrendingButton;
        private Label Title;
        private Label privacyPolicy;
        private Label ContributorLabel;
    }
}