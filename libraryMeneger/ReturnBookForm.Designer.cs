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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.returnMenuButton = new System.Windows.Forms.Button();
            this.currentDateLabel = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.filtParemetrLabel = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.reserveComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Start date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "End date:";
            // 
            // returnMenuButton
            // 
            this.returnMenuButton.Location = new System.Drawing.Point(472, 168);
            this.returnMenuButton.Name = "returnMenuButton";
            this.returnMenuButton.Size = new System.Drawing.Size(111, 36);
            this.returnMenuButton.TabIndex = 15;
            this.returnMenuButton.Text = "Return";
            this.returnMenuButton.UseVisualStyleBackColor = true;
            // 
            // currentDateLabel
            // 
            this.currentDateLabel.AutoSize = true;
            this.currentDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentDateLabel.Location = new System.Drawing.Point(98, 136);
            this.currentDateLabel.Name = "currentDateLabel";
            this.currentDateLabel.Size = new System.Drawing.Size(113, 24);
            this.currentDateLabel.TabIndex = 13;
            this.currentDateLabel.Text = "Current date";
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(472, 72);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(111, 34);
            this.filterButton.TabIndex = 12;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            // 
            // filtParemetrLabel
            // 
            this.filtParemetrLabel.AutoSize = true;
            this.filtParemetrLabel.Location = new System.Drawing.Point(27, 81);
            this.filtParemetrLabel.Name = "filtParemetrLabel";
            this.filtParemetrLabel.Size = new System.Drawing.Size(48, 16);
            this.filtParemetrLabel.TabIndex = 11;
            this.filtParemetrLabel.Text = "Author:";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(81, 78);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(333, 22);
            this.filterTextBox.TabIndex = 10;
            // 
            // reserveComboBox
            // 
            this.reserveComboBox.FormattingEnabled = true;
            this.reserveComboBox.Location = new System.Drawing.Point(30, 30);
            this.reserveComboBox.Name = "reserveComboBox";
            this.reserveComboBox.Size = new System.Drawing.Size(553, 24);
            this.reserveComboBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(98, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Current date";
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 238);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnMenuButton);
            this.Controls.Add(this.currentDateLabel);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.filtParemetrLabel);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.reserveComboBox);
            this.Name = "ReturnBookForm";
            this.Text = "ReturnBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnMenuButton;
        private System.Windows.Forms.Label currentDateLabel;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label filtParemetrLabel;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.ComboBox reserveComboBox;
        private System.Windows.Forms.Label label3;
    }
}