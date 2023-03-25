namespace LibraryProject.Presentation
{
    partial class BookRegister
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
            this.TitleLable = new System.Windows.Forms.Label();
            this.ISBNLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.ISBNBox = new System.Windows.Forms.TextBox();
            this.GenreBox = new System.Windows.Forms.TextBox();
            this.QuantityBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionBox = new System.Windows.Forms.TextBox();
            this.RegisterBookButton = new System.Windows.Forms.Button();
            this.BackLabel = new System.Windows.Forms.Label();
            this.AuthorNamesLabel = new System.Windows.Forms.Label();
            this.AuthorsBox = new System.Windows.Forms.TextBox();
            this.PublisherLabel = new System.Windows.Forms.Label();
            this.publisherNameBox = new System.Windows.Forms.TextBox();
            this.BookShopsBox = new System.Windows.Forms.TextBox();
            this.BookShopsLabel = new System.Windows.Forms.Label();
            this.AddAuthorsButton = new System.Windows.Forms.Button();
            this.AddPublisherButton = new System.Windows.Forms.Button();
            this.AddShopsButton = new System.Windows.Forms.Button();
            this.DisclaimerLabel = new System.Windows.Forms.Label();
            this.CatalogueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TitleLable.Location = new System.Drawing.Point(12, 53);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(35, 17);
            this.TitleLable.TabIndex = 0;
            this.TitleLable.Text = "Title";
            // 
            // ISBNLabel
            // 
            this.ISBNLabel.AutoSize = true;
            this.ISBNLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ISBNLabel.Location = new System.Drawing.Point(12, 102);
            this.ISBNLabel.Name = "ISBNLabel";
            this.ISBNLabel.Size = new System.Drawing.Size(37, 17);
            this.ISBNLabel.TabIndex = 1;
            this.ISBNLabel.Text = "ISBN";
            this.ISBNLabel.Click += new System.EventHandler(this.ISBNLabel_Click);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.GenreLabel.Location = new System.Drawing.Point(12, 152);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(44, 17);
            this.GenreLabel.TabIndex = 2;
            this.GenreLabel.Text = "Genre";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.QuantityLabel.Location = new System.Drawing.Point(152, 53);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(106, 17);
            this.QuantityLabel.TabIndex = 3;
            this.QuantityLabel.Text = "QuantityInStock";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.PriceLabel.Location = new System.Drawing.Point(156, 101);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(38, 17);
            this.PriceLabel.TabIndex = 4;
            this.PriceLabel.Text = "Price";
            // 
            // TitleBox
            // 
            this.TitleBox.Location = new System.Drawing.Point(12, 73);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TitleBox.Size = new System.Drawing.Size(100, 25);
            this.TitleBox.TabIndex = 5;
            // 
            // ISBNBox
            // 
            this.ISBNBox.Location = new System.Drawing.Point(12, 123);
            this.ISBNBox.Name = "ISBNBox";
            this.ISBNBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ISBNBox.Size = new System.Drawing.Size(100, 25);
            this.ISBNBox.TabIndex = 6;
            // 
            // GenreBox
            // 
            this.GenreBox.Location = new System.Drawing.Point(14, 173);
            this.GenreBox.Name = "GenreBox";
            this.GenreBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.GenreBox.Size = new System.Drawing.Size(100, 25);
            this.GenreBox.TabIndex = 7;
            // 
            // QuantityBox
            // 
            this.QuantityBox.Location = new System.Drawing.Point(156, 73);
            this.QuantityBox.Name = "QuantityBox";
            this.QuantityBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.QuantityBox.Size = new System.Drawing.Size(100, 25);
            this.QuantityBox.TabIndex = 8;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(156, 123);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.PriceBox.Size = new System.Drawing.Size(100, 25);
            this.PriceBox.TabIndex = 9;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DateLabel.Location = new System.Drawing.Point(156, 154);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(95, 17);
            this.DateLabel.TabIndex = 10;
            this.DateLabel.Text = "DatePublished";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(156, 173);
            this.DateBox.Name = "DateBox";
            this.DateBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.DateBox.Size = new System.Drawing.Size(100, 25);
            this.DateBox.TabIndex = 11;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.Location = new System.Drawing.Point(75, 213);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(112, 17);
            this.DescriptionLabel.TabIndex = 12;
            this.DescriptionLabel.Text = "Short Description";
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DescriptionBox.Location = new System.Drawing.Point(12, 241);
            this.DescriptionBox.Multiline = true;
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionBox.Size = new System.Drawing.Size(246, 120);
            this.DescriptionBox.TabIndex = 13;
            // 
            // RegisterBookButton
            // 
            this.RegisterBookButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.RegisterBookButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.RegisterBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBookButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegisterBookButton.Location = new System.Drawing.Point(12, 377);
            this.RegisterBookButton.Name = "RegisterBookButton";
            this.RegisterBookButton.Size = new System.Drawing.Size(100, 26);
            this.RegisterBookButton.TabIndex = 14;
            this.RegisterBookButton.Text = "REGISTER";
            this.RegisterBookButton.UseVisualStyleBackColor = false;
            this.RegisterBookButton.Click += new System.EventHandler(this.RegisterBookButton_Click);
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BackLabel.Location = new System.Drawing.Point(12, 416);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(180, 17);
            this.BackLabel.TabIndex = 15;
            this.BackLabel.Text = "Back to Main Contributor Page";
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click);
            // 
            // AuthorNamesLabel
            // 
            this.AuthorNamesLabel.AutoSize = true;
            this.AuthorNamesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AuthorNamesLabel.Location = new System.Drawing.Point(290, 94);
            this.AuthorNamesLabel.Name = "AuthorNamesLabel";
            this.AuthorNamesLabel.Size = new System.Drawing.Size(233, 34);
            this.AuthorNamesLabel.TabIndex = 16;
            this.AuthorNamesLabel.Text = "! Author Name(s) \r\n(Make sure to split with a comma (,)) !";
            this.AuthorNamesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuthorsBox
            // 
            this.AuthorsBox.Location = new System.Drawing.Point(302, 150);
            this.AuthorsBox.Name = "AuthorsBox";
            this.AuthorsBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.AuthorsBox.Size = new System.Drawing.Size(201, 25);
            this.AuthorsBox.TabIndex = 17;
            // 
            // PublisherLabel
            // 
            this.PublisherLabel.AutoSize = true;
            this.PublisherLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.PublisherLabel.Location = new System.Drawing.Point(349, 225);
            this.PublisherLabel.Name = "PublisherLabel";
            this.PublisherLabel.Size = new System.Drawing.Size(103, 17);
            this.PublisherLabel.TabIndex = 18;
            this.PublisherLabel.Text = "Publisher Name";
            // 
            // publisherNameBox
            // 
            this.publisherNameBox.Location = new System.Drawing.Point(302, 246);
            this.publisherNameBox.Name = "publisherNameBox";
            this.publisherNameBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.publisherNameBox.Size = new System.Drawing.Size(201, 25);
            this.publisherNameBox.TabIndex = 19;
            // 
            // BookShopsBox
            // 
            this.BookShopsBox.Location = new System.Drawing.Point(302, 368);
            this.BookShopsBox.Name = "BookShopsBox";
            this.BookShopsBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.BookShopsBox.Size = new System.Drawing.Size(201, 25);
            this.BookShopsBox.TabIndex = 21;
            // 
            // BookShopsLabel
            // 
            this.BookShopsLabel.AutoSize = true;
            this.BookShopsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BookShopsLabel.Location = new System.Drawing.Point(290, 331);
            this.BookShopsLabel.Name = "BookShopsLabel";
            this.BookShopsLabel.Size = new System.Drawing.Size(233, 34);
            this.BookShopsLabel.TabIndex = 20;
            this.BookShopsLabel.Text = "! BookShop Name(s) \r\n(Make sure to split with a comma (,)) !";
            this.BookShopsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddAuthorsButton
            // 
            this.AddAuthorsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.AddAuthorsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.AddAuthorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAuthorsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddAuthorsButton.Location = new System.Drawing.Point(340, 181);
            this.AddAuthorsButton.Name = "AddAuthorsButton";
            this.AddAuthorsButton.Size = new System.Drawing.Size(121, 26);
            this.AddAuthorsButton.TabIndex = 22;
            this.AddAuthorsButton.Text = "ADD AUTHOR(S)";
            this.AddAuthorsButton.UseVisualStyleBackColor = false;
            this.AddAuthorsButton.Click += new System.EventHandler(this.AddAuthorsButton_Click);
            // 
            // AddPublisherButton
            // 
            this.AddPublisherButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.AddPublisherButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.AddPublisherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPublisherButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddPublisherButton.Location = new System.Drawing.Point(340, 277);
            this.AddPublisherButton.Name = "AddPublisherButton";
            this.AddPublisherButton.Size = new System.Drawing.Size(121, 26);
            this.AddPublisherButton.TabIndex = 23;
            this.AddPublisherButton.Text = "ADD PUBLISHER";
            this.AddPublisherButton.UseVisualStyleBackColor = false;
            this.AddPublisherButton.Click += new System.EventHandler(this.AddPublisherButton_Click);
            // 
            // AddShopsButton
            // 
            this.AddShopsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.AddShopsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.AddShopsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddShopsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddShopsButton.Location = new System.Drawing.Point(340, 399);
            this.AddShopsButton.Name = "AddShopsButton";
            this.AddShopsButton.Size = new System.Drawing.Size(121, 26);
            this.AddShopsButton.TabIndex = 24;
            this.AddShopsButton.Text = "ADD SHOP(S)";
            this.AddShopsButton.UseVisualStyleBackColor = false;
            this.AddShopsButton.Click += new System.EventHandler(this.AddShopsButton_Click);
            // 
            // DisclaimerLabel
            // 
            this.DisclaimerLabel.AutoSize = true;
            this.DisclaimerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DisclaimerLabel.Location = new System.Drawing.Point(316, 44);
            this.DisclaimerLabel.Name = "DisclaimerLabel";
            this.DisclaimerLabel.Size = new System.Drawing.Size(187, 34);
            this.DisclaimerLabel.TabIndex = 25;
            this.DisclaimerLabel.Text = "! Please input the book\'s title \r\nto use the buttons below !";
            this.DisclaimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CatalogueLabel
            // 
            this.CatalogueLabel.AutoSize = true;
            this.CatalogueLabel.Font = new System.Drawing.Font("Times New Roman", 19.69811F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CatalogueLabel.Location = new System.Drawing.Point(12, 9);
            this.CatalogueLabel.Name = "CatalogueLabel";
            this.CatalogueLabel.Size = new System.Drawing.Size(239, 33);
            this.CatalogueLabel.TabIndex = 26;
            this.CatalogueLabel.Text = "Bookish catalogue";
            // 
            // BookRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(530, 442);
            this.Controls.Add(this.CatalogueLabel);
            this.Controls.Add(this.DisclaimerLabel);
            this.Controls.Add(this.AddShopsButton);
            this.Controls.Add(this.AddPublisherButton);
            this.Controls.Add(this.AddAuthorsButton);
            this.Controls.Add(this.BookShopsBox);
            this.Controls.Add(this.BookShopsLabel);
            this.Controls.Add(this.publisherNameBox);
            this.Controls.Add(this.PublisherLabel);
            this.Controls.Add(this.AuthorsBox);
            this.Controls.Add(this.AuthorNamesLabel);
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.RegisterBookButton);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.QuantityBox);
            this.Controls.Add(this.GenreBox);
            this.Controls.Add(this.ISBNBox);
            this.Controls.Add(this.TitleBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.ISBNLabel);
            this.Controls.Add(this.TitleLable);
            this.Name = "BookRegister";
            this.Text = "BookRegister";
            this.Load += new System.EventHandler(this.BookRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLable;
        private Label ISBNLabel;
        private Label GenreLabel;
        private Label QuantityLabel;
        private Label PriceLabel;
        private TextBox TitleBox;
        private TextBox ISBNBox;
        private TextBox GenreBox;
        private TextBox QuantityBox;
        private TextBox PriceBox;
        private Label DateLabel;
        private TextBox DateBox;
        private Label DescriptionLabel;
        private TextBox DescriptionBox;
        private Button RegisterBookButton;
        private Label BackLabel;
        private Label AuthorNamesLabel;
        private TextBox AuthorsBox;
        private Label PublisherLabel;
        private TextBox publisherNameBox;
        private TextBox BookShopsBox;
        private Label BookShopsLabel;
        private Button AddAuthorsButton;
        private Button AddPublisherButton;
        private Button AddShopsButton;
        private Label DisclaimerLabel;
        private Label CatalogueLabel;
    }
}