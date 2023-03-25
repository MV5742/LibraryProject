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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AddToWishlistButton = new System.Windows.Forms.Button();
            this.BookSummaryLabel = new System.Windows.Forms.Label();
            this.AdditionalInfoLabel = new System.Windows.Forms.Label();
            this.AuthorButton = new System.Windows.Forms.Button();
            this.PublisherButton = new System.Windows.Forms.Button();
            this.BookShopButton = new System.Windows.Forms.Button();
            this.CatalogueLabel = new System.Windows.Forms.Label();
            this.BackLabel = new System.Windows.Forms.Label();
            this.BookInfoBox = new System.Windows.Forms.RichTextBox();
            this.BookInfoLabel = new System.Windows.Forms.Label();
            this.BookSummaryBox = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(82, 32);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(66, 31);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Title";
            // 
            // AddToWishlistButton
            // 
            this.AddToWishlistButton.Location = new System.Drawing.Point(29, 333);
            this.AddToWishlistButton.Name = "AddToWishlistButton";
            this.AddToWishlistButton.Size = new System.Drawing.Size(203, 36);
            this.AddToWishlistButton.TabIndex = 3;
            this.AddToWishlistButton.Text = "ADD TO WISHLIST";
            this.AddToWishlistButton.UseVisualStyleBackColor = true;
            // 
            // BookSummaryLabel
            // 
            this.BookSummaryLabel.AutoSize = true;
            this.BookSummaryLabel.Location = new System.Drawing.Point(29, 213);
            this.BookSummaryLabel.Name = "BookSummaryLabel";
            this.BookSummaryLabel.Size = new System.Drawing.Size(58, 15);
            this.BookSummaryLabel.TabIndex = 5;
            this.BookSummaryLabel.Text = "Summary";
            // 
            // AdditionalInfoLabel
            // 
            this.AdditionalInfoLabel.AutoSize = true;
            this.AdditionalInfoLabel.Location = new System.Drawing.Point(255, 72);
            this.AdditionalInfoLabel.Name = "AdditionalInfoLabel";
            this.AdditionalInfoLabel.Size = new System.Drawing.Size(184, 15);
            this.AdditionalInfoLabel.TabIndex = 6;
            this.AdditionalInfoLabel.Text = "Author/Publisher/Book Shop Info";
            // 
            // AuthorButton
            // 
            this.AuthorButton.Location = new System.Drawing.Point(470, 93);
            this.AuthorButton.Name = "AuthorButton";
            this.AuthorButton.Size = new System.Drawing.Size(131, 36);
            this.AuthorButton.TabIndex = 7;
            this.AuthorButton.Text = "AUTHOR";
            this.AuthorButton.UseVisualStyleBackColor = true;
            this.AuthorButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // PublisherButton
            // 
            this.PublisherButton.Location = new System.Drawing.Point(470, 135);
            this.PublisherButton.Name = "PublisherButton";
            this.PublisherButton.Size = new System.Drawing.Size(131, 36);
            this.PublisherButton.TabIndex = 8;
            this.PublisherButton.Text = "PUBLISHER";
            this.PublisherButton.UseVisualStyleBackColor = true;
            // 
            // BookShopButton
            // 
            this.BookShopButton.Location = new System.Drawing.Point(470, 177);
            this.BookShopButton.Name = "BookShopButton";
            this.BookShopButton.Size = new System.Drawing.Size(131, 36);
            this.BookShopButton.TabIndex = 9;
            this.BookShopButton.Text = "BOOK SHOP";
            this.BookShopButton.UseVisualStyleBackColor = true;
            // 
            // CatalogueLabel
            // 
            this.CatalogueLabel.AutoSize = true;
            this.CatalogueLabel.Font = new System.Drawing.Font("Times New Roman", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.CatalogueLabel.Location = new System.Drawing.Point(213, 9);
            this.CatalogueLabel.Name = "CatalogueLabel";
            this.CatalogueLabel.Size = new System.Drawing.Size(292, 41);
            this.CatalogueLabel.TabIndex = 11;
            this.CatalogueLabel.Text = "Bookish catalogue";
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Location = new System.Drawing.Point(525, 365);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(106, 15);
            this.BackLabel.TabIndex = 12;
            this.BackLabel.Text = "Back To Main Page";
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click);
            // 
            // BookInfoBox
            // 
            this.BookInfoBox.Enabled = false;
            this.BookInfoBox.Location = new System.Drawing.Point(29, 93);
            this.BookInfoBox.Name = "BookInfoBox";
            this.BookInfoBox.Size = new System.Drawing.Size(203, 117);
            this.BookInfoBox.TabIndex = 14;
            this.BookInfoBox.Text = "";
            // 
            // BookInfoLabel
            // 
            this.BookInfoLabel.AutoSize = true;
            this.BookInfoLabel.Location = new System.Drawing.Point(29, 72);
            this.BookInfoLabel.Name = "BookInfoLabel";
            this.BookInfoLabel.Size = new System.Drawing.Size(100, 15);
            this.BookInfoLabel.TabIndex = 15;
            this.BookInfoLabel.Text = "Book Information";
            // 
            // BookSummaryBox
            // 
            this.BookSummaryBox.Location = new System.Drawing.Point(29, 233);
            this.BookSummaryBox.Name = "BookSummaryBox";
            this.BookSummaryBox.Size = new System.Drawing.Size(203, 96);
            this.BookSummaryBox.TabIndex = 16;
            this.BookSummaryBox.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(255, 93);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(209, 236);
            this.richTextBox3.TabIndex = 17;
            this.richTextBox3.Text = "";
            // 
            // SearchAndViewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 405);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.BookSummaryBox);
            this.Controls.Add(this.BookInfoLabel);
            this.Controls.Add(this.BookInfoBox);
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.CatalogueLabel);
            this.Controls.Add(this.BookShopButton);
            this.Controls.Add(this.PublisherButton);
            this.Controls.Add(this.AuthorButton);
            this.Controls.Add(this.AdditionalInfoLabel);
            this.Controls.Add(this.BookSummaryLabel);
            this.Controls.Add(this.AddToWishlistButton);
            this.Controls.Add(this.TitleLabel);
            this.Name = "SearchAndViewPage";
            this.Text = "BookView";
            this.Load += new System.EventHandler(this.BookView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label TitleLabel;
        private Button AddToWishlistButton;
        private Label BookSummaryLabel;
        private Label AdditionalInfoLabel;
        private Button AuthorButton;
        private Button PublisherButton;
        private Button BookShopButton;
        private Label CatalogueLabel;
        private Label BackLabel;
        private RichTextBox BookInfoBox;
        private Label BookInfoLabel;
        private RichTextBox BookSummaryBox;
        private RichTextBox richTextBox3;
    }
}