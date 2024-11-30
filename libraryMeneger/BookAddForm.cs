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
        BooksRepository repository = new BooksRepository();

        public BookAddForm(AdminUser user)
        {
            InitializeComponent();
            adminUser = user;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ArticleTextBox.Text.Length > 0 && NameTextBox.Text.Length > 0 &&
                AuthorTextBox.Text.Length > 0 && YearNumer.Text.Length > 0)
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
                            MessageBox.Show("Book successfully aded!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
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
                MessageBox.Show("Go fun yourself", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BookAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
