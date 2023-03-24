namespace LibraryProject.Presentation
{
    partial class ContributorModeMain
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
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.AuthorButton = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.PublisherButton = new System.Windows.Forms.Button();
            this.BookShopButton = new System.Windows.Forms.Button();
            this.BackLabel = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.CityButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(138, 87);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(62, 15);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password?";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(120, 118);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 23);
            this.passwordBox.TabIndex = 1;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(86, 48);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(170, 15);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome to Contributor Mode";
            this.welcomeLabel.Visible = false;
            // 
            // AuthorButton
            // 
            this.AuthorButton.Location = new System.Drawing.Point(75, 83);
            this.AuthorButton.Name = "AuthorButton";
            this.AuthorButton.Size = new System.Drawing.Size(107, 23);
            this.AuthorButton.TabIndex = 3;
            this.AuthorButton.Text = "Register Author";
            this.AuthorButton.UseVisualStyleBackColor = true;
            this.AuthorButton.Visible = false;
            this.AuthorButton.Click += new System.EventHandler(this.AuthorButton_Click);
            // 
            // BookButton
            // 
            this.BookButton.Location = new System.Drawing.Point(188, 83);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(97, 23);
            this.BookButton.TabIndex = 4;
            this.BookButton.Text = "Register Book";
            this.BookButton.UseVisualStyleBackColor = true;
            this.BookButton.Visible = false;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // PublisherButton
            // 
            this.PublisherButton.Location = new System.Drawing.Point(12, 110);
            this.PublisherButton.Name = "PublisherButton";
            this.PublisherButton.Size = new System.Drawing.Size(119, 23);
            this.PublisherButton.TabIndex = 5;
            this.PublisherButton.Text = "Register Publisher";
            this.PublisherButton.UseVisualStyleBackColor = true;
            this.PublisherButton.Visible = false;
            this.PublisherButton.Click += new System.EventHandler(this.PublisherButton_Click);
            // 
            // BookShopButton
            // 
            this.BookShopButton.Location = new System.Drawing.Point(226, 110);
            this.BookShopButton.Name = "BookShopButton";
            this.BookShopButton.Size = new System.Drawing.Size(130, 23);
            this.BookShopButton.TabIndex = 6;
            this.BookShopButton.Text = "Register Book Shop";
            this.BookShopButton.UseVisualStyleBackColor = true;
            this.BookShopButton.Visible = false;
            this.BookShopButton.Click += new System.EventHandler(this.BookShopButton_Click);
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Location = new System.Drawing.Point(231, 165);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(111, 15);
            this.BackLabel.TabIndex = 7;
            this.BackLabel.Text = "Back to Home Page";
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(242, 118);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 23);
            this.CheckButton.TabIndex = 8;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // CityButton
            // 
            this.CityButton.Location = new System.Drawing.Point(137, 110);
            this.CityButton.Name = "CityButton";
            this.CityButton.Size = new System.Drawing.Size(83, 23);
            this.CityButton.TabIndex = 9;
            this.CityButton.Text = "Register City";
            this.CityButton.UseVisualStyleBackColor = true;
            this.CityButton.Visible = false;
            // 
            // ContributorModeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 207);
            this.Controls.Add(this.CityButton);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.BookShopButton);
            this.Controls.Add(this.PublisherButton);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.AuthorButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passwordLabel);
            this.Name = "ContributorModeMain";
            this.Text = "ContributorModeMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label passwordLabel;
        private TextBox passwordBox;
        private Label welcomeLabel;
        private Button AuthorButton;
        private Button BookButton;
        private Button PublisherButton;
        private Button BookShopButton;
        private Label BackLabel;
        private Button CheckButton;
        private Button CityButton;
    }
}