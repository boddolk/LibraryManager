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
    public partial class ReservePlus : Form
    {
        RegularUser currentUser;

        public ReservePlus(RegularUser user)
        {
            currentUser = user;
            InitializeComponent();
            CurrentDateTimePicker.Value = DateTime.Today;
            EndDateTimePicker.Value = CurrentDateTimePicker.Value.AddDays(3);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            //стягувати з комбо бокса книжку

            //стягувати дати

            //формувати менеджер

            //вихід

            UserForm form = new UserForm(currentUser);
            form.Show();
            this.Close();


        }
    }
}
