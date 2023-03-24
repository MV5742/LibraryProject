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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(57, 113);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(373, 169);
            this.listBox1.TabIndex = 4;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(85, 310);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(131, 36);
            this.RemoveButton.TabIndex = 11;
            this.RemoveButton.Text = "REMOVE";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(265, 310);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 36);
            this.button5.TabIndex = 12;
            this.button5.Text = "HOME PAGE";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // BackLabel
            // 
            this.BackLabel.AutoSize = true;
            this.BackLabel.Location = new System.Drawing.Point(12, 441);
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
            this.ClientSize = new System.Drawing.Size(484, 474);
            this.Controls.Add(this.BackLabel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Title);
            this.Name = "TrendingPage";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private ListBox listBox1;
        private Button RemoveButton;
        private Button button5;
        private Label BackLabel;
    }
}