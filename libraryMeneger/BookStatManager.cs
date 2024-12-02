using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryMeneger.book
{
    
    public class BookStatManager
    {
        int article;
        private DateTime startDate;
        private DateTime endDate;
        private bool reserveStatus;
        private bool issueStatus;

        public  BookStatManager()
         {

         }

        public BookStatManager(int myarticle, DateTime startDate, DateTime endDate, bool reserveStatus, bool issueStatus)
        {
            this.article = myarticle;
            this.startDate = startDate;
            this.endDate = endDate;
            this.reserveStatus = reserveStatus;
            this.issueStatus = issueStatus;
        }

        public int Article
        {
            get { return article; }
            set { article = value; }
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

        public string GetToStringStatus(string title, string login)
        {
            string item = this.article.ToString() + " | Title: " + title + "; User login: " + login + "; End date: " + this.endDate.ToString("dd.MM.yyyy");
            return item;
        }

        public string GetToStringForHistory(string status, string title)
        {
            string item = this.article.ToString() + " | Status: " + status + "; Title: " + title + "; End date: " + this.endDate.ToString("dd.MM.yyyy");
            return item;
        }
    }
}
