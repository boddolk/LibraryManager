using libraryMeneger.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libraryMeneger.Data.UserRepository;
using libraryMeneger.Data.StatusRepository;

namespace libraryMeneger
{
    public partial class LogInForm : Form
    {
        public RegularUser regUser { get; private set; }
        public AdminUser admUser { get; private set; }

        StatusRepository booksRepository = new StatusRepository();
        public LogInForm()
        {
            InitializeComponent();
            booksRepository.removeOverdueReservedBooks();
            this.DialogResult = DialogResult.Cancel;

            // ADMIN USER
            this.LogInTextBox.Text = "user1_admin";
            this.PasswordTextBox.Text = "12345678";

            // REGULAR USER
            //this.LogInTextBox.Text = "user3";
            //this.PasswordTextBox.Text = "34567890";
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            UserRepository repository = new UserRepository();

            bool correct = false;
            // ЗАМІСТЬ ЗНАЧЕНЬ ТРУ — РЗУЛЬТАТ МЕТОДІВ //сМонохромка
            if (repository.DoesSuchUserExist(LogInTextBox.Text))
            {
                if (repository.IsPasswordCorrect(LogInTextBox.Text, PasswordTextBox.Text))
                {
                    correct = true;
                }
                else
                {
                    MessageBox.Show("Incorrect password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Incorrect login", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // ПЕРЕВІРКА НАЯВНОСТІ ЮЗЕРА, ЯКЩО КОРЕКТНИЙ ТО СТВОРЮЄМО ВІДПОВІДНО КОНКРЕТНОГО
            if (correct)
            {
                string myLogin = LogInTextBox.Text;
                string myName = repository.getName(LogInTextBox.Text);
                string mySurname = repository.getSurname(LogInTextBox.Text);
                string myPassword = repository.getPassword(LogInTextBox.Text);
                string myEmail = repository.getEmail(LogInTextBox.Text);
                string myPhoneNumber = repository.getPhoneNumber(LogInTextBox.Text);

                bool isAdmin = repository.IsGivenUserAdmin(LogInTextBox.Text);

                if (isAdmin)
                {
                    admUser = new AdminUser(myLogin, myName, mySurname, myPassword, myEmail, myPhoneNumber);
                    regUser = null;
                }
                else
                {
                    regUser = new RegularUser(myLogin, myName, mySurname, myPassword, myEmail, myPhoneNumber);
                    admUser = null;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void SingUpButton_Click(object sender, EventArgs e)
        {
            admUser = null;
            SingUp signUpForm = new SingUp();
            if (signUpForm.ShowDialog() == DialogResult.OK)
            {
                regUser = signUpForm.NewUser;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
