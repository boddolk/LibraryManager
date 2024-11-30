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
        private AdminUser currentUser;
        BooksRepository repository = new BooksRepository();
        StatusRepository statRepository = new StatusRepository();

        public AdminForm(AdminUser user)
        {
            InitializeComponent();
            initializeForm(user);
        }

        private void initializeForm(AdminUser user)
        {
            currentUser = user;
            this.Text = "Admin - " + currentUser.Login;

            List<GenBook> allBooks = repository.getAllBooks();

            if (allBooks.Count > 0)
            {
                this.BookComboBox.Items.Add("Select the book:");
                foreach (GenBook book in allBooks)
                {
                    this.BookComboBox.Items.Add(book.BookToString());
                }
            }
            else
            {
                this.BookComboBox.Items.Add("The library has no books!");
            }
            this.BookComboBox.SelectedIndex = 0;
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

                if (statRepository.IsReserved(article)) // ОБДУМАТИ НАСКІЛЬКИ ТУТ КОРЕКТНО
                {
                    this.currentStatusLabel.Text = "RESERVED";
                }
                else if (statRepository.IsIssued(article))
                {
                    this.currentStatusLabel.Text = "ISSUED";
                }
                else
                {
                    this.currentStatusLabel.Text = "AVAILABLE";
                }

                this.currentArticleLabel.ForeColor =
                    currentTitleLabel.ForeColor =
                    currentAuthorLabel.ForeColor =
                    currentYearLabel.ForeColor =
                    currentStatusLabel.ForeColor = Color.Black;
            }
            else
            {
                this.currentArticleLabel.Text = "Empty article";
                this.currentTitleLabel.Text = "Empty title";
                this.currentAuthorLabel.Text = "Empty author";
                this.currentYearLabel.Text = "Empty year";
                this.currentStatusLabel.Text = "Empty status";

                this.currentArticleLabel.ForeColor =
                    currentTitleLabel.ForeColor =
                    currentAuthorLabel.ForeColor =
                    currentYearLabel.ForeColor =
                    currentStatusLabel.ForeColor = Color.LightGray;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BookAddForm bookAddForm = new BookAddForm(currentUser);
            if (bookAddForm.ShowDialog() == DialogResult.OK)
            {
                initializeForm(bookAddForm.adminUser);
                this.Visible = true;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (this.BookComboBox.SelectedIndex != 0)
            {
                int arcticle = Convert.ToInt32(currentArticleLabel.Text);
                this.Visible = false;
                BookEditForm bookEditForm = new BookEditForm(repository.getBook(arcticle), currentUser);
                if (bookEditForm.ShowDialog() == DialogResult.OK)
                {
                    initializeForm(bookEditForm.adminUser);
                    this.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("The book is not chosen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                            MessageBox.Show("Book successfully deleted!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void GiveOutButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ToIssueForm toIssueBookForm = new ToIssueForm(currentUser);
            if (toIssueBookForm.ShowDialog() == DialogResult.OK)
            {
                initializeForm(toIssueBookForm.adminUser);
                this.Visible = true;
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ReturnBookForm returnBookForm = new ReturnBookForm(currentUser);
            if (returnBookForm.ShowDialog() == DialogResult.OK)
            {
                initializeForm(returnBookForm.adminUser);
                this.Visible = true;
            }
        }
    }
}