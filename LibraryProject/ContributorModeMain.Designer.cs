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
            this.authorButton = new System.Windows.Forms.Button();
            this.bookButton = new System.Windows.Forms.Button();
            this.publisherButton = new System.Windows.Forms.Button();
            this.bookShopButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Label();
            this.checkButton = new System.Windows.Forms.Button();
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
            // authorButton
            // 
            this.authorButton.Location = new System.Drawing.Point(49, 160);
            this.authorButton.Name = "authorButton";
            this.authorButton.Size = new System.Drawing.Size(107, 23);
            this.authorButton.TabIndex = 3;
            this.authorButton.Text = "Register Author";
            this.authorButton.UseVisualStyleBackColor = true;
            this.authorButton.Visible = false;
            this.authorButton.Click += new System.EventHandler(this.authorButton_Click);
            // 
            // bookButton
            // 
            this.bookButton.Location = new System.Drawing.Point(162, 160);
            this.bookButton.Name = "bookButton";
            this.bookButton.Size = new System.Drawing.Size(97, 23);
            this.bookButton.TabIndex = 4;
            this.bookButton.Text = "Register Book";
            this.bookButton.UseVisualStyleBackColor = true;
            this.bookButton.Visible = false;
            this.bookButton.Click += new System.EventHandler(this.bookButton_Click);
            // 
            // publisherButton
            // 
            this.publisherButton.Location = new System.Drawing.Point(37, 189);
            this.publisherButton.Name = "publisherButton";
            this.publisherButton.Size = new System.Drawing.Size(119, 23);
            this.publisherButton.TabIndex = 5;
            this.publisherButton.Text = "Register Publisher";
            this.publisherButton.UseVisualStyleBackColor = true;
            this.publisherButton.Visible = false;
            this.publisherButton.Click += new System.EventHandler(this.publisherButton_Click);
            // 
            // bookShopButton
            // 
            this.bookShopButton.Location = new System.Drawing.Point(162, 189);
            this.bookShopButton.Name = "bookShopButton";
            this.bookShopButton.Size = new System.Drawing.Size(130, 23);
            this.bookShopButton.TabIndex = 6;
            this.bookShopButton.Text = "Register Book Shop";
            this.bookShopButton.UseVisualStyleBackColor = true;
            this.bookShopButton.Visible = false;
            this.bookShopButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Location = new System.Drawing.Point(231, 242);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(111, 15);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back to Home Page";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(242, 118);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(75, 23);
            this.checkButton.TabIndex = 8;
            this.checkButton.Text = "Check";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // ContributorModeMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 275);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.bookShopButton);
            this.Controls.Add(this.publisherButton);
            this.Controls.Add(this.bookButton);
            this.Controls.Add(this.authorButton);
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
        private Button authorButton;
        private Button bookButton;
        private Button publisherButton;
        private Button bookShopButton;
        private Label backButton;
        private Button checkButton;
    }
}