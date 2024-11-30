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

namespace libraryMeneger.Data.StatusRepository
{
    public abstract class IStatusRepository
    {
        protected IStatusRepository() { }
        public abstract bool  IsPresentInTable(int article);
        public abstract bool IsReserved(int article);
        public abstract bool IsIssued(int article);
        public abstract bool addBookWithItsStatus( string userID, BookStatManager manager);
        public abstract bool removeBookWithItsStatus(int article);
        public abstract string getUserIDByArticle(int article);
        public abstract List<BookStatManager> getReservedBookInfo();
        public abstract List<BookStatManager> getIssuedBookInfo();
        public abstract bool changeToIssued(int article, DateTime startDate, DateTime endDate);
        public abstract BookStatManager GetBookStatManager(int article);
        public abstract List<BookStatManager> getStatManagersByUser(string login);
        public abstract void removeOverdueReservedBooks();
    }
}
