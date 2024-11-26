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
using libraryMeneger.Data.BookRepository;
using libraryMeneger.Data.UserRepository;
using libraryMeneger.user;

namespace libraryMeneger
{
    public partial class AdminForm : Form
    {
        public AdminForm(AdminUser user)
        {
            InitializeComponent();
            this.Text = "Admin - " + user.Login;

            BooksRepository repository = new BooksRepository("UsersAndBooks.db");
            List<GenBook> allBooks = repository.getAllBooks();

            if (allBooks.Count > 0)
            {
                for (int i = 0; i < allBooks.Count; i++)
                {
                    this.BookComboBox.Items.Insert(i, allBooks[i].BookToString()); // шляпа
                }
            }
            else 
            {
                this.BookComboBox.Items.Add("The library has no books!");
            }
            
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
