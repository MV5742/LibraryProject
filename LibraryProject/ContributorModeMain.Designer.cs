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
            this.CatalogueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(235, 96);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(68, 17);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password?";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(170, 127);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 25);
            this.passwordBox.TabIndex = 1;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.welcomeLabel.Location = new System.Drawing.Point(187, 64);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(188, 17);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome to Contributor Mode";
            this.welcomeLabel.Visible = false;
            // 
            // AuthorButton
            // 
            this.AuthorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.AuthorButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.AuthorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthorButton.Location = new System.Drawing.Point(133, 96);
            this.AuthorButton.Name = "AuthorButton";
            this.AuthorButton.Size = new System.Drawing.Size(137, 26);
            this.AuthorButton.TabIndex = 3;
            this.AuthorButton.Text = "REGISTER AUTHOR";
            this.AuthorButton.UseVisualStyleBackColor = false;
            this.AuthorButton.Visible = false;
            this.AuthorButton.Click += new System.EventHandler(this.AuthorButton_Click);
            // 
            // BookButton
            // 
            this.BookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.BookButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.BookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BookButton.Location = new System.Drawing.Point(285, 96);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(119, 26);
            this.BookButton.TabIndex = 4;
            this.BookButton.Text = "REGISTER BOOK";
            this.BookButton.UseVisualStyleBackColor = false;
            this.BookButton.Visible = false;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // PublisherButton
            // 
            this.PublisherButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.PublisherButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.PublisherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PublisherButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PublisherButton.Location = new System.Drawing.Point(12, 127);
            this.PublisherButton.Name = "PublisherButton";
            this.PublisherButton.Size = new System.Drawing.Size(170, 26);
            this.PublisherButton.TabIndex = 5;
            this.PublisherButton.Text = "REGISTER PUBLISHER";
            this.PublisherButton.UseVisualStyleBackColor = false;
            this.PublisherButton.Visible = false;
            this.PublisherButton.Click += new System.EventHandler(this.PublisherButton_Click);
            // 
            // BookShopButton
            // 
            this.BookShopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.BookShopButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.BookShopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookShopButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BookShopButton.Location = new System.Drawing.Point(340, 128);
            this.BookShopButton.Name = "BookShopButton";
            this.BookShopButton.Size = new System.Drawing.Size(156, 26);
            this.BookShopButton.TabIndex = 6;
            this.BookShopButton.Text = "REGISTER BOOK SHOP";
            this.BookShopButton.UseVisualStyleBackColor = false;
            this.BookShopButton.Visible = false;
            this.BookShopButton.Click += new System.EventHandler(this.BookShopButton_Click);
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BackLabel.Location = new System.Drawing.Point(410, 209);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(117, 17);
            this.BackLabel.TabIndex = 7;
            this.BackLabel.Text = "Back to Home Page";
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CheckButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckButton.Location = new System.Drawing.Point(276, 127);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(106, 26);
            this.CheckButton.TabIndex = 8;
            this.CheckButton.Text = "CHECK";
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // CityButton
            // 
            this.CityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CityButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.CityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CityButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CityButton.Location = new System.Drawing.Point(187, 128);
            this.CityButton.Name = "CityButton";
            this.CityButton.Size = new System.Drawing.Size(147, 26);
            this.CityButton.TabIndex = 9;
            this.CityButton.Text = "REGISTER CITY";
            this.CityButton.UseVisualStyleBackColor = false;
            this.CityButton.Visible = false;
            // 
            // CatalogueLabel
            // 
            this.CatalogueLabel.AutoSize = true;
            this.CatalogueLabel.Font = new System.Drawing.Font("Times New Roman", 19.69811F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CatalogueLabel.Location = new System.Drawing.Point(12, 9);
            this.CatalogueLabel.Name = "CatalogueLabel";
            this.CatalogueLabel.Size = new System.Drawing.Size(239, 33);
            this.CatalogueLabel.TabIndex = 12;
            this.CatalogueLabel.Text = "Bookish catalogue";
            // 
            // ContributorModeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(539, 235);
            this.Controls.Add(this.CatalogueLabel);
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
        private Label CatalogueLabel;
    }
}