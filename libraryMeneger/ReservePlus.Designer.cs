namespace libraryMeneger
{
    partial class ReservePlus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservePlus));
            this.BookComboBox = new System.Windows.Forms.ComboBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CurrentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CurrentDate = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BookComboBox
            // 
            this.BookComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BookComboBox.ForeColor = System.Drawing.Color.RoyalBlue;
            this.BookComboBox.FormattingEnabled = true;
            this.BookComboBox.Location = new System.Drawing.Point(27, 221);
            this.BookComboBox.Name = "BookComboBox";
            this.BookComboBox.Size = new System.Drawing.Size(748, 36);
            this.BookComboBox.TabIndex = 0;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitButton.ForeColor = System.Drawing.Color.Snow;
            this.SubmitButton.Location = new System.Drawing.Point(190, 504);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(374, 63);
            this.SubmitButton.TabIndex = 1;
            this.SubmitButton.Text = "Submmit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CurrentDateTimePicker
            // 
            this.CurrentDateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentDateTimePicker.Enabled = false;
            this.CurrentDateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CurrentDateTimePicker.Location = new System.Drawing.Point(488, 325);
            this.CurrentDateTimePicker.MinDate = new System.DateTime(2024, 11, 27, 0, 0, 0, 0);
            this.CurrentDateTimePicker.Name = "CurrentDateTimePicker";
            this.CurrentDateTimePicker.Size = new System.Drawing.Size(277, 30);
            this.CurrentDateTimePicker.TabIndex = 2;
            this.CurrentDateTimePicker.Value = new System.DateTime(2024, 11, 27, 0, 0, 0, 0);
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDateTimePicker.Enabled = false;
            this.EndDateTimePicker.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDateTimePicker.Location = new System.Drawing.Point(488, 425);
            this.EndDateTimePicker.MinDate = new System.DateTime(2024, 11, 27, 0, 0, 0, 0);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(277, 30);
            this.EndDateTimePicker.TabIndex = 3;
            this.EndDateTimePicker.Value = new System.DateTime(2024, 11, 27, 0, 0, 0, 0);
            // 
            // CurrentDate
            // 
            this.CurrentDate.AutoSize = true;
            this.CurrentDate.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentDate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.CurrentDate.Location = new System.Drawing.Point(21, 325);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(144, 31);
            this.CurrentDate.TabIndex = 4;
            this.CurrentDate.Text = "Current date";
            // 
            // EndDate
            // 
            this.EndDate.AutoSize = true;
            this.EndDate.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndDate.ForeColor = System.Drawing.Color.RoyalBlue;
            this.EndDate.Location = new System.Drawing.Point(21, 425);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(105, 31);
            this.EndDate.TabIndex = 5;
            this.EndDate.Text = "End date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 183);
            this.panel1.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(284, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ReservePlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(787, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.CurrentDate);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.CurrentDateTimePicker);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.BookComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReservePlus";
            this.Text = "ReservePlus";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox BookComboBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.DateTimePicker CurrentDateTimePicker;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.Label CurrentDate;
        private System.Windows.Forms.Label EndDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}