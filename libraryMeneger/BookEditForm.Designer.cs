namespace libraryMeneger
{
    partial class BookEditForm
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
            this.YearNumer = new System.Windows.Forms.NumericUpDown();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.ArticleLabel = new System.Windows.Forms.Label();
            this.currentArticle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumer)).BeginInit();
            this.SuspendLayout();
            // 
            // YearNumer
            // 
            this.YearNumer.Location = new System.Drawing.Point(105, 110);
            this.YearNumer.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.YearNumer.Name = "YearNumer";
            this.YearNumer.Size = new System.Drawing.Size(322, 22);
            this.YearNumer.TabIndex = 24;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(105, 47);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(322, 22);
            this.NameTextBox.TabIndex = 22;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(105, 78);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(322, 22);
            this.AuthorTextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Year:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(12, 82);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(48, 16);
            this.AuthorLabel.TabIndex = 17;
            this.AuthorLabel.Text = "Author:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 50);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(36, 16);
            this.NameLabel.TabIndex = 16;
            this.NameLabel.Text = "Title:";
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(16, 152);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(411, 40);
            this.EditButton.TabIndex = 26;
            this.EditButton.Text = "Edit Book";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ArticleLabel
            // 
            this.ArticleLabel.AutoSize = true;
            this.ArticleLabel.Location = new System.Drawing.Point(12, 20);
            this.ArticleLabel.Name = "ArticleLabel";
            this.ArticleLabel.Size = new System.Drawing.Size(47, 16);
            this.ArticleLabel.TabIndex = 18;
            this.ArticleLabel.Text = "Article:";
            // 
            // currentArticle
            // 
            this.currentArticle.AutoSize = true;
            this.currentArticle.Location = new System.Drawing.Point(102, 20);
            this.currentArticle.Name = "currentArticle";
            this.currentArticle.Size = new System.Drawing.Size(43, 16);
            this.currentArticle.TabIndex = 27;
            this.currentArticle.Text = "noInfo";
            // 
            // BookEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 211);
            this.Controls.Add(this.currentArticle);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.YearNumer);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArticleLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "BookEditForm";
            this.Text = "BookEditForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookEditForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.YearNumer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown YearNumer;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label ArticleLabel;
        private System.Windows.Forms.Label currentArticle;
    }
}