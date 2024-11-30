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
    public partial class UserForm : Form
    {
        private RegularUser currentUser;
        BooksRepository booksRepository = new BooksRepository();
        StatusRepository repository = new StatusRepository();
        
        public UserForm(RegularUser user)
        {
            InitializeComponent();
            initializeForm(user);
        }

        private void initializeForm(RegularUser user)
        {
            this.currentUser = user;

            UsernameLabel.Text = user.Login;
            UsernameLabel.ForeColor = Color.Black;
            NameLabel.Text = user.Name;
            NameLabel.ForeColor = Color.Black;
            SurnameLabel.Text = user.Surname;
            SurnameLabel.ForeColor = Color.Black;
            PhoneLabel.Text = user.PhoneNumber;
            PhoneLabel.ForeColor = Color.Black;
            MailLabel.Text = user.Email;
            MailLabel.ForeColor = Color.Black;

            string Title;
            List<BookStatManager> managers = repository.getStatManagersByUser(currentUser.Login);

            if (managers != null)
            {
                foreach (BookStatManager manager in managers)
                {
                    Title = booksRepository.getBookTitle(manager.Article);
                    BookListBox.Items.Add(manager.GetToStringForHistory(Title));
                }
            }
            else
            {
                BookListBox.Items.Add("You currently have no reserved");
                BookListBox.Items.Add("or borrowed books:(");
                BookListBox.Items.Add("Click reserve and choose:(");
            }
        }

        private void EditProfilButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EditUserInfo editUserForm = new EditUserInfo(currentUser);
            if (editUserForm.ShowDialog() == DialogResult.OK)
            { 
                initializeForm(editUserForm.regularUser);
                this.Visible = true;
            }
        }

        private void ReservedButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ReservePlus reserveBookForm = new ReservePlus(currentUser);
            if (reserveBookForm.ShowDialog() == DialogResult.OK)
            {
                initializeForm(reserveBookForm.regularUser);
                this.Visible = true;
            }
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HistoryForm historyForm = new HistoryForm(currentUser);
            if (historyForm.ShowDialog() == DialogResult.OK)
            {
                this.Visible = true;
            }
        }
    }
}

