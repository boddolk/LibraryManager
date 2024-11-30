namespace libraryMeneger
{
    partial class AdminForm
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
            this.GiveOutButton = new System.Windows.Forms.Button();
            this.BookComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.ArticleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.returnButton = new System.Windows.Forms.Button();
            this.currentArticleLabel = new System.Windows.Forms.Label();
            this.currentTitleLabel = new System.Windows.Forms.Label();
            this.currentAuthorLabel = new System.Windows.Forms.Label();
            this.currentYearLabel = new System.Windows.Forms.Label();
            this.currentStatusLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.bookInfoLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GiveOutButton
            // 
            this.GiveOutButton.Location = new System.Drawing.Point(238, 323);
            this.GiveOutButton.Name = "GiveOutButton";
            this.GiveOutButton.Size = new System.Drawing.Size(128, 38);
            this.GiveOutButton.TabIndex = 0;
            this.GiveOutButton.Text = "To issue";
            this.GiveOutButton.UseVisualStyleBackColor = true;
            this.GiveOutButton.Click += new System.EventHandler(this.GiveOutButton_Click);
            // 
            // BookComboBox
            // 
            this.BookComboBox.FormattingEnabled = true;
            this.BookComboBox.Location = new System.Drawing.Point(19, 27);
            this.BookComboBox.Name = "BookComboBox";
            this.BookComboBox.Size = new System.Drawing.Size(481, 24);
            this.BookComboBox.TabIndex = 1;
            this.BookComboBox.SelectedIndexChanged += new System.EventHandler(this.BookComboBox_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(19, 270);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(160, 29);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add Book";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(19, 301);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(160, 29);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit Book";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(19, 332);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(160, 29);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete Book";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(33, 131);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(36, 16);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Title:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(33, 163);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(48, 16);
            this.AuthorLabel.TabIndex = 6;
            this.AuthorLabel.Text = "Author:";
            // 
            // ArticleLabel
            // 
            this.ArticleLabel.AutoSize = true;
            this.ArticleLabel.Location = new System.Drawing.Point(33, 101);
            this.ArticleLabel.Name = "ArticleLabel";
            this.ArticleLabel.Size = new System.Drawing.Size(47, 16);
            this.ArticleLabel.TabIndex = 7;
            this.ArticleLabel.Text = "Article:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Year:";
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(372, 323);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(128, 38);
            this.returnButton.TabIndex = 16;
            this.returnButton.Text = "Return book";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // currentArticleLabel
            // 
            this.currentArticleLabel.AutoSize = true;
            this.currentArticleLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.currentArticleLabel.Location = new System.Drawing.Point(104, 101);
            this.currentArticleLabel.Name = "currentArticleLabel";
            this.currentArticleLabel.Size = new System.Drawing.Size(84, 16);
            this.currentArticleLabel.TabIndex = 17;
            this.currentArticleLabel.Text = "Empty article";
            // 
            // currentTitleLabel
            // 
            this.currentTitleLabel.AutoSize = true;
            this.currentTitleLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.currentTitleLabel.Location = new System.Drawing.Point(104, 131);
            this.currentTitleLabel.Name = "currentTitleLabel";
            this.currentTitleLabel.Size = new System.Drawing.Size(68, 16);
            this.currentTitleLabel.TabIndex = 18;
            this.currentTitleLabel.Text = "Empty title";
            // 
            // currentAuthorLabel
            // 
            this.currentAuthorLabel.AutoSize = true;
            this.currentAuthorLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.currentAuthorLabel.Location = new System.Drawing.Point(104, 163);
            this.currentAuthorLabel.Name = "currentAuthorLabel";
            this.currentAuthorLabel.Size = new System.Drawing.Size(85, 16);
            this.currentAuthorLabel.TabIndex = 19;
            this.currentAuthorLabel.Text = "Empty author";
            // 
            // currentYearLabel
            // 
            this.currentYearLabel.AutoSize = true;
            this.currentYearLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.currentYearLabel.Location = new System.Drawing.Point(104, 193);
            this.currentYearLabel.Name = "currentYearLabel";
            this.currentYearLabel.Size = new System.Drawing.Size(75, 16);
            this.currentYearLabel.TabIndex = 20;
            this.currentYearLabel.Text = "Empty year";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.AutoSize = true;
            this.currentStatusLabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.currentStatusLabel.Location = new System.Drawing.Point(104, 225);
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(83, 16);
            this.currentStatusLabel.TabIndex = 21;
            this.currentStatusLabel.Text = "Empty status";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(34, 225);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(47, 16);
            this.StatusLabel.TabIndex = 8;
            this.StatusLabel.Text = "Status:";
            // 
            // bookInfoLable
            // 
            this.bookInfoLable.AutoSize = true;
            this.bookInfoLable.Location = new System.Drawing.Point(20, 69);
            this.bookInfoLable.Name = "bookInfoLable";
            this.bookInfoLable.Size = new System.Drawing.Size(66, 16);
            this.bookInfoLable.TabIndex = 22;
            this.bookInfoLable.Text = "Book info:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 384);
            this.Controls.Add(this.bookInfoLable);
            this.Controls.Add(this.currentStatusLabel);
            this.Controls.Add(this.currentYearLabel);
            this.Controls.Add(this.currentAuthorLabel);
            this.Controls.Add(this.currentTitleLabel);
            this.Controls.Add(this.currentArticleLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ArticleLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BookComboBox);
            this.Controls.Add(this.GiveOutButton);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GiveOutButton;
        private System.Windows.Forms.ComboBox BookComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label ArticleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label currentArticleLabel;
        private System.Windows.Forms.Label currentTitleLabel;
        private System.Windows.Forms.Label currentAuthorLabel;
        private System.Windows.Forms.Label currentYearLabel;
        private System.Windows.Forms.Label currentStatusLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label bookInfoLable;
    }
}