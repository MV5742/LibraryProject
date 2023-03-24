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
            this.SuspendLayout();
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(118, 43);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.AddressBox.Size = new System.Drawing.Size(100, 23);
            this.AddressBox.TabIndex = 15;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(12, 43);
            this.NameBox.Name = "NameBox";
            this.NameBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.NameBox.Size = new System.Drawing.Size(100, 23);
            this.NameBox.TabIndex = 14;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(118, 25);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(49, 15);
            this.AddressLabel.TabIndex = 11;
            this.AddressLabel.Text = "Address";
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.Location = new System.Drawing.Point(12, 25);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(39, 15);
            this.TitleLable.TabIndex = 10;
            this.TitleLable.Text = "Name";
            // 
            // DisclaimerLabel
            // 
            this.DisclaimerLabel.AutoSize = true;
            this.DisclaimerLabel.Location = new System.Drawing.Point(353, 24);
            this.DisclaimerLabel.Name = "DisclaimerLabel";
            this.DisclaimerLabel.Size = new System.Drawing.Size(187, 30);
            this.DisclaimerLabel.TabIndex = 31;
            this.DisclaimerLabel.Text = "Please input the publisher\'s name \r\n       to use the buttons below";
            // 
            // AddBooksButton
            // 
            this.AddBooksButton.Location = new System.Drawing.Point(390, 138);
            this.AddBooksButton.Name = "AddBooksButton";
            this.AddBooksButton.Size = new System.Drawing.Size(91, 23);
            this.AddBooksButton.TabIndex = 30;
            this.AddBooksButton.Text = "Add Book(s)";
            this.AddBooksButton.UseVisualStyleBackColor = true;
            this.AddBooksButton.Click += new System.EventHandler(this.AddBooksButton_Click);
            // 
            // BookNamesBox
            // 
            this.BookNamesBox.Location = new System.Drawing.Point(339, 109);
            this.BookNamesBox.Name = "BookNamesBox";
            this.BookNamesBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.BookNamesBox.Size = new System.Drawing.Size(201, 23);
            this.BookNamesBox.TabIndex = 29;
            // 
            // AddBooksLabel
            // 
            this.AddBooksLabel.AutoSize = true;
            this.AddBooksLabel.Location = new System.Drawing.Point(339, 65);
            this.AddBooksLabel.Name = "AddBooksLabel";
            this.AddBooksLabel.Size = new System.Drawing.Size(201, 30);
            this.AddBooksLabel.TabIndex = 28;
            this.AddBooksLabel.Text = "                 Book Name(s) \r\n(Make sure to split with a comma (,))";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(81, 81);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 32;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Location = new System.Drawing.Point(30, 160);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(170, 15);
            this.BackLabel.TabIndex = 33;
            this.BackLabel.Text = "Back to Main Contributor Page";
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click);
            // 
            // CityNameBox
            // 
            this.CityNameBox.Location = new System.Drawing.Point(224, 41);
            this.CityNameBox.Name = "CityNameBox";
            this.CityNameBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.CityNameBox.Size = new System.Drawing.Size(100, 23);
            this.CityNameBox.TabIndex = 35;
            // 
            // CityNameLabel
            // 
            this.CityNameLabel.AutoSize = true;
            this.CityNameLabel.Location = new System.Drawing.Point(224, 23);
            this.CityNameLabel.Name = "CityNameLabel";
            this.CityNameLabel.Size = new System.Drawing.Size(63, 15);
            this.CityNameLabel.TabIndex = 34;
            this.CityNameLabel.Text = "City Name";
            // 
            // PublisherRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 193);
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
    }
}