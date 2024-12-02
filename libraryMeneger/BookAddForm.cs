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
    public partial class BookAddForm : Form
    {
        public AdminUser adminUser { get; private set; }
        public bool IsChanged { get; private set; }
        BooksRepository repository = new BooksRepository();

        public BookAddForm(AdminUser user)
        {
            InitializeComponent();
            adminUser = user;
            this.YearNumer.Value = DateTime.Now.Year;
            IsChanged = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ArticleTextBox.Text.Length > 0 && NameTextBox.Text.Length > 0 &&
                AuthorTextBox.Text.Length > 0 && YearNumer.Text.Length > 0)
            {
                if (ArticleTextBox.Text.All(char.IsDigit))
                {
                    int article = Convert.ToInt32(ArticleTextBox.Text);
                    if (repository.getBook(article) == null)
                    {
                        DialogResult result = MessageBox.Show(
                            "Are you sure to submit?",
                            "Confirmation",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            string title = NameTextBox.Text;
                            string autor = AuthorTextBox.Text;
                            int year = Convert.ToInt32(YearNumer.Text);
                            GenBook book = new GenBook(article, title, autor, year);

                            if (repository.insertBook(book))
                            {
                                this.cleaner();
                                IsChanged = true;
                                MessageBox.Show("Book successfully aded!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("A book with this article already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Article must contain only digits!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Go fun yourself", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cleaner()
        {
            this.ArticleTextBox.Clear();
            this.NameTextBox.Clear();
            this.AuthorTextBox.Clear();
            this.YearNumer.Value = DateTime.Now.Year;
        }

        private void BookAddForm_FormClosing(object sender, FormClosingEventArgs e)
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
