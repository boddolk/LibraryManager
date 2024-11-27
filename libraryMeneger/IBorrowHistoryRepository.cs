using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libraryMeneger.user;
using System.Configuration;
using libraryMeneger.book;

namespace libraryMeneger.Data.BorrowHistory
{
    public abstract class IBorrowHistoryRepository
    {
        protected IBorrowHistoryRepository() { }
        public abstract bool addHistory(string login, int article, DateTime borrowDate, DateTime returnDate);
    }
}
