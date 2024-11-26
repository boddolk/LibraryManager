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
        AdminUser currentUser;
        BooksRepository repository = new BooksRepository("UsersAndBooks.db");
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
           BookAddForm bookAddForm = new BookAddForm(currentUser);
            bookAddForm.Show();

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
          
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            //замінити
            int arcticle = Convert.ToInt32(ArticleTextBox.Text);
            BookEditForm form = new BookEditForm(repository.getBook(arcticle), currentUser);
            form.Show();
            this.Close();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
