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
        GenBook currentBook;
        AdminUser currentUser;
        public BookEditForm(GenBook book, AdminUser user)
        {
            InitializeComponent();
            currentBook = book;
            currentUser = user;

            currentArticle.Text = currentBook.Article.ToString();
            NameTextBox.Text = currentBook.Title.ToString();
            AuthorTextBox.Text = currentBook.Author.ToString();
            YearNumer.Value = currentBook.Year;

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                 "Are you sure to submit?",
                 "Confirmation",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (NameTextBox.Text.Length > 0 &&
                 AuthorTextBox.Text.Length > 0 &&
                 YearNumer.Value > 0)
                {
                    currentBook.Title = NameTextBox.Text;
                    currentBook.Author = AuthorTextBox.Text;   
                    currentBook.Year = Convert.ToInt32(YearNumer.Value);

                    BooksRepository booksRepository = new BooksRepository();

                    bool correct = booksRepository.updateBook(currentBook);
                    if (correct)
                    {
                        AdminForm form = new AdminForm(currentUser);
                        form.Show();
                        this.Close();
                        Console.WriteLine("Коректно відредагувало");
                    }

                    else 
                    {
                        Console.WriteLine("Не відредагувало");

                    }

                }


            }
            if (result == DialogResult.No)
            {
                AdminForm form = new AdminForm(currentUser);
                form.Show();
                this.Close();
            }

        }
    }
}
