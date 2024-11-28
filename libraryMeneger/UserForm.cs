﻿using libraryMeneger.book;
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

            foreach (BookStatManager manager in managers)
            {
                Title = booksRepository.getBookTitle(manager.Article);
                BookListBox.Items.Add(manager.GetToStringForHistory(Title));
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void EditProfilButton_Click(object sender, EventArgs e)
        {
            EditUserInfo editUserInfo = new EditUserInfo(currentUser);
            editUserInfo.Show();
            this.Close();
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void ReservedButton_Click(object sender, EventArgs e)
        {
            ReservePlus form = new ReservePlus(currentUser);
            form.Show();
            this.Close();
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            HistoryForm form = new HistoryForm(currentUser);
            form.Show();
            this.Close();
        }
    }
}

