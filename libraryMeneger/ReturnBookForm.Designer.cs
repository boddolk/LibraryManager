namespace libraryMeneger
{
    partial class ReturnBookForm
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
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.returnMenuButton = new System.Windows.Forms.Button();
            this.cStartDatelabel = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.filtParemetrLabel = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.issuedComboBox = new System.Windows.Forms.ComboBox();
            this.cEndDatelabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.userEmailLabel = new System.Windows.Forms.Label();
            this.currEmailLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startLabel.ForeColor = System.Drawing.Color.Snow;
            this.startLabel.Location = new System.Drawing.Point(45, 305);
            this.startLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(119, 31);
            this.startLabel.TabIndex = 17;
            this.startLabel.Text = "Start date";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endLabel.ForeColor = System.Drawing.Color.Snow;
            this.endLabel.Location = new System.Drawing.Point(57, 378);
            this.endLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(107, 31);
            this.endLabel.TabIndex = 16;
            this.endLabel.Text = "End date";
            // 
            // returnMenuButton
            // 
            this.returnMenuButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.returnMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnMenuButton.ForeColor = System.Drawing.Color.Snow;
            this.returnMenuButton.Location = new System.Drawing.Point(491, 429);
            this.returnMenuButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.returnMenuButton.Name = "returnMenuButton";
            this.returnMenuButton.Size = new System.Drawing.Size(226, 50);
            this.returnMenuButton.TabIndex = 15;
            this.returnMenuButton.Text = "Return";
            this.returnMenuButton.UseVisualStyleBackColor = false;
            this.returnMenuButton.Click += new System.EventHandler(this.returnMenuButton_Click);
            // 
            // cStartDatelabel
            // 
            this.cStartDatelabel.AutoSize = true;
            this.cStartDatelabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cStartDatelabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cStartDatelabel.Location = new System.Drawing.Point(168, 305);
            this.cStartDatelabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cStartDatelabel.Name = "cStartDatelabel";
            this.cStartDatelabel.Size = new System.Drawing.Size(210, 31);
            this.cStartDatelabel.TabIndex = 13;
            this.cStartDatelabel.Text = "Start date is empty";
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.ForeColor = System.Drawing.Color.Snow;
            this.filterButton.Location = new System.Drawing.Point(740, 176);
            this.filterButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(226, 43);
            this.filterButton.TabIndex = 12;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // filtParemetrLabel
            // 
            this.filtParemetrLabel.AutoSize = true;
            this.filtParemetrLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filtParemetrLabel.ForeColor = System.Drawing.Color.Snow;
            this.filtParemetrLabel.Location = new System.Drawing.Point(35, 188);
            this.filtParemetrLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.filtParemetrLabel.Name = "filtParemetrLabel";
            this.filtParemetrLabel.Size = new System.Drawing.Size(124, 31);
            this.filtParemetrLabel.TabIndex = 11;
            this.filtParemetrLabel.Text = "User login";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterTextBox.Location = new System.Drawing.Point(174, 181);
            this.filterTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(543, 34);
            this.filterTextBox.TabIndex = 10;
            // 
            // issuedComboBox
            // 
            this.issuedComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.issuedComboBox.FormattingEnabled = true;
            this.issuedComboBox.Location = new System.Drawing.Point(174, 107);
            this.issuedComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.issuedComboBox.Name = "issuedComboBox";
            this.issuedComboBox.Size = new System.Drawing.Size(792, 36);
            this.issuedComboBox.TabIndex = 9;
            this.issuedComboBox.SelectedIndexChanged += new System.EventHandler(this.issuedComboBox_SelectedIndexChanged);
            // 
            // cEndDatelabel
            // 
            this.cEndDatelabel.AutoSize = true;
            this.cEndDatelabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cEndDatelabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cEndDatelabel.Location = new System.Drawing.Point(168, 378);
            this.cEndDatelabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.cEndDatelabel.Name = "cEndDatelabel";
            this.cEndDatelabel.Size = new System.Drawing.Size(199, 31);
            this.cEndDatelabel.TabIndex = 18;
            this.cEndDatelabel.Text = "End date is empty";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.Snow;
            this.exitButton.Location = new System.Drawing.Point(740, 429);
            this.exitButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(226, 50);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // userEmailLabel
            // 
            this.userEmailLabel.AutoSize = true;
            this.userEmailLabel.ForeColor = System.Drawing.Color.Black;
            this.userEmailLabel.Location = new System.Drawing.Point(485, 305);
            this.userEmailLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.userEmailLabel.Name = "userEmailLabel";
            this.userEmailLabel.Size = new System.Drawing.Size(129, 31);
            this.userEmailLabel.TabIndex = 21;
            this.userEmailLabel.Text = "User email:";
            // 
            // currEmailLabel
            // 
            this.currEmailLabel.AutoSize = true;
            this.currEmailLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currEmailLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.currEmailLabel.Location = new System.Drawing.Point(734, 305);
            this.currEmailLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.currEmailLabel.Name = "currEmailLabel";
            this.currEmailLabel.Size = new System.Drawing.Size(204, 31);
            this.currEmailLabel.TabIndex = 20;
            this.currEmailLabel.Text = "Current user email";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.filtParemetrLabel);
            this.panel2.Controls.Add(this.startLabel);
            this.panel2.Controls.Add(this.endLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 510);
            this.panel2.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(164, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 95);
            this.panel1.TabIndex = 25;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::libraryMeneger.Properties.Resources.book;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(993, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userEmailLabel);
            this.Controls.Add(this.currEmailLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cEndDatelabel);
            this.Controls.Add(this.returnMenuButton);
            this.Controls.Add(this.cStartDatelabel);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.issuedComboBox);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "ReturnBookForm";
            this.Text = "ReturnBookForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Button returnMenuButton;
        private System.Windows.Forms.Label cStartDatelabel;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label filtParemetrLabel;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.ComboBox issuedComboBox;
        private System.Windows.Forms.Label cEndDatelabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label userEmailLabel;
        private System.Windows.Forms.Label currEmailLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}