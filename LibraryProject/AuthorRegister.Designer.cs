namespace LibraryProject.Presentation
{
    partial class AuthorRegister
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
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.BioLabel = new System.Windows.Forms.Label();
            this.BioBox = new System.Windows.Forms.TextBox();
            this.BackLabel = new System.Windows.Forms.Label();
            this.AddBooksButton = new System.Windows.Forms.Button();
            this.BookNamesBox = new System.Windows.Forms.TextBox();
            this.AddBooksLabel = new System.Windows.Forms.Label();
            this.AddAuthorButton = new System.Windows.Forms.Button();
            this.DisclaimerLabel = new System.Windows.Forms.Label();
            this.CatalogueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.FirstNameLabel.Location = new System.Drawing.Point(17, 37);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(73, 17);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LastNameLabel.Location = new System.Drawing.Point(132, 37);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(70, 17);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(17, 57);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(93, 25);
            this.FirstNameBox.TabIndex = 2;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(132, 58);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(93, 25);
            this.LastNameBox.TabIndex = 3;
            // 
            // BioLabel
            // 
            this.BioLabel.AutoSize = true;
            this.BioLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.BioLabel.Location = new System.Drawing.Point(84, 97);
            this.BioLabel.Name = "BioLabel";
            this.BioLabel.Size = new System.Drawing.Size(104, 17);
            this.BioLabel.TabIndex = 4;
            this.BioLabel.Text = "Short Biography";
            // 
            // BioBox
            // 
            this.BioBox.Location = new System.Drawing.Point(12, 118);
            this.BioBox.Multiline = true;
            this.BioBox.Name = "BioBox";
            this.BioBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BioBox.Size = new System.Drawing.Size(246, 120);
            this.BioBox.TabIndex = 14;
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BackLabel.Location = new System.Drawing.Point(12, 298);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(180, 17);
            this.BackLabel.TabIndex = 16;
            this.BackLabel.Text = "Back to Main Contributor Page";
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click);
            // 
            // AddBooksButton
            // 
            this.AddBooksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.AddBooksButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.AddBooksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBooksButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBooksButton.Location = new System.Drawing.Point(341, 203);
            this.AddBooksButton.Name = "AddBooksButton";
            this.AddBooksButton.Size = new System.Drawing.Size(119, 26);
            this.AddBooksButton.TabIndex = 25;
            this.AddBooksButton.Text = "ADD BOOK(S)";
            this.AddBooksButton.UseVisualStyleBackColor = false;
            this.AddBooksButton.Click += new System.EventHandler(this.AddBooksButton_Click);
            // 
            // BookNamesBox
            // 
            this.BookNamesBox.Location = new System.Drawing.Point(295, 172);
            this.BookNamesBox.Name = "BookNamesBox";
            this.BookNamesBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.BookNamesBox.Size = new System.Drawing.Size(212, 25);
            this.BookNamesBox.TabIndex = 24;
            // 
            // AddBooksLabel
            // 
            this.AddBooksLabel.AutoSize = true;
            this.AddBooksLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AddBooksLabel.Location = new System.Drawing.Point(285, 135);
            this.AddBooksLabel.Name = "AddBooksLabel";
            this.AddBooksLabel.Size = new System.Drawing.Size(233, 34);
            this.AddBooksLabel.TabIndex = 23;
            this.AddBooksLabel.Text = "! Book Name(s) \r\n(Make sure to split with a comma (,)) !";
            this.AddBooksLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddAuthorButton
            // 
            this.AddAuthorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.AddAuthorButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.AddAuthorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAuthorButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddAuthorButton.Location = new System.Drawing.Point(12, 244);
            this.AddAuthorButton.Name = "AddAuthorButton";
            this.AddAuthorButton.Size = new System.Drawing.Size(118, 26);
            this.AddAuthorButton.TabIndex = 26;
            this.AddAuthorButton.Text = "REGISTER";
            this.AddAuthorButton.UseVisualStyleBackColor = false;
            this.AddAuthorButton.Click += new System.EventHandler(this.AddAuthorButton_Click);
            // 
            // DisclaimerLabel
            // 
            this.DisclaimerLabel.AutoSize = true;
            this.DisclaimerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.DisclaimerLabel.Location = new System.Drawing.Point(295, 97);
            this.DisclaimerLabel.Name = "DisclaimerLabel";
            this.DisclaimerLabel.Size = new System.Drawing.Size(212, 34);
            this.DisclaimerLabel.TabIndex = 27;
            this.DisclaimerLabel.Text = "! Please input the author\'s names \r\nto use the buttons below !";
            this.DisclaimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CatalogueLabel
            // 
            this.CatalogueLabel.AutoSize = true;
            this.CatalogueLabel.Font = new System.Drawing.Font("Times New Roman", 19.69811F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CatalogueLabel.Location = new System.Drawing.Point(290, 9);
            this.CatalogueLabel.Name = "CatalogueLabel";
            this.CatalogueLabel.Size = new System.Drawing.Size(239, 33);
            this.CatalogueLabel.TabIndex = 28;
            this.CatalogueLabel.Text = "Bookish catalogue";
            // 
            // AuthorRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(541, 324);
            this.Controls.Add(this.CatalogueLabel);
            this.Controls.Add(this.DisclaimerLabel);
            this.Controls.Add(this.AddAuthorButton);
            this.Controls.Add(this.AddBooksButton);
            this.Controls.Add(this.BookNamesBox);
            this.Controls.Add(this.AddBooksLabel);
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.BioBox);
            this.Controls.Add(this.BioLabel);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Name = "AuthorRegister";
            this.Text = "AuthorRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label FirstNameLabel;
        private Label LastNameLabel;
        private TextBox FirstNameBox;
        private TextBox LastNameBox;
        private Label BioLabel;
        private TextBox BioBox;
        private Label BackLabel;
        private Button AddBooksButton;
        private TextBox BookNamesBox;
        private Label AddBooksLabel;
        private Button AddAuthorButton;
        private Label DisclaimerLabel;
        private Label CatalogueLabel;
    }
}