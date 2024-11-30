using libraryMeneger.book;
using libraryMeneger.Data.BookRepository;
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
    public partial class ToIssueForm : Form
    {
        public AdminUser adminUser { get; private set; }
        BooksRepository repository = new BooksRepository();
        StatusRepository statRepository = new StatusRepository();

        public ToIssueForm(AdminUser user)
        {
            InitializeComponent();
            adminUser = user;

            string Title;
            string UserLogin;
            List<BookStatManager> reservedBooks = statRepository.getReservedBookInfo();

            if (reservedBooks != null)
            {
                this.reserveComboBox.Items.Add("Select the reserve:");
                foreach (BookStatManager reservedBook in reservedBooks)
                {
                    Title = repository.getBookTitle(reservedBook.Article);
                    UserLogin = statRepository.getUserIDByArticle(reservedBook.Article);
                    this.reserveComboBox.Items.Add(reservedBook.GetToStringStatus(Title, UserLogin));
                }
            }
            else
            {
                this.reserveComboBox.Items.Add("The library has no reserved books!");
            }
            this.reserveComboBox.SelectedIndex = 0;

            DateTime currentDate = DateTime.Now.Date;
            this.currentDateLabel.Text = currentDate.ToString("dd.MM.yyyy");

            this.endDateTimePicker.MinDate = currentDate.AddDays(1);
            this.endDateTimePicker.MaxDate = currentDate.AddYears(1);

            this.endDateTimePicker.CustomFormat = "dd.MM.yyyy";
            this.endDateTimePicker.Format = DateTimePickerFormat.Custom;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            string Title;
            string UserLogin = this.filterTextBox.Text;
            if (UserLogin.Length != 0) // Якщо логін не пустий то перейте до видобування резервованих за юзером
            {
                List<BookStatManager> resBooksForUser = statRepository.getStatManagersByUser(UserLogin);
                
                this.reserveComboBox.Items.Clear();
                if (resBooksForUser != null)
                {
                    this.reserveComboBox.Items.Add("Select the reserve:");
                    foreach (BookStatManager resUserBook in resBooksForUser)
                    {
                        if (resUserBook.ReserveStatus == true)
                        {
                            Title = repository.getBookTitle(resUserBook.Article);
                            UserLogin = statRepository.getUserIDByArticle(resUserBook.Article);
                            this.reserveComboBox.Items.Add(resUserBook.GetToStringStatus(Title, UserLogin));
                        }
                    }
                }
                else
                {
                    this.reserveComboBox.Items.Add("The library has no reserved books!");
                }
            }
            else
            {
                List<BookStatManager> reservedBooks = statRepository.getReservedBookInfo();

                if (reservedBooks != null)
                {
                    this.reserveComboBox.Items.Add("Select the reserve:");
                    foreach (BookStatManager reservedBook in reservedBooks)
                    {
                        Title = repository.getBookTitle(reservedBook.Article);
                        UserLogin = statRepository.getUserIDByArticle(reservedBook.Article);
                        this.reserveComboBox.Items.Add(reservedBook.GetToStringStatus(Title, UserLogin));
                    }
                }
                else
                {
                    this.reserveComboBox.Items.Add("The library has no reserved books!");
                }
            }
            this.reserveComboBox.SelectedIndex = 0;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (this.reserveComboBox.SelectedIndex != 0)
            {
                int article = int.Parse(new string(this.reserveComboBox.SelectedItem.ToString().TakeWhile(char.IsDigit).ToArray()));
                DateTime startRentDate = DateTime.Now.Date;
                DateTime endRentTime = this.endDateTimePicker.Value;

                DialogResult result = MessageBox.Show("Are you sure that you want to issue book with this article: " + article.ToString() + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (statRepository.changeToIssued(article, startRentDate, endRentTime))
                    {
                        this.reserveComboBox.Items.RemoveAt(this.reserveComboBox.SelectedIndex);
                        this.reserveComboBox.SelectedIndex = 0;
                        MessageBox.Show("Book successfully issued for user: < " + statRepository.getUserIDByArticle(article) + " >!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose book!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToIssueForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
