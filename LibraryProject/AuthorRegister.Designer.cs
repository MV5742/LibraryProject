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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.bioLabel = new System.Windows.Forms.Label();
            this.bioBox = new System.Windows.Forms.TextBox();
            this.backLabel = new System.Windows.Forms.Label();
            this.addBooksButton = new System.Windows.Forms.Button();
            this.bookNamesBox = new System.Windows.Forms.TextBox();
            this.addBooksLabel = new System.Windows.Forms.Label();
            this.addAuthorButton = new System.Windows.Forms.Button();
            this.disclaimerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(46, 25);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(64, 15);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(147, 25);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(63, 15);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(33, 43);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(93, 23);
            this.firstNameBox.TabIndex = 2;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(132, 43);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(93, 23);
            this.lastNameBox.TabIndex = 3;
            // 
            // bioLabel
            // 
            this.bioLabel.AutoSize = true;
            this.bioLabel.Location = new System.Drawing.Point(84, 78);
            this.bioLabel.Name = "bioLabel";
            this.bioLabel.Size = new System.Drawing.Size(92, 15);
            this.bioLabel.TabIndex = 4;
            this.bioLabel.Text = "Short Biography";
            this.bioLabel.Click += new System.EventHandler(this.bioLabel_Click);
            // 
            // bioBox
            // 
            this.bioBox.Location = new System.Drawing.Point(12, 96);
            this.bioBox.Multiline = true;
            this.bioBox.Name = "bioBox";
            this.bioBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.bioBox.Size = new System.Drawing.Size(246, 106);
            this.bioBox.TabIndex = 14;
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Location = new System.Drawing.Point(23, 252);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(170, 15);
            this.backLabel.TabIndex = 16;
            this.backLabel.Text = "Back to Main Contributor Page";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // addBooksButton
            // 
            this.addBooksButton.Location = new System.Drawing.Point(342, 149);
            this.addBooksButton.Name = "addBooksButton";
            this.addBooksButton.Size = new System.Drawing.Size(91, 23);
            this.addBooksButton.TabIndex = 25;
            this.addBooksButton.Text = "Add Book(s)";
            this.addBooksButton.UseVisualStyleBackColor = true;
            this.addBooksButton.Click += new System.EventHandler(this.addBooksButton_Click);
            // 
            // bookNamesBox
            // 
            this.bookNamesBox.Location = new System.Drawing.Point(291, 120);
            this.bookNamesBox.Name = "bookNamesBox";
            this.bookNamesBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.bookNamesBox.Size = new System.Drawing.Size(201, 23);
            this.bookNamesBox.TabIndex = 24;
            // 
            // addBooksLabel
            // 
            this.addBooksLabel.AutoSize = true;
            this.addBooksLabel.Location = new System.Drawing.Point(291, 78);
            this.addBooksLabel.Name = "addBooksLabel";
            this.addBooksLabel.Size = new System.Drawing.Size(201, 30);
            this.addBooksLabel.TabIndex = 23;
            this.addBooksLabel.Text = "                 Book Name(s) \r\n(Make sure to split with a comma (,))";
            // 
            // addAuthorButton
            // 
            this.addAuthorButton.Location = new System.Drawing.Point(35, 208);
            this.addAuthorButton.Name = "addAuthorButton";
            this.addAuthorButton.Size = new System.Drawing.Size(75, 23);
            this.addAuthorButton.TabIndex = 26;
            this.addAuthorButton.Text = "Register";
            this.addAuthorButton.UseVisualStyleBackColor = true;
            this.addAuthorButton.Click += new System.EventHandler(this.addAuthorButton_Click);
            // 
            // disclaimerLabel
            // 
            this.disclaimerLabel.AutoSize = true;
            this.disclaimerLabel.Location = new System.Drawing.Point(305, 36);
            this.disclaimerLabel.Name = "disclaimerLabel";
            this.disclaimerLabel.Size = new System.Drawing.Size(178, 30);
            this.disclaimerLabel.TabIndex = 27;
            this.disclaimerLabel.Text = "Please input the author\'s names \r\n       to use the buttons below";
            // 
            // AuthorRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 286);
            this.Controls.Add(this.disclaimerLabel);
            this.Controls.Add(this.addAuthorButton);
            this.Controls.Add(this.addBooksButton);
            this.Controls.Add(this.bookNamesBox);
            this.Controls.Add(this.addBooksLabel);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.bioBox);
            this.Controls.Add(this.bioLabel);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "AuthorRegister";
            this.Text = "AuthorRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private TextBox firstNameBox;
        private TextBox lastNameBox;
        private Label bioLabel;
        private TextBox bioBox;
        private Label backLabel;
        private Button addBooksButton;
        private TextBox bookNamesBox;
        private Label addBooksLabel;
        private Button addAuthorButton;
        private Label disclaimerLabel;
    }
}