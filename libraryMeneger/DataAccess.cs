using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.IO;
using System.Drawing;


namespace Data
{
    public static class DataAccess
    {
        public static void InitializeDatabase()
        {
           
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string dbPath = Path.Combine(folderPath, "BooksAndUsers.db");            
            if (!File.Exists(dbPath))
            {
                File.Create(dbPath).Dispose();
            }            
            using (var db = new SqliteConnection($"Filename={dbPath}"))
            {
                db.Open();

                
                string createUsersTable = @"
                    CREATE TABLE IF NOT EXISTS Users (
                        Login NVARCHAR(2048) PRIMARY KEY,
                        Name NVARCHAR(2048),
                        Surname NVARCHAR(2048),
                        Password NVARCHAR(2048),
                        Email NVARCHAR(2048),
                        PhoneNumber NVARCHAR(2048),
                        IsAdmin BOOL
                    );";

                string createBooksTable = @"
                    CREATE TABLE IF NOT EXISTS Books (
                        Article INTEGER PRIMARY KEY,
                        Title NVARCHAR(2048),
                        Author NVARCHAR(2048),
                        Year INTEGER
                    );";

                string createUserBooksHistoryTable = @"
                    CREATE TABLE IF NOT EXISTS UserBooksHistory (
                        Login NVARCHAR(2048) NOT NULL,
                        Article INTEGER NOT NULL,
                        StartDate DATE,
                        EndDate DATE,
                        PRIMARY KEY (Login, Article),
                        FOREIGN KEY (Login) REFERENCES Users(Login),
                        FOREIGN KEY (Article) REFERENCES Books(Article)
                    );";

                string createBookStatusTable = @"
                    CREATE TABLE IF NOT EXISTS BookStatus (
                        Login NVARCHAR(2048) NOT NULL,
                        Article INTEGER NOT NULL,
                        StartDate DATE,
                        EndDate DATE,
                        ReserveStatus BOOL,
                        IssueStatus BOOL,
                        PRIMARY KEY (Login, Article),
                        FOREIGN KEY (Login) REFERENCES Users(Login),
                        FOREIGN KEY (Article) REFERENCES Books(Article)
                    );";

               
                ExecuteSql(db, createUsersTable);
                ExecuteSql(db, createBooksTable);
                ExecuteSql(db, createUserBooksHistoryTable);
                ExecuteSql(db, createBookStatusTable);

                
            }
        }

        private static void ExecuteSql(SqliteConnection db, string query)
        {
            using (var command = new SqliteCommand(query, db))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}

