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
        public override bool addHistory(string login, int article, DateTime borrowDate, DateTime returnDate)
        {
            try
            {
                connection.Open();


                string query = "INSERT INTO Borrow_History (UserID, BookID, BorrowDate, ReturnDate) VALUES ( @LoginV, @ArticleV, @BorrowDateV, @ReturnDateV)";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LoginV", login);
                    command.Parameters.AddWithValue("@ArticleV", article);
                    command.Parameters.AddWithValue("@BorrowDateV", borrowDate);
                    command.Parameters.AddWithValue("@ReturnDateV", returnDate);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting item: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public override List<Tuple<int, DateTime, DateTime>> getUserHistory(string login)
        {
            List<Tuple<int, DateTime, DateTime>> history = new List<Tuple<int, DateTime, DateTime>>();
            try
            {
                connection.Open();
                string query = "SELECT BookID, BorrowDate, ReturnDate FROM Borrow_History WHERE UserID = @Value";
               
                using (var command = new SQLiteCommand(query, connection))
                { 
                    command.Parameters.AddWithValue("@Value", login);
                    using (var reader = command.ExecuteReader())
                    {
                      
                        while (reader.Read())
                        {
                            var item = Tuple.Create(
                                Convert.ToInt32(reader["BookID"]),
                                Convert.ToDateTime(reader["BorrowDate"]), 
                                Convert.ToDateTime(reader["ReturnDate"]));
                            history.Add(item);
                        }
                        if (history != null)
                        {
                            return history;
                        }
                        else
                        {
                            Console.WriteLine("Error during retriving list of books from data base");
                            return null;
                        }
                    }
                }
            }

            finally
            {
                connection.Close();
            }
        }
    }
}
