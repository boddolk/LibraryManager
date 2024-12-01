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
        StatusRepository statrepository = new StatusRepository();
        
        public UserForm(RegularUser user)
        {
            InitializeComponent();
            initializeForm(user);
        }

        private void initializeForm(RegularUser user)
        {
            this.currentUser = user;
            this.BookListView.Items.Clear();

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
            List<BookStatManager> managers = statrepository.getStatManagersByUser(currentUser.Login);

            if (managers != null)
            {
                foreach (BookStatManager manager in managers)
                {
                    Title = booksRepository.getBookTitle(manager.Article);
                    if (statrepository.IsIssued(manager.Article))
                    {
                        ListViewItem newPath = new ListViewItem(manager.GetToStringForHistory("ISSUED", Title));
                        newPath.ForeColor = Color.Snow;
                        if (manager.EndDate < DateTime.Now.Date)
                        {
                            newPath.BackColor = Color.OrangeRed;
                        }
                        else
                        {
                            newPath.BackColor = Color.LightGreen;
                        }
                        BookListView.Items.Add(newPath);
                    }
                    else if (statrepository.IsReserved(manager.Article))
                    {
                        BookListView.Items.Add(manager.GetToStringForHistory("RESERVED", Title));
                    }
                }
            }
            else
            {
                BookListView.Items.Add("You currently have no reserved");
                BookListView.Items.Add("or borrowed books:(");
                BookListView.Items.Add("Click reserve and choose:(");
            }
        }

        private void EditProfilButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EditUserInfo editUserForm = new EditUserInfo(currentUser);
            DialogResult result = editUserForm.ShowDialog();
            if (result == DialogResult.OK)
            { 
                initializeForm(editUserForm.regularUser);
                this.Visible = true;
            }
            else if (result == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        private void ReservedButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ReservePlus reserveBookForm = new ReservePlus(currentUser);
            DialogResult result = reserveBookForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                initializeForm(reserveBookForm.regularUser);
                this.Visible = true;
            }
            else if (result == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            HistoryForm historyForm = new HistoryForm(currentUser);
            if (historyForm.ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }
    }
}

