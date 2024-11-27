using libraryMeneger.book;
using libraryMeneger.Data.BookRepository;
using libraryMeneger.Data.BorrowHistory;
using libraryMeneger.Data.StatusRepository;
using libraryMeneger.user;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libraryMeneger
{
    public partial class ReturnBookForm : Form
    {
        AdminUser adminUser;
        BooksRepository repository = new BooksRepository();
        StatusRepository statRepository = new StatusRepository();
        BorrowHistoryRepository borrowRepository = new BorrowHistoryRepository();

        public ReturnBookForm(AdminUser user)
        {
            InitializeComponent();

            adminUser = user;

            string Title;
            string UserLogin;
            List<BookStatManager> issuedBooks = statRepository.getIssuedBookInfo();

            if (issuedBooks != null)
            {
                this.issuedComboBox.Items.Insert(0, "Select the issued:");
                for (int i = 0; i < issuedBooks.Count; i++)
                {
                    Title = repository.getBook(issuedBooks[i].Article).Title;
                    UserLogin = statRepository.getUserIDByArticle(issuedBooks[i].Article);
                    this.issuedComboBox.Items.Insert(i + 1, issuedBooks[i].GetToStringStatus(Title, UserLogin));
                }
            }
            else
            {
                this.issuedComboBox.Items.Add("The library has no issued books!");
            }
            this.issuedComboBox.SelectedIndex = 0;

            //DateTime currentDate = DateTime.Now.Date;
            //this.cStartDatelabel.Text = "Start date empty";
            //this.cEndDatelabel.Text = "End date empty";
        }

        private void issuedComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.issuedComboBox.SelectedIndex != 0)
            {
                int article = int.Parse(new string(this.issuedComboBox.SelectedItem.ToString().TakeWhile(char.IsDigit).ToArray()));
                BookStatManager currentIssuedBook = new BookStatManager(); // затичка!!!!!!!!!!!!!!
                DateTime startDate = currentIssuedBook.StartDate;
                DateTime endDate = currentIssuedBook.EndDate;

                this.cStartDatelabel.Text = startDate.ToString("dd.MM.yyyy");
                this.cEndDatelabel.Text = endDate.ToString("dd.MM.yyyy");
                
                this.cStartDatelabel.ForeColor = Color.Black;
                if (currentIssuedBook.EndDate > DateTime.Now.Date)
                {
                    this.cEndDatelabel.ForeColor = Color.Green;
                }
                else
                {
                    this.cEndDatelabel.ForeColor = Color.Red;
                }
            }
            else
            {
                this.cStartDatelabel.Text = "Start date is empty";
                this.cEndDatelabel.Text = "End date is empty";
                this.cStartDatelabel.ForeColor = Color.LightGray;
                this.cEndDatelabel.ForeColor = Color.LightGray;
            }
        }

        private void returnMenuButton_Click(object sender, EventArgs e)
        {
            if (this.issuedComboBox.SelectedIndex != 0)
            {
                int article = int.Parse(new string(this.issuedComboBox.SelectedItem.ToString().TakeWhile(char.IsDigit).ToArray()));
                BookStatManager currentIssuedBook = new BookStatManager(); // затичка!!!!!!!!!!!!!!
                string Login = statRepository.getUserIDByArticle(article);
                DateTime startDate = currentIssuedBook.StartDate;
                DateTime endDate = currentIssuedBook.EndDate;
                if (borrowRepository.addHistory(Login, article, currentIssuedBook.StartDate, DateTime.Now.Date))
                {
                    if (statRepository.removeBookWithItsStatus(article))
                    {
                        // Привітання
                    }
                }
                else
                {
                    // деякі трабли
                }
            }
            else
            {
                // виберіть книгу!!!
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm(adminUser);
            form.Show();
            this.Close();
        }
    }
}
