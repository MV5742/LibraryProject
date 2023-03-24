namespace LibraryProject.Presentation
{
    partial class CityRegister
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
            this.DisclaimerLabel = new System.Windows.Forms.Label();
            this.AddBookShopsButton = new System.Windows.Forms.Button();
            this.BookShopNamesBox = new System.Windows.Forms.TextBox();
            this.AddBookShopsLabel = new System.Windows.Forms.Label();
            this.AddPublishersButton = new System.Windows.Forms.Button();
            this.PublisherNameBox = new System.Windows.Forms.TextBox();
            this.PublisherNamesLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CityNameBox = new System.Windows.Forms.TextBox();
            this.RegisterCityButton = new System.Windows.Forms.Button();
            this.BackLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DisclaimerLabel
            // 
            this.DisclaimerLabel.AutoSize = true;
            this.DisclaimerLabel.Location = new System.Drawing.Point(15, 83);
            this.DisclaimerLabel.Name = "DisclaimerLabel";
            this.DisclaimerLabel.Size = new System.Drawing.Size(178, 30);
            this.DisclaimerLabel.TabIndex = 31;
            this.DisclaimerLabel.Text = "Please input the author\'s names \r\n       to use the buttons below";
            // 
            // AddBookShopsButton
            // 
            this.AddBookShopsButton.Location = new System.Drawing.Point(57, 195);
            this.AddBookShopsButton.Name = "AddBookShopsButton";
            this.AddBookShopsButton.Size = new System.Drawing.Size(116, 23);
            this.AddBookShopsButton.TabIndex = 30;
            this.AddBookShopsButton.Text = "Add Book Shop(s)";
            this.AddBookShopsButton.UseVisualStyleBackColor = true;
            this.AddBookShopsButton.Click += new System.EventHandler(this.AddBookShopsButton_Click);
            // 
            // BookShopNamesBox
            // 
            this.BookShopNamesBox.Location = new System.Drawing.Point(15, 166);
            this.BookShopNamesBox.Name = "BookShopNamesBox";
            this.BookShopNamesBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.BookShopNamesBox.Size = new System.Drawing.Size(201, 23);
            this.BookShopNamesBox.TabIndex = 29;
            // 
            // AddBookShopsLabel
            // 
            this.AddBookShopsLabel.AutoSize = true;
            this.AddBookShopsLabel.Location = new System.Drawing.Point(15, 124);
            this.AddBookShopsLabel.Name = "AddBookShopsLabel";
            this.AddBookShopsLabel.Size = new System.Drawing.Size(201, 30);
            this.AddBookShopsLabel.TabIndex = 28;
            this.AddBookShopsLabel.Text = "              Book Shop Name(s) \r\n(Make sure to split with a comma (,))";
            // 
            // AddPublishersButton
            // 
            this.AddPublishersButton.Location = new System.Drawing.Point(57, 302);
            this.AddPublishersButton.Name = "AddPublishersButton";
            this.AddPublishersButton.Size = new System.Drawing.Size(107, 23);
            this.AddPublishersButton.TabIndex = 34;
            this.AddPublishersButton.Text = "Add Pubisher(s)";
            this.AddPublishersButton.UseVisualStyleBackColor = true;
            this.AddPublishersButton.Click += new System.EventHandler(this.AddPublishersButton_Click);
            // 
            // PublisherNameBox
            // 
            this.PublisherNameBox.Location = new System.Drawing.Point(15, 273);
            this.PublisherNameBox.Name = "PublisherNameBox";
            this.PublisherNameBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.PublisherNameBox.Size = new System.Drawing.Size(201, 23);
            this.PublisherNameBox.TabIndex = 33;
            // 
            // PublisherNamesLabel
            // 
            this.PublisherNamesLabel.AutoSize = true;
            this.PublisherNamesLabel.Location = new System.Drawing.Point(15, 231);
            this.PublisherNamesLabel.Name = "PublisherNamesLabel";
            this.PublisherNamesLabel.Size = new System.Drawing.Size(201, 30);
            this.PublisherNamesLabel.TabIndex = 32;
            this.PublisherNamesLabel.Text = "                Publisher Name(s) \r\n(Make sure to split with a comma (,))";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(66, 28);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(63, 15);
            this.NameLabel.TabIndex = 35;
            this.NameLabel.Text = "City Name";
            // 
            // CityNameBox
            // 
            this.CityNameBox.Location = new System.Drawing.Point(47, 46);
            this.CityNameBox.Name = "CityNameBox";
            this.CityNameBox.Size = new System.Drawing.Size(100, 23);
            this.CityNameBox.TabIndex = 36;
            // 
            // RegisterCityButton
            // 
            this.RegisterCityButton.Location = new System.Drawing.Point(153, 45);
            this.RegisterCityButton.Name = "RegisterCityButton";
            this.RegisterCityButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterCityButton.TabIndex = 37;
            this.RegisterCityButton.Text = "Register";
            this.RegisterCityButton.UseVisualStyleBackColor = true;
            this.RegisterCityButton.Click += new System.EventHandler(this.RegisterCityButton_Click);
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Location = new System.Drawing.Point(14, 356);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(170, 15);
            this.BackLabel.TabIndex = 38;
            this.BackLabel.Text = "Back to Main Contributor Page";
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click);
            // 
            // CityRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 389);
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.RegisterCityButton);
            this.Controls.Add(this.CityNameBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AddPublishersButton);
            this.Controls.Add(this.PublisherNameBox);
            this.Controls.Add(this.PublisherNamesLabel);
            this.Controls.Add(this.DisclaimerLabel);
            this.Controls.Add(this.AddBookShopsButton);
            this.Controls.Add(this.BookShopNamesBox);
            this.Controls.Add(this.AddBookShopsLabel);
            this.Name = "CityRegister";
            this.Text = "CityRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label DisclaimerLabel;
        private Button AddBookShopsButton;
        private TextBox BookShopNamesBox;
        private Label AddBookShopsLabel;
        private Button AddPublishersButton;
        private TextBox PublisherNameBox;
        private Label PublisherNamesLabel;
        private Label NameLabel;
        private TextBox CityNameBox;
        private Button RegisterCityButton;
        private Label BackLabel;
    }
}