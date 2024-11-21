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

            // ЗАМІСТЬ ЗНАЧЕНЬ ТРУ — РЗУЛЬТАТ МЕТОДІВ //сМонохромка
            bool correct = true; 
            bool isAdmin = true;





            if(isAdmin) 
            {
                if (correct)
                {          
                    AdminForm adminForm = new AdminForm();//створення адмінської форми
                    adminForm.Show();
                    this.Visible = false;
                }
            }
            else
            {
                if (correct)
                {
                    //ЗАТИЧКА, ПОКИ НЕМА ЗВІДКИ ДАНІ СТЯГНУТИ
                    RegularUser user = new RegularUser();
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
