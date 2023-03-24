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
            this.LogInButton.Location = new System.Drawing.Point(157, 130);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(131, 36);
            this.LogInButton.TabIndex = 9;
            this.LogInButton.Text = "LOG IN";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(157, 191);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(131, 36);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "SEARCH";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TrendingButton
            // 
            this.TrendingButton.Location = new System.Drawing.Point(157, 251);
            this.TrendingButton.Name = "TrendingButton";
            this.TrendingButton.Size = new System.Drawing.Size(131, 36);
            this.TrendingButton.TabIndex = 11;
            this.TrendingButton.Text = "TRENDING";
            this.TrendingButton.UseVisualStyleBackColor = true;
            this.TrendingButton.Click += new System.EventHandler(this.TrendingButton_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(37, 39);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(406, 61);
            this.Title.TabIndex = 12;
            this.Title.Text = "Bookish cataloge";
            // 
            // privacyPolicy
            // 
            this.privacyPolicy.AutoSize = true;
            this.privacyPolicy.Location = new System.Drawing.Point(379, 352);
            this.privacyPolicy.Name = "privacyPolicy";
            this.privacyPolicy.Size = new System.Drawing.Size(80, 15);
            this.privacyPolicy.TabIndex = 13;
            this.privacyPolicy.Text = "Privacy Policy";
            // 
            // ContributorLabel
            // 
            this.ContributorLabel.AutoSize = true;
            this.ContributorLabel.Location = new System.Drawing.Point(21, 352);
            this.ContributorLabel.Name = "ContributorLabel";
            this.ContributorLabel.Size = new System.Drawing.Size(103, 15);
            this.ContributorLabel.TabIndex = 14;
            this.ContributorLabel.Text = "Contributor Mode";
            this.ContributorLabel.Click += new System.EventHandler(this.ContributorLabel_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 387);
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