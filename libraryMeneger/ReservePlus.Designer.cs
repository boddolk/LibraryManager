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
            this.BookComboBox = new System.Windows.Forms.ComboBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CurrentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CurrentDate = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BookComboBox
            // 
            this.BookComboBox.FormattingEnabled = true;
            this.BookComboBox.Location = new System.Drawing.Point(12, 12);
            this.BookComboBox.Name = "BookComboBox";
            this.BookComboBox.Size = new System.Drawing.Size(467, 24);
            this.BookComboBox.TabIndex = 0;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(12, 220);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(467, 54);
            this.SubmitButton.TabIndex = 1;
            this.SubmitButton.Text = "Submmit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CurrentDateTimePicker
            // 
            this.CurrentDateTimePicker.Enabled = false;
            this.CurrentDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CurrentDateTimePicker.Location = new System.Drawing.Point(12, 106);
            this.CurrentDateTimePicker.MinDate = new System.DateTime(2024, 11, 27, 0, 0, 0, 0);
            this.CurrentDateTimePicker.Name = "CurrentDateTimePicker";
            this.CurrentDateTimePicker.Size = new System.Drawing.Size(467, 22);
            this.CurrentDateTimePicker.TabIndex = 2;
            this.CurrentDateTimePicker.Value = new System.DateTime(2024, 11, 27, 0, 0, 0, 0);
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Enabled = false;
            this.EndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDateTimePicker.Location = new System.Drawing.Point(12, 159);
            this.EndDateTimePicker.MinDate = new System.DateTime(2024, 11, 27, 0, 0, 0, 0);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(467, 22);
            this.EndDateTimePicker.TabIndex = 3;
            this.EndDateTimePicker.Value = new System.DateTime(2024, 11, 27, 0, 0, 0, 0);
            // 
            // CurrentDate
            // 
            this.CurrentDate.AutoSize = true;
            this.CurrentDate.Location = new System.Drawing.Point(13, 84);
            this.CurrentDate.Name = "CurrentDate";
            this.CurrentDate.Size = new System.Drawing.Size(84, 16);
            this.CurrentDate.TabIndex = 4;
            this.CurrentDate.Text = "Current Date:";
            // 
            // EndDate
            // 
            this.EndDate.AutoSize = true;
            this.EndDate.Location = new System.Drawing.Point(13, 140);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(66, 16);
            this.EndDate.TabIndex = 5;
            this.EndDate.Text = "End Date:";
            // 
            // ReservePlus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 286);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.CurrentDate);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.CurrentDateTimePicker);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.BookComboBox);
            this.Name = "ReservePlus";
            this.Text = "ReservePlus";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReservePlus_FormClosing);
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
    }
}