namespace libraryMeneger
{
    partial class LogInForm
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
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.AdminRButton = new System.Windows.Forms.RadioButton();
            this.UserRButton = new System.Windows.Forms.RadioButton();
            this.LogInButton = new System.Windows.Forms.Button();
            this.SingUpButton = new System.Windows.Forms.Button();
            this.LogInTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(148, 14);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(41, 16);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Логін";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(148, 67);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(56, 16);
            this.PasswordLabel.TabIndex = 1;
            this.PasswordLabel.Text = "Пароль";
            // 
            // AdminRButton
            // 
            this.AdminRButton.AutoSize = true;
            this.AdminRButton.Location = new System.Drawing.Point(12, 127);
            this.AdminRButton.Name = "AdminRButton";
            this.AdminRButton.Size = new System.Drawing.Size(120, 20);
            this.AdminRButton.TabIndex = 2;
            this.AdminRButton.TabStop = true;
            this.AdminRButton.Text = "адміністратор";
            this.AdminRButton.UseVisualStyleBackColor = true;
            // 
            // UserRButton
            // 
            this.UserRButton.AutoSize = true;
            this.UserRButton.Location = new System.Drawing.Point(212, 127);
            this.UserRButton.Name = "UserRButton";
            this.UserRButton.Size = new System.Drawing.Size(105, 20);
            this.UserRButton.TabIndex = 3;
            this.UserRButton.TabStop = true;
            this.UserRButton.Text = "користувач";
            this.UserRButton.UseVisualStyleBackColor = true;
            // 
            // LogInButton
            // 
            this.LogInButton.Location = new System.Drawing.Point(12, 162);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(303, 68);
            this.LogInButton.TabIndex = 4;
            this.LogInButton.Text = "Увійти";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // SingUpButton
            // 
            this.SingUpButton.Location = new System.Drawing.Point(178, 236);
            this.SingUpButton.Name = "SingUpButton";
            this.SingUpButton.Size = new System.Drawing.Size(137, 25);
            this.SingUpButton.TabIndex = 5;
            this.SingUpButton.Text = "Зареєструвати";
            this.SingUpButton.UseVisualStyleBackColor = true;
            this.SingUpButton.Click += new System.EventHandler(this.SingUpButton_Click);
            // 
            // LogInTextBox
            // 
            this.LogInTextBox.Location = new System.Drawing.Point(12, 33);
            this.LogInTextBox.Name = "LogInTextBox";
            this.LogInTextBox.Size = new System.Drawing.Size(303, 22);
            this.LogInTextBox.TabIndex = 6;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 86);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(303, 22);
            this.PasswordTextBox.TabIndex = 7;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 276);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LogInTextBox);
            this.Controls.Add(this.SingUpButton);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.UserRButton);
            this.Controls.Add(this.AdminRButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Name = "LogInForm";
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.RadioButton AdminRButton;
        private System.Windows.Forms.RadioButton UserRButton;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button SingUpButton;
        private System.Windows.Forms.TextBox LogInTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
    }
}