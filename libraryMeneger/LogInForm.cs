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

namespace libraryMeneger
{
   

    public partial class LogInForm : Form
    {
        

        public LogInForm()
        {
            InitializeComponent();
           

        }


                
        private void LogInButton_Click(object sender, EventArgs e)
        {



            UserRepository repository = new UserRepository("UsersAndBooks.db");

            bool correct = false;
            // ЗАМІСТЬ ЗНАЧЕНЬ ТРУ — РЗУЛЬТАТ МЕТОДІВ //сМонохромка
            if (repository.DoesSuchUserExist(LogInTextBox.Text))
            {
                if(repository.IsPasswordCorrect(LogInTextBox.Text, PasswordTextBox.Text))
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



            bool isAdmin = repository.IsGivenUserAdmin(LogInTextBox.Text);





            if(isAdmin) 
            {
                if (correct)
                {
                    string myLogin = LogInTextBox.Text;
                    string myName = repository.getName(LogInTextBox.Text);
                    string mySurname = repository.getSurname(LogInTextBox.Text);
                    string myPassword = repository.getPassword(LogInTextBox.Text);
                    string myEmail = repository.getEmail(LogInTextBox.Text);
                    string myPhoneNumber = repository.getPhoneNumber(LogInTextBox.Text);

                    AdminUser user = new AdminUser(myLogin, myName, mySurname, myPassword, myEmail, myPhoneNumber);

                    AdminForm adminForm = new AdminForm(user);
                    adminForm.Show();
                    this.Visible = false;
                }
            }
            else
            {
                if (correct)
                {
                    string myLogin = LogInTextBox.Text;
                    string myName = repository.getName(LogInTextBox.Text);
                    string mySurname = repository.getSurname(LogInTextBox.Text);
                    string myPassword = repository.getPassword(LogInTextBox.Text);
                    string myEmail = repository.getEmail(LogInTextBox.Text);
                    string myPhoneNumber = repository.getPhoneNumber(LogInTextBox.Text);

                    RegularUser user = new RegularUser(myLogin, myName, mySurname, myPassword, myEmail, myPhoneNumber);
                    UserForm userForm = new UserForm(user);
                    userForm.Show();
                    this.Visible = false;
                }

            }

            

        }

        private void SingUpButton_Click(object sender, EventArgs e)
        {
            SingUp form = new SingUp();
            form.Show();
            this.Hide();

        }
    }
}
