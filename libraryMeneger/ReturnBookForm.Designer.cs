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
            this.cStartDatelabel = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.filtParemetrLabel = new System.Windows.Forms.Label();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.issuedComboBox = new System.Windows.Forms.ComboBox();
            this.cEndDatelabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Start date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "End date:";
            // 
            // returnMenuButton
            // 
            this.returnMenuButton.Location = new System.Drawing.Point(365, 168);
            this.returnMenuButton.Name = "returnMenuButton";
            this.returnMenuButton.Size = new System.Drawing.Size(111, 36);
            this.returnMenuButton.TabIndex = 15;
            this.returnMenuButton.Text = "Return";
            this.returnMenuButton.UseVisualStyleBackColor = true;
            this.returnMenuButton.Click += new System.EventHandler(this.returnMenuButton_Click);
            // 
            // cStartDatelabel
            // 
            this.cStartDatelabel.AutoSize = true;
            this.cStartDatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cStartDatelabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cStartDatelabel.Location = new System.Drawing.Point(103, 136);
            this.cStartDatelabel.Name = "cStartDatelabel";
            this.cStartDatelabel.Size = new System.Drawing.Size(161, 24);
            this.cStartDatelabel.TabIndex = 13;
            this.cStartDatelabel.Text = "Start date is empty";
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(477, 72);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(111, 34);
            this.filterButton.TabIndex = 12;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            // 
            // filtParemetrLabel
            // 
            this.filtParemetrLabel.AutoSize = true;
            this.filtParemetrLabel.Location = new System.Drawing.Point(32, 81);
            this.filtParemetrLabel.Name = "filtParemetrLabel";
            this.filtParemetrLabel.Size = new System.Drawing.Size(48, 16);
            this.filtParemetrLabel.TabIndex = 11;
            this.filtParemetrLabel.Text = "Author:";
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(86, 78);
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(333, 22);
            this.filterTextBox.TabIndex = 10;
            // 
            // issuedComboBox
            // 
            this.issuedComboBox.FormattingEnabled = true;
            this.issuedComboBox.Location = new System.Drawing.Point(35, 30);
            this.issuedComboBox.Name = "issuedComboBox";
            this.issuedComboBox.Size = new System.Drawing.Size(553, 24);
            this.issuedComboBox.TabIndex = 9;
            this.issuedComboBox.SelectedIndexChanged += new System.EventHandler(this.issuedComboBox_SelectedIndexChanged);
            // 
            // cEndDatelabel
            // 
            this.cEndDatelabel.AutoSize = true;
            this.cEndDatelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cEndDatelabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cEndDatelabel.Location = new System.Drawing.Point(103, 179);
            this.cEndDatelabel.Name = "cEndDatelabel";
            this.cEndDatelabel.Size = new System.Drawing.Size(160, 24);
            this.cEndDatelabel.TabIndex = 18;
            this.cEndDatelabel.Text = "End date is empty";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(477, 168);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(111, 36);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 238);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cEndDatelabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnMenuButton);
            this.Controls.Add(this.cStartDatelabel);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.filtParemetrLabel);
            this.Controls.Add(this.filterTextBox);
            this.Controls.Add(this.issuedComboBox);
            this.Name = "ReturnBookForm";
            this.Text = "ReturnBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button returnMenuButton;
        private System.Windows.Forms.Label cStartDatelabel;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label filtParemetrLabel;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.ComboBox issuedComboBox;
        private System.Windows.Forms.Label cEndDatelabel;
        private System.Windows.Forms.Button exitButton;
    }
}