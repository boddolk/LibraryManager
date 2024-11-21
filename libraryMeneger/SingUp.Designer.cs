namespace libraryMeneger
{
    partial class SingUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.LogInTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.MailTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // LogInTextBox
            // 
            this.LogInTextBox.Location = new System.Drawing.Point(15, 37);
            this.LogInTextBox.Name = "LogInTextBox";
            this.LogInTextBox.Size = new System.Drawing.Size(224, 22);
            this.LogInTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 94);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(224, 22);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(15, 153);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(224, 22);
            this.NameTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Surname";
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(15, 214);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(224, 22);
            this.SurnameTextBox.TabIndex = 7;
            // 
            // MailTextBox
            // 
            this.MailTextBox.Location = new System.Drawing.Point(15, 277);
            this.MailTextBox.Name = "MailTextBox";
            this.MailTextBox.Size = new System.Drawing.Size(224, 22);
            this.MailTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mail";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(15, 326);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(224, 67);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // SingUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 430);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.MailTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SurnameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogInTextBox);
            this.Controls.Add(this.label1);
            this.Name = "SingUp";
            this.Text = "SingUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LogInTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.TextBox MailTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SubmitButton;
    }
}