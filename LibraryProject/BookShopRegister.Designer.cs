namespace LibraryProject.Presentation
{
    partial class BookShopRegister
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.CityNameBox = new System.Windows.Forms.TextBox();
            this.CityNameLabel = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.BackLabel = new System.Windows.Forms.Label();
            this.DisclaimerLabel = new System.Windows.Forms.Label();
            this.AddBooksButton = new System.Windows.Forms.Button();
            this.BookNamesBox = new System.Windows.Forms.TextBox();
            this.AddBooksLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(19, 33);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(19, 77);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(49, 15);
            this.AddressLabel.TabIndex = 1;
            this.AddressLabel.Text = "Address";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(19, 51);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 23);
            this.NameBox.TabIndex = 2;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(19, 95);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(100, 23);
            this.AddressBox.TabIndex = 3;
            // 
            // CityNameBox
            // 
            this.CityNameBox.Location = new System.Drawing.Point(19, 142);
            this.CityNameBox.Name = "CityNameBox";
            this.CityNameBox.Size = new System.Drawing.Size(100, 23);
            this.CityNameBox.TabIndex = 5;
            // 
            // CityNameLabel
            // 
            this.CityNameLabel.AutoSize = true;
            this.CityNameLabel.Location = new System.Drawing.Point(19, 124);
            this.CityNameLabel.Name = "CityNameLabel";
            this.CityNameLabel.Size = new System.Drawing.Size(63, 15);
            this.CityNameLabel.TabIndex = 4;
            this.CityNameLabel.Text = "City Name";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(19, 182);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 6;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Location = new System.Drawing.Point(12, 227);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(170, 15);
            this.BackLabel.TabIndex = 39;
            this.BackLabel.Text = "Back to Main Contributor Page";
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click);
            // 
            // DisclaimerLabel
            // 
            this.DisclaimerLabel.AutoSize = true;
            this.DisclaimerLabel.Location = new System.Drawing.Point(142, 51);
            this.DisclaimerLabel.Name = "DisclaimerLabel";
            this.DisclaimerLabel.Size = new System.Drawing.Size(194, 30);
            this.DisclaimerLabel.TabIndex = 43;
            this.DisclaimerLabel.Text = "Please input the book shop\'s name \r\n       to use the buttons below";
            // 
            // AddBooksButton
            // 
            this.AddBooksButton.Location = new System.Drawing.Point(193, 159);
            this.AddBooksButton.Name = "AddBooksButton";
            this.AddBooksButton.Size = new System.Drawing.Size(91, 23);
            this.AddBooksButton.TabIndex = 42;
            this.AddBooksButton.Text = "Add Book(s)";
            this.AddBooksButton.UseVisualStyleBackColor = true;
            this.AddBooksButton.Click += new System.EventHandler(this.AddBooksButton_Click);
            // 
            // BookNamesBox
            // 
            this.BookNamesBox.Location = new System.Drawing.Point(142, 130);
            this.BookNamesBox.Name = "BookNamesBox";
            this.BookNamesBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.BookNamesBox.Size = new System.Drawing.Size(201, 23);
            this.BookNamesBox.TabIndex = 41;
            // 
            // AddBooksLabel
            // 
            this.AddBooksLabel.AutoSize = true;
            this.AddBooksLabel.Location = new System.Drawing.Point(142, 88);
            this.AddBooksLabel.Name = "AddBooksLabel";
            this.AddBooksLabel.Size = new System.Drawing.Size(201, 30);
            this.AddBooksLabel.TabIndex = 40;
            this.AddBooksLabel.Text = "                 Book Name(s) \r\n(Make sure to split with a comma (,))";
            // 
            // BookShopRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 270);
            this.Controls.Add(this.DisclaimerLabel);
            this.Controls.Add(this.AddBooksButton);
            this.Controls.Add(this.BookNamesBox);
            this.Controls.Add(this.AddBooksLabel);
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.CityNameBox);
            this.Controls.Add(this.CityNameLabel);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "BookShopRegister";
            this.Text = "BookShopRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameLabel;
        private Label AddressLabel;
        private TextBox NameBox;
        private TextBox AddressBox;
        private TextBox CityNameBox;
        private Label CityNameLabel;
        private Button RegisterButton;
        private Label BackLabel;
        private Label DisclaimerLabel;
        private Button AddBooksButton;
        private TextBox BookNamesBox;
        private Label AddBooksLabel;
    }
}