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
        public RegularUser regularUser { get; private set; }

        public EditUserInfo(RegularUser user)
        {
            InitializeComponent();
            regularUser = user;
            this.DialogResult = DialogResult.Cancel;

            NameTextBox.Text = user.Name;
            SurnameTextBox.Text = user.Surname;
            PhoneTextBox.Text = user.PhoneNumber;
            MailTextBox.Text = user.Email;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length > 0 && SurnameTextBox.Text.Length > 0 &&
                    PhoneTextBox.Text.Length > 0 && MailTextBox.Text.Length > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure to submit?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    regularUser.Name = NameTextBox.Text;
                    regularUser.Surname = SurnameTextBox.Text;
                    regularUser.PhoneNumber = PhoneTextBox.Text;
                    regularUser.Email = MailTextBox.Text;

                    UserRepository repository = new UserRepository();
                    bool correct = repository.updateUser(regularUser);

                    if (correct)
                    {
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("User successfully edited!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("User do not edited.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("There are empty fields. Editing is not possible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
