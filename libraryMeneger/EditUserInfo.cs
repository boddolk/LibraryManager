using libraryMeneger.Data.UserRepository;
using libraryMeneger.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryMeneger
{
    public partial class EditUserInfo : Form
    {
        private RegularUser currentUser;

        public EditUserInfo(RegularUser user)
        {
            InitializeComponent();
            currentUser = user;

            NameTextBox.Text = user.Name;
            SurnameTextBox.Text = user.Surname;
            PhoneTextBox.Text = user.PhoneNumber;
            MailTextBox.Text = user.Email;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure to submit?",
        "Confirmation",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                currentUser.Name = NameTextBox.Text;
                currentUser.Surname = SurnameTextBox.Text;
                currentUser.PhoneNumber = PhoneTextBox.Text;
                currentUser.Email = MailTextBox.Text;

                UserRepository repository = new UserRepository();

                UserForm form = new UserForm(currentUser);
                bool correct = repository.updateUser(currentUser);

                if (correct)
                {
                    form.Show();
                    this.Close();
                    Console.WriteLine("Коректно відредагувало");

                }
                else
                {
                    Console.WriteLine("Не відредагувало користувача");
                }
            }
            if (result == DialogResult.No) 
            {
                UserForm form = new UserForm(currentUser);
                form.Show();
                this.Close();

            }


        }
    }
}
