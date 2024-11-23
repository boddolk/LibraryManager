using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libraryMeneger.user;

namespace libraryMeneger
{
    public partial class AdminForm : Form
    {
        public AdminForm(AdminUser user)
        {
            InitializeComponent();
            this.Text = "Admin - " + user.Login;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
           

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
