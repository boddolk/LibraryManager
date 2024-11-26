using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libraryMeneger.book;
using libraryMeneger.user;

namespace libraryMeneger
{
    public partial class BookEditForm : Form
    {
        GenBook currentBook;
        AdminUser currentUser;
        public BookEditForm(GenBook book, AdminUser user)
        {
            InitializeComponent();
            currentBook = book;
            currentUser = user;

        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }
    }
}
