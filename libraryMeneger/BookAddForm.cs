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
            DialogResult result = MessageBox.Show(
            "Are you sure to submit?",
            "Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int article = Convert.ToInt32(ArticleTextBox.Text);
                string title = NameTextBox.Text;
                string autor = ArticleTextBox.Text;
                int year = Convert.ToInt32(YearNumer.Text);

                GenBook book = new GenBook(article, title, autor, year);

                BooksRepository repository = new BooksRepository("UsersAndBooks.db");
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
    }
}
