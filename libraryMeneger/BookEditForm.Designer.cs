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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookEditForm));
            this.YearNumer = new System.Windows.Forms.NumericUpDown();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.ArticleLabel = new System.Windows.Forms.Label();
            this.currentArticle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.YearNumer)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // YearNumer
            // 
            this.YearNumer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.YearNumer.Location = new System.Drawing.Point(167, 393);
            this.YearNumer.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.YearNumer.Name = "YearNumer";
            this.YearNumer.Size = new System.Drawing.Size(302, 31);
            this.YearNumer.TabIndex = 24;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(167, 272);
            this.NameTextBox.MaxLength = 32;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(302, 34);
            this.NameTextBox.TabIndex = 22;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorTextBox.Location = new System.Drawing.Point(167, 333);
            this.AuthorTextBox.MaxLength = 25;
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(302, 34);
            this.AuthorTextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(25, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Year";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.AuthorLabel.Location = new System.Drawing.Point(21, 336);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(86, 31);
            this.AuthorLabel.TabIndex = 17;
            this.AuthorLabel.Text = "Author";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.NameLabel.Location = new System.Drawing.Point(25, 275);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(59, 31);
            this.NameLabel.TabIndex = 16;
            this.NameLabel.Text = "Title";
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditButton.ForeColor = System.Drawing.Color.Snow;
            this.EditButton.Location = new System.Drawing.Point(63, 492);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(388, 63);
            this.EditButton.TabIndex = 26;
            this.EditButton.Text = "Edit Book";
            this.EditButton.UseVisualStyleBackColor = false;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // ArticleLabel
            // 
            this.ArticleLabel.AutoSize = true;
            this.ArticleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArticleLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ArticleLabel.Location = new System.Drawing.Point(25, 222);
            this.ArticleLabel.Name = "ArticleLabel";
            this.ArticleLabel.Size = new System.Drawing.Size(82, 31);
            this.ArticleLabel.TabIndex = 18;
            this.ArticleLabel.Text = "Article";
            // 
            // currentArticle
            // 
            this.currentArticle.AutoSize = true;
            this.currentArticle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.currentArticle.Location = new System.Drawing.Point(162, 222);
            this.currentArticle.Name = "currentArticle";
            this.currentArticle.Size = new System.Drawing.Size(67, 25);
            this.currentArticle.TabIndex = 27;
            this.currentArticle.Text = "noInfo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 179);
            this.panel1.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BookEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(514, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.currentArticle);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.YearNumer);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArticleLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookEditForm";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookEditForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.YearNumer)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}