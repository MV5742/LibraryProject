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
            this.SuspendLayout();
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(33, 25);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(64, 15);
            this.FirstNameLabel.TabIndex = 0;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(132, 25);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(63, 15);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(33, 43);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(93, 23);
            this.FirstNameBox.TabIndex = 2;
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(132, 43);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(93, 23);
            this.LastNameBox.TabIndex = 3;
            // 
            // BioLabel
            // 
            this.BioLabel.AutoSize = true;
            this.BioLabel.Location = new System.Drawing.Point(84, 78);
            this.BioLabel.Name = "BioLabel";
            this.BioLabel.Size = new System.Drawing.Size(92, 15);
            this.BioLabel.TabIndex = 4;
            this.BioLabel.Text = "Short Biography";
            // 
            // BioBox
            // 
            this.BioBox.Location = new System.Drawing.Point(12, 96);
            this.BioBox.Multiline = true;
            this.BioBox.Name = "BioBox";
            this.BioBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.BioBox.Size = new System.Drawing.Size(246, 106);
            this.BioBox.TabIndex = 14;
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Location = new System.Drawing.Point(23, 252);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(170, 15);
            this.BackLabel.TabIndex = 16;
            this.BackLabel.Text = "Back to Main Contributor Page";
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click);
            // 
            // AddBooksButton
            // 
            this.AddBooksButton.Location = new System.Drawing.Point(342, 149);
            this.AddBooksButton.Name = "AddBooksButton";
            this.AddBooksButton.Size = new System.Drawing.Size(91, 23);
            this.AddBooksButton.TabIndex = 25;
            this.AddBooksButton.Text = "Add Book(s)";
            this.AddBooksButton.UseVisualStyleBackColor = true;
            this.AddBooksButton.Click += new System.EventHandler(this.AddBooksButton_Click);
            // 
            // BookNamesBox
            // 
            this.BookNamesBox.Location = new System.Drawing.Point(291, 120);
            this.BookNamesBox.Name = "BookNamesBox";
            this.BookNamesBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.BookNamesBox.Size = new System.Drawing.Size(201, 23);
            this.BookNamesBox.TabIndex = 24;
            // 
            // AddBooksLabel
            // 
            this.AddBooksLabel.AutoSize = true;
            this.AddBooksLabel.Location = new System.Drawing.Point(291, 78);
            this.AddBooksLabel.Name = "AddBooksLabel";
            this.AddBooksLabel.Size = new System.Drawing.Size(201, 30);
            this.AddBooksLabel.TabIndex = 23;
            this.AddBooksLabel.Text = "                 Book Name(s) \r\n(Make sure to split with a comma (,))";
            // 
            // AddAuthorButton
            // 
            this.AddAuthorButton.Location = new System.Drawing.Point(35, 208);
            this.AddAuthorButton.Name = "AddAuthorButton";
            this.AddAuthorButton.Size = new System.Drawing.Size(75, 23);
            this.AddAuthorButton.TabIndex = 26;
            this.AddAuthorButton.Text = "Register";
            this.AddAuthorButton.UseVisualStyleBackColor = true;
            this.AddAuthorButton.Click += new System.EventHandler(this.AddAuthorButton_Click);
            // 
            // DisclaimerLabel
            // 
            this.DisclaimerLabel.AutoSize = true;
            this.DisclaimerLabel.Location = new System.Drawing.Point(305, 36);
            this.DisclaimerLabel.Name = "DisclaimerLabel";
            this.DisclaimerLabel.Size = new System.Drawing.Size(178, 30);
            this.DisclaimerLabel.TabIndex = 27;
            this.DisclaimerLabel.Text = "Please input the author\'s names \r\n       to use the buttons below";
            // 
            // AuthorRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 286);
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
    }
}