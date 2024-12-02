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
using libraryMeneger.user;

namespace libraryMeneger
{
    public partial class BookEditForm : Form
    {
        public AdminUser adminUser { get; private set; }
        public bool IsChanged { get; private set; }
        GenBook currentBook;
        
        public BookEditForm(GenBook book, AdminUser user)
        {
            InitializeComponent();
            adminUser = user;
            currentBook = book;
            IsChanged = false;
            currentArticle.Text = currentBook.Article.ToString();
            NameTextBox.Text = currentBook.Title.ToString();
            AuthorTextBox.Text = currentBook.Author.ToString();
            YearNumer.Value = currentBook.Year;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text.Length > 0 && AuthorTextBox.Text.Length > 0 && YearNumer.Value >= 1574)
            {
                DialogResult result = MessageBox.Show(
                 "Are you sure to submit?",
                 "Confirmation",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    currentBook.Title = NameTextBox.Text;
                    currentBook.Author = AuthorTextBox.Text;
                    currentBook.Year = Convert.ToInt32(YearNumer.Value);
                    BooksRepository booksRepository = new BooksRepository();

                    if (booksRepository.updateBook(currentBook))
                    {
                        IsChanged = true;
                        MessageBox.Show("Book successfully edited!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("The book is not edited!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Some fields are empty!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BookEditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsChanged)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}
