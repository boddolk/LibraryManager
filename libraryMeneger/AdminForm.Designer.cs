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
            this.StatusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ArticleTextBox = new System.Windows.Forms.TextBox();
            this.YearNumer = new System.Windows.Forms.NumericUpDown();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumer)).BeginInit();
            this.SuspendLayout();
            // 
            // GiveOutButton
            // 
            this.GiveOutButton.Location = new System.Drawing.Point(582, 352);
            this.GiveOutButton.Name = "GiveOutButton";
            this.GiveOutButton.Size = new System.Drawing.Size(206, 49);
            this.GiveOutButton.TabIndex = 0;
            this.GiveOutButton.Text = "To issue";
            this.GiveOutButton.UseVisualStyleBackColor = true;
            // 
            // BookComboBox
            // 
            this.BookComboBox.FormattingEnabled = true;
            this.BookComboBox.Location = new System.Drawing.Point(12, 29);
            this.BookComboBox.Name = "BookComboBox";
            this.BookComboBox.Size = new System.Drawing.Size(776, 24);
            this.BookComboBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 303);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(160, 40);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add Book";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(12, 349);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(160, 40);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit Book";
            this.EditButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 395);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(160, 40);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete Book";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 102);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(36, 16);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Title:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(12, 134);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(48, 16);
            this.AuthorLabel.TabIndex = 6;
            this.AuthorLabel.Text = "Author:";
            // 
            // ArticleLabel
            // 
            this.ArticleLabel.AutoSize = true;
            this.ArticleLabel.Location = new System.Drawing.Point(12, 72);
            this.ArticleLabel.Name = "ArticleLabel";
            this.ArticleLabel.Size = new System.Drawing.Size(47, 16);
            this.ArticleLabel.TabIndex = 7;
            this.ArticleLabel.Text = "Article:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(13, 196);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(47, 16);
            this.StatusLabel.TabIndex = 8;
            this.StatusLabel.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Year:";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(105, 130);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(683, 22);
            this.AuthorTextBox.TabIndex = 11;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(105, 99);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(683, 22);
            this.NameTextBox.TabIndex = 12;
            // 
            // ArticleTextBox
            // 
            this.ArticleTextBox.Location = new System.Drawing.Point(105, 68);
            this.ArticleTextBox.Name = "ArticleTextBox";
            this.ArticleTextBox.Size = new System.Drawing.Size(683, 22);
            this.ArticleTextBox.TabIndex = 13;
            // 
            // YearNumer
            // 
            this.YearNumer.Location = new System.Drawing.Point(105, 162);
            this.YearNumer.Name = "YearNumer";
            this.YearNumer.Size = new System.Drawing.Size(683, 22);
            this.YearNumer.TabIndex = 14;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(105, 193);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(683, 24);
            this.StatusComboBox.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "returned book";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.YearNumer);
            this.Controls.Add(this.ArticleTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AuthorTextBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.YearNumer)).EndInit();
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
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox ArticleTextBox;
        private System.Windows.Forms.NumericUpDown YearNumer;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Button button1;
    }
}