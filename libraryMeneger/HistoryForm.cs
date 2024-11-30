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

        private RegularUser regularUser;
        BooksRepository BooksRepository = new BooksRepository();
        BorrowHistoryRepository historyRepository = new BorrowHistoryRepository();

        public HistoryForm(RegularUser user)
        {
            InitializeComponent();
            regularUser = user;

            int Article;
            List<Tuple<int, DateTime, DateTime>> History = historyRepository.getUserHistory(regularUser.Login);

            if (History != null)
            {
                foreach (Tuple<int, DateTime, DateTime> manager in History)
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
            else
            {
                HistoryBox.Items.Add("Your books history is empty:(");
                HistoryBox.Items.Add("Reserve books and hurry up to read!!!");
            }
        }

        private void HistoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
