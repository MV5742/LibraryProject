namespace LibraryProject.Presentation
{
    partial class PublisherRegister
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
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.TitleLable = new System.Windows.Forms.Label();
            this.DisclaimerLabel = new System.Windows.Forms.Label();
            this.AddBooksButton = new System.Windows.Forms.Button();
            this.BookNamesBox = new System.Windows.Forms.TextBox();
            this.AddBooksLabel = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.BackLabel = new System.Windows.Forms.Label();
            this.CityNameBox = new System.Windows.Forms.TextBox();
            this.CityNameLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(126, 72);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.AddressBox.Size = new System.Drawing.Size(100, 23);
            this.AddressBox.TabIndex = 15;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(20, 72);
            this.NameBox.Name = "NameBox";
            this.NameBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.NameBox.Size = new System.Drawing.Size(100, 23);
            this.NameBox.TabIndex = 14;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddressLabel.Location = new System.Drawing.Point(126, 55);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(61, 15);
            this.AddressLabel.TabIndex = 11;
            this.AddressLabel.Text = "ADDRESS";
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TitleLable.Location = new System.Drawing.Point(20, 55);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(41, 15);
            this.TitleLable.TabIndex = 10;
            this.TitleLable.Text = "NAME";
            // 
            // DisclaimerLabel
            // 
            this.DisclaimerLabel.AutoSize = true;
            this.DisclaimerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DisclaimerLabel.Location = new System.Drawing.Point(377, 47);
            this.DisclaimerLabel.Name = "DisclaimerLabel";
            this.DisclaimerLabel.Size = new System.Drawing.Size(197, 30);
            this.DisclaimerLabel.TabIndex = 31;
            this.DisclaimerLabel.Text = "! Please input the publisher\'s name \r\nto use the buttons below !";
            this.DisclaimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddBooksButton
            // 
            this.AddBooksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.AddBooksButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.AddBooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBooksButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBooksButton.Location = new System.Drawing.Point(423, 143);
            this.AddBooksButton.Name = "AddBooksButton";
            this.AddBooksButton.Size = new System.Drawing.Size(129, 23);
            this.AddBooksButton.TabIndex = 30;
            this.AddBooksButton.Text = "ADD BOOK(S)";
            this.AddBooksButton.UseVisualStyleBackColor = false;
            this.AddBooksButton.Click += new System.EventHandler(this.AddBooksButton_Click);
            // 
            // BookNamesBox
            // 
            this.BookNamesBox.Location = new System.Drawing.Point(390, 116);
            this.BookNamesBox.Name = "BookNamesBox";
            this.BookNamesBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.BookNamesBox.Size = new System.Drawing.Size(198, 23);
            this.BookNamesBox.TabIndex = 29;
            // 
            // AddBooksLabel
            // 
            this.AddBooksLabel.AutoSize = true;
            this.AddBooksLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBooksLabel.Location = new System.Drawing.Point(377, 83);
            this.AddBooksLabel.Name = "AddBooksLabel";
            this.AddBooksLabel.Size = new System.Drawing.Size(201, 30);
            this.AddBooksLabel.TabIndex = 28;
            this.AddBooksLabel.Text = "Book Name(s) \r\n(Make sure to split with a comma (,))";
            this.AddBooksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.RegisterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RegisterButton.Location = new System.Drawing.Point(20, 110);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(312, 23);
            this.RegisterButton.TabIndex = 32;
            this.RegisterButton.Text = "REGISTER";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BackLabel.Location = new System.Drawing.Point(12, 170);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(168, 15);
            this.BackLabel.TabIndex = 33;
            this.BackLabel.Text = "Back to Main Contributor Page";
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click);
            // 
            // CityNameBox
            // 
            this.CityNameBox.Location = new System.Drawing.Point(232, 72);
            this.CityNameBox.Name = "CityNameBox";
            this.CityNameBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CityNameBox.Size = new System.Drawing.Size(100, 23);
            this.CityNameBox.TabIndex = 35;
            // 
            // CityNameLabel
            // 
            this.CityNameLabel.AutoSize = true;
            this.CityNameLabel.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CityNameLabel.Location = new System.Drawing.Point(232, 55);
            this.CityNameLabel.Name = "CityNameLabel";
            this.CityNameLabel.Size = new System.Drawing.Size(69, 15);
            this.CityNameLabel.TabIndex = 34;
            this.CityNameLabel.Text = "CITY NAME";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 19.69811F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(12, 8);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(226, 31);
            this.Title.TabIndex = 36;
            this.Title.Text = "Bookish catalogue";
            // 
            // PublisherRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(648, 193);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.CityNameBox);
            this.Controls.Add(this.CityNameLabel);
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.DisclaimerLabel);
            this.Controls.Add(this.AddBooksButton);
            this.Controls.Add(this.BookNamesBox);
            this.Controls.Add(this.AddBooksLabel);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.TitleLable);
            this.Name = "PublisherRegister";
            this.Text = "PublisherRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox AddressBox;
        private TextBox NameBox;
        private Label AddressLabel;
        private Label TitleLable;
        private Label DisclaimerLabel;
        private Button AddBooksButton;
        private TextBox BookNamesBox;
        private Label AddBooksLabel;
        private Button RegisterButton;
        private Label BackLabel;
        private TextBox CityNameBox;
        private Label CityNameLabel;
        private Label Title;
    }
}