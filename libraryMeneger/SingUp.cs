using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libraryMeneger.Data.UserRepository;
using libraryMeneger.user;
 


namespace libraryMeneger
{
    public partial class SingUp : Form
    {
        public SingUp()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool empty = false;

            string login = LogInTextBox.Text;
            if (string.IsNullOrEmpty(login))
            {
                empty = true;
            }

            string password = PasswordTextBox.Text;
            if (string.IsNullOrEmpty(password))
            {
                empty = true;
            }

            string name = NameTextBox.Text;
            if (string.IsNullOrEmpty(name))
            {
                empty = true;
            }

            string surname = SurnameTextBox.Text;
            if (string.IsNullOrEmpty(surname))
            {
                empty = true;
            }

            string mail = MailTextBox.Text;
            if (string.IsNullOrEmpty(mail))
            {
                empty = true;
            }

            if (empty)
            {
                MessageBox.Show("Please fill out all form fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                UserRepository repository = new UserRepository("UsersAndBooks.db"); ;
                RegularUser newUser = new RegularUser(login, name, surname, password, mail, "noNumber");

                bool coorect = repository.insertNewUser(newUser);
                if (coorect) 
                {
                    UserForm form = new UserForm(newUser);
                    form.Show();
                    this.Close();
                }
              
            }


        }
    }
}
