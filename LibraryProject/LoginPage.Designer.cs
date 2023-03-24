namespace LibraryProject.Presentation
{
    partial class LoginPage
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.backLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(51, 31);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(406, 61);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Bookish cataloge";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(160, 108);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 15);
            this.EmailLabel.TabIndex = 6;
            this.EmailLabel.Text = "EMAIL";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(160, 126);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(178, 23);
            this.EmailBox.TabIndex = 7;
            this.EmailBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(160, 177);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(178, 23);
            this.PasswordBox.TabIndex = 9;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(160, 159);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(68, 15);
            this.PasswordLabel.TabIndex = 8;
            this.PasswordLabel.Text = "PASSWORD";
            this.PasswordLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(114, 265);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(131, 36);
            this.LogInButton.TabIndex = 10;
            this.LogInButton.Text = "LOG IN";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(251, 265);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(131, 36);
            this.SignUpButton.TabIndex = 11;
            this.SignUpButton.Text = "SIGN UP";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(160, 230);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(178, 23);
            this.UsernameBox.TabIndex = 13;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(160, 212);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(68, 15);
            this.UsernameLabel.TabIndex = 12;
            this.UsernameLabel.Text = "USERNAME";
            // 
            // backLabel
            // 
            this.backLabel.AutoSize = true;
            this.backLabel.Location = new System.Drawing.Point(21, 322);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(106, 15);
            this.backLabel.TabIndex = 14;
            this.backLabel.Text = "Back To Main Page";
            this.backLabel.Click += new System.EventHandler(this.backLabel_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 358);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TitleLabel;
        private Label EmailLabel;
        private TextBox EmailBox;
        private TextBox PasswordBox;
        private Label PasswordLabel;
        private Button LogInButton;
        private Button SignUpButton;
        private TextBox UsernameBox;
        private Label UsernameLabel;
        private Label backLabel;
    }
}