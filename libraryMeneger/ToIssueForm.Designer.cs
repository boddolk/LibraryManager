﻿namespace libraryMeneger
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reserveComboBox
            // 
            this.reserveComboBox.FormattingEnabled = true;
            this.reserveComboBox.Location = new System.Drawing.Point(38, 30);
            this.reserveComboBox.Name = "reserveComboBox";
            this.reserveComboBox.Size = new System.Drawing.Size(553, 24);
            this.reserveComboBox.TabIndex = 0;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(89, 78);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(333, 22);
            this.filterTextBox.TabIndex = 1;
            // 
            // filtParemetrLabel
            // 
            this.filtParemetrLabel.AutoSize = true;
            this.filtParemetrLabel.Location = new System.Drawing.Point(35, 81);
            this.filtParemetrLabel.Name = "filtParemetrLabel";
            this.filtParemetrLabel.Size = new System.Drawing.Size(48, 16);
            this.filtParemetrLabel.TabIndex = 2;
            this.filtParemetrLabel.Text = "Author:";
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(480, 72);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(111, 34);
            this.filterButton.TabIndex = 3;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentDateLabel.Location = new System.Drawing.Point(106, 136);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(113, 24);
            this.currentDateLabel.TabIndex = 4;
            this.currentDateLabel.Text = "Current date";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateTimePicker.Location = new System.Drawing.Point(110, 176);
            this.endDateTimePicker.MaxDate = new System.DateTime(2025, 12, 27, 0, 0, 0, 0);
            this.endDateTimePicker.MinDate = new System.DateTime(2024, 12, 27, 0, 0, 0, 0);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(132, 28);
            this.endDateTimePicker.TabIndex = 5;
            this.endDateTimePicker.Value = new System.DateTime(2024, 12, 27, 0, 0, 0, 0);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(480, 168);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(111, 36);
            this.confirmButton.TabIndex = 6;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "End date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Start date:";
            // 
            // ToIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 232);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.currentDateLabel);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.filtParemetrLabel);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.reserveComboBox);
            this.Name = "ToIssueForm";
            this.Text = "ToIssueForm";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}