using libraryMeneger.Data.BorrowHistory;
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
    public partial class HistoryForm : Form
    {
        RegularUser CurrentUser;
        BorrowHistoryRepository historyRepository;

        public HistoryForm(RegularUser user)
        {
            InitializeComponent();
            CurrentUser = user;
        }

        private void HistoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserForm form = new UserForm(CurrentUser);
        }
    }
}
