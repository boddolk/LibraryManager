namespace libraryMeneger
{
    partial class ToIssueForm
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
            this.reserveComboBox = new System.Windows.Forms.ComboBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.filtParemetrLabel = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.confirmButton = new System.Windows.Forms.Button();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reserveComboBox
            // 
            this.reserveComboBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.reserveComboBox.FormattingEnabled = true;
            this.reserveComboBox.Location = new System.Drawing.Point(188, 110);
            this.reserveComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reserveComboBox.Name = "reserveComboBox";
            this.reserveComboBox.Size = new System.Drawing.Size(788, 36);
            this.reserveComboBox.TabIndex = 0;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.filterTextBox.Location = new System.Drawing.Point(188, 188);
            this.filterTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(231, 31);
            this.filterTextBox.TabIndex = 1;
            // 
            // filtParemetrLabel
            // 
            this.filtParemetrLabel.AutoSize = true;
            this.filtParemetrLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filtParemetrLabel.ForeColor = System.Drawing.Color.Snow;
            this.filtParemetrLabel.Location = new System.Drawing.Point(40, 101);
            this.filtParemetrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.filtParemetrLabel.Name = "filtParemetrLabel";
            this.filtParemetrLabel.Size = new System.Drawing.Size(124, 31);
            this.filtParemetrLabel.TabIndex = 2;
            this.filtParemetrLabel.Text = "User login";
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.ForeColor = System.Drawing.Color.Snow;
            this.filterButton.Location = new System.Drawing.Point(427, 179);
            this.filterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(175, 43);
            this.filterButton.TabIndex = 3;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = false;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDateLabel.ForeColor = System.Drawing.Color.Black;
            this.currentDateLabel.Location = new System.Drawing.Point(183, 290);
            this.currentDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(162, 28);
            this.currentDateLabel.TabIndex = 4;
            this.currentDateLabel.Text = "Empty start date";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(188, 351);
            this.endDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endDateTimePicker.MaxDate = new System.DateTime(2025, 12, 27, 0, 0, 0, 0);
            this.endDateTimePicker.MinDate = new System.DateTime(2024, 12, 27, 0, 0, 0, 0);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(231, 31);
            this.endDateTimePicker.TabIndex = 5;
            this.endDateTimePicker.Value = new System.DateTime(2024, 12, 27, 0, 0, 0, 0);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.ForeColor = System.Drawing.Color.Snow;
            this.confirmButton.Location = new System.Drawing.Point(597, 366);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(175, 49);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endLabel.ForeColor = System.Drawing.Color.Snow;
            this.endLabel.Location = new System.Drawing.Point(54, 259);
            this.endLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(107, 31);
            this.endLabel.TabIndex = 7;
            this.endLabel.Text = "End date";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startLabel.ForeColor = System.Drawing.Color.Snow;
            this.startLabel.Location = new System.Drawing.Point(45, 200);
            this.startLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(119, 31);
            this.startLabel.TabIndex = 8;
            this.startLabel.Text = "Start date";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.Snow;
            this.exitButton.Location = new System.Drawing.Point(800, 366);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(176, 49);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 90);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::libraryMeneger.Properties.Resources.book;
            this.pictureBox2.Location = new System.Drawing.Point(0, -7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(164, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.endLabel);
            this.panel2.Controls.Add(this.filtParemetrLabel);
            this.panel2.Controls.Add(this.startLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 356);
            this.panel2.TabIndex = 11;
            // 
            // ToIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(989, 446);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.currentDateLabel);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.reserveComboBox);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.RoyalBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ToIssueForm";
            this.Text = "ToIssueForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ToIssueForm_FormClosing);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox reserveComboBox;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.Label filtParemetrLabel;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label currentDateLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}