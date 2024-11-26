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
        AdminUser adminUser;
        BooksRepository repository = new BooksRepository();
        public BookAddForm(AdminUser user)
        {
            InitializeComponent();
            adminUser = user;

        }

        private void BookAddForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ArticleTextBox.Text.Length > 0 &&
                NameTextBox.Text.Length > 0 &&
                AuthorTextBox.Text.Length > 0 &&
                YearNumer.Text.Length > 0)
            {

                    DialogResult result = MessageBox.Show(
                "Are you sure to submit?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    int article = Convert.ToInt32(ArticleTextBox.Text);
                    string title = NameTextBox.Text;
                    string autor = AuthorTextBox.Text;
                    int year = Convert.ToInt32(YearNumer.Text);

                    GenBook book = new GenBook(article, title, autor, year);

                    repository.insertBook(book);
                    // дописати перевірку
                    AdminForm form = new AdminForm(adminUser);
                    form.Show();
                    this.Close();
                }

                if (result == DialogResult.No)
                {
                    AdminForm form = new AdminForm(adminUser);
                    form.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Go fun yourself", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}
