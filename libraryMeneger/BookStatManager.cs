using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryMeneger.book
{
    public class BookStatManager
    {
        private GenBook curBook;
        private DateTime startDate;
        private DateTime endDate;
        private bool reserveStatus;
        private bool issueStatus;

        public BookStatManager(int article, string title, string author, int year, DateTime startDate, DateTime endDate, bool reserveStatus, bool issueStatus)
        {
            curBook = new GenBook(article, title, author, year);
            this.startDate = startDate;
            this.endDate = endDate;
            this.reserveStatus = reserveStatus;
            this.issueStatus = issueStatus;
        }

        public GenBook CurrentBook
        {
            get { return curBook; }
            set { curBook = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public bool ReserveStatus
        {
            get { return reserveStatus; }
            set { reserveStatus = value; }
        }

        public bool IssueStatus
        {
            get { return issueStatus; }
            set { issueStatus = value; }
        }
    }
}
