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
            this.logInButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.trendingButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.privacyPolicy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(171, 127);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(131, 36);
            this.logInButton.TabIndex = 9;
            this.logInButton.Text = "LOG IN";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(171, 187);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(131, 36);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // trendingButton
            // 
            this.trendingButton.Location = new System.Drawing.Point(171, 243);
            this.trendingButton.Name = "trendingButton";
            this.trendingButton.Size = new System.Drawing.Size(131, 36);
            this.trendingButton.TabIndex = 11;
            this.trendingButton.Text = "TRENDING";
            this.trendingButton.UseVisualStyleBackColor = true;
            this.trendingButton.Click += new System.EventHandler(this.trendingButton_Click);
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
            this.privacyPolicy.Location = new System.Drawing.Point(375, 329);
            this.privacyPolicy.Name = "privacyPolicy";
            this.privacyPolicy.Size = new System.Drawing.Size(80, 15);
            this.privacyPolicy.TabIndex = 13;
            this.privacyPolicy.Text = "Privacy Policy";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 362);
            this.Controls.Add(this.privacyPolicy);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.trendingButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.logInButton);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button logInButton;
        private Button searchButton;
        private Button trendingButton;
        private Label Title;
        private Label privacyPolicy;
    }
}