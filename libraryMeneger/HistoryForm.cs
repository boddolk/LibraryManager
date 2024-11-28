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
using System.Web;
using System.Windows.Forms;

namespace libraryMeneger
{
    public partial class HistoryForm : Form
    {
        RegularUser CurrentUser;
        BooksRepository BooksRepository;
        BorrowHistoryRepository historyRepository;



        public HistoryForm(RegularUser user)
        {
            InitializeComponent();
            CurrentUser = user;

            int Article;
          
            List<Tuple<int, DateTime, DateTime>> managers = historyRepository.getUserHistory(CurrentUser.Login);

            foreach (Tuple<int, DateTime, DateTime> manager in managers)
            {
                Article = manager.Item1;
                string historyPath = Article.ToString()
                    + " | Title: " + BooksRepository.getBookTitle(Article) 
                    + "; Author: " + BooksRepository.getBook(Article).Author 
                    + "; Start date: " + manager.Item2.ToString("dd.MM.yyyy") 
                    + "; End date: " + manager.Item3.ToString("dd.MM.yyyy");
                HistoryBox.Items.Add(historyPath);
            }
        }

        private void HistoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserForm form = new UserForm(CurrentUser);
            form.Show();
            this.Close();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
