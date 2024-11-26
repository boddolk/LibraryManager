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
using libraryMeneger.Data.StatusRepository;
using libraryMeneger.user;
using System.Drawing.Imaging;

namespace libraryMeneger
{
    public partial class AdminForm : Form
    {
        AdminUser currentUser;
        BooksRepository repository = new BooksRepository();
        StatusRepository statRepository = new StatusRepository();

        public AdminForm(AdminUser user)
        {
            
            InitializeComponent();
            this.Text = "Admin - " + user.Login;

            List<GenBook> allBooks = repository.getAllBooks();

            if (allBooks.Count > 0)
            {
                this.BookComboBox.Items.Insert(0, "Select the book:");
                for (int i = 0; i < allBooks.Count; i++)
                {
                    this.BookComboBox.Items.Insert(i + 1, allBooks[i].BookToString());
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
                int article = int.Parse(this.currentArticleLabel.Text);
                if (!statRepository.IsPresentInTable(article))
                {
                    DialogResult result = MessageBox.Show("Are you sure that you want to delete book with this article: " + article.ToString() + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (repository.deleteBook(article))
                        {
                            this.BookComboBox.Items.RemoveAt(this.BookComboBox.SelectedIndex);
                            this.BookComboBox.SelectedIndex = 0;
                            MessageBox.Show("Book successfully added!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The book is booked or issued!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else 
            {
                MessageBox.Show("Choose book!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BookComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.BookComboBox.SelectedIndex != 0)
            {
                int article = int.Parse(new string(this.BookComboBox.SelectedItem.ToString().TakeWhile(char.IsDigit).ToArray()));
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
