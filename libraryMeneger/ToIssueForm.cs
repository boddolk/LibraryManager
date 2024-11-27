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
                                     // ПЕРЕРОБИТИ для резервованих книг
            List<GenBook> reservedBooks = repository.getAllBooks();

            if (reservedBooks.Count > 0)
            {
                // 
                this.reserveComboBox.Items.Insert(0, "Select the reserve:");
                for (int i = 0; i < reservedBooks.Count; i++)
                {
                    this.reserveComboBox.Items.Insert(i + 1, reservedBooks[i].BookToString());
                }
            }
            else
            {
                this.reserveComboBox.Items.Add("The library has no reserved books!");
            }
            this.reserveComboBox.SelectedIndex = 0;

            DateTime currentDate = DateTime.Now.Date;

            this.currentDateLabel.Text = currentDate.ToString("dd.MM.yyyy");
            //this.endDateTimePicker.Value = currentDate.AddDays(1);

            this.endDateTimePicker.MinDate = currentDate;
            this.endDateTimePicker.MaxDate = currentDate.AddYears(1);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (this.reserveComboBox.SelectedIndex != 0)
            {
                int article = int.Parse(new string(this.reserveComboBox.SelectedItem.ToString().TakeWhile(char.IsDigit).ToArray()));

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
