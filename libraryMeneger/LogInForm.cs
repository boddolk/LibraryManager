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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();     
           
        }
             AdminForm adminForm = new AdminForm();//створення адмінської форми
                
        private void LogInButton_Click(object sender, EventArgs e)
        {
            if(AdminRButton.Checked) //обробник редіобатона, поки так, поки нема бази
            {
                adminForm.Show();
                this.Visible = false;
            }


            

        }

        private void SingUpButton_Click(object sender, EventArgs e)
        {

        }
    }
}
