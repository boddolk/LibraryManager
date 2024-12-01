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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GiveOutButton
            // 
            this.GiveOutButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.GiveOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GiveOutButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GiveOutButton.ForeColor = System.Drawing.Color.Snow;
            this.GiveOutButton.Location = new System.Drawing.Point(550, 526);
            this.GiveOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.GiveOutButton.Name = "GiveOutButton";
            this.GiveOutButton.Size = new System.Drawing.Size(303, 56);
            this.GiveOutButton.TabIndex = 0;
            this.GiveOutButton.Text = "To issue";
            this.GiveOutButton.UseVisualStyleBackColor = false;
            this.GiveOutButton.Click += new System.EventHandler(this.GiveOutButton_Click);
            // 
            // BookComboBox
            // 
            this.BookComboBox.BackColor = System.Drawing.Color.Snow;
            this.BookComboBox.DropDownHeight = 190;
            this.BookComboBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookComboBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BookComboBox.FormattingEnabled = true;
            this.BookComboBox.IntegralHeight = false;
            this.BookComboBox.Location = new System.Drawing.Point(201, 103);
            this.BookComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.BookComboBox.Name = "BookComboBox";
            this.BookComboBox.Size = new System.Drawing.Size(680, 32);
            this.BookComboBox.TabIndex = 1;
            this.BookComboBox.SelectedIndexChanged += new System.EventHandler(this.BookComboBox_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.ForeColor = System.Drawing.Color.Snow;
            this.AddButton.Location = new System.Drawing.Point(202, 529);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(301, 53);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add Book";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.ForeColor = System.Drawing.Color.Snow;
            this.EditButton.Location = new System.Drawing.Point(201, 444);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(302, 56);
            this.EditButton.TabIndex = 3;
            this.EditButton.Text = "Edit Book";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(474, 713);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(200, 42);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete Book";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.SandyBrown;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.Snow;
            this.NameLabel.Location = new System.Drawing.Point(112, 125);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(68, 31);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Title:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.BackColor = System.Drawing.Color.SandyBrown;
            this.AuthorLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel.ForeColor = System.Drawing.Color.Snow;
            this.AuthorLabel.Location = new System.Drawing.Point(85, 178);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(97, 31);
            this.AuthorLabel.TabIndex = 6;
            this.AuthorLabel.Text = "Author:";
            // 
            // ArticleLabel
            // 
            this.ArticleLabel.AutoSize = true;
            this.ArticleLabel.BackColor = System.Drawing.Color.SandyBrown;
            this.ArticleLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArticleLabel.ForeColor = System.Drawing.Color.Snow;
            this.ArticleLabel.Location = new System.Drawing.Point(90, 80);
            this.ArticleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArticleLabel.Name = "ArticleLabel";
            this.ArticleLabel.Size = new System.Drawing.Size(92, 31);
            this.ArticleLabel.TabIndex = 7;
            this.ArticleLabel.Text = "Article:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(112, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Year:";
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnButton.ForeColor = System.Drawing.Color.Snow;
            this.returnButton.Location = new System.Drawing.Point(550, 444);
            this.returnButton.Margin = new System.Windows.Forms.Padding(4);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(303, 56);
            this.returnButton.TabIndex = 16;
            this.returnButton.Text = "Return book";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // currentArticleLabel
            // 
            this.currentArticleLabel.AutoSize = true;
            this.currentArticleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentArticleLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.currentArticleLabel.Location = new System.Drawing.Point(195, 176);
            this.currentArticleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentArticleLabel.Name = "currentArticleLabel";
            this.currentArticleLabel.Size = new System.Drawing.Size(130, 28);
            this.currentArticleLabel.TabIndex = 17;
            this.currentArticleLabel.Text = "Empty article";
            // 
            // currentTitleLabel
            // 
            this.currentTitleLabel.AutoSize = true;
            this.currentTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentTitleLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.currentTitleLabel.Location = new System.Drawing.Point(195, 223);
            this.currentTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentTitleLabel.Name = "currentTitleLabel";
            this.currentTitleLabel.Size = new System.Drawing.Size(110, 28);
            this.currentTitleLabel.TabIndex = 18;
            this.currentTitleLabel.Text = "Empty title";
            // 
            // currentAuthorLabel
            // 
            this.currentAuthorLabel.AutoSize = true;
            this.currentAuthorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentAuthorLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.currentAuthorLabel.Location = new System.Drawing.Point(195, 277);
            this.currentAuthorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentAuthorLabel.Name = "currentAuthorLabel";
            this.currentAuthorLabel.Size = new System.Drawing.Size(135, 28);
            this.currentAuthorLabel.TabIndex = 19;
            this.currentAuthorLabel.Text = "Empty author";
            // 
            // currentYearLabel
            // 
            this.currentYearLabel.AutoSize = true;
            this.currentYearLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentYearLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.currentYearLabel.Location = new System.Drawing.Point(196, 331);
            this.currentYearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentYearLabel.Name = "currentYearLabel";
            this.currentYearLabel.Size = new System.Drawing.Size(113, 28);
            this.currentYearLabel.TabIndex = 20;
            this.currentYearLabel.Text = "Empty year";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.AutoSize = true;
            this.currentStatusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentStatusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentStatusLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.currentStatusLabel.Location = new System.Drawing.Point(196, 381);
            this.currentStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(129, 28);
            this.currentStatusLabel.TabIndex = 21;
            this.currentStatusLabel.Text = "Empty status";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.ForeColor = System.Drawing.Color.Snow;
            this.StatusLabel.Location = new System.Drawing.Point(100, 283);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(86, 31);
            this.StatusLabel.TabIndex = 8;
            this.StatusLabel.Text = "Status:";
            // 
            // bookInfoLable
            // 
            this.bookInfoLable.AutoSize = true;
            this.bookInfoLable.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bookInfoLable.ForeColor = System.Drawing.Color.Snow;
            this.bookInfoLable.Location = new System.Drawing.Point(32, 29);
            this.bookInfoLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bookInfoLable.Name = "bookInfoLable";
            this.bookInfoLable.Size = new System.Drawing.Size(126, 31);
            this.bookInfoLable.TabIndex = 22;
            this.bookInfoLable.Text = "Book info:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 96);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.ArticleLabel);
            this.panel2.Controls.Add(this.NameLabel);
            this.panel2.Controls.Add(this.AuthorLabel);
            this.panel2.Controls.Add(this.bookInfoLable);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.StatusLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 499);
            this.panel2.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::libraryMeneger.Properties.Resources.free_opened_book_icon_3163_thumb;
            this.pictureBox1.Location = new System.Drawing.Point(21, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(894, 595);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.currentStatusLabel);
            this.Controls.Add(this.currentYearLabel);
            this.Controls.Add(this.currentAuthorLabel);
            this.Controls.Add(this.currentTitleLabel);
            this.Controls.Add(this.currentArticleLabel);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.BookComboBox);
            this.Controls.Add(this.GiveOutButton);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}