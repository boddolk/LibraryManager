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
            this.DialogResult = DialogResult.Cancel;

            int Article;
            List<Tuple<int, DateTime, DateTime>> History = historyRepository.getUserHistory(regularUser.Login);

            if (History != null)
            {
                foreach (Tuple<int, DateTime, DateTime> manager in History)
                {
                    Article = manager.Item1;
                    string historyPath1 = " - Article: "+ Article;
                    string historyPath2 = "   Title: " + BooksRepository.getBookTitle(Article) + ";";
                    string historyPath3 = "   Author: " + BooksRepository.getBook(Article).Author + ";";
                    string historyPath4 = "   Start date: " + manager.Item3.ToString("dd.MM.yyyy") + ";";
                    string historyPath5 = "   End date: " + manager.Item3.ToString("dd.MM.yyyy")+ ";";
                    string historyPath6 = " ";
                    HistoryBox.Items.Add(historyPath1);
                    HistoryBox.Items.Add(historyPath2);
                    HistoryBox.Items.Add(historyPath3);
                    HistoryBox.Items.Add(historyPath4);
                    HistoryBox.Items.Add(historyPath5);
                    HistoryBox.Items.Add(historyPath6);
                    
                }
            }
            else
            {
                HistoryBox.Items.Add("Your books history is empty:(\n");
                HistoryBox.Items.Add("Reserve books and hurry up to read!!!");
            }
        }
    }
}
