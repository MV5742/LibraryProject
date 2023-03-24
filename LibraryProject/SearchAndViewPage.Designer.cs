namespace LibraryProject.Presentation
{
    partial class SearchAndViewPage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AddToWishlistButton = new System.Windows.Forms.Button();
            this.SummaryLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AuthorButton = new System.Windows.Forms.Button();
            this.PublisherButton = new System.Windows.Forms.Button();
            this.BookShopButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BackLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(69, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(123, 320);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(66, 31);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Title";
            // 
            // AddToWishlistButton
            // 
            this.AddToWishlistButton.Location = new System.Drawing.Point(60, 354);
            this.AddToWishlistButton.Name = "AddToWishlistButton";
            this.AddToWishlistButton.Size = new System.Drawing.Size(203, 36);
            this.AddToWishlistButton.TabIndex = 3;
            this.AddToWishlistButton.Text = "ADD TO WISHLIST";
            this.AddToWishlistButton.UseVisualStyleBackColor = true;
            // 
            // SummaryLabel
            // 
            this.SummaryLabel.AutoSize = true;
            this.SummaryLabel.Location = new System.Drawing.Point(290, 96);
            this.SummaryLabel.Name = "SummaryLabel";
            this.SummaryLabel.Size = new System.Drawing.Size(65, 15);
            this.SummaryLabel.TabIndex = 5;
            this.SummaryLabel.Text = "SUMMARY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "AUTHOR/PUB/SB";
            // 
            // AuthorButton
            // 
            this.AuthorButton.Location = new System.Drawing.Point(290, 354);
            this.AuthorButton.Name = "AuthorButton";
            this.AuthorButton.Size = new System.Drawing.Size(131, 36);
            this.AuthorButton.TabIndex = 7;
            this.AuthorButton.Text = "AUTHOR";
            this.AuthorButton.UseVisualStyleBackColor = true;
            this.AuthorButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // PublisherButton
            // 
            this.PublisherButton.Location = new System.Drawing.Point(427, 354);
            this.PublisherButton.Name = "PublisherButton";
            this.PublisherButton.Size = new System.Drawing.Size(131, 36);
            this.PublisherButton.TabIndex = 8;
            this.PublisherButton.Text = "PUBLISHER";
            this.PublisherButton.UseVisualStyleBackColor = true;
            // 
            // BookShopButton
            // 
            this.BookShopButton.Location = new System.Drawing.Point(564, 354);
            this.BookShopButton.Name = "BookShopButton";
            this.BookShopButton.Size = new System.Drawing.Size(131, 36);
            this.BookShopButton.TabIndex = 9;
            this.BookShopButton.Text = "BOOK SHOP";
            this.BookShopButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(379, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 41);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bookish cataloge";
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Location = new System.Drawing.Point(12, 415);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(106, 15);
            this.BackLabel.TabIndex = 12;
            this.BackLabel.Text = "Back To Main Page";
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click);
            // 
            // SearchAndViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BookShopButton);
            this.Controls.Add(this.PublisherButton);
            this.Controls.Add(this.AuthorButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SummaryLabel);
            this.Controls.Add(this.AddToWishlistButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SearchAndViewPage";
            this.Text = "BookView";
            this.Load += new System.EventHandler(this.BookView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label TitleLabel;
        private Button AddToWishlistButton;
        private Label SummaryLabel;
        private Label label2;
        private Button AuthorButton;
        private Button PublisherButton;
        private Button BookShopButton;
        private Label label3;
        private Label BackLabel;
    }
}