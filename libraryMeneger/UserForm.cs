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
    public partial class UserForm : Form
    {
        private RegularUser currentUser;

        public UserForm(RegularUser user)
        {
            InitializeComponent(); 
            this.currentUser = user;

            UsernameLabel.Text = user.Login;
            UsernameLabel.ForeColor = Color.Black;
            NameLabel.Text = user.Name;
            NameLabel.ForeColor = Color.Black;
            SurnameLabel.Text = user.Surname;
            SurnameLabel.ForeColor = Color.Black;
            PhoneLabel.Text = user.PhoneNumber;
            PhoneLabel.ForeColor = Color.Black;
            MailLabel.Text = user.Email;
            MailLabel.ForeColor = Color.Black;
                       
        }

        private void UserForm_Load(object sender, EventArgs e)
        {



        }
    }
}
