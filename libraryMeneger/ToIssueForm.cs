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
        AdminUser adminUser;
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
                this.reserveComboBox.Items.Insert(0, "Select the reserve:");
                for (int i = 0; i < reservedBooks.Count; i++)
                {
                    Title = repository.getBook(reservedBooks[i].Article).Title;
                    UserLogin = statRepository.getUserIDByArticle(reservedBooks[i].Article);
                    this.reserveComboBox.Items.Insert(i + 1, reservedBooks[i].GetToStringStatus(Title, UserLogin));
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

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (this.reserveComboBox.SelectedIndex != 0)
            {
                int article = int.Parse(new string(this.reserveComboBox.SelectedItem.ToString().TakeWhile(char.IsDigit).ToArray()));

                DialogResult result = MessageBox.Show("Are you sure that you want to issue book with this article: " + article.ToString() + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (true/*переведення статусу( резервований - - > виданий )*/)
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
            AdminForm form = new AdminForm(adminUser);
            form.Show();
            this.Close();
        }
    }
}
