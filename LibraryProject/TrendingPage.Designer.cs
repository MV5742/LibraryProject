namespace LibraryProject.Presentation
{
    partial class TrendingPage
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
            this.Title = new System.Windows.Forms.Label();
            this.TrendingListBox = new System.Windows.Forms.ListBox();
            this.ViewButton = new System.Windows.Forms.Button();
            this.BackLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(47, 25);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(406, 61);
            this.Title.TabIndex = 3;
            this.Title.Text = "Bookish cataloge";
            // 
            // TrendingListBox
            // 
            this.TrendingListBox.FormattingEnabled = true;
            this.TrendingListBox.ItemHeight = 15;
            this.TrendingListBox.Location = new System.Drawing.Point(57, 113);
            this.TrendingListBox.Name = "TrendingListBox";
            this.TrendingListBox.Size = new System.Drawing.Size(373, 169);
            this.TrendingListBox.TabIndex = 4;
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(168, 298);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(131, 36);
            this.ViewButton.TabIndex = 11;
            this.ViewButton.Text = "View Selected";
            this.ViewButton.UseVisualStyleBackColor = true;
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Location = new System.Drawing.Point(12, 357);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(106, 15);
            this.BackLabel.TabIndex = 13;
            this.BackLabel.Text = "Back To Main Page";
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click);
            // 
            // TrendingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 390);
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.TrendingListBox);
            this.Controls.Add(this.Title);
            this.Name = "TrendingPage";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private ListBox TrendingListBox;
        private Button ViewButton;
        private Label BackLabel;
    }
}