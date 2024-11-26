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
                this.BookComboBox.Items.Insert(0, "Select the book:");
                for (int i = 1; i < allBooks.Count; i++)
                {
                    this.BookComboBox.Items.Insert(i, allBooks[i].BookToString());
                }
            }
            else
            {
                this.BookComboBox.Items.Add("The library has no books!");
                // Підкорегувати видимість полів
            }
            this.BookComboBox.SelectedIndex = 0;
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
            ////замінити
            //int arcticle = Convert.ToInt32(ArticleTextBox.Text);
            //BookEditForm form = new BookEditForm(repository.getBook(arcticle), currentUser);
            //form.Show();
            //this.Close();

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (this.BookComboBox.SelectedIndex != 0)
            {
                if (true/*перевірити, чи книга поточно не резервована/видана*/)
                {
                    if (true/*перепитати, чи дійшно хоче*/)
                    {
                        int article = int.Parse(this.currentArticleLabel.Text);
                        BooksRepository repository = new BooksRepository("UsersAndBooks.db");
                        if (repository.deleteBook(article))
                        {
                            // успішно видалено
                        }
                        else 
                        {
                            // все погано // але чи доцільний елс
                        }
                    }
                }
                else
                {
                    // WARNING!!!

                }
            }
            else 
            {
                // WARNING!!!

            }
        }

        private void BookComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int article = int.Parse(new string(this.BookComboBox.SelectedItem.ToString().TakeWhile(char.IsDigit).ToArray()));
            if (this.BookComboBox.SelectedIndex != 0)
            {
                BooksRepository repository = new BooksRepository("UsersAndBooks.db");
                GenBook currentBook = repository.getBook(article);
                this.currentArticleLabel.Text = currentBook.Article.ToString();
                this.currentTitleLabel.Text = currentBook.Title.ToString();
                this.currentAuthorLabel.Text = currentBook.Author.ToString();
                this.currentYearLabel.Text = currentBook.Year.ToString();
                this.currentStatusLabel.Text = "ZATICHKA _ UVAGA";
            }
            else 
            {
                // Колір та видимість
                this.currentArticleLabel.Text = "Empty article";
                this.currentTitleLabel.Text = "Empty title";
                this.currentAuthorLabel.Text = "Empty author";
                this.currentYearLabel.Text = "Empty year";
                this.currentStatusLabel.Text = "Empty status";
            }
        }
    }
}
