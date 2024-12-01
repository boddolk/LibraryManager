namespace libraryMeneger
{
    partial class UserForm
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
            this.PersonalInfoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.MailLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.BookListBox = new System.Windows.Forms.ListBox();
            this.ReservedButton = new System.Windows.Forms.Button();
            this.EditProfilButton = new System.Windows.Forms.Button();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PersonalInfoLabel
            // 
            this.PersonalInfoLabel.AutoSize = true;
            this.PersonalInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonalInfoLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PersonalInfoLabel.Location = new System.Drawing.Point(88, 14);
            this.PersonalInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PersonalInfoLabel.Name = "PersonalInfoLabel";
            this.PersonalInfoLabel.Size = new System.Drawing.Size(132, 25);
            this.PersonalInfoLabel.TabIndex = 0;
            this.PersonalInfoLabel.Text = "Personal Info:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(18, 173);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(18, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(18, 260);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(18, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(18, 358);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mail:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.NameLabel.Location = new System.Drawing.Point(155, 220);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(65, 23);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "no info";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SurnameLabel.Location = new System.Drawing.Point(155, 260);
            this.SurnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(65, 23);
            this.SurnameLabel.TabIndex = 7;
            this.SurnameLabel.Text = "no info";
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.AutoSize = true;
            this.PhoneLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.PhoneLabel.Location = new System.Drawing.Point(155, 311);
            this.PhoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(65, 23);
            this.PhoneLabel.TabIndex = 8;
            this.PhoneLabel.Text = "no info";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.MailLabel.Location = new System.Drawing.Point(155, 358);
            this.MailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(65, 23);
            this.MailLabel.TabIndex = 9;
            this.MailLabel.Text = "no info";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.UsernameLabel.Location = new System.Drawing.Point(155, 173);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(65, 23);
            this.UsernameLabel.TabIndex = 10;
            this.UsernameLabel.Text = "no info";
            // 
            // BookListBox
            // 
            this.BookListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookListBox.FormattingEnabled = true;
            this.BookListBox.ItemHeight = 23;
            this.BookListBox.Location = new System.Drawing.Point(370, 108);
            this.BookListBox.Margin = new System.Windows.Forms.Padding(4);
            this.BookListBox.Name = "BookListBox";
            this.BookListBox.Size = new System.Drawing.Size(476, 257);
            this.BookListBox.TabIndex = 11;
            // 
            // ReservedButton
            // 
            this.ReservedButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.ReservedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReservedButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ReservedButton.Location = new System.Drawing.Point(370, 393);
            this.ReservedButton.Margin = new System.Windows.Forms.Padding(4);
            this.ReservedButton.Name = "ReservedButton";
            this.ReservedButton.Size = new System.Drawing.Size(476, 61);
            this.ReservedButton.TabIndex = 12;
            this.ReservedButton.Text = "Reserve a book";
            this.ReservedButton.UseVisualStyleBackColor = false;
            this.ReservedButton.Click += new System.EventHandler(this.ReservedButton_Click);
            // 
            // EditProfilButton
            // 
            this.EditProfilButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.EditProfilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditProfilButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.EditProfilButton.Location = new System.Drawing.Point(22, 434);
            this.EditProfilButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditProfilButton.Name = "EditProfilButton";
            this.EditProfilButton.Size = new System.Drawing.Size(260, 57);
            this.EditProfilButton.TabIndex = 13;
            this.EditProfilButton.Text = "Edit profile";
            this.EditProfilButton.UseVisualStyleBackColor = false;
            this.EditProfilButton.Click += new System.EventHandler(this.EditProfilButton_Click);
            // 
            // HistoryButton
            // 
            this.HistoryButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoryButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistoryButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HistoryButton.Location = new System.Drawing.Point(370, 489);
            this.HistoryButton.Margin = new System.Windows.Forms.Padding(4);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(476, 58);
            this.HistoryButton.TabIndex = 14;
            this.HistoryButton.Text = "View history";
            this.HistoryButton.UseVisualStyleBackColor = false;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 55);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.PersonalInfoLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.UsernameLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.EditProfilButton);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.MailLabel);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.NameLabel);
            this.panel2.Controls.Add(this.SurnameLabel);
            this.panel2.Controls.Add(this.PhoneLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 561);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::libraryMeneger.Properties.Resources._1144760;
            this.pictureBox1.Location = new System.Drawing.Point(93, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(524, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "My reserved books";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(894, 616);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HistoryButton);
            this.Controls.Add(this.ReservedButton);
            this.Controls.Add(this.BookListBox);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PersonalInfoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label PhoneLabel;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.ListBox BookListBox;
        private System.Windows.Forms.Button ReservedButton;
        private System.Windows.Forms.Button EditProfilButton;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
    }
}