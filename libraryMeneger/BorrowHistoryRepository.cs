using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using System.IO;
using libraryMeneger.user;
using libraryMeneger.book;

namespace libraryMeneger.Data.BorrowHistory
{
  public class BorrowHistoryRepository : IBorrowHistoryRepository
    {
        private string dbPath;
        private SQLiteConnection connection;
        public BorrowHistoryRepository() 
        {
            string DBFileName = ConfigurationManager.AppSettings["DBFileName"];

            dbPath = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), DBFileName);
            connection = new SQLiteConnection($"Data Source={dbPath};Connect Timeout=600");
        }

    }
}
