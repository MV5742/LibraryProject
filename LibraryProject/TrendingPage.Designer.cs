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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 19.69811F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(282, 18);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(239, 33);
            this.Title.TabIndex = 3;
            this.Title.Text = "Bookish catalogue";
            // 
            // TrendingListBox
            // 
            this.TrendingListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TrendingListBox.Font = new System.Drawing.Font("Segoe UI Semilight", 8.830189F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TrendingListBox.FormattingEnabled = true;
            this.TrendingListBox.ItemHeight = 17;
            this.TrendingListBox.Location = new System.Drawing.Point(66, 122);
            this.TrendingListBox.Name = "TrendingListBox";
            this.TrendingListBox.Size = new System.Drawing.Size(373, 191);
            this.TrendingListBox.TabIndex = 4;
            // 
            // ViewButton
            // 
            this.ViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ViewButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.830189F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewButton.Location = new System.Drawing.Point(113, 340);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(280, 41);
            this.ViewButton.TabIndex = 11;
            this.ViewButton.Text = "VIEW SELECTED";
            this.ViewButton.UseVisualStyleBackColor = false;
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Font = new System.Drawing.Font("Segoe UI", 8.830189F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.BackLabel.Location = new System.Drawing.Point(10, 411);
            this.BackLabel.Name = "BackLabel";
            this.BackLabel.Size = new System.Drawing.Size(115, 17);
            this.BackLabel.TabIndex = 13;
            this.BackLabel.Text = "Back To Main Page";
            this.BackLabel.Click += new System.EventHandler(this.BackLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.69811F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "TRENDING BOOKS";
            // 
            // TrendingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(533, 442);
            this.Controls.Add(this.label1);
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
        private Label label1;
    }
}